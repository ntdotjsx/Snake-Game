namespace Snake
{
    public partial class Form1 : Form
    {
        private List<Berry> Snake = new List<Berry>();
        private Berry food = new Berry();
        public Form1()
        {
            InitializeComponent();
        }
    }
}