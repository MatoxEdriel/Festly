using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Project
{
    public partial class FrmMainLogin : MaterialForm

    {

        public FrmMainLogin()
        {
            InitializeComponent();
            var skinManager = MaterialSkin.MaterialSkinManager.Instance;
            skinManager.EnforceBackcolorOnAllComponents = true;

            txtUsuario.BackColor = Color.White;
            txtUsuario.ForeColor = Color.Black; 

            skinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            skinManager.ColorScheme = new ColorScheme(
                Primary.Blue500, Primary.Blue700,
                Primary.Blue100, Accent.LightBlue200,
                TextShade.BLACK
            );


        }

        private void FrmMainLogin_Load(object sender, EventArgs e)
        {
           
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtUsuario_Click(object sender, EventArgs e)
        {

        }
    }
}
