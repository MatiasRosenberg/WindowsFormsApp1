using OfficeOpenXml;
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
using System.Windows.Forms;
using OfficeOpenXml;
using LicenseContext = OfficeOpenXml.LicenseContext;

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
            dateTimePickerHrInicio.Value=DateTime.Now;
            dateTimePickerHrFin.Value = DateTime.Now;
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
        }

        private void btnCargarMateria_Click(object sender, EventArgs e)
        {
            string nombre = txtNombre.Text;
            int comision = Convert.ToInt32(txtComision.Text);
            string dia = txtDia.Text;
            DateTime horarioInicio = dateTimePickerHrInicio.Value;
            DateTime horarioFin = dateTimePickerHrFin.Value;
            string profesor = txtProfesor.Text;
            string observaciones = txtObservaciones.Text;
            int cantidadVacantes = Convert.ToInt32(txtCantidadVacantes.Text);
            string preferenciaObservacion = txtObservacionPreferencia.Text;


            // Crear una instancia de Materia y asignar el valor de preferencia de observación
            Materia materia = new Materia(nombre, comision, dia, horarioInicio, horarioFin, profesor, observaciones, cantidadVacantes)
            {
                PreferenciaObservacion = txtObservacionPreferencia.Text
            };
            // Asignar la hora de fin de la materia (hora seleccionada en el dateTimePickerHrFin)
            materia.HorarioInicio = horarioInicio;
            materia.HorarioFin = horarioFin;

            materias.Add(materia);

            lstMaterias.Items.Add(materia);
        }

        private void btnGenerarCombinaciones_Click(object sender, EventArgs e)
        {
            // Obtener la franja horaria seleccionada del ComboBox
            string franjaSeleccionada = cboFranjaHoraria.SelectedItem.ToString();

            // Filtrar las materias por la franja horaria seleccionada
            List<Materia> materiasFiltradas = FiltrarMateriasPorFranjaHoraria(franjaSeleccionada);

            // Aquí puedes realizar cualquier otra acción con las materias filtradas,
            // como generar las combinaciones o actualizar la lista de materias mostradas.

            // Por ejemplo, si deseas generar las combinaciones, puedes llamar a la función correspondiente:
            List<List<Materia>> combinaciones = GenerarCombinaciones(materiasFiltradas);

            // Luego, puedes mostrar las combinaciones en el ListBox o en cualquier otro control
            lstCombinaciones.Items.Clear();
            foreach (var combinacion in combinaciones)
            {
                lstCombinaciones.Items.Add(string.Join(", ", combinacion.Select(m => m.Nombre)));
            }
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

            string observacionPreferencia = txtObservacionPreferencia.Text;

            lstCombinaciones.Items.Clear();
            foreach (var combinacion in combinaciones)
                foreach (Materia materia in materias)
                {
                    
                    bool cumpleObservacion = CumpleObservacion(combinacion, observacionPreferencia);

                    if (cumpleObservacion)
                    {
                        lstCombinaciones.Items.Add(string.Join(", ", combinacion));
                    }
                }

        }

        private List<Materia> FiltrarMateriasPorFranjaHoraria(string franjaSeleccionada)
        {
            // Obtener el rango de horas según la franja horaria seleccionada
            DateTime inicioFranja;
            DateTime finFranja;

            switch (franjaSeleccionada)
            {
                case "Mañana":
                    inicioFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 6, 0, 0);
                    finFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 0, 0);
                    break;

                case "Tarde":
                    inicioFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 13, 1, 0);
                    finFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 30, 0);
                    break;

                case "Noche":
                    inicioFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 19, 31, 0);
                    finFranja = new DateTime(DateTime.Now.Year, DateTime.Now.Month, DateTime.Now.Day, 23, 59, 0);
                    break;

                default:
                    return materias; // Si no se selecciona una opción válida, retornar todas las materias sin filtrar
            }

            // Obtener la fecha y hora seleccionada en los DateTimePickers
            DateTime horaInicioSeleccionada = dateTimePickerHrInicio.Value;
            DateTime horaFinSeleccionada = dateTimePickerHrFin.Value;

            // Filtrar las materias según el rango de horas seleccionado
            List<Materia> materiasFiltradas = materias.Where(m =>
                m.HorarioInicio >= horaInicioSeleccionada &&
                m.HorarioFin <= horaFinSeleccionada
            ).ToList();

            return materiasFiltradas;
        }



        private void ActualizarListBoxMaterias(List<Materia> materiasFiltradas)
        {
            lstMaterias.Items.Clear();

            foreach (var materia in materiasFiltradas)
            {
                lstMaterias.Items.Add(materia.Nombre);
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
            dateTimePickerHrInicio.Value = DateTime.Now;
            dateTimePickerHrFin.Value = DateTime.Now;
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
            NombresalBorrar();
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
            dateTimePickerHrInicio.Value = DateTime.Now;
            dateTimePickerHrFin.Value = DateTime.Now;
            txtProfesor.Clear();
            txtObservaciones.Clear();
            txtCantidadVacantes.Clear();
            lstMaterias.Items.Clear();
            lstCombinaciones.Items.Clear();
            materias.Clear();
            NombresalBorrar();
        }

        public void NombresalBorrar()
        {
            txtNombre.Text = "Nombre";
            txtComision.Text = "Comisión";
            txtDia.Text = "Día";
            dateTimePickerHrInicio.Value = DateTime.Now;
            dateTimePickerHrFin.Value = DateTime.Now;
            txtProfesor.Text = "Profesor";
            txtObservaciones.Text = "Observaciones";
            txtCantidadVacantes.Text = "Cantidad de Vacantes";
            txtObservacionPreferencia.Text = "Filtrar Observación";
            lstMaterias.Text = "Materias";
            lstCombinaciones.Text = "Combinaciones";            
        }

        private void btnexcel_Click(object sender, EventArgs e)
        {
            // Mostrar el cuadro de diálogo para seleccionar un archivo de Excel.
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.Filter = "Archivos de Excel|*.xls;*.xlsx|Todos los archivos|*.*";

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    string selectedFileName = openFileDialog.FileName;

                    materias = ImportarDesdeExcel(selectedFileName);

                    foreach (var materia in materias)
                    {
                        lstMaterias.Items.Add(materia);
                    }
                }
            }
        }

        public static List<Materia> ImportarDesdeExcel(string rutaArchivo)
        {
            // Establecer el contexto de licencia
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial; // Solo para uso no comercial, consulta la página de EPPlus para otros contextos de licencia

            List<Materia> materias = new List<Materia>();

            using (var package = new ExcelPackage(new FileInfo(rutaArchivo)))
            {
                var worksheet = package.Workbook.Worksheets[0]; // Suponemos que los datos están en la primera hoja (índice 0)

                // Suponemos que los datos comienzan en la fila 2 (la fila 1 contiene encabezados)
                int fila = 3;

                while (worksheet.Cells[fila, 1].Value != null) // Leemos hasta que la columna "Nombre" esté vacía
                {
                    string nombre = worksheet.Cells[fila, 1].Value.ToString();
                    int comision = Convert.ToInt32(worksheet.Cells[fila, 2].Value);
                    string dia = worksheet.Cells[fila, 3].Value.ToString();
                    DateTime horarioinicio = Convert.ToDateTime(worksheet.Cells[fila, 4].Value);
                    DateTime horariofin = Convert.ToDateTime(worksheet.Cells[fila, 5].Value);
                    string profesor = worksheet.Cells[fila, 6].Value.ToString();
                    int cantidadVacantes = Convert.ToInt32(worksheet.Cells[fila, 7].Value);
                    string observaciones = worksheet.Cells[fila, 8].Value.ToString();

                    // Crea un nuevo objeto Materia y agrégalo a la lista

                    fila++;
                    materias.Add(new Materia(nombre, comision, dia, horarioinicio, horariofin, profesor, observaciones, cantidadVacantes));
                }
            }

            return materias;
        }
    }

    public class Materia
    {
        public string Nombre { get; set; }
        public int Comision { get; set; }
        public string Dia { get; set; }
        public DateTime HorarioInicio { get; set; }
        public DateTime HorarioFin { get; set; }
        public string Profesor { get; set; }
        public string Observaciones { get; set; }
        public int CantidadVacantes { get; set; }
        public string PreferenciaObservacion { get; set; }

        public Materia(string nombre, int comision, string dia, DateTime horarioInicio, DateTime horarioFin, string profesor, string observaciones, int cantidadVacantes)
        {
            Nombre = nombre;
            Comision = comision;
            Dia = dia;
            HorarioInicio = horarioInicio;
            HorarioFin = horarioFin;
            Profesor = profesor;
            Observaciones = observaciones;
            CantidadVacantes = cantidadVacantes;
        }

        public override string ToString()
        {
            return $"Materia: {Nombre}\nComisión: {Comision}\nDía: {Dia}\nHorarioInicio: {HorarioInicio}\nHorarioFin: {HorarioFin}\nProfesor: {Profesor}\nObservaciones: {Observaciones}\nCantidad de vacantes: {CantidadVacantes}";
        }



    }


}
