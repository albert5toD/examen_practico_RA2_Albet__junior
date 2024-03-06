using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace proyectofinal_RA2
{
    public partial class Form1 : Form
    {

        int Matricula, Telefono;

        string Nombre, Email, Direccion, Maestro_Titular;

        string Genero, Área_Tecnica, curso, seccion;

        private void cbo_Area_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Indice = cbo_Area.SelectedIndex;

            Área_Tecnica = cbo_Area.Items[Indice].ToString();

        }

        private void cbo_seccion_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Indice = cbo_seccion.SelectedIndex;

            seccion = cbo_seccion.Items[Indice].ToString();
        }

        private void btn_Salir_Click(object sender, EventArgs e)
        {
            // Display a confirmation dialog
            DialogResult result = MessageBox.Show("¿Quieres salir de la aplicacin?", "Salir de la aplicacion", MessageBoxButtons.YesNo);

            // Exit the application if the user clicks Yes
            if (result == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btn_borrar_Click(object sender, EventArgs e)
        {

            if (dgv_datos.SelectedRows.Count > 0)
            {
                DialogResult result = MessageBox.Show("¿Desea eliminar el registro seleccionado?", "Eliminar registro", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    // Obtén el índice de la fila seleccionada
                    int rowIndex = dgv_datos.SelectedRows[0].Index;

                    // Elimina la fila del DataGridView
                    dgv_datos.Rows.RemoveAt(rowIndex);

                    // Muestra un mensaje de confirmación
                    MessageBox.Show("Registro eliminado correctamente", "Eliminar registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }

        }

        private void dgv_datos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void cbo_Curso_SelectedIndexChanged(object sender, EventArgs e)
        {
            int Indice = cbo_Curso.SelectedIndex;

            curso = cbo_Curso.Items[Indice].ToString();
        }

        private void cbo_genero_SelectedIndexChanged(object sender, EventArgs e)
        {



            int Indice = cbo_genero.SelectedIndex;

            Genero = cbo_genero.Items[Indice].ToString();


        }

        public Form1()
        {
            InitializeComponent();

            txt_matricula.Enabled = false;
            txt_telefono.Enabled = false;
            txt_nombre.Enabled = false;
            txt_email.Enabled = false;
            txt_direccion.Enabled = false;
            txt_maestro.Enabled = false;

            cbo_Area.Enabled = false;
            cbo_Curso.Enabled = false;
            cbo_genero.Enabled = false;
            cbo_seccion.Enabled = false;


        }

        private void btn_nuevo_Click(object sender, EventArgs e)
        {
            txt_matricula.Enabled = true;
            txt_telefono.Enabled = true;
            txt_nombre.Enabled = true;
            txt_email.Enabled = true;
            txt_direccion.Enabled = true;
            txt_maestro.Enabled = true;

            cbo_Area.Enabled = true;
            cbo_Curso.Enabled = true;
            cbo_genero.Enabled = true;
            cbo_seccion.Enabled = true;

            btn_borrar.Enabled = true;
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {

            btn_Salir.Enabled = true;

            string path = @"C:\Users\User Name\Desktop\C#.PRUEBAS\proyectofinal_RA2\Estudiantes poli.txt";

            using (StreamWriter sw = new StreamWriter(path))
            {
                foreach (DataGridViewRow row in dgv_datos.Rows)
                {
                    if (!row.IsNewRow) // Verificar si la fila no es una fila nueva
                    {
                        string matricula = row.Cells[0].Value?.ToString() ?? "";
                        string nombre = row.Cells[1].Value?.ToString() ?? "";
                        string curso = row.Cells[6].Value?.ToString() ?? "";
                        string seccion = row.Cells[7].Value?.ToString() ?? "";
                        string areaTecnica = row.Cells[8].Value?.ToString() ?? "";

                        sw.WriteLine($"{matricula}\t{nombre}\t{curso}\t{seccion}\t{areaTecnica}");
                    }
                }
            }

            MessageBox.Show("Datos guardados en archivo.txt");
        }
    




        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {

            Matricula = Convert.ToInt32(txt_matricula.Text);

            Telefono = Convert.ToInt32(txt_telefono.Text);

            Nombre = txt_nombre.Text;

            Email = txt_email.Text;

            Direccion = txt_direccion.Text;

            Maestro_Titular = txt_maestro.Text;




            dgv_datos.Rows.Add(Matricula, Nombre, Direccion, Telefono, Email, Genero, Maestro_Titular, Área_Tecnica, curso, seccion);

            // Limpiar todos los campos
            txt_matricula.Clear();
            txt_nombre.Clear();
            txt_direccion.Clear();
            txt_telefono.Clear();
            txt_email.Clear();
            txt_maestro.Clear();

        }
    }
}
