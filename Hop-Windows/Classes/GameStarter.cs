using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Speech.Synthesis;
using System.Threading;
using System.Windows.Forms;

namespace Hop_Windows
{
    public class GameStarter
    {
        public int RefereeNumber { get; set; }
        public int GameRound { get; set; }
        private bool IsRandomGameNumber { get; set; }


        private int NumberOfPlayer { get; set; }
        private List<Player> _players { get; set; }
        private Form _form;
        private static GameStarter _instance = null;
        private static object _objLock = new object();

        private GameStarter()
        {
        }

        public static GameStarter GetInstance()
        {
            lock (_objLock)
            {
                if (_instance is null)
                    _instance = new GameStarter();
                return _instance;
            }
        }

        public void InitialStarter(int palyerCount, int repeateCount, bool isRandomGameNumber, Form form)
        {
            NumberOfPlayer = palyerCount;
            GameRound = repeateCount;
            IsRandomGameNumber = isRandomGameNumber;
            this._form = form;
            GenerateStartingNumberOfGame();
            GeneratePlayers();
        }

        public void ResetGame()
        {
            NumberOfPlayer = 0;
            RefereeNumber = 0;
            RemovePlayers();
        }
        public void Start()
        {
            ShowPlayerResult();
        }

        private async void ShowPlayerResult()
        {
            int playerIndex = 0;
            while (GameRound > 0)
            {
                for (int i = 0; i < RefereeNumber; i++)
                {
                    int index = playerIndex < NumberOfPlayer ? playerIndex : playerIndex % NumberOfPlayer;
                    int playerTurn = IsRandomGameNumber ? i + 1 : playerIndex + 1;
                    string name = $"Palyer{index + 1}";
                    string answerPlayer = await _players[index].Play(playerTurn, RefereeNumber);
                    PlayAnswer(answerPlayer);
                    UpdateAnswerPlayer(name, answerPlayer);
                    playerIndex++;
                }
                GameRound--;
                if (IsRandomGameNumber && GameRound > 0)
                {
                    GenerateStartingNumberOfGame();
                    UpdateGameNumber();
                }

            }


        }

        private void UpdateGameNumber()
        {
            Control lblGameNumber = _form.Controls.Find("lblRefereeNumber", true).FirstOrDefault();
            lblGameNumber.Text = RefereeNumber.ToString();
            Control lblRound = _form.Controls.Find("lblRound", true).FirstOrDefault();
            int gameRound = Convert.ToInt32(lblRound.Text) + 1;
            lblRound.Text = gameRound.ToString();
            Application.DoEvents();
        }
        private void PlayAnswer(string answerPlayer)
        {
            Thread.Sleep(500);
            var speechSynthesizerObj = new SpeechSynthesizer();
            //Asynchronously speaks the contents present in RichTextBox1   
            speechSynthesizerObj.SpeakAsync(answerPlayer);
        }
        private void UpdateAnswerPlayer(string name, string answer)
        {
            Control ctn = _form.Controls[name];
            ctn.Text = answer;
            ctn.BackColor = Color.Green;
            Thread.Sleep(500);
            Application.DoEvents();
            ctn.BackColor = SystemColors.Control;
        }

        private void GeneratePlayers()
        {
            if (_players == null)
            {
                _players = new List<Player>();
                for (int i = 1; i <= NumberOfPlayer; i++)
                {
                    string name = $"player {i}";
                    var newPlayer = new Player(name);
                    _players.Add(newPlayer);
                }
                ShowPlayers();
            }

        }

        private void RemovePlayers()
        {
            foreach (Control item in _form.Controls.OfType<Control>().ToList())
            {
                if (item.Name.StartsWith("Palyer") || item.Name.StartsWith("lbl"))
                    _form.Controls.Remove(item);
            }
            _players = null;
        }

        private void ShowPlayers()
        {
            int x = 50;
            int height_lbl = 120;
            int height_btn = 140;
            int formWidth = 600;
            for (int i = 1; i <= NumberOfPlayer; i++)
            {
                if (x > formWidth)
                {
                    height_lbl += 80;
                    height_btn += 80;
                    x = 50;
                }
                var lblAdd = new Label
                {
                    Size = new Size(50, 20),
                    Text = "Palyer" + i,
                    Name = "lbl" + i,
                    Location = new Point(x + 5, height_lbl)
                };
                var btnAdd = new Button
                {
                    Size = new Size(80, 40),
                    Name = "Palyer" + i,
                    Location = new Point(x, height_btn)
                };
                x += 100;
                _form.Controls.Add(lblAdd);
                _form.Controls.Add(btnAdd);
            }
        }

        private void GenerateStartingNumberOfGame()
        {
            var referee = Referee.GetInstance();
            RefereeNumber = referee.GenerateStartingNumberOfGame();
        }

    }
}
