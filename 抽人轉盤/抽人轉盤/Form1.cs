namespace 抽人轉盤
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> options = new List<string> { "A", "B", "C", "D", "E" };
            Random rand = new Random();
            int index = rand.Next(options.Count);
            Result.Text = "抽籤結果: " + options[index];
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show(); // 這將使 Form2 在屏幕中央顯示
        }
    }
}
