namespace Project_1
{
    public partial class Form1 : Form
    {

        private List<int> selectedNumbers = new List<int>();
        private Random random = new Random();
        private int numberRange;

        public Form1()
        {
            InitializeComponent();
            numberGeneratorTimer.Interval = 300; // Default to slow
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void numberRangeTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void enterButton_Click(object sender, EventArgs e)
        {
            if (int.TryParse(numberRangeTextBox.Text, out numberRange))
            {
                numberGeneratorTimer.Start();
                enterButton.Enabled = false;
            }
            else
            {
                MessageBox.Show("Please enter a valid number.");
            }
        }

        private void fastRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (fastRadioButton.Checked)
            {
                numberGeneratorTimer.Interval = 150;
            }
        }

        private void slowRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (slowRadioButton.Checked)
            {
                numberGeneratorTimer.Interval = 300;
            }
        }

        private void numberGeneratorTimer_Tick(object sender, EventArgs e)
        {
            int number = random.Next(-numberRange, numberRange + 1);
            randomNumberLabel.Text = number.ToString();
        }

        private void randomNumberLabel_Click(object sender, EventArgs e)
        {
            numberGeneratorTimer.Stop();
            int selectedNumber = int.Parse(randomNumberLabel.Text);
            selectedNumbers.Add(selectedNumber);
            selectedNumbersLabel.Text += selectedNumber + ", ";

            if (selectedNumbers.Count == 15)
            {
                enterButton.Enabled = true;
                MessageBox.Show("You have selected all 15 numbers.");
                SummaryForm form = new SummaryForm(selectedNumbers,selectedNumbersLabel.Text);
                form.Show();
            }
        }

        private void Form1_Click(object sender, EventArgs e)
        {
            if (!numberGeneratorTimer.Enabled && selectedNumbers.Count < 15)
            {
                numberGeneratorTimer.Start();
            }
        }
    }
}
