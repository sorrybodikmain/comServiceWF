using MaterialSkin.Controls;
using MaterialSkin;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace comServiceWF
{
    
    public partial class ClientForm : MaterialForm
    {
        MyServiceDb myService;
        Client currentClient;
        Credential credential;
        private void PrintInfo()
        {
            //my orders
            if (currentClient.Orders.Count>0)
            {
                foreach (var item in currentClient.Orders.OrderBy(o=>o.Id))
                    ordersGridView.Rows.Add(item.Id, currentClient.FullName, item.TypeOfWork, item.Status,
                        item.DateOfWorks, item.DataCreate, item.toComplate());
            }///about me
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
            AuthForm.InitializeMaterial();
            this.myService = myServiceDb;
            this.currentClient = client;
            this.credential = credential;
        }

        private void buttonSaveChanges_Click(object sender, EventArgs e)
        {
            if (checkChanges())
            {
                MaterialMessageBox.Show("No changes detected!");
            }
            else
            {
                currentClient.City = textBoxCity.Text;
                currentClient.StreetFull = textBoxFullAdress.Text;
                currentClient.Region = textBoxRegion.Text;
                currentClient.FirstName = textBoxFirstName.Text;
                currentClient.LastName = textBoxLastName.Text;
                currentClient.Phone = textBoxPhone.Text;
                credential.Login = loginBox.Text;
                myService.SaveChanges();
                MaterialMessageBox.Show("Everything is saved successfully!");
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
                    Team team = myService.Teams.FirstOrDefault(t => t.Status == false);
                    if (team != null)
                    {
                        myService.Orders.Add(new Order(currentClient.Id, team.Id, DatePicker.Value,
                            typeComboBox.SelectedItem.ToString()));
                        team.UpdateStatus();
                        myService.SaveChanges();
                        MaterialMessageBox.Show("Everything is saved successfully!");
                    }
                    else
                        MaterialMessageBox.Show("Currently all busy groups try later!");
                }
                catch (Exception)
                {
                    MaterialMessageBox.Show("Currently all busy groups try later!");
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
                    MaterialMessageBox.Show("New password save!");
                }
                else
                {
                    MaterialMessageBox.Show("New password does not match!");
                }
            }
            else
            {
                MaterialMessageBox.Show("The current password does not match");
            }
        }
    }
}
