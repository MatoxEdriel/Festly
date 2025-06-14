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
            this.lstBoxEmprendimiento = new MaterialSkin.Controls.MaterialListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.materialCard2 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel3 = new MaterialSkin.Controls.MaterialLabel();
            this.materialButton1 = new MaterialSkin.Controls.MaterialButton();
            this.txtDescripcion = new MaterialSkin.Controls.MaterialMultiLineTextBox2();
            this.btnRegistrar = new MaterialSkin.Controls.MaterialButton();
            this.txtNombreEmprendimiento = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtRubro = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtFacultad = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialCard3 = new MaterialSkin.Controls.MaterialCard();
            this.imgLogo = new System.Windows.Forms.PictureBox();
            this.registrarParticipante = new System.Windows.Forms.TabPage();
            this.materialCard7 = new MaterialSkin.Controls.MaterialCard();
            this.materialLabel7 = new MaterialSkin.Controls.MaterialLabel();
            this.txtNombreCompleto = new MaterialSkin.Controls.MaterialTextBox2();
            this.txtCargo = new MaterialSkin.Controls.MaterialTextBox2();
            this.materialButton2 = new MaterialSkin.Controls.MaterialButton();
            this.materialCard8 = new MaterialSkin.Controls.MaterialCard();
            this.imgLogoParticipante = new System.Windows.Forms.PictureBox();
            this.materialButton3 = new MaterialSkin.Controls.MaterialButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lstBoxParticipante = new MaterialSkin.Controls.MaterialListBox();
            this.Eventos = new System.Windows.Forms.TabPage();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.Salir = new System.Windows.Forms.TabPage();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
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
            this.materialCard3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).BeginInit();
            this.registrarParticipante.SuspendLayout();
            this.materialCard7.SuspendLayout();
            this.materialCard8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoParticipante)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialTabControl1
            // 
            this.materialTabControl1.Controls.Add(this.Home);
            this.materialTabControl1.Controls.Add(this.registrarEmprendimiento);
            this.materialTabControl1.Controls.Add(this.registrarParticipante);
            this.materialTabControl1.Controls.Add(this.Eventos);
            this.materialTabControl1.Controls.Add(this.tabPage1);
            this.materialTabControl1.Controls.Add(this.tabPage2);
            this.materialTabControl1.Controls.Add(this.tabPage3);
            this.materialTabControl1.Controls.Add(this.tabPage4);
            this.materialTabControl1.Controls.Add(this.tabPage5);
            this.materialTabControl1.Controls.Add(this.Salir);
            this.materialTabControl1.Depth = 0;
            this.materialTabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.materialTabControl1.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.materialTabControl1.Location = new System.Drawing.Point(3, 64);
            this.materialTabControl1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialTabControl1.Multiline = true;
            this.materialTabControl1.Name = "materialTabControl1";
            this.materialTabControl1.SelectedIndex = 0;
            this.materialTabControl1.Size = new System.Drawing.Size(1594, 833);
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
            this.Home.Location = new System.Drawing.Point(4, 24);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(1586, 805);
            this.Home.TabIndex = 2;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // pnlBienvenida
            // 
            this.pnlBienvenida.Location = new System.Drawing.Point(366, 54);
            this.pnlBienvenida.Name = "pnlBienvenida";
            this.pnlBienvenida.Size = new System.Drawing.Size(871, 163);
            this.pnlBienvenida.TabIndex = 9;
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
            this.materialLabel6.Location = new System.Drawing.Point(158, 79);
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
            this.iconPictureBox5.Location = new System.Drawing.Point(35, 61);
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
            this.materialLabel5.Location = new System.Drawing.Point(152, 79);
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
            this.iconPictureBox4.Location = new System.Drawing.Point(32, 61);
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
            this.materialLabel4.Location = new System.Drawing.Point(152, 79);
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
            this.iconPictureBox2.Location = new System.Drawing.Point(28, 61);
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
            this.materialCard1.Location = new System.Drawing.Point(65, 234);
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
            this.materialLabel2.Location = new System.Drawing.Point(144, 79);
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
            this.iconPictureBox3.Location = new System.Drawing.Point(26, 61);
            this.iconPictureBox3.Name = "iconPictureBox3";
            this.iconPictureBox3.Size = new System.Drawing.Size(92, 77);
            this.iconPictureBox3.TabIndex = 5;
            this.iconPictureBox3.TabStop = false;
            // 
            // registrarEmprendimiento
            // 
            this.registrarEmprendimiento.Controls.Add(this.label1);
            this.registrarEmprendimiento.Controls.Add(this.materialCard2);
            this.registrarEmprendimiento.Controls.Add(this.panel2);
            this.registrarEmprendimiento.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarEmprendimiento.Location = new System.Drawing.Point(4, 24);
            this.registrarEmprendimiento.Name = "registrarEmprendimiento";
            this.registrarEmprendimiento.Padding = new System.Windows.Forms.Padding(3);
            this.registrarEmprendimiento.Size = new System.Drawing.Size(1586, 805);
            this.registrarEmprendimiento.TabIndex = 0;
            this.registrarEmprendimiento.Text = "Emprendimiento             ";
            this.registrarEmprendimiento.ToolTipText = "Prueba";
            this.registrarEmprendimiento.UseVisualStyleBackColor = true;
            this.registrarEmprendimiento.Click += new System.EventHandler(this.Prueba_Load);
            // 
            // lstBoxEmprendimiento
            // 
            this.lstBoxEmprendimiento.BackColor = System.Drawing.Color.White;
            this.lstBoxEmprendimiento.BorderColor = System.Drawing.Color.LightGray;
            this.lstBoxEmprendimiento.Depth = 0;
            this.lstBoxEmprendimiento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstBoxEmprendimiento.Location = new System.Drawing.Point(89, 19);
            this.lstBoxEmprendimiento.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstBoxEmprendimiento.Name = "lstBoxEmprendimiento";
            this.lstBoxEmprendimiento.SelectedIndex = -1;
            this.lstBoxEmprendimiento.SelectedItem = null;
            this.lstBoxEmprendimiento.Size = new System.Drawing.Size(331, 564);
            this.lstBoxEmprendimiento.TabIndex = 7;
            this.lstBoxEmprendimiento.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 15);
            this.label1.TabIndex = 0;
            // 
            // materialCard2
            // 
            this.materialCard2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard2.Controls.Add(this.materialLabel3);
            this.materialCard2.Controls.Add(this.materialButton1);
            this.materialCard2.Controls.Add(this.txtDescripcion);
            this.materialCard2.Controls.Add(this.btnRegistrar);
            this.materialCard2.Controls.Add(this.txtNombreEmprendimiento);
            this.materialCard2.Controls.Add(this.txtRubro);
            this.materialCard2.Controls.Add(this.txtFacultad);
            this.materialCard2.Controls.Add(this.materialCard3);
            this.materialCard2.Depth = 0;
            this.materialCard2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard2.Location = new System.Drawing.Point(39, 17);
            this.materialCard2.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard2.Name = "materialCard2";
            this.materialCard2.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard2.Size = new System.Drawing.Size(941, 729);
            this.materialCard2.TabIndex = 6;
            this.materialCard2.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard2_Paint);
            // 
            // materialLabel3
            // 
            this.materialLabel3.AutoSize = true;
            this.materialLabel3.Depth = 0;
            this.materialLabel3.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel3.Location = new System.Drawing.Point(45, 67);
            this.materialLabel3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel3.Name = "materialLabel3";
            this.materialLabel3.Size = new System.Drawing.Size(184, 19);
            this.materialLabel3.TabIndex = 13;
            this.materialLabel3.Text = "Registrar Emprendimiento";
            // 
            // materialButton1
            // 
            this.materialButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton1.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton1.Depth = 0;
            this.materialButton1.HighEmphasis = true;
            this.materialButton1.Icon = null;
            this.materialButton1.Location = new System.Drawing.Point(493, 381);
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
            this.txtDescripcion.Location = new System.Drawing.Point(37, 381);
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
            this.txtDescripcion.Size = new System.Drawing.Size(424, 227);
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
            this.btnRegistrar.Location = new System.Drawing.Point(37, 642);
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
            this.txtNombreEmprendimiento.Location = new System.Drawing.Point(37, 136);
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
            this.txtRubro.Location = new System.Drawing.Point(37, 296);
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
            this.txtFacultad.Location = new System.Drawing.Point(37, 212);
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
            this.materialCard3.Controls.Add(this.imgLogo);
            this.materialCard3.Depth = 0;
            this.materialCard3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard3.Location = new System.Drawing.Point(493, 107);
            this.materialCard3.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard3.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard3.Name = "materialCard3";
            this.materialCard3.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard3.Size = new System.Drawing.Size(420, 264);
            this.materialCard3.TabIndex = 0;
            // 
            // imgLogo
            // 
            this.imgLogo.Location = new System.Drawing.Point(17, 17);
            this.imgLogo.Name = "imgLogo";
            this.imgLogo.Size = new System.Drawing.Size(386, 230);
            this.imgLogo.TabIndex = 0;
            this.imgLogo.TabStop = false;
            // 
            // registrarParticipante
            // 
            this.registrarParticipante.Controls.Add(this.materialCard7);
            this.registrarParticipante.Controls.Add(this.panel1);
            this.registrarParticipante.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.registrarParticipante.Location = new System.Drawing.Point(4, 24);
            this.registrarParticipante.Name = "registrarParticipante";
            this.registrarParticipante.Padding = new System.Windows.Forms.Padding(3);
            this.registrarParticipante.Size = new System.Drawing.Size(1586, 805);
            this.registrarParticipante.TabIndex = 1;
            this.registrarParticipante.Text = "Participante                 ";
            this.registrarParticipante.UseVisualStyleBackColor = true;
            this.registrarParticipante.Click += new System.EventHandler(this.tabPage2_Click);
            // 
            // materialCard7
            // 
            this.materialCard7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard7.Controls.Add(this.materialLabel7);
            this.materialCard7.Controls.Add(this.txtNombreCompleto);
            this.materialCard7.Controls.Add(this.txtCargo);
            this.materialCard7.Controls.Add(this.materialButton2);
            this.materialCard7.Controls.Add(this.materialCard8);
            this.materialCard7.Controls.Add(this.materialButton3);
            this.materialCard7.Depth = 0;
            this.materialCard7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard7.Location = new System.Drawing.Point(35, 126);
            this.materialCard7.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard7.Name = "materialCard7";
            this.materialCard7.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard7.Size = new System.Drawing.Size(843, 484);
            this.materialCard7.TabIndex = 9;
            this.materialCard7.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard7_Paint);
            // 
            // materialLabel7
            // 
            this.materialLabel7.AutoSize = true;
            this.materialLabel7.Depth = 0;
            this.materialLabel7.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel7.Location = new System.Drawing.Point(39, 56);
            this.materialLabel7.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel7.Name = "materialLabel7";
            this.materialLabel7.Size = new System.Drawing.Size(135, 19);
            this.materialLabel7.TabIndex = 14;
            this.materialLabel7.Text = "Nuevo Participante";
            // 
            // txtNombreCompleto
            // 
            this.txtNombreCompleto.AnimateReadOnly = false;
            this.txtNombreCompleto.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtNombreCompleto.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtNombreCompleto.Depth = 0;
            this.txtNombreCompleto.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtNombreCompleto.HideSelection = true;
            this.txtNombreCompleto.Hint = "Nombres Completo";
            this.txtNombreCompleto.LeadingIcon = null;
            this.txtNombreCompleto.Location = new System.Drawing.Point(42, 158);
            this.txtNombreCompleto.MaxLength = 32767;
            this.txtNombreCompleto.MouseState = MaterialSkin.MouseState.OUT;
            this.txtNombreCompleto.Name = "txtNombreCompleto";
            this.txtNombreCompleto.PasswordChar = '\0';
            this.txtNombreCompleto.PrefixSuffixText = null;
            this.txtNombreCompleto.ReadOnly = false;
            this.txtNombreCompleto.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreCompleto.SelectedText = "";
            this.txtNombreCompleto.SelectionLength = 0;
            this.txtNombreCompleto.SelectionStart = 0;
            this.txtNombreCompleto.ShortcutsEnabled = true;
            this.txtNombreCompleto.Size = new System.Drawing.Size(369, 48);
            this.txtNombreCompleto.TabIndex = 6;
            this.txtNombreCompleto.TabStop = false;
            this.txtNombreCompleto.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtNombreCompleto.TrailingIcon = null;
            this.txtNombreCompleto.UseSystemPasswordChar = false;
            this.txtNombreCompleto.Click += new System.EventHandler(this.materialTextBox21_Click_1);
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
            this.txtCargo.Location = new System.Drawing.Point(42, 261);
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
            this.materialButton2.Location = new System.Drawing.Point(42, 387);
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
            this.materialCard8.Controls.Add(this.imgLogoParticipante);
            this.materialCard8.Depth = 0;
            this.materialCard8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard8.Location = new System.Drawing.Point(446, 39);
            this.materialCard8.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard8.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard8.Name = "materialCard8";
            this.materialCard8.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard8.Size = new System.Drawing.Size(348, 192);
            this.materialCard8.TabIndex = 10;
            // 
            // imgLogoParticipante
            // 
            this.imgLogoParticipante.Location = new System.Drawing.Point(17, 17);
            this.imgLogoParticipante.Name = "imgLogoParticipante";
            this.imgLogoParticipante.Size = new System.Drawing.Size(314, 158);
            this.imgLogoParticipante.TabIndex = 0;
            this.imgLogoParticipante.TabStop = false;
            // 
            // materialButton3
            // 
            this.materialButton3.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialButton3.Density = MaterialSkin.Controls.MaterialButton.MaterialButtonDensity.Default;
            this.materialButton3.Depth = 0;
            this.materialButton3.HighEmphasis = true;
            this.materialButton3.Icon = null;
            this.materialButton3.Location = new System.Drawing.Point(446, 251);
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
            // panel1
            // 
            this.panel1.Controls.Add(this.lstBoxParticipante);
            this.panel1.Location = new System.Drawing.Point(934, 69);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(567, 427);
            this.panel1.TabIndex = 11;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint_1);
            // 
            // lstBoxParticipante
            // 
            this.lstBoxParticipante.BackColor = System.Drawing.Color.White;
            this.lstBoxParticipante.BorderColor = System.Drawing.Color.LightGray;
            this.lstBoxParticipante.Depth = 0;
            this.lstBoxParticipante.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lstBoxParticipante.Location = new System.Drawing.Point(144, 20);
            this.lstBoxParticipante.MouseState = MaterialSkin.MouseState.HOVER;
            this.lstBoxParticipante.Name = "lstBoxParticipante";
            this.lstBoxParticipante.SelectedIndex = -1;
            this.lstBoxParticipante.SelectedItem = null;
            this.lstBoxParticipante.Size = new System.Drawing.Size(273, 346);
            this.lstBoxParticipante.TabIndex = 10;
            this.lstBoxParticipante.SelectedIndexChanged += new MaterialSkin.Controls.MaterialListBox.SelectedIndexChangedEventHandler(this.materialListBox2_SelectedIndexChanged);
            // 
            // Eventos
            // 
            this.Eventos.Location = new System.Drawing.Point(4, 24);
            this.Eventos.Name = "Eventos";
            this.Eventos.Size = new System.Drawing.Size(1586, 805);
            this.Eventos.TabIndex = 3;
            this.Eventos.Text = "Eventos";
            this.Eventos.UseVisualStyleBackColor = true;
            // 
            // tabPage1
            // 
            this.tabPage1.ImeMode = System.Windows.Forms.ImeMode.Disable;
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1586, 805);
            this.tabPage1.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Size = new System.Drawing.Size(1586, 805);
            this.tabPage2.TabIndex = 6;
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1586, 805);
            this.tabPage3.TabIndex = 7;
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // tabPage4
            // 
            this.tabPage4.Location = new System.Drawing.Point(4, 24);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(1586, 805);
            this.tabPage4.TabIndex = 8;
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // tabPage5
            // 
            this.tabPage5.Location = new System.Drawing.Point(4, 24);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1586, 805);
            this.tabPage5.TabIndex = 9;
            this.tabPage5.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Location = new System.Drawing.Point(4, 24);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(1586, 805);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir ";
            this.Salir.UseVisualStyleBackColor = true;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(693, 33);
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
            this.iconPictureBox1.IconSize = 39;
            this.iconPictureBox1.Location = new System.Drawing.Point(1279, 48);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(90, 39);
            this.iconPictureBox1.TabIndex = 0;
            this.iconPictureBox1.TabStop = false;
            this.iconPictureBox1.Click += new System.EventHandler(this.iconPictureBox1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.lstBoxEmprendimiento);
            this.panel2.Location = new System.Drawing.Point(1006, 17);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(551, 620);
            this.panel2.TabIndex = 8;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // FrmAdminMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1600, 900);
            this.Controls.Add(this.iconPictureBox1);
            this.Controls.Add(this.materialLabel1);
            this.Controls.Add(this.materialTabControl1);
            this.DrawerTabControl = this.materialTabControl1;
            this.Name = "FrmAdminMain";
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
            this.materialCard3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogo)).EndInit();
            this.registrarParticipante.ResumeLayout(false);
            this.materialCard7.ResumeLayout(false);
            this.materialCard7.PerformLayout();
            this.materialCard8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.imgLogoParticipante)).EndInit();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
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
        private MaterialSkin.Controls.MaterialListBox lstBoxEmprendimiento;
        private MaterialSkin.Controls.MaterialMultiLineTextBox2 txtDescripcion;
        private MaterialSkin.Controls.MaterialButton materialButton1;
        private PictureBox imgLogo;
        private MaterialSkin.Controls.MaterialLabel materialLabel3;
        private TabPage Eventos;
        private TabPage Salir;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage3;
        private TabPage tabPage4;
        private TabPage tabPage5;
        private MaterialSkin.Controls.MaterialTextBox2 txtNombreCompleto;
        private MaterialSkin.Controls.MaterialTextBox2 txtCargo;
        private MaterialSkin.Controls.MaterialCard materialCard7;
        private MaterialSkin.Controls.MaterialButton materialButton2;
        private MaterialSkin.Controls.MaterialCard materialCard8;
        private PictureBox imgLogoParticipante;
        private MaterialSkin.Controls.MaterialButton materialButton3;
        private MaterialSkin.Controls.MaterialListBox lstBoxParticipante;
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
        private Panel panel1;
        private Panel panel2;
    }
}