//IGNACY:
// * zrób listę Stringów wyjściowych 
// * kazda delkarke wartosci dodawaj na sam przód listy
// * ogarnij forma do wybierania wartosci na przypiasnie 2 ChoosevarOn
// * zaimplementuj reszte przyciskow 
// * dodaj generacje kodu
// * jesli starczy czasu dodaj scrolla zeby przesowac gora / dol panel z kodem 
//jakby cos to dzwon UwU


using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.Remoting.Channels;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        // Pola klasy Form1

        // Licznik do śledzenia nowo utworzonych zmiennych
        private int newVarIterator = 0;
        
        // Nazwa zmiennej
        private string name;
        
        // Wartość zmiennej
        private int vart;
        
        // Tablica do przechowywania informacji o zmiennych jako ciągów znaków
        public static string[] varsTable = new string[500];
        public static string[] ifOperators = { "==", "<=", ">=", "!=", "<", ">" };
        public static string[] forOperators = { "<=", ">=", "<", ">" };
        
        // Flaga wskazująca, czy przycisk jest przesuwany
        private bool isButtonMoving = false;
        
        // Pozycja myszy
        private int mouseX;
        private int mouseY;
        
        // Flaga wskazująca, czy przycisk "start" został kliknięty
        private bool isButtonStartClicked = false;
        private bool isIfButtonClicked = false;
        private bool isNewVarButtonClicked = false;
        public static bool isButtonPrintSetVarClicked;
        private bool isComboBoxVarValueChanged = false;
        private bool isComboBoxIfValueChanged = false;

        public static int ButtonLocationX = 488;

        // Listy kontrolki GUI
        private List<Button> buttons = new List<Button>();
        private List<ComboBox> comboBoxes = new List<ComboBox>();
        private List<TextBox> textBoxesSet = new List<TextBox>();
        private List<TextBox> textBoxesOn = new List<TextBox>();
        private List<Button> varSettedButtons = new List<Button>();
        internal static  List<Button> buttonsSetOn = new List<Button>();
        
        // Pozycja dla kolejnego przycisku
        private int iteratorButtonY = 60;

        // Kontrolki GUI

        public static int index;

        private bool flagVarAccepted = true;

        public static List<String> codeLinesList = new List<string>();
        
        public static List<ComboBox> comboBoxesList = new List<ComboBox>();
        
        public static Button buttonSetOn = new Button();

        public static String ComboBoxVar;
        public static String ComboBoxVarName;
        public static String ComboBoxIfVarName;
        public static String ComboBoxIfIfName;
        public static String ComboBoxIfVar1Name;
        public static String ComboBoxIfVar;
        public static String ComboBoxIfVar1;
        
        ComboBox comboBoxIfVar = new ComboBox();
        ComboBox comboBoxIfVar1 = new ComboBox();
        ComboBox comboBoxIfIf = new ComboBox();
        
        private string comboBoxIfVarValue;
        private string comboBoxIfIfValue;
        private string comboBoxIfVar1Value;
        private string comboBoxSetValue;
        
        // Konstruktor domyślny
        public Form1()
        {
            InitializeComponent();
            MessageBox.Show("Uwaga! Ta aplikacja jest w wersji rozwojowej i część jej funkcjonalności nie działa poprawnie.");
        }

        // Obsługa kliknięcia przycisku "button1" (POCZĄTEK) - zaznaczenie
        private void button1_Click(object sender, EventArgs e)
        {
            Button buttonStart = sender as Button;

            if (!isButtonStartClicked)
            {
                buttonStart.BackColor = Color.Yellow;
                isButtonStartClicked = true;
            }
            else
            {
                buttonStart.BackColor = Color.FromArgb(255, 255, 255);
                isButtonStartClicked = false;
            }
        }
        
        // Obsługa kliknięcia przycisku "newVar"
        private void newVar_Click(object sender, EventArgs e)
        {
            // Wyświetlanie okna dialogowego do wprowadzenia nazwy i wartości zmiennej
            string varName = Microsoft.VisualBasic.Interaction.InputBox("Podaj nazwę zmiennej ", "Tworzenie zmiennej");
            
            if (varName == "")
            {
                MessageBox.Show("BŁĄD! PODAJ NAZWĘ ZMIENNEJ");
            }
            else
            {
                var varVarStr = Microsoft.VisualBasic.Interaction.InputBox("Podaj wartość zmiennej", "Tworzenie zmiennej", "0");
                int varVar;
                if (int.TryParse(varVarStr, out varVar))
                {
                    flagVarAccepted = true;
                    Console.Out.WriteLine(varVar);
                }
                else
                {
                    flagVarAccepted = false;
                    MessageBox.Show("BŁĄD! PODAJ WARTOŚĆ LICZBOWĄ");
                }

                if (flagVarAccepted)
                {
                    MessageBox.Show("Utworzono zmienną o nazwie: " + varName + ", o wartości: " + varVar);
            
                    Console.Out.WriteLine("[ID: " + newVarIterator + "] " + varName + " o wartosci: " + varVar);

                    // Dodawanie informacji o zmiennej do tablicy
                    varsTable[newVarIterator] = varName + ": " + varVar;
                    newVarIterator++;
                    
                    codeLinesList.Insert(0, varName.ToString() + " = " + varVar.ToString());
                }
            }
        }

        // Obsługa kliknięcia przycisku "setvar"
        void setvar_Click(object sender, EventArgs e)
        {
            // Tworzenie nowego przycisku
            Button newButton = new Button();
            
            TextBox textBoxSet = new TextBox();
            TextBox textBoxOn = new TextBox();
            ComboBox comboBox = new ComboBox();
            
            
            
            newButton.Text = "";
            newButton.Width = 283;
            newButton.Height = 30;
            newButton.BackColor = Color.FromArgb(255, 255, 255);
            newButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            
            comboBox.Location = new Point(40, 5);

            textBoxSet.Text = "Ustaw";
            textBoxSet.Location = new Point(3, 8);
            textBoxSet.Width = 37;
            textBoxSet.ReadOnly = true;
            textBoxSet.BorderStyle = BorderStyle.None;
            textBoxSet.BackColor = Color.FromArgb(255, 255, 255);

            textBoxOn.Text = "Na";
            textBoxOn.Location = new Point(144, 8);
            textBoxOn.Width = 20;
            textBoxOn.ReadOnly = true;
            textBoxOn.BorderStyle = BorderStyle.None;
            textBoxOn.BackColor = Color.FromArgb(255, 255, 255);

            buttonSetOn.Text = "Wybierz";
            buttonSetOn.Location = new Point(167, 5);
            
            // Obsługa kliknięcia na nowym przycisku
            comboBox.Click += new EventHandler(comboBox_Click);
            buttonSetOn.Click += new EventHandler(buttonSetOn_Click);
            buttonsSetOn.Add(buttonSetOn);

            // Dodanie przycisku do listy przycisków
            buttons.Add(newButton);
            comboBoxes.Add(comboBox);
            textBoxesOn.Add(textBoxOn);
            textBoxesSet.Add(textBoxSet);
            

            // Dodanie przycisku do formularza
            comboBox.Width = 100;
            
            panel1.Controls.Add(newButton);
            newButton.Controls.Add(textBoxSet);
            newButton.Controls.Add(comboBox);
            newButton.Controls.Add(textBoxOn);
            newButton.Controls.Add(buttonSetOn);
            
            newButton.SendToBack();
            comboBox.BringToFront();
            textBoxSet.BringToFront();
            textBoxOn.BringToFront();
            buttonSetOn.BringToFront();
            
            comboBox.DataSource = null;
            comboBox.DataSource = varsTable;

            newButton.Click += new EventHandler(newVarButton_Click);
            comboBox.SelectedIndexChanged += new EventHandler(SelectedIndexChangedSetVar);
            
            iteratorButtonY += 30;

            //buttonSetOn.Tag = buttonsSetOn.IndexOf(buttonSetOn);
            
            
             
            
            if (comboBox.SelectedItem == null)
            {
                buttonSetOn.Enabled = false;
            }
            else
            {
                
                ComboBoxVar = comboBox.SelectedItem.ToString();
                Console.Write(ComboBoxVar);
                buttonSetOn.Enabled = true;
            }
        }

        private void SelectedIndexChangedSetVar(object sender, EventArgs e)
        {
            ComboBox comboBoxTemp = sender as ComboBox;

            if (comboBoxTemp.SelectedItem == null)
            {
                buttonSetOn.Enabled = false;
            }
            else
            {
                comboBoxSetValue = comboBoxTemp.SelectedItem.ToString();
                string[] parts = comboBoxSetValue.Split(':');
                ComboBoxVarName = parts[0];
                buttonSetOn.Enabled = true;
            }
        }
        
        // Obsługa kliknięcia na nowym przycisku
        private void buttonSetOn_Click(object sender, EventArgs e)
        {
            index = buttonsSetOn.IndexOf(sender as Button);
            
            var ChooseForm = new ChoosseVarOn();
            ChooseForm.Show();
        }
        
        //Obsługa kliknięcia na przycisk newVarButton - zaznaczenie
        private void newVarButton_Click(object sender, EventArgs e)
        {
            Button newVarButton = sender as Button;

            if (!isNewVarButtonClicked)
            {
                newVarButton.BackColor = Color.Yellow;
                isNewVarButtonClicked = true;
            }
            else
            {
                newVarButton.BackColor = Color.FromArgb(255, 255, 255);
                isNewVarButtonClicked = false;
            }
        }
        
        // Obsługa kliknięcia na ComboBox zmiennych "comboBox"
        private void comboBox_Click(object sender, EventArgs e) 
        {
            ComboBox comboBox = sender as ComboBox;
            
            // Wymuszenie rozwinięcia "comboBox" i aktualizacja źródła danych
            comboBox.DroppedDown = true;
            comboBox.DataSource = null;
            comboBox.DataSource = varsTable;
        }
        
        //Obsługa przycisku If (Jeśli)
        private void If_Click(object sender, EventArgs e)  
        {
            // Tworzenie nowego przycisku
            Button IfButton = new Button();
            TextBox textBoxIf = new TextBox();
            TextBox textBoxThen = new TextBox();
            
            
            IfButton.Text = "";
            IfButton.Width = 283;
            IfButton.Height = 30;
            IfButton.BackColor = Color.FromArgb(255, 255, 255);
            IfButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            

            textBoxIf.Text = "Jezeli";
            textBoxIf.Location = new Point(3, 8);
            textBoxIf.Width = 33;
            textBoxIf.ReadOnly = true;
            textBoxIf.BorderStyle = BorderStyle.None;
            textBoxIf.BackColor = Color.FromArgb(255, 255, 255);
            
            textBoxThen.Text = "to:";
            textBoxThen.Location = new Point(263, 8);
            textBoxThen.Width = 15;
            textBoxThen.ReadOnly = true;
            textBoxThen.BorderStyle = BorderStyle.None;
            textBoxThen.BackColor = Color.FromArgb(255, 255, 255);
            
            comboBoxIfVar.Location = new Point(34, 5);
            comboBoxIfIf.Location = new Point(122, 5);
            comboBoxIfVar1.Location = new Point(175, 5);
            
            comboBoxIfVar.Click += new EventHandler(comboBox_Click);
            comboBoxIfVar1.Click += new EventHandler(comboBox_Click);
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(IfButton);
            comboBoxes.Add(comboBoxIfVar);
            comboBoxes.Add(comboBoxIfVar1);
            comboBoxes.Add(comboBoxIfIf);
            textBoxesOn.Add(textBoxIf);
            textBoxesOn.Add(textBoxThen);
            
            // Dodanie przycisku do formularza
            comboBoxIfVar.Width = 85;
            comboBoxIfVar1.Width = 85;
            comboBoxIfIf.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(IfButton);
            IfButton.Controls.Add(textBoxIf); //Jeśli
            IfButton.Controls.Add(comboBoxIfVar); //Var1
            IfButton.Controls.Add(comboBoxIfIf);  //Warunek
            IfButton.Controls.Add(comboBoxIfVar1);//Var2
            IfButton.Controls.Add(textBoxThen); //To: 
            
            IfButton.SendToBack();
            textBoxIf.BringToFront();
            comboBoxIfVar.BringToFront();
            comboBoxIfIf.BringToFront();
            comboBoxIfVar1.BringToFront();
            textBoxThen.BringToFront();
            
            comboBoxIfVar.DataSource = null;
            comboBoxIfVar.DataSource = varsTable;
            comboBoxIfVar1.DataSource = null;
            comboBoxIfVar1.DataSource = varsTable;
            comboBoxIfIf.DataSource = ifOperators;
            
            IfButton.Click += new EventHandler(IfButton_Click);
            comboBoxIfVar.SelectedIndexChanged += new EventHandler(SelectedIndexChangedIfComboBoxVar);
            comboBoxIfIf.SelectedIndexChanged += new EventHandler(SelectedIndexChangedIfComboBoxIf);
            comboBoxIfVar1.SelectedIndexChanged += new EventHandler(SelectedIndexChangedIfComboBoxVar1);
            
            comboBoxIfVar1.Enabled = false;
            
            ButtonLocationX += 36;
            iteratorButtonY += 30;
        }

        
        private void SelectedIndexChangedIfComboBoxVar(object sender, EventArgs e)
        {
            ComboBox comboBoxIfIf = sender as ComboBox;

            if (comboBoxIfVar.SelectedItem == null)
            {
                isComboBoxVarValueChanged = false;
            }
            else
            {
                comboBoxIfVar.Enabled = true;

                comboBoxIfVar1.Enabled = true;
                comboBoxIfIf.Enabled = true;

                comboBoxIfVarValue = comboBoxIfVar.SelectedItem.ToString();
                string[] parts = comboBoxIfVarValue.Split(':');
                ComboBoxIfVarName = parts[0];
            }
        }
        
        private void SelectedIndexChangedIfComboBoxIf(object sender, EventArgs e)
        {
            ComboBox comboBoxIfIf = sender as ComboBox;
            ComboBoxIfIfName = comboBoxIfIf.SelectedItem.ToString();
        }
        
        private void SelectedIndexChangedIfComboBoxVar1(object sender, EventArgs e)
        {
            ComboBox comboBoxIfVar1 = sender as ComboBox;

            comboBoxIfVar1.Enabled = true;

            comboBoxIfVar1Value = comboBoxIfVar1.SelectedItem.ToString();

            string[] parts = comboBoxIfVar1Value.Split(':');
            ComboBoxIfVar1Name = parts[0];
        }

        //Obsługa przycisku IfButton - zaznaczenie
        private void IfButton_Click(object sender, EventArgs e)
        {
            Button IfButton = sender as Button;

            if (!isIfButtonClicked)
            {
                IfButton.BackColor = Color.Yellow;
                isIfButtonClicked = true;
            }
            else
            {
                IfButton.BackColor = Color.FromArgb(255, 255, 255);
                isIfButtonClicked = false;
            }
        }

        private void endIf_Click(object sender, EventArgs e)
        {
            if (ButtonLocationX <= 488)
            {
                ButtonLocationX = 488;
                MessageBox.Show("Jesteś w programie głównym. Zamknąłeś ostatni warunek \"Jeśli\"");
            }
            else
            {
                ButtonLocationX -= 36;
                MessageBox.Show("Wyszedłeś/aś z warunku");
            }
        }

        private void ifElse_Click(object sender, EventArgs e)
        {
            //IF
            // Tworzenie nowego przycisku
            Button IfButton = new Button();
            ComboBox comboBoxVar = new ComboBox();
            ComboBox comboBoxVar1 = new ComboBox();
            ComboBox comboBoxIf = new ComboBox();
            TextBox textBoxIf = new TextBox();
            TextBox textBoxThen = new TextBox();
            
            
            IfButton.Text = "";
            IfButton.Width = 283;
            IfButton.Height = 30;
            IfButton.BackColor = Color.FromArgb(255, 255, 255);
            IfButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            

            textBoxIf.Text = "Jezeli";
            textBoxIf.Location = new Point(3, 8);
            textBoxIf.Width = 33;
            textBoxIf.ReadOnly = true;
            textBoxIf.BorderStyle = BorderStyle.None;
            textBoxIf.BackColor = Color.FromArgb(255, 255, 255);
            
            textBoxThen.Text = "to:";
            textBoxThen.Location = new Point(263, 8);
            textBoxThen.Width = 15;
            textBoxThen.ReadOnly = true;
            textBoxThen.BorderStyle = BorderStyle.None;
            textBoxThen.BackColor = Color.FromArgb(255, 255, 255);
            
            comboBoxVar.Location = new Point(34, 5);
            comboBoxIf.Location = new Point(122, 5);
            comboBoxVar1.Location = new Point(175, 5);
            
            comboBoxVar.Click += new EventHandler(comboBox_Click);
            comboBoxVar1.Click += new EventHandler(comboBox_Click);
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(IfButton);
            comboBoxes.Add(comboBoxVar);
            comboBoxes.Add(comboBoxVar1);
            comboBoxes.Add(comboBoxIf);
            textBoxesOn.Add(textBoxIf);
            textBoxesOn.Add(textBoxThen);
            
            // Dodanie przycisku do formularza
            comboBoxVar.Width = 85;
            comboBoxVar1.Width = 85;
            comboBoxIf.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(IfButton);
            IfButton.Controls.Add(textBoxIf); //Jeśli
            IfButton.Controls.Add(comboBoxVar); //Var1
            IfButton.Controls.Add(comboBoxIf);  //Warunek
            IfButton.Controls.Add(comboBoxVar1);//Var2
            IfButton.Controls.Add(textBoxThen); //To: 
            
            
            IfButton.SendToBack();
            textBoxIf.BringToFront();
            comboBoxVar.BringToFront();
            comboBoxIf.BringToFront();
            comboBoxVar1.BringToFront();
            textBoxThen.BringToFront();
            
            comboBoxVar.DataSource = null;
            comboBoxVar.DataSource = varsTable;
            comboBoxVar1.DataSource = null;
            comboBoxVar1.DataSource = varsTable;
            comboBoxIf.DataSource = ifOperators;
            
            IfButton.Click += new EventHandler(IfButton_Click);

            ButtonLocationX += 36;
            iteratorButtonY += 30;
            
            //ELSE
            
            Button ElseButton = new Button();
            TextBox textBoxElse = new TextBox();
            
            
            ElseButton.Text = "";
            ElseButton.Width = 283;
            ElseButton.Height = 30;
            ElseButton.BackColor = Color.FromArgb(255, 255, 255);
            ElseButton.Location = new Point(ButtonLocationX-36, iteratorButtonY);
            

            textBoxElse.Text = "W przeciwnym wypadku:";
            textBoxElse.Location = new Point(3, 8);
            textBoxElse.Width = 120;
            textBoxElse.ReadOnly = true;
            textBoxElse.BorderStyle = BorderStyle.None;
            textBoxElse.BackColor = Color.FromArgb(255, 255, 255);
            
            buttons.Add(ElseButton);
            textBoxesOn.Add(textBoxElse);
            
            panel1.Controls.Add(ElseButton);
            ElseButton.Controls.Add(textBoxElse); //Else
            
            ElseButton.SendToBack();
            textBoxElse.BringToFront();
        }

        private void For_Click(object sender, EventArgs e)
        {
            //FOR
            // Tworzenie nowego przycisku
            Button ForButton = new Button();
            ComboBox comboBoxIterator = new ComboBox();
            ComboBox comboBoxFor = new ComboBox();
            TextBox textBoxFor = new TextBox();
            Button timesButton = new Button();
            
            
            ForButton.Text = "";
            ForButton.Width = 283;
            ForButton.Height = 30;
            ForButton.BackColor = Color.FromArgb(255, 255, 255);
            ForButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            
            timesButton.Text = "Wybierz";
            timesButton.Width = 57; 
            timesButton.Height = 23;
            timesButton.BackColor = Color.FromArgb(255, 255, 255);
            timesButton.Location = new Point(218, 5);
            
            textBoxFor.Text = "Wkonuj dopóki";
            textBoxFor.Location = new Point(3, 8);
            textBoxFor.Width = 75;
            textBoxFor.ReadOnly = true;
            textBoxFor.BorderStyle = BorderStyle.None;
            textBoxFor.BackColor = Color.FromArgb(255, 255, 255);
            
            
            comboBoxIterator.Location = new Point(77, 5);
            comboBoxFor.Location = new Point(165, 5);
            
            comboBoxIterator.Click += new EventHandler(comboBox_Click);
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(ForButton);
            comboBoxes.Add(comboBoxIterator);
            comboBoxes.Add(comboBoxFor);
            textBoxesOn.Add(textBoxFor);
            buttons.Add(timesButton);
            
            
            // Dodanie przycisku do formularza
            comboBoxIterator.Width = 85;
            comboBoxFor.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(ForButton);
            ForButton.Controls.Add(textBoxFor); //Jeśli
            ForButton.Controls.Add(comboBoxIterator); //Var1
            ForButton.Controls.Add(comboBoxFor);  //Warunek
            ForButton.Controls.Add(timesButton);  //Var2
            
            
            ForButton.SendToBack();
            textBoxFor.BringToFront();
            comboBoxIterator.BringToFront();
            comboBoxFor.BringToFront();
            timesButton.BringToFront();
            
            comboBoxIterator.DataSource = null;
            comboBoxIterator.DataSource = varsTable;
            comboBoxFor.DataSource = forOperators;
            
            ForButton.Click += new EventHandler(IfButton_Click);
            timesButton.Click += new EventHandler(timesButton_Click);

            ButtonLocationX += 36;
            iteratorButtonY += 30;
        }
        
        private void timesButton_Click(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton = sender as Button;
            Console.Out.WriteLine(index);
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void While_Click(object sender, EventArgs e)
        {
            //WHILE
            // Tworzenie nowego przycisku
            Button WhileButton = new Button();
            TextBox textBoxWhile = new TextBox();
            Button var1Button = new Button();
            ComboBox comboBoxIf = new ComboBox();
            Button var2Button = new Button();
            
            WhileButton.Text = "";
            WhileButton.Width = 283;
            WhileButton.Height = 30;
            WhileButton.BackColor = Color.FromArgb(255, 255, 255);
            WhileButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            
            textBoxWhile.Text = "Wykonuj dopóki";
            textBoxWhile.Location = new Point(3, 8);
            textBoxWhile.Width = 80;
            textBoxWhile.ReadOnly = true;
            textBoxWhile.BorderStyle = BorderStyle.None;
            textBoxWhile.BackColor = Color.FromArgb(255, 255, 255);
            
            //Var1
            var1Button.Text = "Wybierz";
            var1Button.Width = 57; 
            var1Button.Height = 23;
            var1Button.BackColor = Color.FromArgb(255, 255, 255);
            var1Button.Location = new Point(83, 5);
            
            comboBoxIf.Location = new Point(143, 5);
            
            //Var2
            var2Button.Text = "Wybierz";
            var2Button.Width = 57; 
            var2Button.Height = 23;
            var2Button.BackColor = Color.FromArgb(255, 255, 255);
            var2Button.Location = new Point(196, 5);
            
            
            // Dodanie przycisku do listy przycisków
            buttons.Add(WhileButton);
            comboBoxes.Add(comboBoxIf);
            textBoxesOn.Add(textBoxWhile);
            buttons.Add(var1Button);
            buttons.Add(var2Button);
            
            
            // Dodanie comboboxa do formularza
            comboBoxIf.Width = 50;
            
            //Dodanie kontrolek do formularza
            panel1.Controls.Add(WhileButton);
            WhileButton.Controls.Add(textBoxWhile); //Jeśli
            WhileButton.Controls.Add(comboBoxIf);  //Warunek
            WhileButton.Controls.Add(var1Button);  //Var1
            WhileButton.Controls.Add(var2Button);  //Var2
            
            
            WhileButton.SendToBack();
            textBoxWhile.BringToFront();
            var1Button.BringToFront();
            comboBoxIf.BringToFront();
            var2Button.BringToFront();
            
            comboBoxIf.DataSource = forOperators;
            
            WhileButton.Click += new EventHandler(IfButton_Click);
            var1Button.Click += new EventHandler(var1Button_Click);
            var2Button.Click += new EventHandler(var2Button_Click);

            ButtonLocationX += 36;
            iteratorButtonY += 30;
        }
        
        private void var1Button_Click(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton = sender as Button;
            Console.Out.WriteLine(index);
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }
        
        private void var2Button_Click(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton = sender as Button;
            Console.Out.WriteLine(index);
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }

        private void print_Click(object sender, EventArgs e)
        {
            Button PrintButton = new Button();
            TextBox textBoxPrint = new TextBox();
            Button varButton = new Button();
            
            PrintButton.Text = "";
            PrintButton.Width = 283;
            PrintButton.Height = 30;
            PrintButton.BackColor = Color.FromArgb(255, 255, 255);
            PrintButton.Location = new Point(ButtonLocationX, iteratorButtonY);
            
            textBoxPrint.Text = "Wyświetl";
            textBoxPrint.Location = new Point(10, 8);
            textBoxPrint.Width = 45;
            textBoxPrint.ReadOnly = true;
            textBoxPrint.BorderStyle = BorderStyle.None;
            textBoxPrint.BackColor = Color.FromArgb(255, 255, 255);
            
            //Var1
            varButton.Text = "Wybierz";
            varButton.BackColor = Color.FromArgb(255, 255, 255);
            varButton.Location = new Point(59, 5);
            
            buttons.Add(PrintButton);
            textBoxesOn.Add(textBoxPrint);
            buttons.Add(varButton);
            
            panel1.Controls.Add(PrintButton);
            PrintButton.Controls.Add(textBoxPrint); //Wyświetl
            PrintButton.Controls.Add(varButton); //Var
            
            PrintButton.SendToBack();
            textBoxPrint.BringToFront();
            varButton.BringToFront();
            
            PrintButton.Click += new EventHandler(PrintButton_Click);
            varButton.Click += new EventHandler(varButton_Click);
            
            iteratorButtonY += 30;
        }
        
        private void PrintButton_Click(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton = sender as Button;
            Console.Out.WriteLine(index);
            var ChooseForm = new ChooseVar();
            ChooseForm.Show();
        }
        
        private void varButton_Click(object sender, EventArgs e)
        {
            ChoosseVarOn.clickedButton = sender as Button;
            Console.Out.WriteLine(index);
            var ChooseForm = new ChooseVar();
            isButtonPrintSetVarClicked = true;
            ChooseForm.Show();
        }

        private void Kompiluj_Click(object sender, EventArgs e)
        {
            int iteratorPlikow = 1;
            string finalCodeExport = codeLinesList.Aggregate((current, next) => current + Environment.NewLine + next);
            MessageBox.Show(finalCodeExport, "Kompilacja");
            
            File.WriteAllText("komplacaja" + iteratorPlikow + ".py", finalCodeExport);


            MessageBox.Show("Zapisano do pliku " + "komplacja" + iteratorPlikow + ".py");

            iteratorPlikow++;
            //throw new System.NotImplementedException();
        }
    }
}