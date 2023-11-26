namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        string lblString;

        public Form1()
        {
            InitializeComponent();
            lblString = lblInfo.Text;
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "0";
        }

        private void btnDot_Click(object sender, EventArgs e)
        {
            lblInfo.Text += ".";
        }

        private void btnC_Click(object sender, EventArgs e)
        {
            lblInfo.Text = "";
        }

        private void btnDelenye_Click(object sender, EventArgs e)
        {
            lblInfo.Text += " / ";
        }

        private void btnMulty_Click(object sender, EventArgs e)
        {
            lblInfo.Text += " * ";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            lblInfo.Text += " - ";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            lblInfo.Text += " + ";
        }

        private void btnStep_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "^(";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            try
            {
                double result = EvaluateExpression(lblInfo.Text);
                lblInfo.Text = result.ToString();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка: " + ex.Message);
            }
        }

        private double EvaluateExpression(string expression)
        {
            var dataTable = new System.Data.DataTable();
            var dataview = new System.Data.DataView();
            try
            {
                var result = dataTable.Compute(expression, "");
                return Convert.ToDouble(result);
            }
            catch
            {
                throw new Exception("Ошибка в выражении.");
            }
        }

        private void btnSkobkaL_Click(object sender, EventArgs e)
        {
            lblInfo.Text += "(";
        }

        private void btnSkobkaR_Click(object sender, EventArgs e)
        {
            lblInfo.Text += ")";
        }
    }
}