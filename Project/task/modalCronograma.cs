using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using Modelos.EF;

namespace Project.task
{
    public partial class modalCronograma : MaterialForm
    {

        private Emprendimiento _emprendimiento;

        public modalCronograma(Emprendimiento emprendimiento)
        {
            InitializeComponent();
            _emprendimiento = emprendimiento;
            datePicker.Format = DateTimePickerFormat.Short;
            datePicker.Width = 150;
             // lblTitulo.Text = $"Cronograma para: {_emprendimiento.Nombre}";
        }

        private void modalCronograma_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void materialCard1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
