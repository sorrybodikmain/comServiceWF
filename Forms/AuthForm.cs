using System;
using System.Linq;
using System.Windows.Forms;
//materialskin2
using MaterialSkin;
using MaterialSkin.Controls;
//-------------
namespace comServiceWF
{
    public partial class AuthForm : MaterialForm
    {
        MyServiceDb myServiceDb = new MyServiceDb();
        void InitializeMaterial()
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
        void hidePanels(int u)
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
            BoxAuthPhone.Text = "dtick0";
            BoxAuthPass.Text = "rlQGiz9l";

        }

        private void buttonSignUp_Click(object sender, EventArgs e)
        {
            hidePanels(2);
        }

        private void buttonSignIn_Click(object sender, EventArgs e)
        {
            if (BoxAuthPhone.Text != "admin" && BoxAuthPass.Text != "")
            {
                try
                {
                    Credential cr = myServiceDb.Credentials.First(c => c.Login == BoxAuthPhone.Text);
                    if (cr != null && cr.Password == BoxAuthPass.Text)
                    {
                        Client cl = myServiceDb.Clients.First(c => c.Id == cr.ClientId);
                        this.Hide();
                        ClientForm clientForm = new ClientForm(myServiceDb, cl);
                        clientForm.Closed += (s, args) => this.Close();
                        clientForm.ShowDialog();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Wrong login or password! {ex.Message}");
                }
            }
            else
            {
                MessageBox.Show("Admin form in development!");
            }

        }


        private void NoPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MaterialMessageBox.Show("Please contact support!");
        }

        private void buttonRes1_Click(object sender, EventArgs e)
        {
            if (BoxPass1.Text != BoxPass2.Text)
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
                myServiceDb.Credentials.Add(new Credential(LoginBox.Text, BoxPass1.Text));
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
