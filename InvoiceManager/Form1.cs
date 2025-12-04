namespace InvoiceManager
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void readFileButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist");
                return;
            }

            var content = File.ReadAllText(path);

            content = content.Replace(";", "\t");

            resultTextBox.Text = content;
        }

        private void categoryButton_Click(object sender, EventArgs e)
        {
            var path = pathTextBox.Text;

            if (!File.Exists(path))
            {
                MessageBox.Show("File does not exist");
                return;
            }

            var lines = File.ReadAllLines(path);

            var result = new Dictionary<string, decimal>();

            for (int i = 1; i < lines.Length; i++) 
            {
                var line = lines[i]; //Sushi;95;Food;2025-12-03
                
                var split = line.Split(";"); //["Sushi","95","Food","2025-12-03"]

                var amount = decimal.Parse(split[1]); //95
                var category = split[2]; //"Food"

                if (result.ContainsKey(category))
                    result[category] += amount;
                else
                    result[category] = amount;
            }

            resultTextBox.Text = "Category\tAmount\r\n";
            foreach (var key in result.Keys) 
            {
                resultTextBox.Text += $"{key}\t{result[key]}\r\n";
            }
        }
    }
}
