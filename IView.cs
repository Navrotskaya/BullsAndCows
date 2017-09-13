using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BullsAndCows
{
    interface IView
    {
        string GetLenghtWord();
        string GetWord();
        void SetGame(int lenghtCodeWord);
        void SetBullsAndCows(int bulls, int cows);
        void SetCodeWord(string codeWord);
        event EventHandler GenerateCodeWord;
        event EventHandler CallBullsAndCows;
        event EventHandler ShowCodeWord;
    }
}
