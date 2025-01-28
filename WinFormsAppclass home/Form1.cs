namespace WinFormsAppclass_home
{
    public partial class Form1 : Form
    {
        
        private Todo MyTodo;

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

            
            MyTodo = new Todo(textBoxTask.Text, date, false);

            MessageBox.Show("Success");

           
            listView1.Items.Add(MyTodo.ToString());
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            textBoxTask.Clear();
            textBoxDueDate.Clear(); 
            MessageBox.Show("Form cleared");

            
            if (MyTodo != null)
            {
                listView1.Items.Add(MyTodo.ToString());
            }

            ClearForm();
        }

        private void ClearForm()
        {
            textBoxTask.Clear();
            textBoxDueDate.Clear();
        }
    }
}
