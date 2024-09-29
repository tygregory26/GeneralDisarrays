namespace FeatureInterface
{
    public partial class mainWindow : Form
    {
        public mainWindow()
        {
            InitializeComponent();
        }

        private void movingBox_MouseEnter(object sender, EventArgs e)
        { 
            Random random = new Random();
            int x = random.Next(10000);
            int y = random.Next(10000);
            movingBox.Location = new Point(x, y);
        }
    }
}
