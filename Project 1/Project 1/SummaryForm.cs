using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_1
{
    public partial class SummaryForm : Form
    {
        public SummaryForm(List<int> selectedNumbers, String selectedNumbersLabel)
        {
            InitializeComponent();
            DisplayCounts(selectedNumbers);
            label2.Text = selectedNumbersLabel;
        }

        private void SummaryForm_Load(object sender, EventArgs e)
        {
            
        }

        private void DisplayCounts(List<int> numbers)
        {
            positiveCountLabel.Text = "Total positive: " + numbers.Count(n => n > 0).ToString();
            zeroCountLabel.Text = "Total zero: " + numbers.Count(n => n == 0).ToString();
            negativeCountLabel.Text = "Total negative: " + numbers.Count(n => n < 0).ToString();
        }
    }
}
