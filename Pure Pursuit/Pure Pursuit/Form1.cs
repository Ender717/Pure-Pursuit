namespace Pure_Pursuit
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            int size = Math.Min(this.Width - 90, this.Height - 120);
            FieldPanel.Size = new Size(size, size);
            FieldPanel.Location = new Point(this.Width - size - 45, 30);
        }
    }
}