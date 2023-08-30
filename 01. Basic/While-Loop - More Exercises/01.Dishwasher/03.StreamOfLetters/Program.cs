using System;

namespace _03.StreamOfLetters
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string output = "";
            string finalOutput = "";

            bool cIsHere = false;
            bool oIsHere = false;
            bool nIsHere = false;
            

            while (input != "End")
            {
                char currentLetter = char.Parse(input);


                if (currentLetter >= 'A' && currentLetter <= 'Z' || currentLetter >= 'a' && currentLetter <= 'z')
                {
                    if (currentLetter == 'c')
                    {
                        if (cIsHere)
                        {
                            finalOutput += currentLetter;
                        }
                        else
                        {
                            cIsHere = true;
                        }
                    }
                    
                    if (currentLetter == 'o')
                    {
                        if (oIsHere)
                        {
                            finalOutput += currentLetter;
                        }
                        else
                        {
                            oIsHere = true;
                        }
                    }

                    if(currentLetter == 'n')
                    {
                        if (nIsHere)
                        {
                            finalOutput += currentLetter;
                        }
                        else
                        {
                            nIsHere = true;
                        }
                    }

                    if (currentLetter != 'o' && currentLetter != 'n' && currentLetter != 'c')
                    {
                        finalOutput += currentLetter;
                    }

                    if (cIsHere && oIsHere && nIsHere)
                    {
                        cIsHere = false;
                        oIsHere = false;
                        nIsHere = false;
                        output += finalOutput;
                        output += " ";
                        finalOutput = "";
                    }

                }


                input = Console.ReadLine();
            }

            Console.WriteLine(output);
        }
    }
}
