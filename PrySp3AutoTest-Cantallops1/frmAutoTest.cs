using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PrySp3AutoTest_Cantallops
{
    public partial class frmAutoTest : Form
    {
        // declaracion de la estructura para los turnos
        public struct TURNO
        {
            public int NumeroTurno;
            public string Dominio;
            public int AnioFabricacion;
            public string Titular;
        };

        // constante para la cantidad total de elementos del arreglo
        const int MAX = 50;
        // declaracion del arreglo unidimensional de 50 elementos
        public TURNO[] turnos;
        // variable para controlar la cantidad de elementos cargados
        public int Cantidad = 0;
        public frmAutoTest()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmAutoTest_Load(object sender, EventArgs e)
        {
            // creacion del arreglo
            turnos = new TURNO[MAX];
            // inicializar la variable que controla la cantida de elemntos cargados
            Cantidad = 0;
            // establecer el estado inical de todos los componentes de la interfaz
            inicializarInterfaz();
        }

        private void inicializarInterfaz()
        {
            limpiarControles(); //estado inical de los controles de carga de datos
            // estado inicial de los controles de consultas
            txtCantidadTurnos.Clear();
            txtAnioMasAntiguo.Clear();
            txtDominio6Caracteres.Clear();
        }

        private void limpiarControles()
        {
            //valores para el estado inicla de los controles de carga
            txtNroTurno.Clear();
            txtDominio.Clear();
            numAnioFabricacion.Value = 2022;
            txtTitular.Clear();
        }

        // Evento keyPress : debe permitir el ingreso solamente numeros (y borrar)
        private void txtNroTurno_KeyPress(object sender, KeyPressEventArgs e)
        {
            //sin NO es un digito y NO es backspace (para borrar)
            if (!(char.IsDigit(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true; //borra la tecla ingresada
            }

        }


        // Evento KeyPress: convierte minusculas en mayusculas y no permite ingresar mas que letras y numeros
        private void txtDominio_KeyPress(object sender, KeyPressEventArgs e)
        {
            //usamos los metodos de la clase 'Char' (IsLower y ToUpper)
            if (Char.IsLower (e.KeyChar)) // es una minuscula?
            {
                e.KeyChar = Char.ToUpper(e.KeyChar); // convierte en mayuscula
            }
            // no es ni letra ni numero y es distintio de backspace ?
            if (!Char.IsLetterOrDigit (e.KeyChar) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true; //borrar la tecla
            }
        }

        private bool validarDatos()
        {
            bool resultado = false; // valor a devolver si no se cumplen todas las condiciones
            //validar la existencia de los datos a ingresar
            if (txtNroTurno.Text != "" && txtDominio.Text != "" && txtTitular.Text != "")
            {
                if (txtDominio.Text.Length >= 6) // validar el contenido de dominio
                {
                    //validar que NO exista el numero de turno a cargar
                    if (!buscarTurno(int.Parse(txtNroTurno.Text)))
                    {
                        resultado = true; // si todo esta bien devuelve verdadero
                    }
                    else
                    {
                        MessageBox.Show("El Número de Turno ingresado ya existe",
                            "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Dominio debe tener 6 o 7 caracteres",
                        "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                
            }
            else
            {
                MessageBox.Show("Debe completar los datos faltantes",
                    "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return resultado;
        }

        // funcion para buscar un numero de turno en el arreglo de turnos
        // recibe por parametro el numero a buscar
        // devuelve verdadero si el numero existe en el arreglo y flaso en caso contrario
        private bool buscarTurno(int numero)
        {
            bool existe = false; //valor incial a devolver
            int pos = 0; // primera posicion del arreglo
            // recorrer el arreglo hasta la posicion que tenga datos cargados
            while(pos < Cantidad)
            {
                //comprar el numero buscado con el numero en el arreglo
                if (numero == turnos[pos].NumeroTurno)
                {
                    existe = true; // indica que el numero fue encontrado
                    break; // sale del ciclo while
                }
                pos++; // proxima posicion del arreglo
            }
            return existe; // devuelve verdadero o falso
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            //validar los datos antes de ingresarlos al arreglo
            if (validarDatos())
            {
                // agregar los datos al arreglo en la posicion idicada por la variable 'Cantidad'
                turnos[Cantidad].NumeroTurno = int.Parse(txtNroTurno.Text);
                turnos[Cantidad].Dominio = txtDominio.Text;
                turnos[Cantidad].AnioFabricacion = int.Parse(numAnioFabricacion.Value.ToString());
                turnos[Cantidad].Titular = txtTitular.Text;
                //incrementar la cantidad de elementos cargados
                Cantidad++;
                //verificar si queda espacio en el arreglo
                if (Cantidad == MAX)
                {
                    MessageBox.Show("Se completó la capacidad de carga de datos",
                        "ATENCIÓN", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    btnRegistrar.Enabled = false; // deshabilitar el boton Registrar
                }
                limpiarControles(); //restablecer el estado inical del formulario
            }
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

            // primer consulta: cantidad de turnos registrados
            // se obtiene directamente de la variable 'Cantidad'
            txtCantidadTurnos.Text = Cantidad.ToString();
            //segunda consulta: se debe recorrer el arreglo y determinar el menor valor del campo 'AnioFabricacion'
            int menor = int.MaxValue; // mayor valor posible
            int pos;
            // recorrer el arreglo hasta la posicon con datos
            for(pos=0; pos<Cantidad; pos++)
            {
                //comparar el valor del elemento con el arreglo
                if (turnos[pos].AnioFabricacion < menor)
                {
                    menor = turnos[pos].AnioFabricacion; // guarda el menor valor
                }
            }
            //mostrar el resultado
            txtAnioMasAntiguo.Text = menor.ToString();

            //tercera consulta: cantidad de vehiculos con dominio de 6 caracteres
            int contador = 0; //contador en cero
            //recorrer el arreglo hasta la poscion con datos
            for(pos = 0; pos<Cantidad; pos++)
            {
                //controlar si la longitud del dominio es 6
                if (turnos[pos].Dominio.Length == 6)
                {
                    contador++; //incrementa el contador
                }
            }
            //mostar el resultado
            txtDominio6Caracteres.Text = contador.ToString();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Close(); // cierra el formulario
        }
    }
}
