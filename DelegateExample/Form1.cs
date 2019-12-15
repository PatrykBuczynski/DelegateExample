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
        public MainWindow()
        {
            InitializeComponent();
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
            myActionDelegate("Results: ");
        }

        private void oneArgumentRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (oneArgumentRadioButton.Checked)
            {
                secondArgumentTextBox.Visible = false;
            }
            else 
            {
                
            }
        }

        private void twoArgumentsRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            if (twoArgumentsRadioButton.Checked)
            {
                secondArgumentTextBox.Visible = true;
            }
            else 
            {

            }
        }
    }
}
