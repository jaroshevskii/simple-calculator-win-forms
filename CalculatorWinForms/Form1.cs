namespace CalculatorWinForms
{
  public partial class CalculatorForm : Form
  {
    public CalculatorForm()
    {
      InitializeComponent();
    }

    private void label2_Click(object sender, EventArgs e)
    {

    }

    private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    private void CalculatorForm_Load(object sender, EventArgs e)
    {

    }

    private void firstNumber_TextChanged(object sender, EventArgs e)
    {

    }

    private void calculateButton_Click(object sender, EventArgs e)
    {
      if (firstNumberString.Text == "" || secondNumberString.Text == "" || operationString.Text == "")
      {
        MessageBox.Show("Field cannot be empty", "Damn it", MessageBoxButtons.OK, MessageBoxIcon.Error);
        return;
      }

      double firstNumber = double.Parse(firstNumberString.Text);
      double secondNumber = double.Parse(secondNumberString.Text);

      switch (operationString.Text)
      {
        case "+":
          resultString.Text = (firstNumber + secondNumber).ToString();
          break;
        case "-":
          resultString.Text = (firstNumber - secondNumber).ToString();
          break;
        case "*":
          resultString.Text = (firstNumber * secondNumber).ToString();
          break;
        case "/":
          if (secondNumber == 0)
          {
            MessageBox.Show("You cannot divide by zero", "Damn it", MessageBoxButtons.OK, MessageBoxIcon.Error);
            return;
          }
          resultString.Text = (firstNumber / secondNumber).ToString();
          break;
        case "%":
          resultString.Text = (firstNumber % secondNumber).ToString();
          break;
        default:
          MessageBox.Show("Invalid operator", "Damn it", MessageBoxButtons.OK, MessageBoxIcon.Error);
          break;
      }
    }
  }
}