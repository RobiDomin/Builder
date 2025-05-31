namespace Builder
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = new CustomPizzaBuilder();
            var director = new Director();
            director.SetBuilder(builder);

            // Director
            director.BuildMargherita();
            var margherita = builder.GetPizza();
            Console.WriteLine("Pizza Margherita:");
            margherita.Show();
            Console.WriteLine();

            // Custom
            builder.SetDough("Klasyczne ciasto");
            builder.AddMeat("Kurczak");
            builder.AddCheese("Ser feta");
            builder.AddVeggies("Rukola, pomidor");
            builder.AddSpices("Ostra papryka");
            var custom = builder.GetPizza();
            Console.WriteLine("Pizza użytkownika (custom):");
            custom.Show();
        }
    }
}
