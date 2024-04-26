namespace HumainMecanique
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Humain humain = new Humain("test");
            Console.WriteLine(humain.JambeHumaineGauche);

        }
    }
}
