using WinFormsProject;

namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            resultLabel.Text = "Odota.";

            string originPath = originPathTextBox.Text;
            string resultFileName = resultPathTextBox.Text;
            string textToFind = textToSearchTextBox.Text;

            if (originPath == "" || resultFileName == "" || textToFind == "")
            {
                resultLabel.Text = "Puuttuva teksti.";
                return;
            }

            if (!Directory.Exists(originPath))
            {
                resultLabel.Text = $"Kansio {originPath} ei löytynyt.";
                return;
            }

            resultLabel.Text = LogicHelper.CreatePdfFromMatchingPages(resultFileName, originPath, textToFind);
        }
    }
}