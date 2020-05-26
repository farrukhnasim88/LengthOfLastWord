using System;

namespace LengthOfLastWord
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Console.Write("Please Write sentence to see length of last word \n");
            input= Console.ReadLine();
             
            int a = LengthOfLastWord(input);
            Console.WriteLine("The length of last word is:  " + a);

            static int LengthOfLastWord(string findLength)
            {

                string[] charWords = findLength.Split(' ');
                string lastWord = charWords[charWords.Length - 1];

                if ( lastWord != "")
                {
                    
                    return lastWord.Length;
                }
                else
                    return 0;
            }






        }
    }
}
