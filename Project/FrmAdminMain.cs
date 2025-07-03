using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls.Primitives;
using System.Windows.Forms;
using Controladores.AgendaController;
using Controladores.EmprendimientoController;
using Controladores.EventoController;
using Controladores.ParticipanteController;
using MaterialSkin;
using MaterialSkin.Controls;
using Modelos.EF;
using Project.task;




namespace Project
{
    public partial class FrmAdminMain : MaterialForm
    {

        public event EventHandler TabControlChanged;
        
        private readonly MaterialSkinManager materialSkinManager;
      
        private readonly ParticipanteController _participante;
        private readonly EmprendimientoController _controllerEmprendimiento;
        private readonly AgendaController _agendaController;   
        private readonly EventoController _eventoController;






        public FrmAdminMain()
        {
            InitializeComponent();


            this.StartPosition = FormStartPosition.CenterScreen;
           
           
            _participante = new ParticipanteController();
            _controllerEmprendimiento = new EmprendimientoController();
            _agendaController = new AgendaController();
            _eventoController = new EventoController();

            ImprimirTagsDeCards(pnlConfiguracion2);


            CargarEmprendimiento();

            //materialTabControl1.SelectedIndexChanged += materialTabControl1_SelectedIndexChanged;


            materialSkinManager = MaterialSkinManager.Instance;

          
            materialSkinManager.AddFormToManage(this);

            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;

            materialSkinManager.ColorScheme = new ColorScheme(
                Primary.Indigo500,     
                Primary.Indigo700,     
                Primary.Indigo100,    
                Accent.Blue200,        
                TextShade.WHITE        
            );



            CargarEmprendimientosComoCards();

            //FlowLayout de por si tiene una coleccion es decir pnlConfiguracion2.controls 
            pnlConfiguracion2.AllowDrop = true;
            pnlConfiguracion2.FlowDirection = FlowDirection.TopDown;
            pnlConfiguracion2.WrapContents = false;
            pnlConfiguracion2.AutoScroll = true;

            pnlConfiguracion2.DragEnter += (s, e) =>
            {
                if (e.Data.GetDataPresent(typeof(MaterialSkin.Controls.MaterialCard)))
                {
                    e.Effect = DragDropEffects.Move;
                }
            };

            pnlConfiguracion2.DragDrop += (s, e) =>
            {
                var card = e.Data.GetData(typeof(MaterialSkin.Controls.MaterialCard)) as MaterialSkin.Controls.MaterialCard;
                if (card != null)
                {
                    Point punto = pnlConfiguracion2.PointToClient(new Point(e.X, e.Y));

            
                    pnlConfiguracion2.Controls.Remove(card);

                    int index = 0;
                    foreach (Control c in pnlConfiguracion2.Controls)
                    {
                        if (punto.Y < c.Top + c.Height / 2)
                        {
                            break; 
                        }
                        index++;
                    }

                    pnlConfiguracion2.Controls.Add(card);
                    pnlConfiguracion2.Controls.SetChildIndex(card, index);
                }
            };

            dateHourIn.Format = DateTimePickerFormat.Custom;
            dateHourIn.CustomFormat = "HH:mm tt";
            dateHourIn.ShowUpDown = true;

            dateHourOut.Format = DateTimePickerFormat.Custom;
            dateHourOut.CustomFormat = "HH:mm tt";
            dateHourOut.ShowUpDown = true;



        }

