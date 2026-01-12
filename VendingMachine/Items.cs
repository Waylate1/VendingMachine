using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine
{
    public class Items
    {
        int UserChoice = 0;
        public void Run()
        {
            DisplayItems();
            Dispense();

        }
        public void DisplayItems()
        {
            Console.WriteLine("1. Water");
            Console.WriteLine("2. Coca Cola");
            Console.WriteLine("3. Red Bull");
            Console.WriteLine("4. Dr. Pepper");
        }

        public void Dispense()
        {
            UserChoice = GetSelection(UserChoice);
            if (UserChoice == 1)
            {
                Console.WriteLine("Dispensing water");
            } 
            if(UserChoice == 2)
            {
                Console.WriteLine("Dispensing Coca Cola");
            }
            if(UserChoice == 3)
            {
                Console.WriteLine("Dispensing Red Bull");
            }
            if( UserChoice == 4)
            {
                Console.WriteLine("Dispensing Dr. Pepper");
            }
        }

        public int GetSelection(int i)
        {
            int UserChoice = 0;
            Console.WriteLine("Enter a displayed number for the item");
            while (!int.TryParse(Console.ReadLine(), out UserChoice) || !ValidateChoice(UserChoice))
            {
                Console.WriteLine("Please enter a valid choice");
            }
            return UserChoice;
        }

        private bool ValidateChoice(int UserChoice)
        {
            return UserChoice >= 1 && UserChoice <= 4;
        }
    }
}
