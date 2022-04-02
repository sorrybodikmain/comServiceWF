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
        public AuthForm()
        {
            InitializeComponent();
            //materialskin2
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Blue800,
                Primary.Blue900,
                Primary.Blue500,
                Accent.LightBlue200,
                TextShade.WHITE
                );
        }
        void hidePanels(int u)
        {
            switch (u)
            {
                case 1:
                    panelNewClient.Visible = false;
                    break;
                case 2:
                    panelNewClient.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure all data is correct?", "Confirmation of registration", 
                MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                myServiceDb.Clients.Add(new Client(textBoxFirstName.Text, textBoxLastName.Text, textBoxPhone.Text,
                    textBoxFirstCity.Text, textBoxFullAdress.Text, textBoxRegion.Text, textBoxPassword.Text));
                myServiceDb.SaveChanges();
                hidePanels(1);
            }
        }


        public void Form1_Load(object sender, EventArgs e)
        {
            hidePanels(1);

            textBoxAuthPhone.Text = "0696466461";
            textBoxAuthPass.Text = "password";
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            hidePanels(2);
        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            if (textBoxAuthPhone.Text != "admin" && textBoxAuthPass.Text != "")
            {
                try
                {
                    Client cl = myServiceDb.Clients.First(c => c.Phone == textBoxAuthPhone.Text);
                    if (cl != null)
                        if (textBoxAuthPass.Text == cl.Password)
                        {
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
    }
}
