using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Task4
{
    public partial class LCG_Form : Form
    {
        public LCG_Form()
        {
            InitializeComponent();
        }

        private void LCG_Form_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<double> generatedNumbers = new List<double>();
            try
            {
                double a = double.Parse(multiplierField.Text.ToString());
                double seed = double.Parse(seedField.Text.ToString());
                double increment = double.Parse(incrementField.Text.ToString());
                double modulus = double.Parse(modulusField.Text.ToString());
                int numberOfIterations = int.Parse(numberIterationField.Text.ToString());
                LCG lcgGenerator = new LCG(seed, a, increment, modulus, numberOfIterations);
                generatedNumbers = lcgGenerator.generateRandomeNumbers();
            }
            catch (Exception error) {
                MessageBox.Show(error.ToString());
            }
            if (generatedNumbers.Count != 0) {
                fillGridData(generatedNumbers);
            }
        }

        private void fillGridData(List<double> generatedNumbers) {
            for (int i = 0; i < generatedNumbers.Count; i++)
                dataGridView1.Rows.Add(generatedNumbers[i].ToString());
        }
    }
}
