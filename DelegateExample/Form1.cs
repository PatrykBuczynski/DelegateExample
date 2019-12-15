using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{
    public partial class MainWindow : Form
    {
        public Action<String> myActionDelegate;
        public Func<Double, Double> operationOne;
        public Func<Double, Double, Double> operationTwo;
        readonly List<string> oneArgumentList = new List<string>();
        readonly List<string> twoArgumentsList = new List<string>();

        public MainWindow()
        {
            InitializeComponent();
            oneArgumentList.Add("sqrt");
            oneArgumentList.Add("factorial");

            twoArgumentsList.Add("+");
            twoArgumentsList.Add("-");
            twoArgumentsList.Add("*");
            twoArgumentsList.Add("/");

            oneArgumentRadioButton.Checked = true;

        }

        private void DialogCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (DialogCheckBox.Checked)
            {
                GoButton.Enabled = true;
                myActionDelegate += Output.ShowDialogBox;
            }
            else
            {
                myActionDelegate -= Output.ShowDialogBox;
            }
            if (!DialogCheckBox.Checked && !SaveToFileCheckBox.Checked)
            {
                GoButton.Enabled = false;
            }
        }

        private void SaveToFileCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (SaveToFileCheckBox.Checked)
            {
                GoButton.Enabled = true;
                myActionDelegate += Output.SaveToFile;
            }
            else
            {
                myActionDelegate -= Output.SaveToFile;
            }
            if (!DialogCheckBox.Checked && !SaveToFileCheckBox.Checked)
            {
                GoButton.Enabled = false;
            }
        }

        private void GoButton_Click(object sender, EventArgs e)
        {
            if (oneArgumentRadioButton.Checked) 
            {
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "factorial") == 0)
                {
                    operationOne = (double x) => (int)x <= 1 ? 1 : (int) x * operationOne(x-1);
                }
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "sqrt") == 0)
                {
                    operationOne = (double x) => Math.Sqrt(x);
                }
                myActionDelegate("Results: " + operationOne(Convert.ToDouble(firstArgumentTextBox.Text)));
            }
            if (twoArgumentsRadioButton.Checked)
            {
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "+") == 0)
                {
                    operationTwo = (double x, double y) => x + y;
                }
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "-") == 0)
                {
                    operationTwo = (double x, double y) => x - y;
                }
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "*") == 0)
                {
                    operationTwo = (double x, double y) => x * y;
                }
                if (String.Compare(mathComboBox.SelectedItem.ToString(), "/") == 0)
                {
                    operationTwo = (double x, double y) => y == 0 ? 0 : x / y;
                }
                myActionDelegate("Results: " + operationTwo(Convert.ToDouble(firstArgumentTextBox.Text), Convert.ToDouble(secondArgumentTextBox.Text)));
            }

        }

        private void oneArgumentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (oneArgumentRadioButton.Checked)
            {
                secondArgumentTextBox.Visible = false;
                mathComboBox.DataSource = oneArgumentList;
            }
        }

        private void twoArgumentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (twoArgumentsRadioButton.Checked)
            {
                secondArgumentTextBox.Visible = true;
                mathComboBox.DataSource = twoArgumentsList;
            }

        }


    }
}
