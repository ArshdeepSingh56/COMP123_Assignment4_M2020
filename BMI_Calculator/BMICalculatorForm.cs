using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
/*BMI Calculator 
 * Name = Arshdeep Singh
 * Student id no = 301118326
 * 
*/
/// <summary>
/// Changes in user interface design 
/// Created BMICalculator form
/// Created UI Controls
/// Created BMI button, input and output functions.
///BMI Calculator finalization,
///when the Calculate BMI button was disabled, user must select first the units.
/// </summary>
namespace BMI_Calculator
{
    public partial class BMICalculatorForm : Form
    {
        public Form parent { get; set; }

        public BMICalculatorForm()
        {
            InitializeComponent();
        }
        private void BMICalculatorForm_Load(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = false;
        }
        /// <summary>
        /// Modified BMI result functionality.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CalculateBMIButton_Click(object sender, EventArgs e)
        {
            double height = Convert.ToDouble(HeightTextbox.Text);
            double weight = Convert.ToDouble(WeightTextbox.Text);

            double bmi=0;
            if (ImperialRadioButton.Checked == true)
            {
                bmi = weight * 703 / (height * height);
                BmiScaleResult.Text = "";
                
            }
            else if (MetricRadioButton.Checked == true)
            {
                bmi = weight / (height * height);
            }
            else
            {
                BmiScaleResult.Text = "Select Unit";
                BmiResult.Text = "";
            }
            
            if (bmi < 18.5)
            {
                BmiScaleResult.Text = "UNDERWEIGHT";
            }
            else if (bmi >= 18.5 && bmi <= 24.9)
            {
                BmiScaleResult.Text = "NORMAL";
            }
            else if (bmi >= 25 && bmi <= 29.9)
            {
                BmiScaleResult.Text = "OVERWEIGHT";
            }
            else if (bmi >= 30)
            {
                BmiScaleResult.Text = "OBESE";
            }
            else
            {
                BmiScaleResult.Text = "ERROR!";
            }
            BmiResult.Text = bmi.ToString();
        }

   
        private void UnitRadioButton_Click(object sender, EventArgs e)
        {
            CalculateBMIButton.Enabled = true;
        }
         
        private void BMICalculatorForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void ResetButton_Click(object sender, EventArgs e)
        {
            HeightTextbox.Text = String.Empty;
            WeightTextbox.Text = String.Empty;
            BmiResult.Text = String.Empty;
            BmiScaleResult.Text = String.Empty;
        }

        private void GenerateCalculatorButton_Click(object sender, EventArgs e)
        {
            //BMICalculatorForm bmicalculatorform = new BMICalculatorForm();
            //bmicalculatorform.parent = this;
            //bmicalculatorform.Show();
            //this.Hide();
            //Program.Forms[FormName.END_FORM].Show();
            //this.Hide();
        }
    }
}
