namespace Query
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            string[] template = { "a", "b", "c" };
            string[] args = { "a", "b", "c" };
            MessageBox.Show(Database.Insert("person", template));
        }
    }
}