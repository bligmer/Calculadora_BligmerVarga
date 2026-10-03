namespace bligmer_vargas
{
    public partial class btnLimpiar : Form
    {
        public btnLimpiar()
        {
            InitializeComponent();
        }


        private void btnSumar_Click(object sender, EventArgs e)
        {
            // Validar que no estén vacíos
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Escribe los dos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sean números
            if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
            {
                MessageBox.Show("Escribe solo números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
                return;
            }

            // Sumar y mostrar resultado
            double suma = n1 + n2;
            txtResultado.Text = suma.ToString();
        }


        private void btnRestar_Click(object sender, EventArgs e)
        {
            // Validar que no estén vacíos
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Escribe los dos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sean números válidos
            if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
            {
                MessageBox.Show("Escribe solo números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
                return;
            }

            // Restar y mostrar resultado
            double resta = n1 - n2;
            txtResultado.Text = resta.ToString();
        }

        private void btnMultiplicar_Click(object sender, EventArgs e)
        {
            // Verificar que no falten datos
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Completa los dos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Verificar que sean números válidos
            if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
            {
                MessageBox.Show("Escribe solo números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
                return;
            }

            // Multiplicar y mostrar
            double producto = n1 * n2;
            txtResultado.Text = producto.ToString();
        }

        private void btnDividir_Click(object sender, EventArgs e)
        {
            // Validar que no estén vacíos
            if (txtNum1.Text == "" || txtNum2.Text == "")
            {
                MessageBox.Show("Completa los dos números", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar que sean números válidos
            if (!double.TryParse(txtNum1.Text, out double n1) || !double.TryParse(txtNum2.Text, out double n2))
            {
                MessageBox.Show("Escribe solo números válidos", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtNum1.Clear();
                txtNum2.Clear();
                txtNum1.Focus();
                return;
            }

            // Validación IMPORTANTE: no dividir por cero
            if (n2 == 0)
            {
                MessageBox.Show("No se puede dividir por cero ⚠️", "Error de Cálculo", MessageBoxButtons.OK, MessageBoxIcon.Stop);
                txtNum2.Clear();
                txtNum2.Focus();
                return;
            }

            // Dividir y mostrar resultado
            double division = n1 / n2;
            txtResultado.Text = division.ToString();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            // Borrar todo el contenido de los tres cuadros
            txtNum1.Clear();
            txtNum2.Clear();
            txtResultado.Clear();

            // Volver el cursor al primer cuadro para escribir rápido
            txtNum1.Focus();
        }
    }
}


