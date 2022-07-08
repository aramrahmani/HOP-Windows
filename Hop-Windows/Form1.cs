using System;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Hop_Windows
{
    public partial class Form1 : Form
    {
        private GameStarter starter;
        private Thread thrGamer;
        private int GameRepeateCount { get; set; }
        public Form1()
        {
            CheckForIllegalCrossThreadCalls = false;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btnStartGame.Visible = false;
        }


        private void btnShowPlayers_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtPlayerNumber.Text))
            {
                MessageBox.Show("تعداد بازيكن را وارد كنيد");
                return;
            }
            if (string.IsNullOrEmpty(txtRepeateCount.Text))
            {
                MessageBox.Show("تعداد دور بازی را وارد كنيد");
                return;
            }
            if (Convert.ToInt32(txtPlayerNumber.Text)>24)
            {
                MessageBox.Show("تعداد بازيكن حداکثر 24 می باشد");
                return;
            }

            var playerNumber = Convert.ToInt32(txtPlayerNumber.Text);
            GameRepeateCount = Convert.ToInt32(txtRepeateCount.Text);
            bool isRandomGameNumber = chIsRandomGameN.Checked;
            starter = GameStarter.GetInstance();
            starter.InitialStarter(playerNumber, GameRepeateCount, isRandomGameNumber, this);

            btnShowPlayers.Enabled = false;
            btnStartGame.Visible = true;
            btnStopGame.Visible = true;
            lblRefereeNumber.Text = starter.RefereeNumber.ToString();
            int gameRoundlbl = starter.GameRound - starter.GameRound + 1;
            lblRound.Text= gameRoundlbl.ToString();
        }

        private void btnStartGame_Click(object sender, EventArgs e)
        {
            thrGamer = new Thread(starter.Start);
            thrGamer.Start();
            btnStartGame.Enabled = false;
            //btnStartGame.Visible = !btnStartGame.Visible;
            //btnStopGame.Visible = !btnStopGame.Visible;
        }

        private void btnStopGame_Click(object sender, EventArgs e)
        {
            if (thrGamer!=null)
                thrGamer.Abort();

            starter.ResetGame();
            btnStartGame.Visible = !btnStartGame.Visible;
            btnStopGame.Visible = !btnStopGame.Visible;
            lblRefereeNumber.Text = "";
            lblRound.Text = "";
            txtPlayerNumber.Text = "";
            txtRepeateCount.Text = "";
            chIsRandomGameN.Checked = false;
            txtPlayerNumber.Focus();
            btnShowPlayers.Enabled = true;
            btnStartGame.Enabled = true;
        }
    }
}
