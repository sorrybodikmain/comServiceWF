using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using comServiceWF.Delegates;

namespace comServiceWF
{
    
    public partial class ClientForm : MaterialForm
    {
        MyServiceDb myService;
        Client currentClient;
        Credential credential;
        MyMessageBox md = new MyMessageBox(delegate (string mes) { MaterialMessageBox.Show(mes); });
        private void InitializeMaterial()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.EnforceBackcolorOnAllComponents = true;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
            );
        }
        private void PrintInfo()
        {
            //my orders
            var orders = myService.Orders.Where(o => o.ClientId == currentClient.Id).OrderBy(c => c.ClientId);
            foreach (var item in orders)
                ordersGridView.Rows.Add(item.Id, currentClient.FullName, item.TypeOfWork, item.Status,
                    item.DateOfWorks, item.DataCreate, item.toComplate());
            ///about me
            textBoxFirstName.Text = currentClient.FirstName;
            textBoxLastName.Text = currentClient.LastName;
            textBoxPhone.Text = currentClient.Phone;
            textBoxCity.Text = currentClient.City;
            textBoxFullAdress.Text = currentClient.StreetFull;
            textBoxRegion.Text = currentClient.Region;
            loginBox.Text = credential.Login;
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

            return true;
        }
        private void clearPassBoxes()
        {
            passBox1.Text = "";
            passBox2.Text = "";
            passBox3.Text = "";
        }
        public ClientForm()
        {
            currentClient = new Client();
            myService = new MyServiceDb();
            credential = new Credential();
            InitializeComponent();
        }
        public ClientForm(MyServiceDb myServiceDb, Client client, Credential credential)
        {
            InitializeComponent();
            InitializeMaterial();
            this.myService = myServiceDb;
            this.currentClient = client;
            this.credential = credential;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (checkChanges())
            {
                md("No changes detected!");
            }
            else
            {
                currentClient.City = textBoxCity.Text;
                currentClient.StreetFull = textBoxFullAdress.Text;
                currentClient.Region = textBoxRegion.Text;
                currentClient.FirstName = textBoxFirstName.Text;
                currentClient.LastName = textBoxLastName.Text;
                credential.Login = loginBox.Text;
                myService.SaveChanges();
                md("Everything is saved successfully!");
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
                        myService.Orders.Add(new Order(currentClient.Id, team.Id, DatePicker.Value,
                            typeComboBox.SelectedItem.ToString()));
                        team.status = true;
                        myService.SaveChanges();
                        MaterialMessageBox.Show("Everything is saved successfully!");
                    }
                }
                catch (Exception)
                {
                    md("Currently all busy groups try later!");
                    throw;
                }
            }
        }

        private void passConfButton_Click(object sender, EventArgs e)
        {
            if(passBox1.Text.Trim() == credential.Password)
            {
                if(passBox2.Text.Trim() == credential.Password)
                {
                    MaterialMessageBox.Show("The new password cannot be equal to the current one!");
                } 
                else if (passBox2.Text.Trim() == passBox3.Text.Trim())
                {
                    //save password
                    myService.Credentials.First(c => c.ClientId == credential.ClientId).Password = passBox2.Text.Trim();
                    credential.Password = passBox2.Text.Trim();
                    myService.SaveChanges();
                    clearPassBoxes();
                }
                else
                {
                    md("New password does not match!");
                }
            }
            else
            {
                MaterialMessageBox.Show("The current password does not match");
            }
        }
    }
}
