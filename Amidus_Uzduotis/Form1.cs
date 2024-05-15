using Amidus_Uzduotis.Manager;

namespace Amidus_Uzduotis
{
    public partial class Form1 : Form
    {
        private readonly LanguagesManager languagesManager = new();

        private readonly List<String> languagesName = ["C", "Java", "C#", "Python", "Go", "Swift"];
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            try
            {
                PopulateLanguagesComboBox();
                LoadData();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            string selectedLanguage = languagesComboBox.Text;
            string score = scoreTextBox.Text;

            if (string.IsNullOrEmpty(selectedLanguage) | string.IsNullOrEmpty(score))
            {
                MessageBox.Show("Select language and type your score!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(score) > 100)
            {
                MessageBox.Show("Maximum score can be 100!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (int.Parse(score) < 0)
            {
                MessageBox.Show("Minimum score can be 0!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                languagesManager.SaveNewScore(selectedLanguage, int.Parse(score));
                Reset();
            }
        }

        private void PopulateLanguagesComboBox()
        {
            languagesComboBox.DataSource = languagesName;
        }

        private void LoadData()
        {
            var languages = languagesManager.GetAllLanguages();
            languagesDataGridView.Rows.Clear();
            foreach (var language in languages)
            {
                languagesDataGridView.Rows.Add(
                    language.Id, language.Name, language.MinScore,
                    language.MaxScore, language.AverageScore, language.NumberOfVotes
                );
            }
        }

        private void Reset()
        {
            languagesComboBox.Text = string.Empty;
            scoreTextBox.Text = string.Empty;
            LoadData();
        }
    }
}
