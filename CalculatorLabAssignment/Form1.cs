namespace CalculatorLabAssignment
{
    public partial class Form1 : Form
    {
        Double resultvalue=0;
        String operationperformed = "";
        bool isOperationPerformed = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_click(object sender, EventArgs e)
        { 
            if((textBox_Result.Text=="0") || (isOperationPerformed))
            {
                textBox_Result.Clear();
            }
            isOperationPerformed = false;
            Button button = (Button)sender;
            if(button.Text==".")
            {
                if(!textBox_Result.Text.Contains("."))
                    textBox_Result.Text=textBox_Result.Text + button.Text;
            }else
            textBox_Result.Text = textBox_Result.Text + button.Text;
        }

        private void operation_click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (resultvalue != 0)
            {
                button15.PerformClick();
                operationperformed = button.Text;
                labelOperation.Text = resultvalue + " " + operationperformed;
                isOperationPerformed = true;
            }
            else
            {
                operationperformed = button.Text;
                resultvalue = Double.Parse(textBox_Result.Text);
                labelOperation.Text = resultvalue + " " + operationperformed;
                isOperationPerformed = true;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox_Result.Text = "0";
            resultvalue = 0;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            switch(operationperformed)
            {
                case "+":
                    textBox_Result.Text=(resultvalue + Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "-":
                    textBox_Result.Text = (resultvalue - Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "*":
                    textBox_Result.Text = (resultvalue * Double.Parse(textBox_Result.Text)).ToString();
                    break;
                case "/":
                    textBox_Result.Text = (resultvalue / Double.Parse(textBox_Result.Text)).ToString();
                    break;
                    default:
                    break;
            }
        }
    }
}