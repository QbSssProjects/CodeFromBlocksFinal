using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using static WindowsFormsApp2.Form1;

namespace WindowsFormsApp2
{
    public partial class ChoosseVarOn : Form
    {
        public static string add1VarNameValue;
        public static string add2VarNameValue;
        public static string sub1VarNameValue;
        public static string sub2VarNameValue;
        public static string multiply1VarNameValue;
        public static string multiply2VarNameValue;
        public static string div1VarNameValue;
        public static string div2VarNameValue;
        public static string mod1VarNameValue;
        public static string mod2VarNameValue;
        public static string onVarVarNameValue;
        public static string onNumberValue;

        public static string add1VarName;
        public static string add2VarName;
        public static string sub1VarName;
        public static string sub2VarName;
        public static string multiply1VarName;
        public static string multiply2VarName;
        public static string div1VarName;
        public static string div2VarName;
        public static string mod1VarName;
        public static string mod2VarName;
        public static string onVarVarName;
        
        public static Button clickedButton;
        
        public ChoosseVarOn()
        {
            var classForm = new Form1();

            InitializeComponent();
        }

        //dodawaniexD
        private void AddRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Add1.Enabled == false && Add2.Enabled == false)
            {
                Add1.Enabled = true;
                Add2.Enabled = true;
                
                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
                
            }
            else
            {
                Add1.Enabled = false;
                Add2.Enabled = false;
            }
        }

        private void SubRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Sub1.Enabled == false && Sub2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = true;
                Sub2.Enabled = true;
                
                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Sub1.Enabled = false;
                Sub2.Enabled = false;
            }
        }

        private void MultipyRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Multipy1.Enabled == false && Multipy2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;
                
                Multipy1.Enabled = true;
                Multipy2.Enabled = true;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;

                Multipy1.Enabled = true;
                Multipy2.Enabled = true;
            }
            else
            {
                Multipy1.Enabled = false;
                Multipy2.Enabled = false;
            }
        }

        private void DivRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Div1.Enabled == false && Div2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;
                
                Div1.Enabled = true;
                Div2.Enabled = true;

                Mod1.Enabled = false;
                Mod2.Enabled = false;

                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Div1.Enabled = false;
                Div2.Enabled = false;
            }
        }

        private void ModRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (Mod1.Enabled == false && Mod2.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = true;
                Mod2.Enabled = true;
                
                OnVar.Enabled = false;
                OnNumer.Enabled = false;
            }
            else
            {
                Mod1.Enabled = false;
                Mod2.Enabled = false;
            }
        }

        private void OnVarRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OnVar.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod1.Enabled = false; 
                
                OnVar.Enabled = true;
                OnNumer.Enabled = false;
            }
            else
            {
                OnVar.Enabled = false;
            }
        }
        
        private void OnVar_Clicked(object sender, EventArgs e)
        {
            OnVar.DataSource = null;
            OnVar.DataSource = varsTable;

            OnVar.DroppedDown = true;
        }
        
        private void OnNumberRadio_CheckedChanged(object sender, EventArgs e)
        {
            if (OnNumer.Enabled == false)
            {
                Add1.Enabled = false;
                Add2.Enabled = false;

                Sub1.Enabled = false;
                Sub2.Enabled = false;

                Multipy1.Enabled = false;
                Multipy2.Enabled = false;

                Div1.Enabled = false;
                Div2.Enabled = false;

                Mod1.Enabled = false;
                Mod1.Enabled = false; 
                
                OnVar.Enabled = false;
                OnNumer.Enabled = true;
            }
            else
            {
                OnNumer.Enabled = false;
            }
        }
        
        private void OnNumer_ValueChanged(object sender, EventArgs e)
        {
            onNumberValue = OnNumer.Value.ToString();
            //Console.Out.WriteLine(onNumberVarNameValue);
            buttonsSetOn[index].Text = onNumberValue.ToString();

            //throw new System.NotImplementedException();
        }

        private void Ok_Click(object sender, EventArgs e)
        {
            if (Add1.Enabled == true)
            {
                add1VarNameValue = Add1.Text;
                add2VarNameValue = Add2.Text;
                Console.Out.WriteLine("add1VarNameValue: " + add1VarNameValue);
                Console.Out.WriteLine("add2VarNameValue: " + add2VarNameValue);

                if (add1VarNameValue.Contains(":") && add2VarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + add1VarNameValue);
                    string[] add1Var = add1VarNameValue.Split(':');
                    string[] add2Var = add2VarNameValue.Split(':');
                    add1VarName = add1Var[0];
                    add2VarName = add2Var[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value add1Var: " + add1Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value add1Var: " + add1Var[1]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value add1Var: " + add2Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value add1Var: " + add2Var[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + add1VarName + " + " + add2VarName);
                    
                    buttonsSetOn[index].Text = add1VarName + " + " + add2VarName;

                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }

            else if (Sub1.Enabled == true)
            {
                sub1VarNameValue = Sub1.Text;
                sub2VarNameValue = Sub2.Text;
                Console.Out.WriteLine("sub1VarNameValue: " + sub1VarNameValue);
                Console.Out.WriteLine("sub2VarNameValue: " + sub2VarNameValue);

                if (sub1VarNameValue.Contains(":") && sub2VarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + sub1VarNameValue);
                    string[] sub1Var = sub1VarNameValue.Split(':');
                    string[] sub2Var = sub2VarNameValue.Split(':');
                    sub1VarName = sub1Var[0];
                    sub2VarName = sub2Var[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value sub1Var: " + sub1Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value sub1Var: " + sub1Var[1]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value sub2Var: " + sub2Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value sub2Var: " + sub2Var[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + sub1VarName + " - " + sub2VarName);

                    buttonsSetOn[index].Text = sub1VarName + " - " + sub2VarName;
                    
                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }

            else if (Multipy1.Enabled == true)
            {
                multiply1VarNameValue = Multipy1.Text;
                multiply2VarNameValue = Multipy2.Text;
                Console.Out.WriteLine("multiply1VarNameValue: " + multiply1VarNameValue);
                Console.Out.WriteLine("multiply2VarNameValue: " + multiply2VarNameValue);

                if (multiply1VarNameValue.Contains(":") && multiply2VarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + multiply1VarNameValue);
                    string[] multiply1Var = multiply1VarNameValue.Split(':');
                    string[] multiply2Var = multiply2VarNameValue.Split(':');
                    multiply1VarName = multiply1Var[0];
                    multiply2VarName = multiply2Var[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value multiply1Var: " + multiply1Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value multiply1Var: " + multiply1Var[1]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value multiply2Var: " + multiply2Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value multiply2Var: " + multiply2Var[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + multiply1VarName + " * " + multiply2VarName);

                    buttonsSetOn[index].Text = multiply1VarName + " * " + multiply2VarName;
                    
                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }

            else if (Div1.Enabled == true)
            {
                div1VarNameValue = Div1.Text;
                div2VarNameValue = Div2.Text;
                Console.Out.WriteLine("div1VarNameValue: " + div1VarNameValue);
                Console.Out.WriteLine("div2VarNameValue: " + div2VarNameValue);

                if (div1VarNameValue.Contains(":") && div2VarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + div1VarNameValue);
                    string[] div1Var = div1VarNameValue.Split(':');
                    string[] div2Var = div2VarNameValue.Split(':');
                    div1VarName = div1Var[0];
                    div2VarName = div2Var[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value div1Var: " + div1Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value div1Var: " + div1Var[1]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value div2Var: " + div2Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value div2Var: " + div2Var[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + div1VarName + " / " + div2VarName);

                    buttonsSetOn[index].Text = div1VarName + " / " + div2VarName;
                    
                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }

            else if (Mod1.Enabled == true)
            {
                mod1VarNameValue = Mod1.Text;
                mod2VarNameValue = Mod1.Text;
                Console.Out.WriteLine("mod1VarNameValue: " + mod1VarNameValue);
                Console.Out.WriteLine("mod2VarNameValue: " + mod2VarNameValue);

                if (mod1VarNameValue.Contains(":") && mod2VarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + mod1VarNameValue);
                    string[] mod1Var = mod1VarNameValue.Split(':');
                    string[] mod2Var = mod2VarNameValue.Split(':');
                    mod1VarName = mod1Var[0];
                    mod2VarName = mod2Var[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value mod1Var: " + mod1Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value mod1Var: " + mod1Var[1]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value mod2Var: " + mod2Var[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value mod2Var: " + mod2Var[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + mod1VarName + " % " + mod2VarName);

                    buttonsSetOn[index].Text = mod1VarName + " % " + mod2VarName;
                    
                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }
            
            else if (OnVar.Enabled == true)
            {
                onVarVarNameValue = OnVar.SelectedItem as string;
                
                if (onVarVarNameValue.Contains(":"))
                {
                    Console.Out.WriteLine("Po sprawdzeniu warunku: " + onVarVarNameValue);
                    string[] onVarVar = onVarVarNameValue.Split(':');
                    onVarVarName = onVarVar[0];
                    Console.Out.WriteLine("Po odzieleniu Name od Value onVarVar: " + onVarVar[0]);
                    Console.Out.WriteLine("Po odzieleniu Name od Value onVarVar: " + onVarVar[1]);

                    codeLinesList.Add(ComboBoxVarName + " = " + onVarVarName);

                    buttonsSetOn[index].Text = onVarVarName;
                    
                    foreach (var cokolwiek in codeLinesList)
                    {
                        Console.Out.WriteLine(cokolwiek);
                    }

                    this.Close();
                }

                else
                {
                    MessageBox.Show("Należy wybrać drugą wartość!!!");
                }
            }
            
            else if (OnNumer.Enabled == true)
            {
                codeLinesList.Add(ComboBoxVarName + " = " + onNumberValue);
                
                buttonsSetOn[index].Text = onNumberValue;
                
                foreach (var cokolwiek in codeLinesList)
                {
                    Console.Out.WriteLine(cokolwiek);
                }
                this.Close();
            }
        }

        //Wywoływanie okna ChooseVar
        private void Add1_Click(object sender, EventArgs e)
        {
            Console.Out.WriteLine("pierwotna wartość: " + add1VarNameValue);
            
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Add2_Click(object sender, EventArgs e)
        {
            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Sub1_Click(object sender, EventArgs e)
        {
            sub1VarNameValue = Sub1.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Sub2_Click(object sender, EventArgs e)
        {
            sub2VarNameValue = Sub2.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Multipy1_Click(object sender, EventArgs e)
        {
            multiply1VarNameValue = Multipy1.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Multipy2_Click(object sender, EventArgs e)
        {
            multiply2VarNameValue = Multipy2.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Div1_Click(object sender, EventArgs e)
        {
            div1VarNameValue = Div1.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Div2_Click(object sender, EventArgs e)
        {
            div2VarNameValue = Div2.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Mod1_Click(object sender, EventArgs e)
        {
            mod1VarNameValue = Mod1.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void Mod2_Click(object sender, EventArgs e)
        {
            mod2VarNameValue = Mod2.Text;

            clickedButton = sender as Button;
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }
    }
}