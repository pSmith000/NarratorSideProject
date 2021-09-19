using System;
using System.Threading;
using System.Collections.Generic;
using System.Text;

namespace NarratorSideProject
{
    class Game
    {
        public void Run()
        {
            TypeOutWords("Uh... Hello there stranger. Nice to meet you", 100);
            
        }

        public void TypeOutWords(string sentence, int timeBetweenLetters)
        {
            char[] chars = sentence.ToCharArray();

            for (int i = 0; i < chars.Length; i++)
            {
                Console.Write(chars[i]);
                Thread.Sleep(timeBetweenLetters);
            }
        }
    }
}