        private void guardarOrdenPresentacion(int evento) {
            int orden = 1; // Empieza en 1 o 0 según tu lógica
                           //Posiblemente explote xd

            Console.WriteLine($"Cantidad de controles en pnlConfiguracion2: {pnlConfiguracion2.Controls.Count}");

            foreach (Control control in pnlConfiguracion2.Controls)
            {


                if (control is MaterialCard card)
                    if (card.Tag != null && int.TryParse(card.Tag.ToString(), out int emprendimientoId))
                    {
                        Console.WriteLine($"Emprendimiento ID: {emprendimientoId} - Orden: {orden}");

                        _agendaController.GuardarAgenda(evento, emprendimientoId, orden);
                        Console.WriteLine("SI FUNCIONA");

                        orden++;
                    }
             
                
            }
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
            lblTitulo.Location = new Point(30, 30); 




     

          
            frameBienvenida.Controls.Add(lblTitulo);

            pnlBienvenida.Controls.Clear();
            pnlBienvenida.Controls.Add(frameBienvenida);

            CargarEmprendimientosComoCards();

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
                if (imgLogo != null) { 
                    this.IconoCamaraEmprendimiento.Visible = false;
                }
                else{
                    this.IconoCamaraEmprendimiento.Visible = true;
                }
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
             
                Image logo = imgLogo.Image;
                _controllerEmprendimiento.registrarEmprendimiento(nombre, facultad, rubro, descripcion, logo);
                MessageBox.Show("¡Emprendimiento registrado exitosamente!");
                CargarEmprendimiento();
                limpiarTextField(this);
         
                imgLogo.Image = null;
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
            string primerNombre = txtPrimerNombre.Text.Trim();
            string segundoNombre = txtSegundoNombre.Text.Trim();
            string primerApellido = txtPrimerApellido.Text.Trim();
            string segundoApellido = txtSegundoApellido.Text.Trim();    
            string cargo = txtCargo.Text.Trim();
            Image photo = imgLogoParticipante.Image;




            if (string.IsNullOrWhiteSpace(primerNombre) 
                || (string.IsNullOrWhiteSpace(cargo) 
                || string.IsNullOrWhiteSpace(segundoNombre) || string.IsNullOrWhiteSpace(primerApellido) 
                || string.IsNullOrWhiteSpace(segundoApellido)))
            {
                MessageBox.Show("Por favor completa todos los campos.");
                return;
            }


            try {

                _participante.registrarParticipante(primerNombre,segundoNombre, primerApellido, segundoApellido, cargo, photo);
                
                MessageBox.Show("Usuario registrado uwu ");
                limpiarTextField(this);
                imgLogoParticipante.Image = null;
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
                if (imgLogoParticipante != null)
                {
                    this.iconCamara.Visible = false;
                }
                else {
                    this.iconCamara.Visible = true;

                }
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
       

            tableEmprendimiento.DataSource = lstEmprendimiento.Select(e => new
            {
                e.Nombre,
                e.Facultad,
                e.Rubro
            }).ToList();
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }


        public Image ConvertirBytesAImagen(byte[] bytes)
        {
            if (bytes == null || bytes.Length == 0)
                return null;

            using (var ms = new MemoryStream(bytes))
            {
                return Image.FromStream(ms);
            }
        }


        private void ImprimirTagsDeCards(FlowLayoutPanel panel)
        {
            foreach (Control control in panel.Controls)
            {
                if (control is MaterialSkin.Controls.MaterialCard card)
                {
                    Console.WriteLine($"Card Tag: {card.Tag}");
                }
            }
        }


        private void CargarEmprendimientosComoCards()
        {
            pnlEmprendimientos.Controls.Clear();
            pnlEmprendimientoCards.Controls.Clear();

            var lista = _controllerEmprendimiento.ObtenerTodos();


            foreach (var emp in lista)
            {

                Console.WriteLine($"Cargando emprendimiento con Id: {emp.Id}");

                var card = new MaterialSkin.Controls.MaterialCard
                {
                    Width = 260,
                    Height = 75,
                    Margin = new Padding(10),
                    BackColor = Color.WhiteSmoke,
                    Padding = new Padding(5),
                    Tag = emp.Id
                };

                

            








                var panelContenido = new TableLayoutPanel
                {
                    Dock = DockStyle.Fill,
                    ColumnCount = 2,
                    RowCount = 1
                };

                panelContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40));
                panelContenido.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 60));
                panelContenido.RowStyles.Add(new RowStyle(SizeType.Percent, 100));

                var pictureBox = new PictureBox
                {
                    Dock = DockStyle.Fill,
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Image = ConvertirBytesAImagen(emp.LogoBinary)
                };

                var label = new Label
                {
                    Text = $"Nombre: {emp.Nombre}\nFacultad: {emp.Facultad}\nRubro: {emp.Rubro}",
                    Dock = DockStyle.Fill,
                    Font = new Font("Segoe UI", 8, FontStyle.Bold),
                    Padding = new Padding(10),
                    TextAlign = ContentAlignment.MiddleLeft
                };

                panelContenido.Controls.Add(pictureBox, 0, 0);
                panelContenido.Controls.Add(label, 1, 0);

                card.Controls.Add(panelContenido);

                pnlEmprendimientos.Controls.Add(card);
                pnlEmprendimientoCards.Controls.Add(card);

           
                var currentCard = card;
                HabilitarDragEnControl(card, currentCard);

                currentCard.MouseDown += (s, e) =>
                {
                    if (e.Button == MouseButtons.Left)
                    {
                        Console.WriteLine("Iniciando arrastre de tarjeta...");
                        currentCard.DoDragDrop(currentCard, DragDropEffects.Move);
                    }
                };



            }
        }


        private void HabilitarDragEnControl(Control ctrl, MaterialSkin.Controls.MaterialCard cardReferencia)
        {
            ctrl.MouseDown += (s, e) =>
            {
                if (e.Button == MouseButtons.Left)
                {
                    Console.WriteLine("Iniciando arrastre de tarjeta...");
                    cardReferencia.DoDragDrop(cardReferencia, DragDropEffects.Move);
                }
            };

            foreach (Control hijo in ctrl.Controls)
            {
                HabilitarDragEnControl(hijo, cardReferencia);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void materialCard3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void materialTextBox21_Click_2(object sender, EventArgs e)
        {

        }

        private void pnlBienvenida_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void imgLogoParticipante_Click(object sender, EventArgs e)
        {

        }

        private void flowLayoutPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void materialCard9_Paint(object sender, PaintEventArgs e)
        {

        }

        private void materialTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateTimePicker2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialLabel12_Click(object sender, EventArgs e)
        {

        }

        private void materialLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pnlConfiguracion2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void botonGuardar_Click(object sender, EventArgs e)
        {


            string tituloEvento = txtTituloEvento.Text.Trim();
            DateTime fechaExposicionEvento = fechaExposicion.Value;
            DateTime horaInicio = dateHourIn.Value;
            DateTime horaFin = dateHourOut.Value;
            string ubicacion = txtUbicacion.Text.Trim();

         
            int nuevoEventoId = _eventoController.CrearEvento(tituloEvento, fechaExposicionEvento, horaInicio, horaFin, ubicacion);

            if (nuevoEventoId > 0)
            {
                guardarOrdenPresentacion(nuevoEventoId);
          
                MessageBox.Show("Evento creado correctamente con ID: " + nuevoEventoId);
            }
            else
            {
                MessageBox.Show("Error al crear el evento.");
            }


        }
    }
}
