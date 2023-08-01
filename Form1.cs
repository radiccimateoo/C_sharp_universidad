namespace TP_Radicci_Mateo
{
    public partial class Form1 : Form
    {
        public struct Auto
        {
            public int numeroRepuesto;
            public string marca;
            public string origen;
            public string descripcion;
            public float precio;
        }

        Auto[] autos = new Auto[100];
        int i = 0;

        // MÉTODOS

        private bool validarNumero(int numero)
        // este metodo va a evaluar si el numero de repuesto se repite
        {
            bool bandera = false;

            for (int indice = 0; indice < i; indice++)
            {
                if (autos[indice].numeroRepuesto == numero)
                {
                    bandera = true;
                    break;
                }
            }
            return bandera;
        }

        private void listadoMarcaYOrigen(string consultaMarca, string consultaOrigen)
        // este metodo toma como parametro marca y origen consultado
        // y agrega los datos necesarios a la lista
        {
            for (int indice = 0; indice < i; indice++)
            {
                if (consultaMarca == autos[indice].marca && consultaOrigen == autos[indice].origen)
                {
                    lstDatos.Items.Add(autos[indice].numeroRepuesto + "   -   " + autos[indice].descripcion +
                        "   -   " + autos[indice].precio);
                }
            }
        }
        private void mostrarDatosConsulta()
        // este metodo muestra los datos consultados segun lo deseado
        {
            // - tiene que haber otra forma de simplificar esto - 

            if (cboMarcaConsulta.Text == "P" && radioNacional.Checked)
            {
                listadoMarcaYOrigen("P", "N");
            }
            else
            {
                if (cboMarcaConsulta.Text == "P" && radioImportado.Checked)
                {
                    listadoMarcaYOrigen("P", "I");
                }
            }

            if (cboMarcaConsulta.Text == "F" && radioNacional.Checked)
            {
                listadoMarcaYOrigen("F", "N");
            }
            else
            {
                if (cboMarcaConsulta.Text == "F" && radioImportado.Checked)
                {
                    listadoMarcaYOrigen("F", "I");
                }
            }

            if (cboMarcaConsulta.Text == "R" && radioNacional.Checked)
            {
                listadoMarcaYOrigen("R", "N");
            }
            else
            {
                if (cboMarcaConsulta.Text == "R" && radioImportado.Checked)
                {
                    listadoMarcaYOrigen("R", "I");
                }
            }
        }
        private void limpiar()
        // este metodo limpia los campos para registrar
        {
            txtNroRepuesto.Text = "";
            txtDescripcion.Text = "";
            txtPrecio.Text = "";
        }

        private bool validarConsulta()
        // este metodo valida si falta algun campo de completar
        // para realizar la consulta
        {
            bool bandera = false;

            if (radioNacional.Checked == false &&
                radioImportado.Checked == false)
            {
                MessageBox.Show("Debe seleccionar un origen");
                bandera = true;
            }

            if (cboMarcaConsulta.Text == "")
            {
                MessageBox.Show("Debe seleccionar una marca");
                bandera = true;
            }

            return bandera;
        }

        public Form1()
        {
            InitializeComponent();
        }

        private bool validarRegisdtro()
        // este metodo valida que no quede vacio ningun campo al hacer
        // click en registrar
        {
            if (txtNroRepuesto.Text == "")
            {
                MessageBox.Show("El numero de repuesto no puede quedar vacio, ingrese un valor");
                return true;
            }

            else
            {
                if (validarNumero(int.Parse(txtNroRepuesto.Text)))
                {
                    MessageBox.Show("El número ya existe, intente con otro");
                    return true;
                }

                else
                {
                    if (cboMarca.Text == "")
                    {
                        MessageBox.Show("Debe seleccionar algunas de las marcas para su auto");
                        return true;
                    }

                    else
                    {
                        if (cboOrigen.Text == "")
                        {
                            MessageBox.Show("Debe seleccionar el origen de su auto");
                            return true;
                        }
                        else
                        {
                            if (txtDescripcion.Text == "")
                            {
                                MessageBox.Show("Debe agregar alguna descripción a su vehículo");
                                return true;
                            }
                            else
                            {
                                if (txtPrecio.Text == "")
                                {
                                    MessageBox.Show("Debe ingresarle un precio a su auto");
                                    return true;
                                }
                            }
                        }
                    }
                }
            }

            return false;
        }

        private void cmdRegistrar_Click(object sender, EventArgs e)
        {
            if (!validarRegisdtro())
            {
                float precio = float.Parse(txtPrecio.Text);

                autos[i].numeroRepuesto = int.Parse(txtNroRepuesto.Text);
                autos[i].marca = cboMarca.Text;
                autos[i].origen = cboOrigen.Text;
                autos[i].descripcion = txtDescripcion.Text;
                autos[i].precio = precio;

                i++;

                MessageBox.Show("Registro exitoso");
            }

            if (i == 99)
            {
                cmdRegistrar.Enabled = false;
                MessageBox.Show("Completaste los 100 registros, no puedes registrar más autos");
            }

        }

        private void cmdLimpiar_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void cmdConsultar_Click(object sender, EventArgs e)
        {
            lstDatos.Items.Clear();

            if (!validarConsulta())
            {
                lstDatos.Items.Add("Número - Descripción - Precio");

                mostrarDatosConsulta();
            }
        }

        private void txtNroRepuesto_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back)
            {
                e.Handled = true;
            }
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(Char.IsDigit(e.KeyChar)) && e.KeyChar != (char)Keys.Back
                && e.KeyChar != (char)Keys.Oemcomma)
            {
                e.Handled = true;
            }
        }
    }
}