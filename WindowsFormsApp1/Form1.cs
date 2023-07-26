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

namespace WindowsFormsApp1

{
    public partial class Form1 : Form
    {
        private List<Materia> materias;
        private List<List<Materia>> combinaciones;

        public Form1()
        {
            InitializeComponent();

            // Suscribir el evento lstCombinaciones_KeyDown al control lstCombinaciones
            lstMaterias.KeyDown += lstMaterias_KeyDown;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            materias = new List<Materia>();
            combinaciones = new List<List<Materia>>();

        }

        private List<List<Materia>> GenerarCombinaciones(List<Materia> materias)
        {
            List<List<Materia>> combinaciones = new List<List<Materia>>();
            GenerarCombinacionesRecursivas(materias, new List<Materia>(), combinaciones);
            return combinaciones;
        }

        private void GenerarCombinacionesRecursivas(List<Materia> materiasDisponibles, List<Materia> combinacionActual, List<List<Materia>> combinaciones)
        {
            if (materiasDisponibles.Count == 0)
            {
                combinaciones.Add(combinacionActual);
                return;
            }

            Materia materiaActual = materiasDisponibles[0];
            List<Materia> nuevasMateriasDisponibles = new List<Materia>(materiasDisponibles);
            nuevasMateriasDisponibles.RemoveAt(0);

            GenerarCombinacionesRecursivas(nuevasMateriasDisponibles, combinacionActual, combinaciones);

            List<Materia> nuevaCombinacion = new List<Materia>(combinacionActual);
            nuevaCombinacion.Add(materiaActual);
            GenerarCombinacionesRecursivas(nuevasMateriasDisponibles, nuevaCombinacion, combinaciones);
        }

        private bool CumpleFranjaHoraria(List<Materia> combinacion, string franjaHoraria)
        {
            foreach (var materia in combinacion)
            {
                if (!materia.Horario.Equals(franjaHoraria))
                {
                    return false;
                }
            }

            return true;
        }

        private bool CumpleObservacion(List<Materia> combinacion, string observacionPreferencia)
        {
            foreach (var materia in combinacion)
            {
                if (!materia.Observaciones.Equals(observacionPreferencia))
                {
                    return false;
                }
            }

            return true;
        }

        private void LimpiarCamposMateria()
        {
            txtNombre.Clear();
            txtComision.Clear();
            txtDia.Clear();
            txtHorario.Clear();
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
        }

        private void btnCargarMateria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int comision = Convert.ToInt32(txtComision.Text);
            string dia = txtDia.Text;
            string horario = txtHorario.Text;
            string profesor = txtProfesor.Text;
            string observaciones = txtObservaciones.Text;
            int cantidadVacantes = Convert.ToInt32(txtCantidadVacantes.Text);
            string preferenciaObservacion = txtObservacionPreferencia.Text;


            // Crear una instancia de Materia y asignar el valor de preferencia de observación
            Materia materia = new Materia(nombre, comision, dia, horario, profesor, observaciones, cantidadVacantes)
            {
                PreferenciaObservacion = txtObservacionPreferencia.Text
            };

            materias.Add(materia);

            lstMaterias.Items.Add(materia);
            


        }

        private void btnGenerarCombinaciones_Click(object sender, EventArgs e)
        {
            combinaciones = GenerarCombinaciones(materias);

            lstCombinaciones.Items.Clear();
            foreach (var combinacion in combinaciones)
            {
                lstCombinaciones.Items.Add(string.Join(", ", combinacion));
            }

        }

        private void lstMaterias_KeyDown(object sender, KeyEventArgs e)
        {
            // Verificar si se presionó la tecla "Supr" (Delete)
            if (e.KeyCode == Keys.Delete)
            {
                // Obtener el índice de la materia seleccionada
                int indiceSeleccionado = lstMaterias.SelectedIndex;

                // Verificar si se seleccionó una materia
                if (indiceSeleccionado >= 0)
                {
                    // Eliminar la materia seleccionada de la lista
                    lstMaterias.Items.RemoveAt(indiceSeleccionado);
                }
            }
        }
        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string franjaHoraria = cboFranjaHoraria.Text;
            string observacionPreferencia = txtObservacionPreferencia.Text;

            lstCombinaciones.Items.Clear();
            foreach (var combinacion in combinaciones)
                foreach (Materia materia in materias)
                {
                    bool cumpleFranjaHoraria = CumpleFranjaHoraria(combinacion, franjaHoraria);
                    bool cumpleObservacion = CumpleObservacion(combinacion, observacionPreferencia);

                    if (cumpleFranjaHoraria && cumpleObservacion)
                    {
                        lstCombinaciones.Items.Add(string.Join(", ", combinacion));
                    }
                }

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void LimpiarCampos()
        {
            txtNombre.Clear();
            txtComision.Clear();
            txtDia.Clear();
            txtHorario.Clear();
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
        }

        private void btnLimpiartodo_Click(object sender, EventArgs e)
        {
            LimpiarTodo();
        }

        private void LimpiarTodo()
        {
            txtNombre.Clear();
            txtComision.Clear();
            txtDia.Clear();
            txtHorario.Clear();
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
            lstMaterias.Items.Clear();
            lstCombinaciones.Items.Clear();
            materias.Clear();
        }

        private void cboFranjaHoraria_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void lstMaterias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtComision_TextChanged(object sender, EventArgs e)
        {

        }
    }

    public class Materia
    {
        public string Nombre { get; set; }
        public int Comision { get; set; }
        public string Dia { get; set; }
        public string Horario { get; set; }
        public string Profesor { get; set; }
        public string Observaciones { get; set; }
        public int CantidadVacantes { get; set; }
        public string PreferenciaObservacion { get; set; }

        public Materia(string nombre, int comision, string dia, string horario, string profesor, string observaciones, int cantidadVacantes)
        {
            Nombre = nombre;
            Comision = comision;
            Dia = dia;
            Horario = horario;
            Profesor = profesor;
            Observaciones = observaciones;
            CantidadVacantes = cantidadVacantes;
        }

        public override string ToString()
        {
            return $"Materia: {Nombre}\nComisión: {Comision}\nDía: {Dia}\nHorario: {Horario}\nProfesor: {Profesor}\nObservaciones: {Observaciones}\nCantidad de vacantes: {CantidadVacantes}";
        }



    }


}
