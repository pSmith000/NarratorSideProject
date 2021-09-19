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
