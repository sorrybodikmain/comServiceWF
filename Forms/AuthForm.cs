using System;
using System.Linq;
using System.Windows.Forms;
using comServiceWF.Forms;
//materialskin2
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.EntityFrameworkCore;
//-------------
namespace comServiceWF
{
    public partial class AuthForm : MaterialForm
    {
        MyServiceDb myServiceDb = new MyServiceDb();
        public static void InitializeMaterial()
        {
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.BlueGrey800,
                Primary.BlueGrey900,
                Primary.BlueGrey500,
                Accent.LightBlue200,
                TextShade.WHITE
                );
        }
        public AuthForm()
        {
            InitializeComponent();
            InitializeMaterial();

        }
        private void hidePanels(int u)
        {
            switch (u)
            {
                case 1:
                    AuthPanel.Visible = true;
                    SignUpPanel.Visible = false;
                    SignUpPanel2.Visible = false;
                    break;
                case 2:
                    AuthPanel.Visible = true;
                    SignUpPanel.Visible = true;
                    SignUpPanel2.Visible = false;
                    break;
                case 3:
                    AuthPanel.Visible = true;
                    SignUpPanel.Visible = true;
                    SignUpPanel2.Visible = true;
                    break;
                default:
                    break;
            }
        }

        public void Form1_Load(object sender, EventArgs e)
        {
            hidePanels(1);
            ///// test values ///////
            BoxAuthLogin.Text = "admin";
            BoxAuthPass.Text = "admin";

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            hidePanels(2);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            try
            {
                Credential  credential = myServiceDb.Credentials.First(c => c.Login == BoxAuthLogin.Text);
                if (credential != null && credential.Password == BoxAuthPass.Text)
                {
                    
                    if (credential.Login != "admin")
                    {
                        Client client = myServiceDb.Clients.Include(x => x.Orders).First(c => c.Id == credential.ClientId);
                        this.Hide();
                        ClientForm clientForm = new ClientForm(myServiceDb, client, credential);
                        clientForm.Closed += (s, args) => this.Close();
                        clientForm.ShowDialog();
                    }
                    else
                    {
                        this.Hide();
                        AdminForm adminForm = new AdminForm();
                        adminForm.Closed += (s, args) => this.Close();
                        adminForm.ShowDialog();
                    }
                }
                else
                    MaterialMessageBox.Show($"Wrong login or password!");
            }
            catch (Exception ex)
            {
                MaterialMessageBox.Show($"Wrong login or password! {ex.Message}");
            }

        }


        private void NoPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MaterialMessageBox.Show("Please contact support!");
        }

        private void buttonRes1_Click(object sender, EventArgs e)
        {
            if (BoxPass1.Text.Trim() != BoxPass2.Text.Trim())
            {
                MaterialMessageBox.Show("Passwords do not match!");
            }
            else
            {
                hidePanels(3);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure all data is correct?", "Confirmation of registration",
                           MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myServiceDb.Clients.Add(new Client(FirstNameBox.Text, LastNameBox.Text,
                    PhoneBox.Text, cityBox.Text, addressBox.Text, regionBox.Text));
                myServiceDb.SaveChanges();
                myServiceDb.Credentials.Add(new Credential(LoginBox.Text, BoxPass1.Text, myServiceDb.
                    Clients.First(c => c.Phone == PhoneBox.Text.Trim()).Id));
                myServiceDb.SaveChanges();
                MaterialMessageBox.Show("New registration successful!");
                hidePanels(1);
            }
            else
            {
                hidePanels(1);
            }
        }


    }
}
