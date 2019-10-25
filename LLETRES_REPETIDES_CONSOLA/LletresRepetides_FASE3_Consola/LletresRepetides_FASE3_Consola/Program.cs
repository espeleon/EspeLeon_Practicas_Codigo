using System;
using System.Collections.Generic;
using System.Linq;

namespace LletresRepetides_FASE3_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new List<char>(); // create the list
           
            var dictionaryWords = new Dictionary<int, char>(); //create the dictionary

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
                                
                for (int i = 0; i < nameList.Count; i++) // start the bucle 
                {
                    var charLetter = char.ToUpper(nameList[i]); // convert to Upper all

                    dictionaryWords.Add(i, nameList[i]); //add elements to the dictionary

                    if (Char.IsLetter(dictionaryWords[i])) // if is letter
                    {
                        switch (charLetter)
                        {
                            // case is vocal
                            case 'A':
                            case 'E':
                            case 'I':
                            case 'O':
                            case 'U':
                                // get de value of the element by the key (position), get the position
                                Console.WriteLine("Lletra: {0}, Posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                                    dictionaryWords.Keys.ElementAt(i) + " es ..... VOCAL");
                                break;
                            // case is consonant
                            default:

                                Console.WriteLine("Lletra: {0}, Posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                                dictionaryWords.Keys.ElementAt(i) + " es ..... CONSONANTE");
                                break;
                        }
                    }

                    else // if is a number 
                    {
                        Console.WriteLine("{0}, en la posició: {1}", dictionaryWords[dictionaryWords.Keys.ElementAt(i)],
                             dictionaryWords.Keys.ElementAt(i) + " es ... Els noms de persones no contenen números!");

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
