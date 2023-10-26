using System;
using System.CodeDom;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class ChooseVar : Form
    {
        public int numberSetedValue1;
        public ChooseVar()
        {
            InitializeComponent();
            
            comboBoxChooseVar.DataSource = null;
            comboBoxChooseVar.DataSource = Form1.varsTable;
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseVar.Enabled == false)
            {
                comboBoxChooseVar.Enabled = true;
                ChooseNumber.Enabled = false;
            }
            else
            {
                comboBoxChooseVar.Enabled = false;
            }
        }

        private void NumberRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (comboBoxChooseVar.Enabled == false)
            {
                comboBoxChooseVar.Enabled = false;
                ChooseNumber.Enabled = true;
            }
            else
            {
                ChooseNumber.Enabled = false;
            }
        }
        
        private void ChooseNumber_ValueChanged(object sender, EventArgs e)
        {
            numberSetedValue1 = (int)ChooseNumber.Value; 
            ChoosseVarOn.clickedButton.Text = numberSetedValue1.ToString();
        }

        private void comboBoxChooseVar_SelectedIndexChanged(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton.Text = comboBoxChooseVar.SelectedItem as string;
        }

        private void OkChooseVar_Click(object sender, EventArgs e)
        {
            if (Form1.isButtonPrintSetVarClicked == true)
            {

                if (ChooseNumber.Enabled == true)
                {
                    Form1.codeLinesList.Add("print(" + numberSetedValue1.ToString() + ")");
                }
                else if (comboBoxChooseVar.Enabled == true)
                {
                    string[] parts = comboBoxChooseVar.SelectedItem.ToString().Split(':');
                    var tempVarNameDone = parts[0];
                    
                    Form1.codeLinesList.Add("print(" + tempVarNameDone as string + ")");
                }
            }
            this.Close();
        }
    }
}