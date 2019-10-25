using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;

namespace LletresRepetides_FASE2_CONSOLA
{
    class Program
    {
        static void Main(string[] args)
        {

            var nameList = new List<char>(); // create the list

            Console.WriteLine("Write your name, please?");
            var sName = Console.ReadLine().ToUpper(); // read and asign
            sName.Trim(); // remove white spaces
            int iLength = sName.Length;

            try
            {

                // bucle for convert the string in a char and insert the chars in the list
                for (int i = 0; i < iLength; i++)
                {
                    var Vord = sName.Substring(i, 1);
                    nameList.Add(Char.Parse(Vord));

                }

                // start the bucle 
                for (int i = 0; i < nameList.Count; i++)
                {
                    if (char.IsLetter(nameList[i])) // if is letter
                    {
                        var charLetter = char.ToUpper(nameList[i]); // convert to Upper all

                        switch (charLetter)
                        {
                            // case is vocal
                            case 'A':
                            case 'E':
                            case 'I':
                            case 'O':
                            case 'U':
                                Console.WriteLine(charLetter + " es ..... VOCAL");
                                break;
                            // case is consonant
                            default:
                                Console.WriteLine(charLetter + " es ..... CONSONANTE");
                                break;
                        }
                    }

                    else // if is a number 
                    {
                        Console.WriteLine(nameList[i] + " es ... Els noms de persones no contenen números!");

                    }

                }

                Console.ReadLine();
                
            }
            catch (Exception ex)
            {

                Console.WriteLine("Ha ocurrido el siguiente error: " + ex);
            }

            
        }
    }
}
