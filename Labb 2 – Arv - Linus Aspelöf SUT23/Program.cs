namespace Labb_2___Arv___Linus_Aspelöf_SUT23
// Linus Aspelöf SUT23
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Animal whale = new Animal("Val", 50, "Svart", 50000, 0);
            Dachshund dachshund = new Dachshund("Hund", 5, "Svart", 9, 4, "Tax", true);
            Cat cat = new Cat("Katt", 3, "vit", 2, 4, false);
            Chicken chicken = new Chicken("Kyckling", 1, "Svart", 1, 2, true);

            Animal[] Farm = { whale, dachshund, cat, chicken };

            foreach (var animal in Farm)
            {
                Console.WriteLine("\n\t===============");
                animal.MakeSound();
                animal.Legs();
            }
            Console.ReadKey();
        }
    }
}