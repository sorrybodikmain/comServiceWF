using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//materialskin2
using  MaterialSkin;
using MaterialSkin.Controls;
using MaterialSkin.Animations;
//-------------
namespace comServiceWF
{
    public partial class Form1 : MaterialForm
    {
        public Form1()
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
            if (u == 1)
            {
                panel2.Visible = false;
                panel3.Visible = false;

            }
            else if (u == 2)
            {
                panel3.Visible = true;
                panel2.Visible = true;
            }
        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            hidePanels(1);
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            hidePanels(1);
        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            hidePanels(2);
        }
    }
}
