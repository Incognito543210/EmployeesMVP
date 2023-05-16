namespace Pracownicy.View
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //function that can get acces to listbox
        public int selectedItemListBox()
        {

            return listBox1.SelectedIndex;

        }

        public string returnStringListBox()
        {
            return listBox1.GetItemText(listBox1.SelectedItem);

        }

        public void clearListBox()
        {
            listBox1.Items.Clear();
        }
        public void addToListBox(string employe)
        {


            listBox1.Items.Add(employe);


        }

        //propertis 
        public string Name
        {

            get
            {
                if (textBox1.Text == string.Empty)
                {
                    errorProvider1.SetError(textBox1, "Podaj imie!");
                    return "er";
                }
                else
                {
                    return textBox1.Text;
                }
            }
            set { textBox1.Text = value; }
        }

        public string LastName
        {

            get
            {
                if (textBox2.Text == string.Empty)
                {
                    errorProvider2.SetError(textBox2, "Podaj nazwisko!");
                    return "er";
                }
                else
                {
                    return textBox2.Text;
                }

            }



            set { textBox2.Text = value; }
        }

        public string Date
        {
            get
            {
                if (dateTimePicker1.Text == string.Empty)
                {
                    errorProvider3.SetError(dateTimePicker1, "Podaj date!");
                    return "er";
                }
                else
                {
                    return dateTimePicker1.Text;
                }
            }

            set { dateTimePicker1.Text = value; }
        }


        public string Salary
        {
            get
            {
                return numericUpDown1.Text;

            }
            set { numericUpDown1.Text = value; }
        }

        public string Position
        {
            get
            {

                if (comboBox1.Text == string.Empty)
                {
                    errorProvider5.SetError(comboBox1, "Wybierz stanowisko!");
                    return "er";
                }
                else
                {
                    return comboBox1.Text;
                }





            }
            set { comboBox1.Text = value; }
        }

        public string Agreement
        {

            get
            {
                if (radioButton1.Checked)
                {
                    return radioButton1.Text;
                }
                else if (radioButton2.Checked)
                {
                    return radioButton2.Text;
                }
                else
                {
                    return radioButton3.Text;
                }


            }

            set
            {
                if (radioButton1.Checked)
                {
                    radioButton1.Text = value;
                }
                else if (radioButton2.Checked)
                {
                    radioButton2.Text = value;
                }
                else
                {
                    radioButton3.Text = value;
                }
            }

        }

        //function to check which answer is check
        public void checkRadioButton(string radiobutton)
        {
            if(radiobutton.Equals("umowa na czas nieokreœlony"))
            {
                radioButton1.Checked = true;
            }
            else if(radiobutton.Equals("umowa na czas okreœlony"))
            {
                radioButton2.Checked = true;
            }
            else 
            {
                radioButton3.Checked = true;
            }


        }

        //action for buttons

        public event Action AddButtonEvent;
        public event Action SaveButtonEvent;
        public event Action LoadButtonEvent;
        public event Action EditButtonEvent;
        public event Action ChangeButtonEvent;

        void add_button_event(object sender, EventArgs e)
        {
            AddButtonEvent?.Invoke();
        }
        void save_button_event(object sender, EventArgs e)
        {
            SaveButtonEvent?.Invoke();
        }
        void load_button_event(object sender, EventArgs e)
        {
            LoadButtonEvent?.Invoke();
        }

        void edit_button_event(object sender, EventArgs e)
        {
            EditButtonEvent?.Invoke();
        }

        void change_button_event(object sender, EventArgs e)
        {
            ChangeButtonEvent?.Invoke();
        }





    }
}