namespace WinFormsAppclass_home
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            var date = DateTime.Parse(textBoxDueDate.Text);

            // Where we handle the add event.
            todo MyTodo = new Todo(textBoxTask.Text, date);

            MessageBox.Show("Succes");

        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
        
            textBoxTask.Clear();
            textBoxDueDate.Show();
            MessageBox.Show("Form cleared");


            listView1.Items.Add(MyTodo.toString());

            ClearForm();
        }

        private void ClearForm()

        { 
            textBoxTask.Clear();
            textBoxDueDate.Clear();
        }
    }
}
