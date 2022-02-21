namespace PasswordGenerator
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

        private void GenerateButton_Click(object sender, EventArgs e)
        {
            var parts = 7;
            var partlen = 7;
            var numberOfNonAlphanumericCharacters = 2;

            var password = string.Empty;

            for (int i = 0; i < parts; i++)
            {
                var passwordPart = Password.Generate(partlen, numberOfNonAlphanumericCharacters);
                password += passwordPart + "-";
            }

            PasswordTextBox.Text = password;
        }
    }
}
