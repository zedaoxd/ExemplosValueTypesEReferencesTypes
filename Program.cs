using System;

namespace ExemplosValueTypesEReferencesTypes
{
    class Item
    {
        public int Price;
        public string Name;
    }

    class Program
    {
        static void Main(string[] args)
        {
            /*
            // int, float, double, bool, char... Value Type
            int x = 10;
            Console.WriteLine(x);
            SumTwo(x);
            Console.WriteLine(x);
            Console.ReadKey();
            
            // Reference Type
            Item item = new Item() 
            {
                Price = 100,
                Name = "MyItem"
            };

            Console.WriteLine($"Item: {item.Name} - {item.Price}");
            ChangeItem(item);
            Console.WriteLine($"Item: {item.Name} - {item.Price}");
            

            // array são tipos refencia, mas o conteudo deles não
            int[] numbers = new int[3]
            {
                2, -11, 45
            };

            SumTwo(numbers[1]);
            Console.WriteLine(numbers[1]);

            Console.WriteLine("-----------------------");

            SumTwo(numbers, 1);
            Console.WriteLine(numbers[1]);
            */

            // strings são tipo referencia mas se comportam como um tipo valor
            string myText = "MyText";
            Console.WriteLine(myText);
            ChangedString(myText);
            Console.WriteLine(myText);

            Console.ReadKey();
        }

        static void ChangedString(String text)
        {
            text = "CHANGED TEXT";
            //text[0] = 'N'; strings são imutavéis esta linha da erro
            // char firstChar = text[0]; esta linha funciona, posso somente ler dados em string
        }

        /*
        static void SumTwo(int number)
        {
            number += 2;
        }

        static void SumTwo(int[] numbers, int index)
        {
            numbers[index] += 2;
        }

        
        static void ChangeItem(Item item)
        {
            item.Price = 2;
            item.Name = "CHANGED";
        }
        */
    }
}
