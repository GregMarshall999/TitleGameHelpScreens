namespace TitleGameHelpScreens
{
    public partial class TitleScreen : Form
    {
        GameScreen gameScreen = new GameScreen();
        HelpScreen helpScreen = new HelpScreen();

        public TitleScreen()
        {
            InitializeComponent();
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            gameScreen.Show();
        }

        private void helpBtn_Click(object sender, EventArgs e)
        {
            helpScreen.Show();
        }
    }
}