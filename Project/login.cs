using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class login : Form
    {

     
        
        public login()
        {
           

            InitializeComponent();

            this.StartPosition = FormStartPosition.CenterScreen;

            BackColor = System.Drawing.Color.FromArgb(241, 240, 247);
            this.FormBorderStyle = FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false; 


            SetPlaceholder(textBox1, "Usuario");
            SetPlaceholder(textBox2, "Requerido");

            this.textBox1.Font = new Font("Segoe UI", 12, FontStyle.Regular);
            this.textBox2.Font = new Font("Segoe UI", 12, FontStyle.Regular);

            label1.Font = new Font(label1.Font.FontFamily, 12, FontStyle.Bold);
            label2.Font = new Font(label2.Font.FontFamily, 12, FontStyle.Bold);
         






            textBox1.Leave += SetPlaceholderIfEmpty;
            textBox1.Enter += removePlaceholder;

            textBox2.Leave += SetPlaceholderIfEmpty;
            textBox2.Enter += removePlaceholder;


            



        }

        private void removePlaceholder(object sender, EventArgs e) {
            TextBox tb = sender as TextBox;
            if (tb != null && tb.ForeColor == Color.Gray)
            {
                tb.Text = "";
                tb.ForeColor = Color.Black;

                if (tb == textBox2)
                {
                    tb.UseSystemPasswordChar = true;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {
          
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {


        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        private void SetPlaceholderIfEmpty(object sender, EventArgs e)
        {
            TextBox tb = sender as TextBox;
            if (tb != null && string.IsNullOrWhiteSpace(tb.Text))
            {
                if (tb == textBox1)
                    SetPlaceholder(tb, "Ingrese usuario");
                else if (tb == textBox2)
                    SetPlaceholder(tb, "Ingrese contraseña");
            }
        }

        private void SetPlaceholder(TextBox tb, string placeholder)
        {
            if (string.IsNullOrWhiteSpace(tb.Text))
            {
                tb.Text = placeholder;
                tb.ForeColor = Color.Gray;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.MaximizeBox = false;
            this.MinimizeBox = false;
        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void RedondearPanel(Panel pb)
        {
            GraphicsPath path = new GraphicsPath();
            int radio = 40;
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(pb.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(pb.Width - radio, pb.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, pb.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            pb.Region = new Region(path);
        }


        private void RedondearBtn(Button btn)
        {
            GraphicsPath path = new GraphicsPath();
            int radio = 60;
            path.AddArc(0, 0, radio, radio, 180, 90);
            path.AddArc(btn.Width - radio, 0, radio, radio, 270, 90);
            path.AddArc(btn.Width - radio, btn.Height - radio, radio, radio, 0, 90);
            path.AddArc(0, btn.Height - radio, radio, radio, 90, 90);
            path.CloseAllFigures();
            btn.Region = new Region(path);
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            RedondearPanel(pnlLogin);
            RedondearPanel(pnlContra);
            RedondearBtn(btnAcceder);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.FormBorderStyle = FormBorderStyle.None;
        }

        private void panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            string usuario = textBox1.Text;
            string password = textBox2.Text;

            if (usuario == "Gabriel" && password == "123") {
                //MessageBox.Show($"Acceso Correcto , Bienvenido {usuario}","Acceso");
                MostrarSaludo(usuario);
                FrmAdminMain frmPrincipal = new FrmAdminMain();
                frmPrincipal.Show();

                this.Hide();


            }
            else
            {

                MessageBox.Show("Usuario o contraseña incorrectos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }



        }




        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void panel4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pnlContra_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }





        private async void MostrarSaludo(string usuario)
        {

            Form saludoForm = new Form()
            {
                Width = 300,
                Height = 150,
                FormBorderStyle = FormBorderStyle.FixedDialog,
                StartPosition = FormStartPosition.CenterScreen,
                ControlBox = false,
                Text = "Bienvenido",
                TopMost = true
            };

            Label lbl = new Label()
            {
                Text = $"¡Bienvenido, {usuario}!",
                Dock = DockStyle.Fill,
                TextAlign = ContentAlignment.MiddleCenter,
                Font = new Font("Segoe UI", 12, FontStyle.Bold)
            };

            saludoForm.Controls.Add(lbl);
            saludoForm.Show();

            await Task.Delay(1000);
            saludoForm.Close();
        }







    }
}
