using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateExample
{
    class Output
    {
        static public void ShowDialogBox(String text) 
        {
            MessageBox.Show(text);
        }
        static public void SaveToFile(String text) 
        {
            String path = "results.txt";
            try 
            {
                using (StreamWriter sw = File.AppendText(path)) 
                {
                    sw.WriteLine(text);
                }
            }
            catch (IOException ex)
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
