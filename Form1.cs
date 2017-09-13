using System;
using System.Windows.Forms;

namespace BullsAndCows
{
    public partial class Form1 : Form, IView
    {
        // false - положение вне игры,  true - положение в игре
        private bool _inGame;

        public Form1()
        {
            _inGame = false;
            InitializeComponent();
            MaskedWord.LostFocus += (s, a) => CheckLenghtWord();
        }

        public string GetLenghtWord()
        {
            return Lenght.Text;
        }

        public string GetWord()
        {
            return MaskedWord.Text;
        }

        public void SetGame(int lenghtCodeWord)
        {
            if (lenghtCodeWord > 0)
            {
                MaskedWordMask(lenghtCodeWord);
                Message.Text = "Ваш вариант!";
                InGame();
            }
            else
            {
                Message.Text = "Неверная длина слова!";
                OutGame();
            }
        }

        public void SetBullsAndCows(int bulls, int cows)
        {
            if (bulls != MaskedWord.Text.Length)
            {
                Progress.Text = MaskedWord.Text + "   " + string.Format("{0} {1}, {2} {3}", bulls, SpellingBull(bulls), cows, SpellingCow(cows)) + ";\n" + Progress.Text;
                MaskedWord.Text = null;
                MaskedWord.Focus();
            }
            else
            {
                Message.Text = "Ура!    " + MaskedWord.Text + " - верный ответ!";
                OutGame();
            }
        }

        public void SetCodeWord(string codeWord)
        {
            Message.Text = codeWord;
            OutGame();
        }

        public event EventHandler GenerateCodeWord;
        public event EventHandler CallBullsAndCows;
        public event EventHandler ShowCodeWord;


        private void Start_Click(object sender, EventArgs e)
        {
            //Если находимся "вне игры", то генерируем код, иначе показываем загаданое слова
            if (!_inGame)
            {
                if (GenerateCodeWord != null)
                {
                    GenerateCodeWord(this, e);
                }

            }
            else
            {
                if (ShowCodeWord != null)
                {
                    ShowCodeWord(this, e);
                }
            }
        }

        private void Check_Click(object sender, EventArgs e)
        {
            if (CheckLenghtWord())
            {
                if (CallBullsAndCows != null)
                {
                    CallBullsAndCows(this, e);
                }
            }
        }

        private void MaskedWordKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab)) 
            {
                CheckLenghtWord();
            }
        }

        private void LenghtKeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == Keys.Enter) || (e.KeyCode == Keys.Tab))
            {
                CheckLenght();
            }
        }

        private void MaskedWordMask(int lenghtWord)
        {
            var str = "0";
            for (var i = 1; i < lenghtWord; i++)
            {
                str += "0";
            }
            MaskedWord.Mask = str;
        }

        public void InGame()
        {
            _inGame = true;
            Start.Text = "Сдаюсь";

            Lenght.Enabled = false;
            MaskedWord.Enabled = true;
            Check.Enabled = true;
            Progress.Enabled = true;
            Progress.Text = null;

            MaskedWord.Focus();
        }

        public void OutGame()
        {
            _inGame = false;
            Start.Text = "Начать игру!";

            Lenght.Text = null;
            MaskedWord.Text = null;
            Lenght.Enabled = true;
            MaskedWord.Enabled = false;
            Check.Enabled = false;
            Progress.Enabled = false;

            Lenght.Focus();
        }
        private static string SpellingBull(int b)
        {
            if ((b > 1) && (b < 5)) return "быка";
            if (b != 1) return "быков";
            else return "бык";
        }

        private static string SpellingCow(int b)
        {
            if ((b > 1) && (b < 5)) return "коровы";
            if (b != 1) return "коров";
            else return "корова";
        }

        private bool CheckLenghtWord()
        {
            int lenght = Int32.TryParse(Lenght.Text, out lenght) ? lenght : 0;
            if (MaskedWord.Text.Length != lenght)
            {
                Message.Text = "Неверная длина слова!";
                MaskedWord.Focus();
                return false;
            }
            else
            {
                Check.Focus();
                return true;
            }
        }

        private bool CheckLenght()
        {
            if ((Lenght.Text == null) || (Lenght.Text == "0"))
            {
                Message.Text = "Длина слова должна быть больше 0!";
                Lenght.Focus();
                return false;
            }
            else
            {
                Start.Focus();
                return true;
            }
        }
        
    }
}
