using System;
using System.Reflection;
using System.Windows.Forms;

namespace personsList
{
    public partial class Form1 : Form
    {
        private List<Person> personsList = new List<Person>();
        public Form1()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBox3.Text) && !string.IsNullOrWhiteSpace(textBox2.Text) &&
                !string.IsNullOrWhiteSpace(textBox1.Text) && !listBox1.Items.Contains(textBox1.Text) &&
                !listBox1.Items.Contains(textBox2.Text) && (Gender.SelectedItem != null))
            {

                Person p1 = new Person(textBox1.Text, textBox2.Text, Gender.SelectedItem.ToString(), Convert.ToInt32(textBox3.Text), monthCalendar1.SelectionStart); personsList.Add(p1);
                listBox1.Items.Add(p1);
                textBox1.Clear(); textBox2.Clear(); textBox3.Clear();
                Gender.SelectedIndex = -1;
                monthCalendar1.SetDate(DateTime.Now);
            }
            else
            {
                MessageBox.Show("All of the fields must be filled!");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (listBox1.SelectedIndex != -1)
            {
                int selectedIndex = listBox1.SelectedIndex;
                listBox1.Items.RemoveAt(selectedIndex);
                personsList.RemoveAt(selectedIndex);
            }
            else
            {
                MessageBox.Show("Element was not selected!");
            }
        }




        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }

        private void monthCalendar1_DateChanged_1(object sender, DateRangeEventArgs e)
        {
            //MessageBox.Show("DateChanged: " + monthCalendar1.SelectionRange.ToString());
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void ProductsList_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            panel1.Hide(); EditButton_Click(sender, e);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            if (index != -1 )
            {
                if (!textBox5.Enabled)
                {
                    textBox4_SetText();
                    textBox5_SetText();
                    textBox6_SetText();
                    genderComboBox_Set();
                    monthCalendar2_Set();
                }
            }
            else
            {
                textBox4.Clear(); textBox5.Clear(); textBox6.Clear();
                comboBoxGender.SelectedIndex = -1;
                monthCalendar2.SetDate(DateTime.Now);
            }
        }

        private void monthCalendar2_Set()
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                monthCalendar2.SetDate(personsList[index].Birthday);
            }
        }
        private void genderComboBox_Set()
        {
            int index = listBox1.SelectedIndex;
            if (index != -1)
            {
                switch (personsList[index].Gender)
                {
                    case "Male":
                        comboBoxGender.SelectedIndex = 0;
                        break;
                    case "Female":
                        comboBoxGender.SelectedIndex = 1;
                        break;
                    case "Other.":
                        comboBoxGender.SelectedIndex = 2;
                        break;
                }
            }
        }
        private void ShowInfoButton_Click(object sender, EventArgs e)
        {
            if (textBox5.Enabled)
            {
                EditButton_Click(sender, e);
            }
            if (listBox1.SelectedIndex != -1)
            {
                panel1.Show();
            }
            else
            {
                MessageBox.Show("Choose item to see infotmation!");
            }
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox4_SetText()
        {

            int ind = listBox1.SelectedIndex;
            if (ind != -1)
            {

                textBox4.Text = personsList[ind].Name;
                textBox4.ForeColor = Color.Gray;

            }
            textBox4.ForeColor = Color.Black;

        }

        private void textBox5_SetText()
        {

            int ind = listBox1.SelectedIndex;
            if (ind != -1)
            {
                textBox5.Text = personsList[ind].Surname;
                textBox5.ForeColor = Color.Gray;
            }
            textBox5.ForeColor = Color.Black;
        }

        private void textBox6_SetText()
        {

            int ind = listBox1.SelectedIndex;
            if (ind != -1)
            {
                textBox6.Text = personsList[ind].Age.ToString();
                textBox6.ForeColor = Color.Gray;

            }
            textBox6.ForeColor = Color.Black;
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            panel1.Hide(); EditButton_Click(sender, e);

        }

        private void comboBoxGender_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void EditButton_Click(object sender, EventArgs e)
        {
            textBox4.Enabled = !textBox4.Enabled;
            textBox5.Enabled = !textBox5.Enabled;
            textBox6.Enabled = !textBox6.Enabled;
            comboBoxGender.Enabled = !comboBoxGender.Enabled;
            monthCalendar2.Enabled = !monthCalendar2.Enabled;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            int selectedIndex = listBox1.SelectedIndex;

            if (selectedIndex >= 0 && selectedIndex < listBox1.Items.Count)
            {
                listBox1.Items.RemoveAt(selectedIndex);
                personsList.RemoveAt(selectedIndex);
                Person p2 = new Person(textBox4.Text, textBox5.Text, comboBoxGender.SelectedItem.ToString(), Convert.ToInt32(textBox6.Text), monthCalendar2.SelectionStart);
                personsList.Insert(selectedIndex, p2);
                listBox1.Items.Insert(selectedIndex, p2);
            }
            else
            {
                MessageBox.Show("No item selected or invalid selection.");
            }
            panel1.Hide();
            EditButton_Click(sender, e);
        }
    }
}