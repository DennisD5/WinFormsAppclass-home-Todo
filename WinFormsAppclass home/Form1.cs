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
            Todo MyTodo = new Todo(textBoxTask.Text, date);

            MessageBox.Show("Succes");

        }
    }
}
