namespace Project.task
{
    partial class modalCronograma
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
            this.materialCard1 = new MaterialSkin.Controls.MaterialCard();
            this.txtUbicacionEvento = new MaterialSkin.Controls.MaterialTextBox2();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.saveDate = new FontAwesome.Sharp.IconButton();
            this.cancelDate = new FontAwesome.Sharp.IconButton();
            this.materialLabel1 = new MaterialSkin.Controls.MaterialLabel();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.materialCard1.SuspendLayout();
            this.SuspendLayout();
            // 
            // materialCard1
            // 
            this.materialCard1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.materialCard1.Controls.Add(this.dateTimePicker2);
            this.materialCard1.Controls.Add(this.dateTimePicker1);
            this.materialCard1.Controls.Add(this.materialLabel1);
            this.materialCard1.Controls.Add(this.cancelDate);
            this.materialCard1.Controls.Add(this.saveDate);
            this.materialCard1.Controls.Add(this.datePicker);
            this.materialCard1.Controls.Add(this.txtUbicacionEvento);
            this.materialCard1.Depth = 0;
            this.materialCard1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.materialCard1.Location = new System.Drawing.Point(17, 78);
            this.materialCard1.Margin = new System.Windows.Forms.Padding(14);
            this.materialCard1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialCard1.Name = "materialCard1";
            this.materialCard1.Padding = new System.Windows.Forms.Padding(14);
            this.materialCard1.Size = new System.Drawing.Size(355, 344);
            this.materialCard1.TabIndex = 0;
            this.materialCard1.Paint += new System.Windows.Forms.PaintEventHandler(this.materialCard1_Paint);
            // 
            // txtUbicacionEvento
            // 
            this.txtUbicacionEvento.AnimateReadOnly = false;
            this.txtUbicacionEvento.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.txtUbicacionEvento.CharacterCasing = System.Windows.Forms.CharacterCasing.Normal;
            this.txtUbicacionEvento.Depth = 0;
            this.txtUbicacionEvento.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.txtUbicacionEvento.HideSelection = true;
            this.txtUbicacionEvento.Hint = "Ubicacion";
            this.txtUbicacionEvento.LeadingIcon = null;
            this.txtUbicacionEvento.Location = new System.Drawing.Point(43, 148);
            this.txtUbicacionEvento.Margin = new System.Windows.Forms.Padding(2);
            this.txtUbicacionEvento.MaxLength = 32767;
            this.txtUbicacionEvento.MouseState = MaterialSkin.MouseState.OUT;
            this.txtUbicacionEvento.Name = "txtUbicacionEvento";
            this.txtUbicacionEvento.PasswordChar = '\0';
            this.txtUbicacionEvento.PrefixSuffixText = null;
            this.txtUbicacionEvento.ReadOnly = false;
            this.txtUbicacionEvento.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtUbicacionEvento.SelectedText = "";
            this.txtUbicacionEvento.SelectionLength = 0;
            this.txtUbicacionEvento.SelectionStart = 0;
            this.txtUbicacionEvento.ShortcutsEnabled = true;
            this.txtUbicacionEvento.Size = new System.Drawing.Size(172, 48);
            this.txtUbicacionEvento.TabIndex = 7;
            this.txtUbicacionEvento.TabStop = false;
            this.txtUbicacionEvento.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtUbicacionEvento.TrailingIcon = null;
            this.txtUbicacionEvento.UseSystemPasswordChar = false;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(43, 82);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 8;
            this.datePicker.ValueChanged += new System.EventHandler(this.dateTimePicker1_ValueChanged);
            // 
            // saveDate
            // 
            this.saveDate.BackColor = System.Drawing.Color.Transparent;
            this.saveDate.FlatAppearance.BorderSize = 0;
            this.saveDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.saveDate.ForeColor = System.Drawing.Color.Green;
            this.saveDate.IconChar = FontAwesome.Sharp.IconChar.CalendarCheck;
            this.saveDate.IconColor = System.Drawing.Color.Green;
            this.saveDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.saveDate.Location = new System.Drawing.Point(43, 238);
            this.saveDate.Name = "saveDate";
            this.saveDate.Size = new System.Drawing.Size(83, 61);
            this.saveDate.TabIndex = 9;
            this.saveDate.UseVisualStyleBackColor = false;
            // 
            // cancelDate
            // 
            this.cancelDate.BackColor = System.Drawing.Color.Transparent;
            this.cancelDate.FlatAppearance.BorderSize = 0;
            this.cancelDate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelDate.IconChar = FontAwesome.Sharp.IconChar.Ban;
            this.cancelDate.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.cancelDate.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.cancelDate.Location = new System.Drawing.Point(196, 238);
            this.cancelDate.Name = "cancelDate";
            this.cancelDate.Size = new System.Drawing.Size(83, 61);
            this.cancelDate.TabIndex = 10;
            this.cancelDate.UseVisualStyleBackColor = false;
            // 
            // materialLabel1
            // 
            this.materialLabel1.AutoSize = true;
            this.materialLabel1.Depth = 0;
            this.materialLabel1.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.materialLabel1.Location = new System.Drawing.Point(40, 14);
            this.materialLabel1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialLabel1.Name = "materialLabel1";
            this.materialLabel1.Size = new System.Drawing.Size(107, 19);
            this.materialLabel1.TabIndex = 11;
            this.materialLabel1.Text = "materialLabel1";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker1.Location = new System.Drawing.Point(43, 123);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker1.ShowUpDown = true;
            this.dateTimePicker1.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker1.TabIndex = 12;
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dateTimePicker2.Location = new System.Drawing.Point(196, 123);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker2.ShowUpDown = true;
            this.dateTimePicker2.Size = new System.Drawing.Size(104, 20);
            this.dateTimePicker2.TabIndex = 13;
            // 
            // modalCronograma
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(387, 446);
            this.Controls.Add(this.materialCard1);
            this.Name = "modalCronograma";
            this.Text = "modalCronograma";
            this.Load += new System.EventHandler(this.modalCronograma_Load);
            this.materialCard1.ResumeLayout(false);
            this.materialCard1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private MaterialSkin.Controls.MaterialCard materialCard1;
        private MaterialSkin.Controls.MaterialTextBox2 txtUbicacionEvento;
        private System.Windows.Forms.DateTimePicker datePicker;
        private MaterialSkin.Controls.MaterialLabel materialLabel1;
        private FontAwesome.Sharp.IconButton cancelDate;
        private FontAwesome.Sharp.IconButton saveDate;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.DateTimePicker dateTimePicker2;
    }
}