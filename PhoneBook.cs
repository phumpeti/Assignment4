using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment4C
{
    class PhoneBook
    {

        private string[] names;
        private string[] phones;
        private string[,] phoneList;

        public PhoneBook()
        {
            names = new string[] { "Maynard James Keenan", "Peter Steele", "Chris Cornell", "Henric Wiktor", "Saul Hudson" };
            phones = new string[] { "111-1234", "222-2341", "333-3412", "555-4123", "444-1234" };

            DisplayList();
            SortByName(); ;

            phoneList = new string[5, 2];
            FillTable();
            DisplayTable();
        }
        public void DisplayList()
        {
            Console.WriteLine("Phone Book:");
            for (int i = 0; i < names.Length; i++)
            {
                Console.WriteLine($"{names[i]} - {phones[i]}");
            }
            Console.WriteLine();
        }
        public void SortByName()
        {
            for (int i = 0; i < names.Length - 1; i++)
            {
                for (int j = 0; j < names.Length - 1 - i; j++)
                {
                    if (string.Compare(names[j], names[j + 1]) > 0)
                    {
                        Swap(ref names[j], ref names[j + 1]);
                        Swap(ref phones[j], ref phones[j + 1]);
                    }
                }
            }
        }
        private void Swap(ref string a, ref string b)
        {
            string temp = a;
            a = b;
            b = temp;
        }
        public void FillTable()
        {
            for (int row = 0; row < names.Length; row++)
            {
                phoneList[row, 0] = names[row];
                phoneList[row, 1] = phones[row];
            }
        }
        public void DisplayTable()
        {
            Console.WriteLine("Phone Book Table:");
            for (int row = 0; row < names.Length; row++)
            {
                Console.WriteLine($"{phoneList[row, 0]} - {phoneList[row, 1]}");
            }
            Console.WriteLine();
        }


    }
}