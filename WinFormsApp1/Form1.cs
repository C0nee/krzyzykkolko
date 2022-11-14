namespace WinFormsApp1
{
    enum Zawodnik
        {
            Cross,
            Circle
        }
    public partial class Form1 : Form
    {
        Zawodnik ZK;
        public Form1()
        {
            InitializeComponent();
            ZK = Zawodnik.Cross;
            changeLabel();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Mark(object sender, EventArgs e)
        {
            Button senderButton = (Button)sender;
            if (ZK == Zawodnik.Cross)
            {
                senderButton.Text = "X";
                ZK = Zawodnik.Circle;
            }
            else
            {
                senderButton.Text = "O";
                ZK = Zawodnik.Cross;
            }
            changeLabel();
            senderButton.Enabled = false;
            checkForWinner();

        }
        public void changeLabel()
        {
            if (ZK == Zawodnik.Cross)
            {
                zawodnikLabel.Text = "Krzyzyk";

            }
            else
            {
                zawodnikLabel.Text = "Kolko";
            }
        }
        public void checkForWinner()
        {
                if(String.Compare(tl.Text, cl.Text) == 0 && String.Compare(cl.Text, bl.Text) == 0)
            {
                Form2 victoryScreen = new Form2(this);
                victoryScreen.winner = tl.Text;
                victoryScreen.Show();
            }
        }
        public void clearBoard()
        {
            TableLayoutControlCollection buttons = tableLayoutPanel1.Controls;
             for (int i = 0; i < buttons.Count; i++)
            {
                if (buttons[i] is Button)
                {
                    buttons[i].Text = "";
                    buttons[i].Enabled = true;
                }
            }
        }
    }
}