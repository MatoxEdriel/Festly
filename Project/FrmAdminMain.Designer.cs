using System.Drawing;
using System.Windows.Forms;


namespace Project
{
    partial class FrmAdminMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.materialTabControl1 = new MaterialSkin.Controls.MaterialTabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.pnlBienvenida = new System.Windows.Forms.Panel();
            this.materialCard6 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel11 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel6 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox5 = new FontAwesome.Sharp.IconPictureBox();
            this.materialCard5 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel10 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel5 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox4 = new FontAwesome.Sharp.IconPictureBox();
            this.materialCard4 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel9 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel4 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox2 = new FontAwesome.Sharp.IconPictureBox();
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel8 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel2 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox3 = new FontAwesome.Sharp.IconPictureBox();
            this.registrarEmprendimiento = new System.Windows.Forms.TabPage();
            this.pnlEmprendimientos = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.label2 = new System.Windows.Forms.Label();
            this.tableEmprendimiento = new System.Windows.Forms.DataGridView();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreEmprendimiento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRubro = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFacultad = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.IconoCamaraEmprendimiento = new FontAwesome.Sharp.IconPictureBox();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.registrarParticipante = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.txtSegundoApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtSegundoNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtPrimerApellido = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtPrimerNombre = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCargo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.iconCamara = new FontAwesome.Sharp.IconPictureBox();
            this.imgLogoParticipante = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Eventos = new System.Windows.Forms.TabPage();
            this.materialCard9 = new MaterialSkin.Controls.MaterialCard();
            this.pnlConfiguracion = new MaterialSkin.Controls.MaterialCard();
            this.materialCard11 = new MaterialSkin.Controls.MaterialCard();
            this.cancelBoton = new FontAwesome.Sharp.IconButton();
            this.botonGuardar = new FontAwesome.Sharp.IconButton();
            this.pnlConfiguracion2 = new System.Windows.Forms.FlowLayoutPanel();
            this.txtTituloEvento = new MaterialSkin.Controls.MaterialTextBox();
            this.materialCard10 = new MaterialSkin.Controls.MaterialCard();
            this.iconButton3 = new FontAwesome.Sharp.IconButton();
            this.txtUbicacion = new MaterialSkin.Controls.MaterialTextBox();
            this.materialLabel12 = new MaterialSkin.Controls.MaterialLabel();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton1 = new FontAwesome.Sharp.IconButton();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dateHourOut = new System.Windows.Forms.DateTimePicker();
            this.fechaExposicion = new System.Windows.Forms.DateTimePicker();
            this.dateHourIn = new System.Windows.Forms.DateTimePicker();
            this.pnlEmprendimientoCards = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPremiacion = new System.Windows.Forms.TabPage();
            this.materialCard12 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel13 = new MaterialSkin.Controls.MaterialLabel();
            this.materialCard13 = new MaterialSkin.Controls.MaterialCard();
            this.btnGuardarCategorias = new FontAwesome.Sharp.IconButton();
            this.txtObservacion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.cmbEmprendimiento = new MaterialSkin.Controls.MaterialComboBox();
            this.cmbCategoria = new MaterialSkin.Controls.MaterialComboBox();
            this.txtGanadores = new MaterialSkin.Controls.MaterialLabel();
            this.iconButton2 = new FontAwesome.Sharp.IconButton();
            this.materialCard16 = new MaterialSkin.Controls.MaterialCard();
            this.tblPremiacion = new System.Windows.Forms.DataGridView();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Salir = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.pnlCardParticipante = new MaterialSkin.Controls.MaterialCard();
            this.materialTabControl1.SuspendLayout();
            this.Home.SuspendLayout();
            this.materialCard6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).BeginInit();
            this.materialCard5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).BeginInit();
            this.materialCard4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).BeginInit();
            this.materialCard1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).BeginInit();
            this.registrarEmprendimiento.SuspendLayout();
            this.materialCard2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprendimiento)).BeginInit();
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.IconoCamaraEmprendimiento)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.registrarParticipante.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconCamara)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoParticipante)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.Eventos.SuspendLayout();
            this.materialCard9.SuspendLayout();
            this.pnlConfiguracion.SuspendLayout();
            this.materialCard11.SuspendLayout();
            this.materialCard10.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.tabPremiacion.SuspendLayout();
            this.materialCard12.SuspendLayout();
            this.materialCard13.SuspendLayout();
            this.materialCard16.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tblPremiacion)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.registrarEmprendimiento);
            this.materialTabControl1.Controls.Add(this.registrarParticipante);
            this.materialTabControl1.Controls.Add(this.Eventos);
            this.materialTabControl1.Controls.Add(this.tabPremiacion);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.Salir);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(3, 65);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1605, 832);
            this.materialTabControl1.TabIndex = 0;
            this.materialTabControl1.SelectedIndexChanged += new System.EventHandler(this.Prueba_Load);
            // 
            // Home
            // 
            this.Home.Controls.Add(this.pnlBienvenida);
            this.Home.Controls.Add(this.materialCard6);
            this.Home.Controls.Add(this.materialCard5);
            this.Home.Controls.Add(this.materialCard4);
            this.Home.Controls.Add(this.materialCard1);
            this.Home.Location = new System.Drawing.Point(4, 34);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1597, 794);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.Location = new System.Drawing.Point(114, 54);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(1391, 176);
            this.pnlBienvenida.TabIndex = 9;
            this.pnlBienvenida.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlBienvenida_Paint);
            // 
            // materialCard6
            // 
            this.materialCard6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard6.Controls.Add(this.materialLabel11);
            this.materialCard6.Controls.Add(this.materialLabel6);
            this.materialCard6.Controls.Add(this.iconPictureBox5);
            this.materialCard6.Depth = 0;
            this.materialCard6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard6.Location = new System.Drawing.Point(1174, 234);
            this.materialCard6.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard6.Name = "materialCard6";
            this.materialCard6.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard6.Size = new System.Drawing.Size(322, 223);
            this.materialCard6.TabIndex = 8;
            // 
            // materialLabel11
            // 
            this.materialLabel11.AutoSize = true;
            this.materialLabel11.Depth = 0;
            this.materialLabel11.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel11.Location = new System.Drawing.Point(158, 108);
            this.materialLabel11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel11.Name = "materialLabel11";
            this.materialLabel11.Size = new System.Drawing.Size(31, 19);
            this.materialLabel11.TabIndex = 11;
            this.materialLabel11.Text = "PDF";
            // 
            // materialLabel6
            // 
            this.materialLabel6.AutoSize = true;
            this.materialLabel6.Depth = 0;
            this.materialLabel6.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel6.Location = new System.Drawing.Point(158, 78);
            this.materialLabel6.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel6.Name = "materialLabel6";
            this.materialLabel6.Size = new System.Drawing.Size(85, 19);
            this.materialLabel6.TabIndex = 10;
            this.materialLabel6.Text = "Exportacion";
            // 
            // iconPictureBox5
            // 
            this.iconPictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox5.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconPictureBox5.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox5.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox5.IconSize = 77;
            this.iconPictureBox5.Location = new System.Drawing.Point(34, 62);
            this.iconPictureBox5.Name = "iconPictureBox5";
            this.iconPictureBox5.Size = new System.Drawing.Size(92, 77);
            this.iconPictureBox5.TabIndex = 5;
            this.iconPictureBox5.TabStop = false;
            // 
            // materialCard5
            // 
            this.materialCard5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard5.Controls.Add(this.materialLabel10);
            this.materialCard5.Controls.Add(this.materialLabel5);
            this.materialCard5.Controls.Add(this.iconPictureBox4);
            this.materialCard5.Depth = 0;
            this.materialCard5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard5.Location = new System.Drawing.Point(836, 234);
            this.materialCard5.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard5.Name = "materialCard5";
            this.materialCard5.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard5.Size = new System.Drawing.Size(322, 223);
            this.materialCard5.TabIndex = 7;
            // 
            // materialLabel10
            // 
            this.materialLabel10.AutoSize = true;
            this.materialLabel10.Depth = 0;
            this.materialLabel10.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel10.Location = new System.Drawing.Point(152, 108);
            this.materialLabel10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel10.Name = "materialLabel10";
            this.materialLabel10.Size = new System.Drawing.Size(57, 19);
            this.materialLabel10.TabIndex = 9;
            this.materialLabel10.Text = "Eventos";
            // 
            // materialLabel5
            // 
            this.materialLabel5.AutoSize = true;
            this.materialLabel5.Depth = 0;
            this.materialLabel5.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel5.Location = new System.Drawing.Point(152, 78);
            this.materialLabel5.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel5.Name = "materialLabel5";
            this.materialLabel5.Size = new System.Drawing.Size(71, 19);
            this.materialLabel5.TabIndex = 8;
            this.materialLabel5.Text = "Visualizar";
            // 
            // iconPictureBox4
            // 
            this.iconPictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox4.IconChar = FontAwesome.Sharp.IconChar.Eye;
            this.iconPictureBox4.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox4.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox4.IconSize = 77;
            this.iconPictureBox4.Location = new System.Drawing.Point(32, 62);
            this.iconPictureBox4.Name = "iconPictureBox4";
            this.iconPictureBox4.Size = new System.Drawing.Size(92, 77);
            this.iconPictureBox4.TabIndex = 5;
            this.iconPictureBox4.TabStop = false;
            // 
            // materialCard4
            // 
            this.materialCard4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard4.Controls.Add(this.materialLabel9);
            this.materialCard4.Controls.Add(this.materialLabel4);
            this.materialCard4.Controls.Add(this.iconPictureBox2);
            this.materialCard4.Depth = 0;
            this.materialCard4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard4.Location = new System.Drawing.Point(456, 234);
            this.materialCard4.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard4.Name = "materialCard4";
            this.materialCard4.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard4.Size = new System.Drawing.Size(362, 223);
            this.materialCard4.TabIndex = 6;
            // 
            // materialLabel9
            // 
            this.materialLabel9.AutoSize = true;
            this.materialLabel9.Depth = 0;
            this.materialLabel9.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel9.Location = new System.Drawing.Point(152, 108);
            this.materialLabel9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel9.Name = "materialLabel9";
            this.materialLabel9.Size = new System.Drawing.Size(86, 19);
            this.materialLabel9.TabIndex = 8;
            this.materialLabel9.Text = "Participante";
            // 
            // materialLabel4
            // 
            this.materialLabel4.AutoSize = true;
            this.materialLabel4.Depth = 0;
            this.materialLabel4.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel4.Location = new System.Drawing.Point(152, 78);
            this.materialLabel4.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel4.Name = "materialLabel4";
            this.materialLabel4.Size = new System.Drawing.Size(79, 19);
            this.materialLabel4.TabIndex = 7;
            this.materialLabel4.Text = "Registrar \r\n";
            // 
            // iconPictureBox2
            // 
            this.iconPictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox2.IconChar = FontAwesome.Sharp.IconChar.Person;
            this.iconPictureBox2.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox2.IconSize = 77;
            this.iconPictureBox2.Location = new System.Drawing.Point(28, 62);
            this.iconPictureBox2.Name = "iconPictureBox2";
            this.iconPictureBox2.Size = new System.Drawing.Size(92, 77);
            this.iconPictureBox2.TabIndex = 5;
            this.iconPictureBox2.TabStop = false;
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.materialLabel8);
            this.materialCard1.Controls.Add(this.materialLabel2);
            this.materialCard1.Controls.Add(this.iconPictureBox3);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(64, 234);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(374, 223);
            this.materialCard1.TabIndex = 1;
            // 
            // materialLabel8
            // 
            this.materialLabel8.AutoSize = true;
            this.materialLabel8.Depth = 0;
            this.materialLabel8.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel8.Location = new System.Drawing.Point(146, 108);
            this.materialLabel8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel8.Name = "materialLabel8";
            this.materialLabel8.Size = new System.Drawing.Size(117, 19);
            this.materialLabel8.TabIndex = 7;
            this.materialLabel8.Text = "Emprendimiento";
            // 
            // materialLabel2
            // 
            this.materialLabel2.AutoSize = true;
            this.materialLabel2.Depth = 0;
            this.materialLabel2.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel2.Location = new System.Drawing.Point(144, 78);
            this.materialLabel2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel2.Name = "materialLabel2";
            this.materialLabel2.Size = new System.Drawing.Size(79, 19);
            this.materialLabel2.TabIndex = 6;
            this.materialLabel2.Text = "Registrar \r\n";
            // 
            // iconPictureBox3
            // 
            this.iconPictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox3.IconChar = FontAwesome.Sharp.IconChar.Pen;
            this.iconPictureBox3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(24)))), ((int)(((byte)(119)))), ((int)(((byte)(242)))));
            this.iconPictureBox3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox3.IconSize = 77;
            this.iconPictureBox3.Location = new System.Drawing.Point(26, 62);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(92, 77);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // registrarEmprendimiento
            // 
            this.registrarEmprendimiento.Controls.Add(this.pnlEmprendimientos);
            this.registrarEmprendimiento.Controls.Add(this.label1);
            this.registrarEmprendimiento.Controls.Add(this.materialCard2);
            this.registrarEmprendimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEmprendimiento.Location = new System.Drawing.Point(4, 34);
            this.registrarEmprendimiento.Name = "registrarEmprendimiento";
            this.registrarEmprendimiento.Padding = new System.Windows.Forms.Padding(3);
            this.registrarEmprendimiento.Size = new System.Drawing.Size(1597, 794);
            this.registrarEmprendimiento.TabIndex = 0;
            this.registrarEmprendimiento.Text = "Emprendimiento             ";
            this.registrarEmprendimiento.ToolTipText = "Prueba";
            this.registrarEmprendimiento.UseVisualStyleBackColor = true;
            this.registrarEmprendimiento.Click += new System.EventHandler(this.Prueba_Load);
            // 
            // pnlEmprendimientos
            // 
            this.pnlEmprendimientos.AutoScroll = true;
            this.pnlEmprendimientos.Location = new System.Drawing.Point(998, 380);
            this.pnlEmprendimientos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmprendimientos.Name = "pnlEmprendimientos";
            this.pnlEmprendimientos.Size = new System.Drawing.Size(540, 348);
            this.pnlEmprendimientos.TabIndex = 10;
            this.pnlEmprendimientos.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 25);
            this.label1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.label2);
            this.materialCard2.Controls.Add(this.tableEmprendimiento);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.txtDescripcion);
            this.materialCard2.Controls.Add(this.btnRegistrar);
            this.materialCard2.Controls.Add(this.txtNombreEmprendimiento);
            this.materialCard2.Controls.Add(this.txtRubro);
            this.materialCard2.Controls.Add(this.txtFacultad);
            this.materialCard2.Controls.Add(this.materialCard3);
            this.materialCard2.Controls.Add(this.pictureBox2);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(39, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(1527, 738);
            this.materialCard2.TabIndex = 6;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI Semibold", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(56, 82);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 31);
            this.label2.TabIndex = 15;
            this.label2.Text = "Nuevo Emprendimiento";
            // 
            // tableEmprendimiento
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tableEmprendimiento.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.tableEmprendimiento.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tableEmprendimiento.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tableEmprendimiento.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tableEmprendimiento.EnableHeadersVisualStyles = false;
            this.tableEmprendimiento.GridColor = this.tableEmprendimiento.BackgroundColor;
            this.tableEmprendimiento.Location = new System.Drawing.Point(958, 35);
            this.tableEmprendimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tableEmprendimiento.Name = "tableEmprendimiento";
            this.tableEmprendimiento.RowHeadersWidth = 62;
            this.tableEmprendimiento.Size = new System.Drawing.Size(540, 318);
            this.tableEmprendimiento.TabIndex = 9;
            this.tableEmprendimiento.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(470, 363);
            this.materialButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton1.Name = "materialButton1";
            this.materialButton1.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton1.Size = new System.Drawing.Size(122, 36);
            this.materialButton1.TabIndex = 12;
            this.materialButton1.Text = "Subir Imagen";
            this.materialButton1.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton1.UseAccentColor = false;
            this.materialButton1.UseVisualStyleBackColor = true;
            this.materialButton1.Click += new System.EventHandler(this.materialButton1_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.AnimateReadOnly = false;
            this.txtDescripcion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtDescripcion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtDescripcion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDescripcion.Depth = 0;
            this.txtDescripcion.HideSelection = true;
            this.txtDescripcion.Hint = "Descripcion breve";
            this.txtDescripcion.Location = new System.Drawing.Point(38, 382);
            this.txtDescripcion.MaxLength = 32767;
            this.txtDescripcion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.PasswordChar = '\0';
            this.txtDescripcion.ReadOnly = false;
            this.txtDescripcion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtDescripcion.SelectedText = "";
            this.txtDescripcion.SelectionLength = 0;
            this.txtDescripcion.SelectionStart = 0;
            this.txtDescripcion.ShortcutsEnabled = true;
            this.txtDescripcion.Size = new System.Drawing.Size(424, 228);
            this.txtDescripcion.TabIndex = 11;
            this.txtDescripcion.TabStop = false;
            this.txtDescripcion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtDescripcion.UseSystemPasswordChar = false;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnRegistrar.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.btnRegistrar.Depth = 0;
            this.btnRegistrar.HighEmphasis = true;
            this.btnRegistrar.Icon = null;
            this.btnRegistrar.Location = new System.Drawing.Point(38, 642);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btnRegistrar.MouseState = MaterialSkin.MouseState.HOVER;
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.NoAccentTextColor = System.Drawing.Color.Empty;
            this.btnRegistrar.Size = new System.Drawing.Size(99, 36);
            this.btnRegistrar.TabIndex = 9;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.btnRegistrar.UseAccentColor = false;
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtNombreEmprendimiento
            // 
            this.txtNombreEmprendimiento.AnimateReadOnly = false;
            this.txtNombreEmprendimiento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreEmprendimiento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreEmprendimiento.Depth = 0;
            this.txtNombreEmprendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreEmprendimiento.HideSelection = true;
            this.txtNombreEmprendimiento.Hint = "Nombre";
            this.txtNombreEmprendimiento.LeadingIcon = null;
            this.txtNombreEmprendimiento.Location = new System.Drawing.Point(38, 135);
            this.txtNombreEmprendimiento.MaxLength = 32767;
            this.txtNombreEmprendimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreEmprendimiento.Name = "txtNombreEmprendimiento";
            this.txtNombreEmprendimiento.PasswordChar = '\0';
            this.txtNombreEmprendimiento.PrefixSuffixText = null;
            this.txtNombreEmprendimiento.ReadOnly = false;
            this.txtNombreEmprendimiento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEmprendimiento.SelectedText = "";
            this.txtNombreEmprendimiento.SelectionLength = 0;
            this.txtNombreEmprendimiento.SelectionStart = 0;
            this.txtNombreEmprendimiento.ShortcutsEnabled = true;
            this.txtNombreEmprendimiento.Size = new System.Drawing.Size(225, 48);
            this.txtNombreEmprendimiento.TabIndex = 5;
            this.txtNombreEmprendimiento.TabStop = false;
            this.txtNombreEmprendimiento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreEmprendimiento.TrailingIcon = null;
            this.txtNombreEmprendimiento.UseSystemPasswordChar = false;
            this.txtNombreEmprendimiento.Click += new System.EventHandler(this.materialTextBox21_Click);
            // 
            // txtRubro
            // 
            this.txtRubro.AnimateReadOnly = false;
            this.txtRubro.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtRubro.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtRubro.Depth = 0;
            this.txtRubro.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtRubro.HideSelection = true;
            this.txtRubro.Hint = "Rubro";
            this.txtRubro.LeadingIcon = null;
            this.txtRubro.Location = new System.Drawing.Point(38, 295);
            this.txtRubro.MaxLength = 32767;
            this.txtRubro.MouseState = MaterialSkin.MouseState.OUT;
            this.txtRubro.Name = "txtRubro";
            this.txtRubro.PasswordChar = '\0';
            this.txtRubro.PrefixSuffixText = null;
            this.txtRubro.ReadOnly = false;
            this.txtRubro.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtRubro.SelectedText = "";
            this.txtRubro.SelectionLength = 0;
            this.txtRubro.SelectionStart = 0;
            this.txtRubro.ShortcutsEnabled = true;
            this.txtRubro.Size = new System.Drawing.Size(225, 48);
            this.txtRubro.TabIndex = 8;
            this.txtRubro.TabStop = false;
            this.txtRubro.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtRubro.TrailingIcon = null;
            this.txtRubro.UseSystemPasswordChar = false;
            // 
            // txtFacultad
            // 
            this.txtFacultad.AnimateReadOnly = false;
            this.txtFacultad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtFacultad.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtFacultad.Depth = 0;
            this.txtFacultad.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtFacultad.HideSelection = true;
            this.txtFacultad.Hint = "Facultad";
            this.txtFacultad.LeadingIcon = null;
            this.txtFacultad.Location = new System.Drawing.Point(38, 212);
            this.txtFacultad.MaxLength = 32767;
            this.txtFacultad.MouseState = MaterialSkin.MouseState.OUT;
            this.txtFacultad.Name = "txtFacultad";
            this.txtFacultad.PasswordChar = '\0';
            this.txtFacultad.PrefixSuffixText = null;
            this.txtFacultad.ReadOnly = false;
            this.txtFacultad.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtFacultad.SelectedText = "";
            this.txtFacultad.SelectionLength = 0;
            this.txtFacultad.SelectionStart = 0;
            this.txtFacultad.ShortcutsEnabled = true;
            this.txtFacultad.Size = new System.Drawing.Size(225, 48);
            this.txtFacultad.TabIndex = 7;
            this.txtFacultad.TabStop = false;
            this.txtFacultad.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtFacultad.TrailingIcon = null;
            this.txtFacultad.UseSystemPasswordChar = false;
            this.txtFacultad.Click += new System.EventHandler(this.materialTextBox22_Click);
            // 
            // materialCard3
            // 
            this.materialCard3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard3.Controls.Add(this.IconoCamaraEmprendimiento);
            this.materialCard3.Controls.Add(this.imgLogo);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(300, 135);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(346, 211);
            this.materialCard3.TabIndex = 0;
            this.materialCard3.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard3_Paint);
            // 
            // IconoCamaraEmprendimiento
            // 
            this.IconoCamaraEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.IconoCamaraEmprendimiento.ForeColor = System.Drawing.Color.RoyalBlue;
            this.IconoCamaraEmprendimiento.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.IconoCamaraEmprendimiento.IconColor = System.Drawing.Color.RoyalBlue;
            this.IconoCamaraEmprendimiento.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.IconoCamaraEmprendimiento.IconSize = 123;
            this.IconoCamaraEmprendimiento.Location = new System.Drawing.Point(110, 49);
            this.IconoCamaraEmprendimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.IconoCamaraEmprendimiento.Name = "IconoCamaraEmprendimiento";
            this.IconoCamaraEmprendimiento.Size = new System.Drawing.Size(123, 125);
            this.IconoCamaraEmprendimiento.TabIndex = 1;
            this.IconoCamaraEmprendimiento.TabStop = false;
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(16, 17);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(314, 188);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.Image = global::Project.Properties.Resources.emprendimiento;
            this.pictureBox2.Location = new System.Drawing.Point(18, 18);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(1491, 711);
            this.pictureBox2.TabIndex = 14;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // registrarParticipante
            // 
            this.registrarParticipante.Controls.Add(this.materialCard7);
            this.registrarParticipante.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarParticipante.Location = new System.Drawing.Point(4, 34);
            this.registrarParticipante.Name = "registrarParticipante";
            this.registrarParticipante.Padding = new System.Windows.Forms.Padding(3);
            this.registrarParticipante.Size = new System.Drawing.Size(1597, 794);
            this.registrarParticipante.TabIndex = 1;
            this.registrarParticipante.Text = "Participante                 ";
            this.registrarParticipante.UseVisualStyleBackColor = true;
            this.registrarParticipante.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.pnlCardParticipante);
            this.materialCard7.Controls.Add(this.txtSegundoApellido);
            this.materialCard7.Controls.Add(this.txtSegundoNombre);
            this.materialCard7.Controls.Add(this.txtPrimerApellido);
            this.materialCard7.Controls.Add(this.materialLabel7);
            this.materialCard7.Controls.Add(this.txtPrimerNombre);
            this.materialCard7.Controls.Add(this.txtCargo);
            this.materialCard7.Controls.Add(this.materialButton2);
            this.materialCard7.Controls.Add(this.materialCard8);
            this.materialCard7.Controls.Add(this.materialButton3);
            this.materialCard7.Controls.Add(this.pictureBox1);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(16, 45);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(1550, 731);
            this.materialCard7.TabIndex = 9;
            this.materialCard7.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard7_Paint);
            // 
            // txtSegundoApellido
            // 
            this.txtSegundoApellido.AnimateReadOnly = false;
            this.txtSegundoApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSegundoApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSegundoApellido.Depth = 0;
            this.txtSegundoApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoApellido.HideSelection = true;
            this.txtSegundoApellido.Hint = "Apellido Materno";
            this.txtSegundoApellido.LeadingIcon = null;
            this.txtSegundoApellido.Location = new System.Drawing.Point(44, 362);
            this.txtSegundoApellido.MaxLength = 32767;
            this.txtSegundoApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegundoApellido.Name = "txtSegundoApellido";
            this.txtSegundoApellido.PasswordChar = '\0';
            this.txtSegundoApellido.PrefixSuffixText = null;
            this.txtSegundoApellido.ReadOnly = false;
            this.txtSegundoApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSegundoApellido.SelectedText = "";
            this.txtSegundoApellido.SelectionLength = 0;
            this.txtSegundoApellido.SelectionStart = 0;
            this.txtSegundoApellido.ShortcutsEnabled = true;
            this.txtSegundoApellido.Size = new System.Drawing.Size(369, 48);
            this.txtSegundoApellido.TabIndex = 17;
            this.txtSegundoApellido.TabStop = false;
            this.txtSegundoApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSegundoApellido.TrailingIcon = null;
            this.txtSegundoApellido.UseSystemPasswordChar = false;
            // 
            // txtSegundoNombre
            // 
            this.txtSegundoNombre.AnimateReadOnly = false;
            this.txtSegundoNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtSegundoNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtSegundoNombre.Depth = 0;
            this.txtSegundoNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtSegundoNombre.HideSelection = true;
            this.txtSegundoNombre.Hint = "Segundo Nombre";
            this.txtSegundoNombre.LeadingIcon = null;
            this.txtSegundoNombre.Location = new System.Drawing.Point(334, 111);
            this.txtSegundoNombre.MaxLength = 32767;
            this.txtSegundoNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtSegundoNombre.Name = "txtSegundoNombre";
            this.txtSegundoNombre.PasswordChar = '\0';
            this.txtSegundoNombre.PrefixSuffixText = null;
            this.txtSegundoNombre.ReadOnly = false;
            this.txtSegundoNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtSegundoNombre.SelectedText = "";
            this.txtSegundoNombre.SelectionLength = 0;
            this.txtSegundoNombre.SelectionStart = 0;
            this.txtSegundoNombre.ShortcutsEnabled = true;
            this.txtSegundoNombre.Size = new System.Drawing.Size(258, 48);
            this.txtSegundoNombre.TabIndex = 16;
            this.txtSegundoNombre.TabStop = false;
            this.txtSegundoNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtSegundoNombre.TrailingIcon = null;
            this.txtSegundoNombre.UseSystemPasswordChar = false;
            // 
            // txtPrimerApellido
            // 
            this.txtPrimerApellido.AnimateReadOnly = false;
            this.txtPrimerApellido.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrimerApellido.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrimerApellido.Depth = 0;
            this.txtPrimerApellido.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerApellido.HideSelection = true;
            this.txtPrimerApellido.Hint = "Apellido Paterno";
            this.txtPrimerApellido.LeadingIcon = null;
            this.txtPrimerApellido.Location = new System.Drawing.Point(44, 240);
            this.txtPrimerApellido.MaxLength = 32767;
            this.txtPrimerApellido.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimerApellido.Name = "txtPrimerApellido";
            this.txtPrimerApellido.PasswordChar = '\0';
            this.txtPrimerApellido.PrefixSuffixText = null;
            this.txtPrimerApellido.ReadOnly = false;
            this.txtPrimerApellido.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrimerApellido.SelectedText = "";
            this.txtPrimerApellido.SelectionLength = 0;
            this.txtPrimerApellido.SelectionStart = 0;
            this.txtPrimerApellido.ShortcutsEnabled = true;
            this.txtPrimerApellido.Size = new System.Drawing.Size(369, 48);
            this.txtPrimerApellido.TabIndex = 15;
            this.txtPrimerApellido.TabStop = false;
            this.txtPrimerApellido.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrimerApellido.TrailingIcon = null;
            this.txtPrimerApellido.UseSystemPasswordChar = false;
            this.txtPrimerApellido.Click += new System.EventHandler(this.materialTextBox21_Click_2);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(39, 55);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(135, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Nuevo Participante";
            // 
            // txtPrimerNombre
            // 
            this.txtPrimerNombre.AnimateReadOnly = false;
            this.txtPrimerNombre.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtPrimerNombre.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtPrimerNombre.Depth = 0;
            this.txtPrimerNombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtPrimerNombre.HideSelection = true;
            this.txtPrimerNombre.Hint = "Primer Nombre";
            this.txtPrimerNombre.LeadingIcon = null;
            this.txtPrimerNombre.Location = new System.Drawing.Point(44, 111);
            this.txtPrimerNombre.MaxLength = 32767;
            this.txtPrimerNombre.MouseState = MaterialSkin.MouseState.OUT;
            this.txtPrimerNombre.Name = "txtPrimerNombre";
            this.txtPrimerNombre.PasswordChar = '\0';
            this.txtPrimerNombre.PrefixSuffixText = null;
            this.txtPrimerNombre.ReadOnly = false;
            this.txtPrimerNombre.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtPrimerNombre.SelectedText = "";
            this.txtPrimerNombre.SelectionLength = 0;
            this.txtPrimerNombre.SelectionStart = 0;
            this.txtPrimerNombre.ShortcutsEnabled = true;
            this.txtPrimerNombre.Size = new System.Drawing.Size(258, 48);
            this.txtPrimerNombre.TabIndex = 6;
            this.txtPrimerNombre.TabStop = false;
            this.txtPrimerNombre.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtPrimerNombre.TrailingIcon = null;
            this.txtPrimerNombre.UseSystemPasswordChar = false;
            this.txtPrimerNombre.Click += new System.EventHandler(this.materialTextBox21_Click_1);
            // 
            // txtCargo
            // 
            this.txtCargo.AnimateReadOnly = false;
            this.txtCargo.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtCargo.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtCargo.Depth = 0;
            this.txtCargo.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtCargo.HideSelection = true;
            this.txtCargo.Hint = "Cargo";
            this.txtCargo.LeadingIcon = null;
            this.txtCargo.Location = new System.Drawing.Point(44, 495);
            this.txtCargo.MaxLength = 32767;
            this.txtCargo.MouseState = MaterialSkin.MouseState.OUT;
            this.txtCargo.Name = "txtCargo";
            this.txtCargo.PasswordChar = '\0';
            this.txtCargo.PrefixSuffixText = null;
            this.txtCargo.ReadOnly = false;
            this.txtCargo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCargo.SelectedText = "";
            this.txtCargo.SelectionLength = 0;
            this.txtCargo.SelectionStart = 0;
            this.txtCargo.ShortcutsEnabled = true;
            this.txtCargo.Size = new System.Drawing.Size(369, 48);
            this.txtCargo.TabIndex = 7;
            this.txtCargo.TabStop = false;
            this.txtCargo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtCargo.TrailingIcon = null;
            this.txtCargo.UseSystemPasswordChar = false;
            // 
            // materialButton2
            // 
            this.materialButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton2.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton2.Depth = 0;
            this.materialButton2.HighEmphasis = true;
            this.materialButton2.Icon = null;
            this.materialButton2.Location = new System.Drawing.Point(44, 622);
            this.materialButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton2.Name = "materialButton2";
            this.materialButton2.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton2.Size = new System.Drawing.Size(99, 36);
            this.materialButton2.TabIndex = 8;
            this.materialButton2.Text = "Registrar ";
            this.materialButton2.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton2.UseAccentColor = false;
            this.materialButton2.UseVisualStyleBackColor = true;
            this.materialButton2.Click += new System.EventHandler(this.materialButton2_Click);
            // 
            // materialCard8
            // 
            this.materialCard8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.materialCard8.Controls.Add(this.iconCamara);
            this.materialCard8.Controls.Add(this.imgLogoParticipante);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(609, 28);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(347, 285);
            this.materialCard8.TabIndex = 10;
            // 
            // iconCamara
            // 
            this.iconCamara.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.iconCamara.ForeColor = System.Drawing.Color.RoyalBlue;
            this.iconCamara.IconChar = FontAwesome.Sharp.IconChar.CameraRetro;
            this.iconCamara.IconColor = System.Drawing.Color.RoyalBlue;
            this.iconCamara.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconCamara.IconSize = 123;
            this.iconCamara.Location = new System.Drawing.Point(116, 82);
            this.iconCamara.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconCamara.Name = "iconCamara";
            this.iconCamara.Size = new System.Drawing.Size(123, 125);
            this.iconCamara.TabIndex = 19;
            this.iconCamara.TabStop = false;
            // 
            // imgLogoParticipante
            // 
            this.imgLogoParticipante.Location = new System.Drawing.Point(18, 17);
            this.imgLogoParticipante.Name = "imgLogoParticipante";
            this.imgLogoParticipante.Size = new System.Drawing.Size(314, 249);
            this.imgLogoParticipante.TabIndex = 0;
            this.imgLogoParticipante.TabStop = false;
            this.imgLogoParticipante.Click += new System.EventHandler(this.imgLogoParticipante_Click);
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(609, 323);
            this.materialButton3.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialButton3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialButton3.Name = "materialButton3";
            this.materialButton3.NoAccentTextColor = System.Drawing.Color.Empty;
            this.materialButton3.Size = new System.Drawing.Size(122, 36);
            this.materialButton3.TabIndex = 13;
            this.materialButton3.Text = "Subir Imagen";
            this.materialButton3.Type = MaterialSkin.Controls.MaterialButton.MaterialButtonType.Contained;
            this.materialButton3.UseAccentColor = false;
            this.materialButton3.UseVisualStyleBackColor = true;
            this.materialButton3.Click += new System.EventHandler(this.materialButton3_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Image = global::Project.Properties.Resources.register21;
            this.pictureBox1.Location = new System.Drawing.Point(297, 2);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1228, 726);
            this.pictureBox1.TabIndex = 18;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Eventos
            // 
            this.Eventos.Controls.Add(this.materialCard9);
            this.Eventos.Location = new System.Drawing.Point(4, 34);
            this.Eventos.Name = "Eventos";
            this.Eventos.Size = new System.Drawing.Size(1597, 794);
            this.Eventos.TabIndex = 3;
            this.Eventos.Text = "Eventos";
            this.Eventos.UseVisualStyleBackColor = true;
            // 
            // materialCard9
            // 
            this.materialCard9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard9.Controls.Add(this.pnlConfiguracion);
            this.materialCard9.Controls.Add(this.pnlEmprendimientoCards);
            this.materialCard9.Depth = 0;
            this.materialCard9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard9.Location = new System.Drawing.Point(20, 29);
            this.materialCard9.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard9.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard9.Name = "materialCard9";
            this.materialCard9.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard9.Size = new System.Drawing.Size(1550, 746);
            this.materialCard9.TabIndex = 10;
            this.materialCard9.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard9_Paint);
            // 
            // pnlConfiguracion
            // 
            this.pnlConfiguracion.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlConfiguracion.Controls.Add(this.materialCard11);
            this.pnlConfiguracion.Controls.Add(this.txtTituloEvento);
            this.pnlConfiguracion.Controls.Add(this.materialCard10);
            this.pnlConfiguracion.Depth = 0;
            this.pnlConfiguracion.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlConfiguracion.Location = new System.Drawing.Point(915, 18);
            this.pnlConfiguracion.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.pnlConfiguracion.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlConfiguracion.Name = "pnlConfiguracion";
            this.pnlConfiguracion.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.pnlConfiguracion.Size = new System.Drawing.Size(627, 709);
            this.pnlConfiguracion.TabIndex = 20;
            // 
            // materialCard11
            // 
            this.materialCard11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard11.Controls.Add(this.cancelBoton);
            this.materialCard11.Controls.Add(this.botonGuardar);
            this.materialCard11.Controls.Add(this.pnlConfiguracion2);
            this.materialCard11.Depth = 0;
            this.materialCard11.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard11.Location = new System.Drawing.Point(18, 332);
            this.materialCard11.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard11.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard11.Name = "materialCard11";
            this.materialCard11.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard11.Size = new System.Drawing.Size(592, 360);
            this.materialCard11.TabIndex = 3;
            // 
            // cancelBoton
            // 
            this.cancelBoton.FlatAppearance.BorderSize = 0;
            this.cancelBoton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelBoton.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.cancelBoton.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelBoton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelBoton.Location = new System.Drawing.Point(402, 271);
            this.cancelBoton.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cancelBoton.Name = "cancelBoton";
            this.cancelBoton.Size = new System.Drawing.Size(112, 80);
            this.cancelBoton.TabIndex = 2;
            this.cancelBoton.UseVisualStyleBackColor = true;
            // 
            // botonGuardar
            // 
            this.botonGuardar.FlatAppearance.BorderSize = 0;
            this.botonGuardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.botonGuardar.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.botonGuardar.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.botonGuardar.IconColor = System.Drawing.Color.Green;
            this.botonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.botonGuardar.Location = new System.Drawing.Point(153, 271);
            this.botonGuardar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.botonGuardar.Name = "botonGuardar";
            this.botonGuardar.Size = new System.Drawing.Size(112, 80);
            this.botonGuardar.TabIndex = 1;
            this.botonGuardar.UseVisualStyleBackColor = true;
            this.botonGuardar.Click += new System.EventHandler(this.botonGuardar_Click);
            // 
            // pnlConfiguracion2
            // 
            this.pnlConfiguracion2.Location = new System.Drawing.Point(8, 12);
            this.pnlConfiguracion2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlConfiguracion2.Name = "pnlConfiguracion2";
            this.pnlConfiguracion2.Size = new System.Drawing.Size(576, 237);
            this.pnlConfiguracion2.TabIndex = 0;
            this.pnlConfiguracion2.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlConfiguracion2_Paint);
            // 
            // txtTituloEvento
            // 
            this.txtTituloEvento.AnimateReadOnly = false;
            this.txtTituloEvento.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTituloEvento.Depth = 0;
            this.txtTituloEvento.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtTituloEvento.Hint = "Nombre del Evento";
            this.txtTituloEvento.LeadingIcon = null;
            this.txtTituloEvento.Location = new System.Drawing.Point(26, 9);
            this.txtTituloEvento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTituloEvento.MaxLength = 50;
            this.txtTituloEvento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtTituloEvento.Multiline = false;
            this.txtTituloEvento.Name = "txtTituloEvento";
            this.txtTituloEvento.Size = new System.Drawing.Size(483, 50);
            this.txtTituloEvento.TabIndex = 0;
            this.txtTituloEvento.Text = "";
            this.txtTituloEvento.TrailingIcon = null;
            this.txtTituloEvento.TextChanged += new System.EventHandler(this.materialTextBox1_TextChanged);
            // 
            // materialCard10
            // 
            this.materialCard10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard10.Controls.Add(this.iconButton3);
            this.materialCard10.Controls.Add(this.txtUbicacion);
            this.materialCard10.Controls.Add(this.materialLabel12);
            this.materialCard10.Controls.Add(this.materialLabel3);
            this.materialCard10.Controls.Add(this.iconButton1);
            this.materialCard10.Controls.Add(this.pictureBox3);
            this.materialCard10.Controls.Add(this.dateHourOut);
            this.materialCard10.Controls.Add(this.fechaExposicion);
            this.materialCard10.Controls.Add(this.dateHourIn);
            this.materialCard10.Depth = 0;
            this.materialCard10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard10.Location = new System.Drawing.Point(18, 60);
            this.materialCard10.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard10.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard10.Name = "materialCard10";
            this.materialCard10.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard10.Size = new System.Drawing.Size(592, 258);
            this.materialCard10.TabIndex = 2;
            // 
            // iconButton3
            // 
            this.iconButton3.FlatAppearance.BorderSize = 0;
            this.iconButton3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton3.IconChar = FontAwesome.Sharp.IconChar.Flag;
            this.iconButton3.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.iconButton3.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton3.IconSize = 25;
            this.iconButton3.Location = new System.Drawing.Point(198, 122);
            this.iconButton3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton3.Name = "iconButton3";
            this.iconButton3.Size = new System.Drawing.Size(52, 38);
            this.iconButton3.TabIndex = 9;
            this.iconButton3.UseVisualStyleBackColor = true;
            // 
            // txtUbicacion
            // 
            this.txtUbicacion.AnimateReadOnly = false;
            this.txtUbicacion.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtUbicacion.Depth = 0;
            this.txtUbicacion.Font = new System.Drawing.Font("Roboto", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUbicacion.Hint = "Ubicacion";
            this.txtUbicacion.LeadingIcon = null;
            this.txtUbicacion.Location = new System.Drawing.Point(26, 169);
            this.txtUbicacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtUbicacion.MaxLength = 50;
            this.txtUbicacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUbicacion.Multiline = false;
            this.txtUbicacion.Name = "txtUbicacion";
            this.txtUbicacion.Size = new System.Drawing.Size(358, 50);
            this.txtUbicacion.TabIndex = 4;
            this.txtUbicacion.Text = "";
            this.txtUbicacion.TrailingIcon = null;
            // 
            // materialLabel12
            // 
            this.materialLabel12.AutoSize = true;
            this.materialLabel12.Depth = 0;
            this.materialLabel12.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel12.Location = new System.Drawing.Point(249, 91);
            this.materialLabel12.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel12.Name = "materialLabel12";
            this.materialLabel12.Size = new System.Drawing.Size(64, 19);
            this.materialLabel12.TabIndex = 7;
            this.materialLabel12.Text = "Termina:";
            this.materialLabel12.Click += new System.EventHandler(this.materialLabel12_Click);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(26, 91);
            this.materialLabel3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(66, 19);
            this.materialLabel3.TabIndex = 6;
            this.materialLabel3.Text = "Empieza:";
            this.materialLabel3.Click += new System.EventHandler(this.materialLabel3_Click);
            // 
            // iconButton1
            // 
            this.iconButton1.FlatAppearance.BorderSize = 0;
            this.iconButton1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.iconButton1.IconChar = FontAwesome.Sharp.IconChar.Stopwatch;
            this.iconButton1.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton1.IconSize = 25;
            this.iconButton1.Location = new System.Drawing.Point(8, 122);
            this.iconButton1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton1.Name = "iconButton1";
            this.iconButton1.Size = new System.Drawing.Size(52, 38);
            this.iconButton1.TabIndex = 2;
            this.iconButton1.UseVisualStyleBackColor = true;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox3.Image = global::Project.Properties.Resources.p1__1_;
            this.pictureBox3.Location = new System.Drawing.Point(402, 35);
            this.pictureBox3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(188, 175);
            this.pictureBox3.TabIndex = 5;
            this.pictureBox3.TabStop = false;
            // 
            // dateHourOut
            // 
            this.dateHourOut.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHourOut.Location = new System.Drawing.Point(254, 125);
            this.dateHourOut.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateHourOut.Name = "dateHourOut";
            this.dateHourOut.Size = new System.Drawing.Size(128, 31);
            this.dateHourOut.TabIndex = 4;
            // 
            // fechaExposicion
            // 
            this.fechaExposicion.Location = new System.Drawing.Point(26, 35);
            this.fechaExposicion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.fechaExposicion.Name = "fechaExposicion";
            this.fechaExposicion.Size = new System.Drawing.Size(356, 31);
            this.fechaExposicion.TabIndex = 1;
            // 
            // dateHourIn
            // 
            this.dateHourIn.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateHourIn.Location = new System.Drawing.Point(69, 125);
            this.dateHourIn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateHourIn.Name = "dateHourIn";
            this.dateHourIn.Size = new System.Drawing.Size(118, 31);
            this.dateHourIn.TabIndex = 3;
            this.dateHourIn.ValueChanged += new System.EventHandler(this.dateTimePicker2_ValueChanged);
            // 
            // pnlEmprendimientoCards
            // 
            this.pnlEmprendimientoCards.AutoScroll = true;
            this.pnlEmprendimientoCards.Location = new System.Drawing.Point(18, 18);
            this.pnlEmprendimientoCards.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pnlEmprendimientoCards.Name = "pnlEmprendimientoCards";
            this.pnlEmprendimientoCards.Size = new System.Drawing.Size(880, 709);
            this.pnlEmprendimientoCards.TabIndex = 19;
            this.pnlEmprendimientoCards.Paint += new System.Windows.Forms.PaintEventHandler(this.flowLayoutPanel1_Paint_1);
            // 
            // tabPremiacion
            // 
            this.tabPremiacion.Controls.Add(this.materialCard12);
            this.tabPremiacion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.tabPremiacion.Location = new System.Drawing.Point(4, 34);
            this.tabPremiacion.Name = "tabPremiacion";
            this.tabPremiacion.Size = new System.Drawing.Size(1597, 794);
            this.tabPremiacion.TabIndex = 5;
            this.tabPremiacion.Text = "Premiacion";
            this.tabPremiacion.UseVisualStyleBackColor = true;
            this.tabPremiacion.Click += new System.EventHandler(this.tabPage1_Click_1);
            // 
            // materialCard12
            // 
            this.materialCard12.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard12.Controls.Add(this.materialLabel13);
            this.materialCard12.Controls.Add(this.materialCard13);
            this.materialCard12.Controls.Add(this.txtGanadores);
            this.materialCard12.Controls.Add(this.iconButton2);
            this.materialCard12.Controls.Add(this.materialCard16);
            this.materialCard12.Controls.Add(this.pictureBox4);
            this.materialCard12.Depth = 0;
            this.materialCard12.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard12.Location = new System.Drawing.Point(15, 22);
            this.materialCard12.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard12.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard12.Name = "materialCard12";
            this.materialCard12.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard12.Size = new System.Drawing.Size(1552, 752);
            this.materialCard12.TabIndex = 0;
            this.materialCard12.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard12_Paint);
            // 
            // materialLabel13
            // 
            this.materialLabel13.AutoSize = true;
            this.materialLabel13.Depth = 0;
            this.materialLabel13.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel13.Location = new System.Drawing.Point(52, 257);
            this.materialLabel13.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.materialLabel13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel13.Name = "materialLabel13";
            this.materialLabel13.Size = new System.Drawing.Size(169, 19);
            this.materialLabel13.TabIndex = 6;
            this.materialLabel13.Text = " PremiacionesCategoria";
            // 
            // materialCard13
            // 
            this.materialCard13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard13.Controls.Add(this.btnGuardarCategorias);
            this.materialCard13.Controls.Add(this.txtObservacion);
            this.materialCard13.Controls.Add(this.cmbEmprendimiento);
            this.materialCard13.Controls.Add(this.cmbCategoria);
            this.materialCard13.Depth = 0;
            this.materialCard13.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard13.Location = new System.Drawing.Point(26, 88);
            this.materialCard13.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard13.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard13.Name = "materialCard13";
            this.materialCard13.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard13.Size = new System.Drawing.Size(1502, 148);
            this.materialCard13.TabIndex = 1;
            this.materialCard13.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard13_Paint);
            // 
            // btnGuardarCategorias
            // 
            this.btnGuardarCategorias.FlatAppearance.BorderSize = 0;
            this.btnGuardarCategorias.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnGuardarCategorias.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnGuardarCategorias.IconChar = FontAwesome.Sharp.IconChar.CircleCheck;
            this.btnGuardarCategorias.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnGuardarCategorias.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnGuardarCategorias.Location = new System.Drawing.Point(1364, 45);
            this.btnGuardarCategorias.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnGuardarCategorias.Name = "btnGuardarCategorias";
            this.btnGuardarCategorias.Size = new System.Drawing.Size(112, 80);
            this.btnGuardarCategorias.TabIndex = 3;
            this.btnGuardarCategorias.UseVisualStyleBackColor = true;
            this.btnGuardarCategorias.Click += new System.EventHandler(this.iconButton4_Click);
            // 
            // txtObservacion
            // 
            this.txtObservacion.AnimateReadOnly = false;
            this.txtObservacion.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtObservacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtObservacion.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtObservacion.Depth = 0;
            this.txtObservacion.HideSelection = true;
            this.txtObservacion.Location = new System.Drawing.Point(960, 48);
            this.txtObservacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtObservacion.MaxLength = 32767;
            this.txtObservacion.MouseState = MaterialSkin.MouseState.OUT;
            this.txtObservacion.Name = "txtObservacion";
            this.txtObservacion.PasswordChar = '\0';
            this.txtObservacion.ReadOnly = false;
            this.txtObservacion.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.txtObservacion.SelectedText = "";
            this.txtObservacion.SelectionLength = 0;
            this.txtObservacion.SelectionStart = 0;
            this.txtObservacion.ShortcutsEnabled = true;
            this.txtObservacion.Size = new System.Drawing.Size(375, 78);
            this.txtObservacion.TabIndex = 2;
            this.txtObservacion.TabStop = false;
            this.txtObservacion.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtObservacion.UseSystemPasswordChar = false;
            this.txtObservacion.Click += new System.EventHandler(this.materialMultiLineTextBox21_Click);
            // 
            // cmbEmprendimiento
            // 
            this.cmbEmprendimiento.AutoResize = false;
            this.cmbEmprendimiento.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbEmprendimiento.Depth = 0;
            this.cmbEmprendimiento.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbEmprendimiento.DropDownHeight = 174;
            this.cmbEmprendimiento.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbEmprendimiento.DropDownWidth = 121;
            this.cmbEmprendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbEmprendimiento.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbEmprendimiento.FormattingEnabled = true;
            this.cmbEmprendimiento.IntegralHeight = false;
            this.cmbEmprendimiento.ItemHeight = 43;
            this.cmbEmprendimiento.Location = new System.Drawing.Point(549, 51);
            this.cmbEmprendimiento.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbEmprendimiento.MaxDropDownItems = 4;
            this.cmbEmprendimiento.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbEmprendimiento.Name = "cmbEmprendimiento";
            this.cmbEmprendimiento.Size = new System.Drawing.Size(328, 49);
            this.cmbEmprendimiento.StartIndex = 0;
            this.cmbEmprendimiento.TabIndex = 1;
            this.cmbEmprendimiento.SelectedIndexChanged += new System.EventHandler(this.cmbEmprendimiento_SelectedIndexChanged);
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.AutoResize = false;
            this.cmbCategoria.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.cmbCategoria.Depth = 0;
            this.cmbCategoria.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawVariable;
            this.cmbCategoria.DropDownHeight = 174;
            this.cmbCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCategoria.DropDownWidth = 121;
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Pixel);
            this.cmbCategoria.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.IntegralHeight = false;
            this.cmbCategoria.ItemHeight = 43;
            this.cmbCategoria.Location = new System.Drawing.Point(32, 48);
            this.cmbCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cmbCategoria.MaxDropDownItems = 4;
            this.cmbCategoria.MouseState = MaterialSkin.MouseState.OUT;
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(463, 49);
            this.cmbCategoria.StartIndex = 0;
            this.cmbCategoria.TabIndex = 0;
            this.cmbCategoria.SelectedIndexChanged += new System.EventHandler(this.cmbCategoria_SelectedIndexChanged);
            // 
            // txtGanadores
            // 
            this.txtGanadores.AutoSize = true;
            this.txtGanadores.Depth = 0;
            this.txtGanadores.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtGanadores.Location = new System.Drawing.Point(52, 37);
            this.txtGanadores.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.txtGanadores.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtGanadores.Name = "txtGanadores";
            this.txtGanadores.Size = new System.Drawing.Size(97, 19);
            this.txtGanadores.TabIndex = 5;
            this.txtGanadores.Text = "Premiaciones";
            // 
            // iconButton2
            // 
            this.iconButton2.FlatAppearance.BorderSize = 0;
            this.iconButton2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.iconButton2.ForeColor = System.Drawing.Color.Red;
            this.iconButton2.IconChar = FontAwesome.Sharp.IconChar.FilePdf;
            this.iconButton2.IconColor = System.Drawing.Color.Red;
            this.iconButton2.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconButton2.Location = new System.Drawing.Point(1202, 308);
            this.iconButton2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.iconButton2.Name = "iconButton2";
            this.iconButton2.Size = new System.Drawing.Size(108, 82);
            this.iconButton2.TabIndex = 4;
            this.iconButton2.UseVisualStyleBackColor = true;
            this.iconButton2.Click += new System.EventHandler(this.iconButton2_Click);
            // 
            // materialCard16
            // 
            this.materialCard16.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard16.Controls.Add(this.tblPremiacion);
            this.materialCard16.Depth = 0;
            this.materialCard16.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard16.Location = new System.Drawing.Point(26, 308);
            this.materialCard16.Margin = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard16.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard16.Name = "materialCard16";
            this.materialCard16.Padding = new System.Windows.Forms.Padding(21, 22, 21, 22);
            this.materialCard16.Size = new System.Drawing.Size(1154, 414);
            this.materialCard16.TabIndex = 3;
            this.materialCard16.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard16_Paint);
            // 
            // tblPremiacion
            // 
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.tblPremiacion.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle2;
            this.tblPremiacion.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.tblPremiacion.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.tblPremiacion.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tblPremiacion.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tblPremiacion.EnableHeadersVisualStyles = false;
            this.tblPremiacion.GridColor = this.tblPremiacion.BackgroundColor;
            this.tblPremiacion.Location = new System.Drawing.Point(21, 22);
            this.tblPremiacion.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tblPremiacion.Name = "tblPremiacion";
            this.tblPremiacion.RowHeadersWidth = 62;
            this.tblPremiacion.Size = new System.Drawing.Size(1112, 370);
            this.tblPremiacion.TabIndex = 10;
            this.tblPremiacion.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.tblPremiacion_CellContentClick);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = global::Project.Properties.Resources.premios2_0;
            this.pictureBox4.Location = new System.Drawing.Point(807, 37);
            this.pictureBox4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(183, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 0;
            this.pictureBox4.TabStop = false;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 34);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1597, 794);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 34);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1597, 794);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 34);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1597, 794);
            this.tabPage4.TabIndex = 8;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 34);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1597, 794);
            this.tabPage5.TabIndex = 9;
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(4, 34);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(1597, 794);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir ";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(693, 32);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(1, 0);
            this.materialLabel1.TabIndex = 1;
            this.materialLabel1.Click += new System.EventHandler(this.materialLabel1_Click);
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.User;
            this.iconPictureBox1.IconColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 38;
            this.iconPictureBox1.Location = new System.Drawing.Point(1280, 48);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 38);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // pnlCardParticipante
            // 
            this.pnlCardParticipante.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.pnlCardParticipante.Depth = 0;
            this.pnlCardParticipante.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pnlCardParticipante.Location = new System.Drawing.Point(984, 28);
            this.pnlCardParticipante.Margin = new System.Windows.Forms.Padding(14);
            this.pnlCardParticipante.MouseState = MaterialSkin.MouseState.HOVER;
            this.pnlCardParticipante.Name = "pnlCardParticipante";
            this.pnlCardParticipante.Padding = new System.Windows.Forms.Padding(14);
            this.pnlCardParticipante.Size = new System.Drawing.Size(511, 643);
            this.pnlCardParticipante.TabIndex = 19;
            this.pnlCardParticipante.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard14_Paint);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1611, 900);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FrmAdminMain";
            this.Padding = new System.Windows.Forms.Padding(3, 65, 3, 3);
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Prueba_Load);
            this.materialTabControl1.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            this.materialCard6.ResumeLayout(false);
            this.materialCard6.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox5)).EndInit();
            this.materialCard5.ResumeLayout(false);
            this.materialCard5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox4)).EndInit();
            this.materialCard4.ResumeLayout(false);
            this.materialCard4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox2)).EndInit();
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox3)).EndInit();
            this.registrarEmprendimiento.ResumeLayout(false);
            this.registrarEmprendimiento.PerformLayout();
            this.materialCard2.ResumeLayout(false);
            this.materialCard2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tableEmprendimiento)).EndInit();
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.IconoCamaraEmprendimiento)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.registrarParticipante.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconCamara)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoParticipante)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.Eventos.ResumeLayout(false);
            this.materialCard9.ResumeLayout(false);
            this.pnlConfiguracion.ResumeLayout(false);
            this.materialCard11.ResumeLayout(false);
            this.materialCard10.ResumeLayout(false);
            this.materialCard10.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.tabPremiacion.ResumeLayout(false);
            this.materialCard12.ResumeLayout(false);
            this.materialCard12.PerformLayout();
            this.materialCard13.ResumeLayout(false);
            this.materialCard16.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tblPremiacion)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialTabControl materialTabControl1;
        private System.Windows.Forms.TabPage registrarEmprendimiento;
        private System.Windows.Forms.TabPage registrarParticipante;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private Label label1;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreEmprendimiento;
        private MaterialSkin.Controls.MaterialCard materialCard2;
        private MaterialSkin.Controls.MaterialCard materialCard3;
        private MaterialSkin.Controls.MaterialTextBox2 txtRubro;
        private MaterialSkin.Controls.MaterialTextBox2 txtFacultad;
        private MaterialSkin.Controls.MaterialButton btnRegistrar;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox imgLogo;
        private TabPage Eventos;
        private TabPage Salir;
        private TabPage tabPremiacion;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtCargo;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private PictureBox imgLogoParticipante;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialLabel materialLabel7;
        private TabPage Home;
        private Panel pnlBienvenida;
        private MaterialSkin.Controls.MaterialCard materialCard6;
        private MaterialSkin.Controls.MaterialLabel materialLabel11;
        private MaterialSkin.Controls.MaterialLabel materialLabel6;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox5;
        private MaterialSkin.Controls.MaterialCard materialCard5;
        private MaterialSkin.Controls.MaterialLabel materialLabel10;
        private MaterialSkin.Controls.MaterialLabel materialLabel5;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox4;
        private MaterialSkin.Controls.MaterialCard materialCard4;
        private MaterialSkin.Controls.MaterialLabel materialLabel9;
        private MaterialSkin.Controls.MaterialLabel materialLabel4;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox2;
        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialLabel materialLabel8;
        private MaterialSkin.Controls.MaterialLabel materialLabel2;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox3;
        private DataGridView tableEmprendimiento;
        private FlowLayoutPanel pnlEmprendimientos;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegundoApellido;
        private MaterialSkin.Controls.MaterialTextBox2 txtSegundoNombre;
        private MaterialSkin.Controls.MaterialTextBox2 txtPrimerApellido;
        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private FontAwesome.Sharp.IconPictureBox IconoCamaraEmprendimiento;
        private Label label2;
        private FontAwesome.Sharp.IconPictureBox iconCamara;
        private MaterialSkin.Controls.MaterialCard materialCard9;
        private FlowLayoutPanel pnlEmprendimientoCards;
        private MaterialSkin.Controls.MaterialCard pnlConfiguracion;
        private FlowLayoutPanel pnlConfiguracion2;
        private DateTimePicker fechaExposicion;
        private MaterialSkin.Controls.MaterialCard materialCard10;
        private MaterialSkin.Controls.MaterialTextBox txtTituloEvento;
        private DateTimePicker dateHourIn;
        private DateTimePicker dateHourOut;
        private MaterialSkin.Controls.MaterialCard materialCard11;
        private FontAwesome.Sharp.IconButton botonGuardar;
        private FontAwesome.Sharp.IconButton cancelBoton;
        private PictureBox pictureBox3;
        private MaterialSkin.Controls.MaterialLabel materialLabel12;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private FontAwesome.Sharp.IconButton iconButton1;
        private MaterialSkin.Controls.MaterialTextBox txtUbicacion;
        private FontAwesome.Sharp.IconButton iconButton3;
        private MaterialSkin.Controls.MaterialCard materialCard12;
        private PictureBox pictureBox4;
        private MaterialSkin.Controls.MaterialCard materialCard13;
        private MaterialSkin.Controls.MaterialCard materialCard16;
        private FontAwesome.Sharp.IconButton iconButton2;
        private MaterialSkin.Controls.MaterialLabel txtGanadores;
        private MaterialSkin.Controls.MaterialLabel materialLabel13;
        private MaterialSkin.Controls.MaterialComboBox cmbCategoria;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtObservacion;
        private MaterialSkin.Controls.MaterialComboBox cmbEmprendimiento;
        private DataGridView tblPremiacion;
        private FontAwesome.Sharp.IconButton btnGuardarCategorias;
        private MaterialSkin.Controls.MaterialCard pnlCardParticipante;
    }
}