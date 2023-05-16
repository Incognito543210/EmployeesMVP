namespace Pracownicy.View
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            listBox1 = new ListBox();
            contextMenuStrip1 = new ContextMenuStrip(components);
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            numericUpDown1 = new NumericUpDown();
            comboBox1 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            groupBox1 = new GroupBox();
            change = new Button();
            Edit = new Button();
            LoadButton = new Button();
            AddButton = new Button();
            SaveButton = new Button();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            errorProvider1 = new ErrorProvider(components);
            errorProvider2 = new ErrorProvider(components);
            errorProvider3 = new ErrorProvider(components);
            errorProvider5 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).BeginInit();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 15;
            listBox1.Location = new Point(375, 6);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(413, 439);
            listBox1.TabIndex = 1;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // textBox1
            // 
            textBox1.Location = new Point(134, 49);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(193, 23);
            textBox1.TabIndex = 0;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(134, 98);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(193, 23);
            textBox2.TabIndex = 1;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Format = DateTimePickerFormat.Short;
            dateTimePicker1.Location = new Point(134, 144);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(193, 23);
            dateTimePicker1.TabIndex = 2;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Increment = new decimal(new int[] { 25, 0, 0, 0 });
            numericUpDown1.Location = new Point(134, 192);
            numericUpDown1.Maximum = new decimal(new int[] { 3000, 0, 0, 0 });
            numericUpDown1.Minimum = new decimal(new int[] { 2000, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(75, 23);
            numericUpDown1.TabIndex = 3;
            numericUpDown1.Value = new decimal(new int[] { 2000, 0, 0, 0 });
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Tester", "Projektant", "Inżynier", "Młodszy programista", "Starszy programista" });
            comboBox1.Location = new Point(134, 242);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(175, 23);
            comboBox1.TabIndex = 4;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            radioButton1.Checked = true;
            radioButton1.Location = new Point(134, 290);
            radioButton1.Name = "radioButton1";
            radioButton1.Size = new Size(176, 19);
            radioButton1.TabIndex = 5;
            radioButton1.TabStop = true;
            radioButton1.Text = "umowa na czas nieokreślony";
            radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            radioButton2.Location = new Point(134, 315);
            radioButton2.Name = "radioButton2";
            radioButton2.Size = new Size(160, 19);
            radioButton2.TabIndex = 6;
            radioButton2.Text = "umowa na czas określony";
            radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            radioButton3.Location = new Point(134, 340);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(110, 19);
            radioButton3.TabIndex = 7;
            radioButton3.Text = "umowa zlecenie";
            radioButton3.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(change);
            groupBox1.Controls.Add(Edit);
            groupBox1.Controls.Add(LoadButton);
            groupBox1.Controls.Add(AddButton);
            groupBox1.Controls.Add(SaveButton);
            groupBox1.Controls.Add(label6);
            groupBox1.Controls.Add(label5);
            groupBox1.Controls.Add(label4);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Controls.Add(label1);
            groupBox1.Controls.Add(radioButton3);
            groupBox1.Controls.Add(radioButton2);
            groupBox1.Controls.Add(radioButton1);
            groupBox1.Controls.Add(comboBox1);
            groupBox1.Controls.Add(numericUpDown1);
            groupBox1.Controls.Add(dateTimePicker1);
            groupBox1.Controls.Add(textBox2);
            groupBox1.Controls.Add(textBox1);
            groupBox1.Location = new Point(4, 6);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(365, 440);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dane pracownika";
            // 
            // change
            // 
            change.Location = new Point(252, 380);
            change.Name = "change";
            change.Size = new Size(57, 23);
            change.TabIndex = 17;
            change.Text = "Zmień";
            change.UseVisualStyleBackColor = true;
            change.Click += change_button_event;
            // 
            // Edit
            // 
            Edit.Location = new Point(185, 380);
            Edit.Name = "Edit";
            Edit.Size = new Size(66, 23);
            Edit.TabIndex = 16;
            Edit.Text = "Edytuj";
            Edit.UseVisualStyleBackColor = true;
            Edit.Click += edit_button_event;
            // 
            // LoadButton
            // 
            LoadButton.Location = new Point(183, 409);
            LoadButton.Name = "LoadButton";
            LoadButton.Size = new Size(127, 23);
            LoadButton.TabIndex = 2;
            LoadButton.Text = "Wczytaj";
            LoadButton.UseVisualStyleBackColor = true;
            LoadButton.Click += load_button_event;
            // 
            // AddButton
            // 
            AddButton.Location = new Point(49, 380);
            AddButton.Name = "AddButton";
            AddButton.Size = new Size(127, 23);
            AddButton.TabIndex = 15;
            AddButton.Text = "Dodaj";
            AddButton.UseVisualStyleBackColor = true;
            AddButton.Click += add_button_event;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(49, 409);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(127, 23);
            SaveButton.TabIndex = 14;
            SaveButton.Text = "Zapisz";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += save_button_event;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(22, 290);
            label6.Name = "label6";
            label6.Size = new Size(88, 15);
            label6.TabIndex = 13;
            label6.Text = "Rodzaj umowy:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(22, 242);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 12;
            label5.Text = "Stanowsiko:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 192);
            label4.Name = "label4";
            label4.Size = new Size(44, 15);
            label4.TabIndex = 11;
            label4.Text = "Pensja:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 144);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 10;
            label3.Text = "Data urodzenia:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 98);
            label2.Name = "label2";
            label2.Size = new Size(60, 15);
            label2.TabIndex = 9;
            label2.Text = "Nazwisko:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(22, 49);
            label1.Name = "label1";
            label1.Size = new Size(33, 15);
            label1.TabIndex = 8;
            label1.Text = "Imię:";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            errorProvider3.ContainerControl = this;
            // 
            // errorProvider5
            // 
            errorProvider5.ContainerControl = this;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listBox1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider2).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider3).EndInit();
            ((System.ComponentModel.ISupportInitialize)errorProvider5).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ListBox listBox1;
        private ContextMenuStrip contextMenuStrip1;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private NumericUpDown numericUpDown1;
        private ComboBox comboBox1;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private GroupBox groupBox1;
        private Label label1;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Button LoadButton;
        private Button AddButton;
        private Button SaveButton;
        private ErrorProvider errorProvider1;
        private ErrorProvider errorProvider2;
        private ErrorProvider errorProvider3;
        private ErrorProvider errorProvider5;
        private Button Edit;
        private Button change;
    }
}