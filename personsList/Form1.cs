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

                Person p1 = new Person(textBox1.Text, textBox2.Text, Gender.SelectedItem.ToString(), Convert.ToInt32(textBox3.Text));
                personsList.Add(p1);
                listBox1.Items.Add(p1);
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

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
        }
    }
}