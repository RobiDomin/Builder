using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builder
{
    public class Pizza
    {
        public string Dough { get; set; }
        public string Meat { get; set; }
        public string Cheese { get; set; }
        public string Veggies { get; set; }
        public string Spices { get; set; }

        public void Show()
        {
            Console.WriteLine("Zbudowana pizza:");
            Console.WriteLine($"- Spód: {Dough}");
            Console.WriteLine($"- Wędliny: {Meat}");
            Console.WriteLine($"- Ser: {Cheese}");
            Console.WriteLine($"- Warzywa: {Veggies}");
            Console.WriteLine($"- Przyprawy: {Spices}");
        }
    }

    public interface IPizzaBuilder
    {
        void Reset();
        void SetDough(string dough);
        void AddMeat(string meat);
        void AddCheese(string cheese);
        void AddVeggies(string veggies);
        void AddSpices(string spices);
        Pizza GetPizza();
    }

    public class CustomPizzaBuilder : IPizzaBuilder
    {
        private Pizza pizza;

        public CustomPizzaBuilder()
        {
            Reset();
        }

        public void Reset()
        {
            pizza = new Pizza();
        }

        public void SetDough(string dough)
        {
            pizza.Dough = dough;
        }

        public void AddMeat(string meat)
        {
            pizza.Meat = meat;
        }

        public void AddCheese(string cheese)
        {
            pizza.Cheese = cheese;
        }

        public void AddVeggies(string veggies)
        {
            pizza.Veggies = veggies;
        }

        public void AddSpices(string spices)
        {
            pizza.Spices = spices;
        }

        public Pizza GetPizza()
        {
            Pizza result = pizza;
            Reset(); 
            return result;
        }
    }

    
    public class Director
    {
        private IPizzaBuilder builder;

        public void SetBuilder(IPizzaBuilder builder)
        {
            this.builder = builder;
        }

        public void BuildMargherita()
        {
            builder.Reset();
            builder.SetDough("Cienkie ciasto");
            builder.AddCheese("Mozzarella");
            builder.AddSpices("Bazylia");
        }

        public void BuildMeatLovers()
        {
            builder.Reset();
            builder.SetDough("Grube ciasto");
            builder.AddMeat("Pepperoni, Szynka");
            builder.AddCheese("Cheddar");
            builder.AddVeggies("Cebula, papryka");
            builder.AddSpices("Oregano");
        }
    }
}
