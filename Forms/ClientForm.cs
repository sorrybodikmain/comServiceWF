using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace comServiceWF
{
    public partial class ClientForm : MaterialForm
    {
        MyServiceDb myService;
        Client currentClient;
        private void InitializeMaterial()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        private void PrintInfo()
        {
            //my orders
            var orders  = myService.Orders.Where(o => o.ClientId == currentClient.Id).ToList();
            foreach (var item in orders)
                dataGridView1.Rows.Add(item.Id, item.TeamId, currentClient.FullName, item.dateOfWorks, item.Status);
            ///about me
            textBoxFirstName.Text = currentClient.FirstName;
            textBoxLastName.Text = currentClient.LastName;
            textBoxPhone.Text = currentClient.Phone;
            textBoxCity.Text = currentClient.City;
            textBoxFullAdress.Text = currentClient.StreetFull;
            textBoxRegion.Text = currentClient.Region;
            textBoxPassword.Text = currentClient.Password;
        }
        private bool checkChanges()
        {
            if (textBoxFirstName.Text != currentClient.FirstName)
                return false;
            if (textBoxLastName.Text != currentClient.LastName)
                return false;
            if (textBoxPhone.Text != currentClient.Phone)
                return false;
            if (textBoxCity.Text != currentClient.City)
                return false;
            if (textBoxFullAdress.Text != currentClient.StreetFull)
                return false;
            if (textBoxRegion.Text != currentClient.Region)
                return false;
            if (textBoxPassword.Text != currentClient.Password)
                return false;

            return true;
        }
        public ClientForm()
        {
            currentClient = new Client();
            myService = new MyServiceDb();
            InitializeComponent();
        }
        public ClientForm(MyServiceDb myServiceDb, Client client)
        {
            InitializeComponent();
            InitializeMaterial();
            this.myService = myServiceDb;
            this.currentClient = client;

        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if(checkChanges())
            {
                MessageBox.Show("No changes detected!");
            }
            else
            {
                ///save*********************
                MessageBox.Show("Everything is saved successfully!");
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            PrintInfo();
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure all data is correct?", "Confirmation",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                try
                {
                    Team team = myService.Teams.First(t => t.status == false);
                    if (team != null)
                    {
                        //DateTime x = new DateTime(DatePicker.Value.Date,TimePicker.Value.TimeOfDay);
                        myService.Orders.Add(new Order(currentClient.Id, team.Id, DatePicker.Value));
                        team.status = true;
                        myService.SaveChanges();
                        MessageBox.Show("Everything is saved successfully!");
                    }
                }
                catch (Exception)
                {
                    MessageBox.Show("Currently all busy groups try later!");
                    throw;
                }
            }
        }
    }
}
