using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reverse_Roman
{
    class Program
    {
        static void Main(string[] args)


        {
            while (true)
            {
                Console.WriteLine("Enter your number to be converted from Roman");
                string userinput = Console.ReadLine();

                char[] RomanCharacters = userinput.ToCharArray();                           //converts string into a CHAR array - an array of each individual component of the string
                int upperbound = Convert.ToInt32(RomanCharacters.GetUpperBound(0));         //determines the size of array of the roman numeral. e.g. XIX = 2 (0,1,2 positions in the array)
                int sum = 0;

                for (int i = upperbound; i >= 0; i--)                                       //the loop runs "backwards" - checking the character at the end of the array and working towards the first.
                                                                                            
                {                                                                           
                    string currentroman = Convert.ToString(RomanCharacters[i]);
                    currentroman = currentroman.ToLower();
                    string futureroman = "";

                    if (i != 0)                                                             //creates a variable that is the "next" number in the roman numeral, unless it is at the last position in the array.
                    {
                        futureroman = Convert.ToString(RomanCharacters[(i - 1)]);
                    }

                    if (i == 0)                                                             //makes sure that futureroman never tries to set itself to a number outside of the array when i=0, i-1 would be negative. outside of the array.
                    {
                        futureroman = Convert.ToString(RomanCharacters[0]);
                    }

                    if (currentroman == "i")
                    {
                        sum = sum + 1;
                    }

                    if (currentroman == "v" && futureroman == "i")                  //think like a computer, not a person. We read IV as "one less than five" but for our purposes, we can treat V's in this
                                                                                    //scenario as "3". So IV = 1 + 3 = 4. This way we only ever use addition.
                    {
                        sum = sum + 3;
                    }

                    if (currentroman == "v" && futureroman != "i")                  //V is 5 in every scenario but there being an I in front of it.
                    {
                        sum = sum + 5;
                    }

                    if (currentroman == "x" && futureroman == "i")                  //the same logic drives the 9 scenario. ix = 1+8=9.  So an so forth.
                    {
                        sum = sum + 8;
                    }

                    if (currentroman == "x" && futureroman != "i")  
                    {
                        sum = sum + 10;
                    }

                    if (currentroman == "l" && futureroman == "x")
                    {
                        sum = sum + 30;
                    }

                    if (currentroman == "l" && futureroman != "x")
                    {
                        sum = sum + 50;
                    }

                    if (currentroman == "c" && futureroman == "x")
                    {
                        sum = sum + 80;
                    }

                    if (currentroman == "c" && futureroman != "x")
                    {
                        sum = sum + 100;
                    }
                }

                Console.WriteLine(userinput.ToUpper() + " expressed as a normal number is " + sum);

                Console.ReadLine();



            }





        }
    }
}
