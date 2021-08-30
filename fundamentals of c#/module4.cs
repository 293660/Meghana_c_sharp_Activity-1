 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_Sharp_Activity
{
    class Program
    {
        static void Main(string[] args)
        {
 roll1 = dice.Next(1, 7);
            roll2 = dice.Next(1, 7);
            roll3 = dice.Next(1, 7);
            total = roll1 + roll2 + roll3;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if (total > 14)
            {
                Console.WriteLine("You win!");
            }
            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
            String message1 = "The quick brown fox jumps over the lazy dog.";
            bool result = message1.Contains("dog");
            Console.WriteLine(result);
            if (message1.Contains("fox"))
            {
                Console.WriteLine("What does the fox say?");
            }
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles! +2 bonus to total!");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples! +6 bonus to total!");
                total += 6;
            }
            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            if (total < 15)
            {
                Console.WriteLine("Sorry, you lose.");
            }
            roll1 = 6;
            roll2 = 6;
            roll3 = 5;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }
            roll1 = 6;
            roll2 = 6;
            roll3 = 6;
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");
            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                total += 2;
            }
            if ((roll1 == roll2) && (roll2 == roll3))
            {
                Console.WriteLine("You rolled triples!  +6 bonus to total!");
                total += 6;
            }
            if (total >= 15)
            {
                Console.WriteLine("You win!");
            }
            else
            {
                Console.WriteLine("Sorry, you lose.");
            }
            Console.WriteLine($"Dice roll: {roll1} + {roll2} + {roll3} = {total}");

            if ((roll1 == roll2) || (roll2 == roll3) || (roll1 == roll3))
            {
                if ((roll1 == roll2) && (roll2 == roll3))
                {
                    Console.WriteLine("You rolled triples!  +6 bonus to total!");
                    total += 6;
                }
                else
                {
                    Console.WriteLine("You rolled doubles!  +2 bonus to total!");
                    total += 2;
                }
            }

            if (total >= 16)
            {
                Console.WriteLine("You win a new car!");
            }
            else if (total >= 10)
            {
                Console.WriteLine("You win a new laptop!");
            }
            else if (total == 7)
            {
                Console.WriteLine("You win a trip for two!");
            }
            else
            {
                Console.WriteLine("You win a kitten!");
            }
            int daysUntilExpiration = random.Next(12);
            int discountPercentage = 0;

            if (daysUntilExpiration == 0)
            {
                Console.WriteLine("Your subscription has expired.");
            }
            else if (daysUntilExpiration == 1)
            {
                Console.WriteLine("Your subscription expires within a day!");
                discountPercentage = 20;
            }
            else if (daysUntilExpiration <= 5)
            {
                Console.WriteLine($"Your subscription expires in {daysUntilExpiration} days.");
                discountPercentage = 10;
            }
            else if (daysUntilExpiration <= 10)
            {
                Console.WriteLine("Your subscription will expire soon.  Renew now!");
            }
            if (discountPercentage > 0)
            {
                Console.WriteLine($"Renew now and save {discountPercentage}%.");
            }
