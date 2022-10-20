using UsedCarLab;

public class Program
{
    public static void Main()
    {
        {
            bool goOn = true;

            List<Car> inventory = new List<Car>();
            inventory.Add(new Car("Ford", "F-150", 2023, 99));
            inventory.Add(new Car("Chrysler", "300", 2023, 12000));
            inventory.Add(new Car("GMC", "Acadia", 2022, 9000));
            inventory.Add(new UsedCar("Ford", "Focus", 2013, 12000, 12021));
            inventory.Add(new UsedCar("Dodge", "Durango", 2014, 15000, 120083));
            inventory.Add(new UsedCar("Chrysler", "Sebring", 2006, 5000, 142450));

            Console.WriteLine("\nWelcome to our new and used car dealership!\n");

            while (goOn)
            {
                if (inventory.Count == 0)
                {
             
                    Console.WriteLine("Have a nice day!\n");
                    break;
                }

                // "\n" space
                Console.WriteLine("Here is our current list of new and used vehicles:\n");

                int index = 1;

                // for each car inside inventory
                foreach (Car car in inventory)
                {
                    Console.WriteLine(index + ":  " + car);
                    index++;
                }

                Console.WriteLine("\nWhich car would you like to purchase? Please select a number.\n");

                int input = int.Parse(Console.ReadLine());
                Console.WriteLine();

                Console.WriteLine($"{inventory[input - 1].Year} {inventory[input - 1].Make} " +
                    $"{inventory[input - 1].Model} for ${inventory[input - 1].Price}.\n");

                inventory.RemoveAt(input - 1);

                


            }


        }
        
        
    }
}