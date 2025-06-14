using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Controladores.EmprendimientoController;
using Controladores.ParticipanteController;
using MaterialSkin;
using MaterialSkin.Controls;
using Project.task;




namespace Project
{
    public partial class FrmAdminMain : MaterialForm
    {

        public event EventHandler TabControlChanged;
        
        private readonly MaterialSkinManager materialSkinManager;
        private readonly EmprendimientoController _controller;
        private readonly ParticipanteController _participante;
        private readonly EmprendimientoController _controllerEmprendimiento;


  


        public FrmAdminMain()
        {
            InitializeComponent();
            this.StartPosition = FormStartPosition.CenterScreen;
           
            _controller = new EmprendimientoController(); //Para que cargue una vez 
            _participante = new ParticipanteController();
            _controllerEmprendimiento = new EmprendimientoController();
            CargarEmprendimiento();

            //materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;


            materialSkinManager = MaterialSkinManager.Instance;

          
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,     // Barra superior azul Facebook
                Primary.Indigo700,     // Elementos como pestañas activas
                Primary.Indigo100,     // Fondo claro general
                Accent.Blue200,        // Acentos como botones
                TextShade.WHITE        // Texto blanco en la barra superior
            );





       

        }

   
        public void LoadFormInTab(Form form, TabPage tabPage)
        {
            //La carga
        
            tabPage.Controls.Clear();

            form.TopLevel = false;
            form.FormBorderStyle = FormBorderStyle.None;
            form.Dock = DockStyle.Fill;

            tabPage.Controls.Add(form);
            form.Show();
        }

        public void limpiarTextField(Control control)
        {
            foreach (Control componente in control.Controls)
            {
                if (componente is TextBox || componente is MaterialSkin.Controls.MaterialTextBox)
                {
                    componente.Text = string.Empty;
                }
                if (componente.HasChildren)
                {
                    limpiarTextField(componente);
                }
            }
        }



        //private void materialTabControl1_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    //if (materialTabControl1.SelectedTab == registrarEmprendimiento)
        //    //{
        //    //    CargarEmprendimiento(); // Aquí sí es correcto
        //    //}
        //}



        private void Prueba_Load(object sender, EventArgs e)
        {
            Panel frameBienvenida = new Panel();
            frameBienvenida.Dock = DockStyle.Fill;
            frameBienvenida.BackColor = Color.White;

           
            Label lblTitulo = new Label();
            lblTitulo.Text = "¿Qué puede hacer Festly?";
            lblTitulo.Font = new Font("Segoe UI", 32, FontStyle.Bold);
            lblTitulo.ForeColor = Color.Black;
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(30, 30); // Puedes ajustar según necesidad

            // Agregar label al panel
            frameBienvenida.Controls.Add(lblTitulo);

            // Agregar al panel principal del formulario
            pnlBienvenida.Controls.Clear();
            pnlBienvenida.Controls.Add(frameBienvenida);


        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        private void iconPictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

      


        }


   

        private void tabPage2_Click(object sender, EventArgs e)
        {

    


        }

       
        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialLabel2_Click(object sender, EventArgs e)
        {

        }

        private void materialCard4_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnHome_Click(object sender, EventArgs e)
        {
       
        }

        private void materialCard2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox22_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click(object sender, EventArgs e)
        {

        }

        private void materialButton1_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            { 
                imgLogo.Image = Image.FromFile(openFileDialog.FileName);
                imgLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string nombre = txtNombreEmprendimiento.Text.Trim();
            string facultad = txtFacultad.Text.Trim();
            string rubro = txtRubro.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombre) || string.IsNullOrWhiteSpace(facultad) ||
                string.IsNullOrWhiteSpace(rubro) || string.IsNullOrWhiteSpace(descripcion))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }

            try
            {
                _controllerEmprendimiento.registrarEmprendimiento(nombre, facultad, rubro, descripcion);
                MessageBox.Show("¡Emprendimiento registrado exitosamente!");
                CargarEmprendimiento();
                limpiarTextField(this);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void txtMain_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click_1(object sender, EventArgs e)
        {

        }

        private void materialButton2_Click(object sender, EventArgs e)
        {
            string nombres = txtNombreCompleto.Text.Trim(); 
            string cargo = txtCargo.Text.Trim();

            if (string.IsNullOrWhiteSpace(nombres) || (string.IsNullOrWhiteSpace(cargo)))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }


            try {

                _participante.registrarParticipante(nombres, cargo);

                MessageBox.Show("Usuario registrado uwu ");





            }
            catch (Exception ex) {

                MessageBox.Show("Error: " + ex.Message);

            }




        }

        private void materialButton3_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Title = "Seleccionar imagen";
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.bmp";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                imgLogoParticipante.Image = Image.FromFile(openFileDialog.FileName);
                imgLogoParticipante.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

        }

        private void materialCard7_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void materialListBox2_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {

        }

        private void panel1_Paint_1(object sender, PaintEventArgs e)
        {



        }

        private void materialListBox1_SelectedIndexChanged(object sender, MaterialListBoxItem selectedItem)
        {
          
        }

        private void CargarEmprendimiento() {

            var lstEmprendimiento = _controllerEmprendimiento.ObtenerTodos();
            lstBoxEmprendimiento.Items.Clear();

            foreach (var emp in lstEmprendimiento)
            {
                var item = new MaterialListBoxItem(emp.Nombre);
                item.Tag = emp;
                lstBoxEmprendimiento.Items.Add(item);
            }

            /*  Implementar esto cuando sea el momento xd 
             *       lstBoxEmprendimiento.Items.Clear();
            var lista = await Task.Run(() => _controllerEmprendimiento.ObtenerTodos());

            foreach (var emp in lista)
            {
                var item = new MaterialListBoxItem(emp.Nombre);
                item.Tag = emp;
                lstBoxEmprendimiento.Items.Add(item);
            }
             * 
             * 
             */
        }


        private void panel2_Paint(object sender, PaintEventArgs e)
        {  

         
        }
    }
}
