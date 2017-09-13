using System;

namespace BullsAndCows
{
    /// <summary>
    /// Модель игры быки и коровы.
    /// "слово" - строка из попарно различных цифр, длина не превышает 9 символов.
    /// </summary>
    class Model
    {
        private string _codeWord;
        private int _lenghtCodeWord;

        public Model()
        {
            _codeWord = null;
            _lenghtCodeWord = 0;
        }

        /// <summary>
        /// Возвращает загаданное "слово".
        /// </summary>
        /// <returns></returns>
        public string GetCodeWord()
        {
            return _codeWord;
        }

        /// <summary>
        /// Генерирует "слово" заданной длины случайным образом. Возвращает 0, если неверно задана длина слова, иначе длину "слова". 
        /// </summary>
        /// <param name="l">длина "слова"</param>
        /// <returns></returns>
        public int GenerateCode(int l)
        {
            if ((l > 0) && (l < 10))
            {
                _codeWord = RandomCodeWord(l);
                _lenghtCodeWord = l;
                return l;
            }
            else return 0;
        }

        /// <summary>
        /// Сравнивает загаданное слово - _codeWord с word, возвращает количество быков и передает количество коров.
        /// </summary>
        /// <param name="word">"слово" для сравнения</param>
        /// <param name="c">количество коров</param>
        /// <returns></returns>
        public int SearchBullsAndCows(string word, out int c)
        {
            var bulls = 0;
            var cows = 0;
            var l = _codeWord.Length;
            c = 0;
            if (l == word.Length)
            {
                for (var i = 0; i < l; i++)
                {
                    for (var j = 0; j < l; j++)
                    {
                        if (word[j] == _codeWord[i])
                            if (i != j) cows++;
                            else bulls++;
                    }
                }
                c = cows;
                return bulls;
            }
            return -1;
        }

        private static string RandomCodeWord(int l)
        {
            var rnd = new Random();
            string cw = null;
            if ((l > 0) && (l < 10))
            {
                var r = rnd.Next(0, 10).ToString();
                cw = r;
                for (var i = 0; i < l - 1; i++)
                {
                    var flag = false;

                    r = rnd.Next(0, 10).ToString();
                    for (var j = 0; j < cw.Length; j++)
                    {
                        if (cw[j].ToString() == r)
                        {
                            flag = true;
                            break;
                        }
                    }
                    if (flag == false) cw += r;
                    else i--;
                }
            }
            return cw;
        }

        
    }
}
