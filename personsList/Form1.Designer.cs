namespace personsList
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
            listBox1 = new ListBox();
            button1 = new Button();
            deleteButton = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            Gender = new ComboBox();
            monthCalendar1 = new MonthCalendar();
            ShowInfoButton = new Button();
            label5 = new Label();
            panel1 = new Panel();
            textBox6 = new TextBox();
            textBox5 = new TextBox();
            textBox4 = new TextBox();
            label7 = new Label();
            monthCalendar2 = new MonthCalendar();
            comboBoxGender = new ComboBox();
            genderLabel = new Label();
            ageLabel = new Label();
            surnameLabel = new Label();
            label6 = new Label();
            ProductsList = new ListBox();
            SaveButton = new Button();
            EditButton = new Button();
            closeButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // listBox1
            // 
            listBox1.BackColor = Color.WhiteSmoke;
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 20;
            listBox1.Location = new Point(297, 183);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(529, 284);
            listBox1.TabIndex = 0;
            // 
            // button1
            // 
            button1.BackColor = Color.Chartreuse;
            button1.Cursor = Cursors.Hand;
            button1.Location = new Point(709, 77);
            button1.Name = "button1";
            button1.Size = new Size(117, 39);
            button1.TabIndex = 1;
            button1.Text = "Add person";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // deleteButton
            // 
            deleteButton.BackColor = Color.IndianRed;
            deleteButton.Cursor = Cursors.Hand;
            deleteButton.Location = new Point(709, 496);
            deleteButton.Name = "deleteButton";
            deleteButton.Size = new Size(111, 40);
            deleteButton.TabIndex = 2;
            deleteButton.Text = "Delete person";
            deleteButton.UseVisualStyleBackColor = false;
            deleteButton.Click += deleteButton_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(102, 12);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(142, 27);
            textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(102, 45);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(142, 27);
            textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(102, 77);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(60, 27);
            textBox3.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.FromArgb(192, 192, 255);
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(11, 16);
            label1.Name = "label1";
            label1.Size = new Size(62, 22);
            label1.TabIndex = 7;
            label1.Text = "Name:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.FromArgb(192, 192, 255);
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label2.Location = new Point(11, 47);
            label2.Name = "label2";
            label2.Size = new Size(84, 22);
            label2.TabIndex = 8;
            label2.Text = "Surname:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.FromArgb(192, 192, 255);
            label3.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(11, 77);
            label3.Name = "label3";
            label3.Size = new Size(48, 22);
            label3.TabIndex = 9;
            label3.Text = "Age:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.FromArgb(192, 192, 255);
            label4.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label4.Location = new Point(11, 112);
            label4.Name = "label4";
            label4.Size = new Size(68, 22);
            label4.TabIndex = 10;
            label4.Text = "Gender";
            // 
            // Gender
            // 
            Gender.Cursor = Cursors.Hand;
            Gender.FormattingEnabled = true;
            Gender.Items.AddRange(new object[] { "Male", "Female", "Other." });
            Gender.Location = new Point(102, 109);
            Gender.Name = "Gender";
            Gender.Size = new Size(151, 28);
            Gender.TabIndex = 13;
            Gender.Text = "Select";
            Gender.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // monthCalendar1
            // 
            monthCalendar1.Location = new Point(11, 220);
            monthCalendar1.Margin = new Padding(10, 12, 10, 12);
            monthCalendar1.Name = "monthCalendar1";
            monthCalendar1.TabIndex = 14;
            monthCalendar1.DateChanged += monthCalendar1_DateChanged_1;
            // 
            // ShowInfoButton
            // 
            ShowInfoButton.Location = new Point(25, 508);
            ShowInfoButton.Margin = new Padding(3, 4, 3, 4);
            ShowInfoButton.Name = "ShowInfoButton";
            ShowInfoButton.Size = new Size(137, 48);
            ShowInfoButton.TabIndex = 15;
            ShowInfoButton.Text = "Show Info";
            ShowInfoButton.UseVisualStyleBackColor = true;
            ShowInfoButton.Click += ShowInfoButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.FromArgb(192, 192, 255);
            label5.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point);
            label5.Location = new Point(70, 183);
            label5.Name = "label5";
            label5.Size = new Size(172, 22);
            label5.TabIndex = 16;
            label5.Text = "Select your Birthday";
            // 
            // panel1
            // 
            panel1.BackColor = Color.MediumSlateBlue;
            panel1.Controls.Add(textBox6);
            panel1.Controls.Add(textBox5);
            panel1.Controls.Add(textBox4);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(monthCalendar2);
            panel1.Controls.Add(comboBoxGender);
            panel1.Controls.Add(genderLabel);
            panel1.Controls.Add(ageLabel);
            panel1.Controls.Add(surnameLabel);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(ProductsList);
            panel1.Controls.Add(SaveButton);
            panel1.Controls.Add(EditButton);
            panel1.Controls.Add(closeButton);
            panel1.Location = new Point(138, 45);
            panel1.Margin = new Padding(3, 4, 3, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(688, 511);
            panel1.TabIndex = 17;
            panel1.Paint += panel1_Paint;
            // 
            // textBox6
            // 
            textBox6.Location = new Point(97, 89);
            textBox6.Margin = new Padding(3, 4, 3, 4);
            textBox6.Name = "textBox6";
            textBox6.Size = new Size(101, 27);
            textBox6.TabIndex = 13;
            // 
            // textBox5
            // 
            textBox5.Location = new Point(97, 47);
            textBox5.Margin = new Padding(3, 4, 3, 4);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(101, 27);
            textBox5.TabIndex = 12;
            // 
            // textBox4
            // 
            textBox4.Location = new Point(97, 7);
            textBox4.Margin = new Padding(3, 4, 3, 4);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(101, 27);
            textBox4.TabIndex = 11;
            textBox4.TextChanged += textBox4_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.BackColor = Color.LightSteelBlue;
            label7.Location = new Point(80, 191);
            label7.Name = "label7";
            label7.Size = new Size(108, 20);
            label7.TabIndex = 10;
            label7.Text = "Select Birthday";
            // 
            // monthCalendar2
            // 
            monthCalendar2.Location = new Point(34, 220);
            monthCalendar2.Margin = new Padding(10, 12, 10, 12);
            monthCalendar2.Name = "monthCalendar2";
            monthCalendar2.TabIndex = 9;
            // 
            // comboBoxGender
            // 
            comboBoxGender.FormattingEnabled = true;
            comboBoxGender.Items.AddRange(new object[] { "Male", "Female", "Other." });
            comboBoxGender.Location = new Point(97, 128);
            comboBoxGender.Margin = new Padding(3, 4, 3, 4);
            comboBoxGender.Name = "comboBoxGender";
            comboBoxGender.Size = new Size(99, 28);
            comboBoxGender.TabIndex = 8;
            comboBoxGender.SelectedIndexChanged += comboBoxGender_SelectedIndexChanged;
            // 
            // genderLabel
            // 
            genderLabel.AutoSize = true;
            genderLabel.BackColor = Color.LightSteelBlue;
            genderLabel.Location = new Point(23, 132);
            genderLabel.Name = "genderLabel";
            genderLabel.Size = new Size(57, 20);
            genderLabel.TabIndex = 7;
            genderLabel.Text = "Gender";
            // 
            // ageLabel
            // 
            ageLabel.AutoSize = true;
            ageLabel.BackColor = Color.LightSteelBlue;
            ageLabel.Location = new Point(23, 89);
            ageLabel.Name = "ageLabel";
            ageLabel.Size = new Size(39, 20);
            ageLabel.TabIndex = 6;
            ageLabel.Text = "Age:";
            // 
            // surnameLabel
            // 
            surnameLabel.AutoSize = true;
            surnameLabel.BackColor = Color.LightSteelBlue;
            surnameLabel.Location = new Point(23, 51);
            surnameLabel.Name = "surnameLabel";
            surnameLabel.Size = new Size(70, 20);
            surnameLabel.TabIndex = 5;
            surnameLabel.Text = "Surname:";
            surnameLabel.Click += label7_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.BackColor = Color.LightSteelBlue;
            label6.Location = new Point(23, 17);
            label6.Name = "label6";
            label6.Size = new Size(52, 20);
            label6.TabIndex = 4;
            label6.Text = "Name:";
            // 
            // ProductsList
            // 
            ProductsList.FormattingEnabled = true;
            ProductsList.ItemHeight = 20;
            ProductsList.Location = new Point(264, 223);
            ProductsList.Margin = new Padding(3, 4, 3, 4);
            ProductsList.Name = "ProductsList";
            ProductsList.Size = new Size(417, 204);
            ProductsList.TabIndex = 3;
            ProductsList.SelectedIndexChanged += ProductsList_SelectedIndexChanged;
            // 
            // SaveButton
            // 
            SaveButton.Location = new Point(571, 445);
            SaveButton.Margin = new Padding(3, 4, 3, 4);
            SaveButton.Name = "SaveButton";
            SaveButton.Size = new Size(96, 52);
            SaveButton.TabIndex = 2;
            SaveButton.Text = "Save";
            SaveButton.UseVisualStyleBackColor = true;
            SaveButton.Click += SaveButton_Click;
            // 
            // EditButton
            // 
            EditButton.Location = new Point(573, 138);
            EditButton.Margin = new Padding(3, 4, 3, 4);
            EditButton.Name = "EditButton";
            EditButton.Size = new Size(94, 51);
            EditButton.TabIndex = 1;
            EditButton.Text = "Edit";
            EditButton.UseVisualStyleBackColor = true;
            EditButton.Click += EditButton_Click;
            // 
            // closeButton
            // 
            closeButton.BackColor = Color.Crimson;
            closeButton.ForeColor = SystemColors.ControlLightLight;
            closeButton.Location = new Point(650, 4);
            closeButton.Margin = new Padding(3, 4, 3, 4);
            closeButton.Name = "closeButton";
            closeButton.Size = new Size(31, 33);
            closeButton.TabIndex = 0;
            closeButton.Text = "X";
            closeButton.UseVisualStyleBackColor = false;
            closeButton.Click += closeButton_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.MidnightBlue;
            ClientSize = new Size(849, 572);
            Controls.Add(panel1);
            Controls.Add(label5);
            Controls.Add(ShowInfoButton);
            Controls.Add(monthCalendar1);
            Controls.Add(Gender);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox3);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(deleteButton);
            Controls.Add(button1);
            Controls.Add(listBox1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listBox1;
        private Button button1;
        private Button deleteButton;
        private TextBox textBox1;
        private TextBox textBox2;
        private TextBox textBox3;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox Gender;
        private MonthCalendar monthCalendar1;
        private Button ShowInfoButton;
        private Label label5;
        private Panel panel1;
        private ListBox ProductsList;
        private Button SaveButton;
        private Button EditButton;
        private Button closeButton;
        private Label genderLabel;
        private Label ageLabel;
        private Label surnameLabel;
        private Label label6;
        private Label label7;
        private MonthCalendar monthCalendar2;
        private ComboBox comboBoxGender;
        private TextBox textBox6;
        private TextBox textBox5;
        private TextBox textBox4;
    }
}