using System;
using System.Collections.Generic;

namespace LletresRepetides_FASE4_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            var nameList = new List<char>(); // create the list for the name

            Console.WriteLine("Write your name and press ENTER, please?");
            var sName = Console.ReadLine().ToUpper(); // read and asign
            int iLength = sName.Length;

            var surnameList = new List<char>(); // create the list for the surname

            Console.WriteLine("Write your surname and press ENTER, please?");
            var sSurname = Console.ReadLine().ToUpper(); // read and asign
            int iLength2 = sSurname.Length;

            try
            {

                // bucle for convert the string in a char and insert the chars in the Name list
                for (int i = 0; i < iLength; i++)
                {
                    var Vord = sName.Substring(i, 1);
                    nameList.Add(Char.Parse(Vord));

                }

                for (int i = 0; i < iLength2; i++)
                {
                    var Vord = sSurname.Substring(i, 1);
                    surnameList.Add(Char.Parse(Vord));

                }

                nameList.Add(' '); // add a white space in the name list

                nameList.AddRange(surnameList); // joint the two list

                // start the bucle
                for (int i = 0; i < nameList.Count; i++)
                {
                    var charLetter = char.ToUpper(nameList[i]); // convert to Upper all
                    Console.WriteLine(charLetter);

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
