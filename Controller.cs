using System;
using System.Linq;

namespace BullsAndCows
{
    internal class Controller
    {
        private IView _view;
        private Model _model;

        public Controller(IView view, Model model)
        {
            _view = view;
            _model = model;
            _view.GenerateCodeWord += OnGenerateCodeWord;
            _view.CallBullsAndCows += OnCallBullsAndCows;
            _view.ShowCodeWord += OnShowCodeWord;
        }

        private void OnGenerateCodeWord(object sender, EventArgs e)
        {
            int lenght = Int32.TryParse(_view.GetLenghtWord(), out lenght) ? lenght : 0;
            if (_model.GenerateCode(lenght) != 0)
            {
                _view.SetGame(lenght);
            }
            else _view.SetGame(0);
        }

        private void OnShowCodeWord(object sender, EventArgs e)
        {
            var str=_model.GetCodeWord();
            _view.SetCodeWord(str);
        }

        private void OnCallBullsAndCows(object sender, EventArgs e)
        {
            //Считаем быков и коров выдаем строку-ответ
            int cows = 9;
            var bulls = 0;
            bulls = _model.SearchBullsAndCows(_view.GetWord(), out cows);
            _view.SetBullsAndCows(bulls, cows);
        }
      
    }
}