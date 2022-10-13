using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZooPark
{
    internal class ZooManager
    {
        public ZooManager()
        {
            Animals = new List<Animal>();
            CreateAnimalList();
            _availableFunds = 0;
        }

        private int _availableFunds;
        public List<Animal> Animals { get; set; }

        private int _idForPurchase;
        public void CreateAnimalList()
        {
            Ape ape = new Ape("Oranutan", 10, 1500, "Africa");
            Animals.Add(ape);
            Bird bird = new Bird("Struts", 15, 1100, "Africa");
            Animals.Add(bird);
            Cat cat = new Cat("Lion", 15, 1100, "Africa");
            Animals.Add(cat);
            cat = new Cat("Cougar", 20, 1800, "North America");
            Animals.Add(cat);
        }

        public void ShowAllAnimals()
        {
            Console.WriteLine("Animals available for purchase");
            foreach (Animal item in Animals)
            {
                Console.WriteLine($"Id: {item.Id}, Name: {item.Name}, Age: {item.Age}, Origin: {item.Origin}, Price: {item.CurrentValue}");
            }
        }

        public void AddFunds(int amount)
        {
            _availableFunds += amount;
            ShowAvailableFunds();
        }

        public void ShowAvailableFunds()
        {
            Console.WriteLine($"\nThe zoo has now {_availableFunds} to spend");
        }

        public void PurchaseAnimal()
        {
            Console.WriteLine("Type the Id for the animal you wish to purchase");
            int chosenId = int.Parse(Console.ReadLine());

            foreach (Animal item in Animals)
            {
                if (item.Id == chosenId)
                {
                    if (item.CurrentValue <= _availableFunds)
                    {
                        _idForPurchase = item.Id;
                        _availableFunds -= item.CurrentValue;
                        ShowAvailableFunds();
                        break;
                    }
                    else
                    {
                        Console.WriteLine("Too litle funds available. Add more funds, please");
                    }
                }
            }

            //CompleteTransaction();
        }

        private void CompleteTransaction()
        {
            //Not used yet
        }
    }
}
