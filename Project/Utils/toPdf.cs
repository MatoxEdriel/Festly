using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using iTextSharp.text.pdf;
using iTextSharp.text;
using System.Windows.Forms;


namespace Project.Utils
{
    public class ToPdf
    {
      
        public void ExportarDataGridViewAPdf(DataGridView dgv, string rutaArchivo)
        {
            try
            {
                Document documento = new Document(PageSize.LETTER, 10f, 10f, 20f, 20f);
                PdfWriter.GetInstance(documento, new FileStream(rutaArchivo, FileMode.Create));
                documento.Open();

                PdfPTable tabla = new PdfPTable(dgv.Columns.Count);
                tabla.WidthPercentage = 100;

                foreach (DataGridViewColumn columna in dgv.Columns)
                {
                    PdfPCell celda = new PdfPCell(new Phrase(columna.HeaderText));
                    celda.BackgroundColor = new BaseColor(240, 240, 240);
                    tabla.AddCell(celda);
                }

                foreach (DataGridViewRow fila in dgv.Rows)
                {
                    if (fila.IsNewRow) continue;
                    foreach (DataGridViewCell celda in fila.Cells)
                    {
                        tabla.AddCell(celda.Value?.ToString() ?? "");
                    }
                }

                documento.Add(tabla);
                documento.Close();

                MessageBox.Show("PDF generado correctamente en:\n" + rutaArchivo);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al exportar a PDF: " + ex.Message);
            }
        }
    }
}
