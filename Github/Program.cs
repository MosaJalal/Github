namespace Github
{

    enum Beverage
    {
        
        Kaffe,
        Te,
        Vatten,
        Redbull,
        Juice,
    }

    internal class Program
    {


        static void Main(string[] args)
        {
            Console.WriteLine("Välkommen till maskinen");
            Console.WriteLine("Vilken beverage föredrar du? (Kaffe, Te, Vatten, redbull, Juice)");
            string userinput = Console.ReadLine();

            switch (userinput.ToLower()) 
            {
                case "kaffe":
                    respond(Beverage.Kaffe);
                    break;
                case "te":
                    respond(Beverage.Te);
                    break;
                case "vatten":
                    respond(Beverage.Vatten);
                    break;
                case "redbull":
                    respond(Beverage.Redbull);
                    break;
                case "juice":
                    respond(Beverage.Juice);
                    break;
                default: 
                    Console.WriteLine("Fel knapp, denna dryck finns inte");
                    break;

            }
        }

        static void respond(Beverage dryck)
        {
            switch (dryck)
            {
                case Beverage.Kaffe:
                    Console.WriteLine("Du valde Kaffe latte");
                    break;
                case Beverage.Te:
                    Console.WriteLine("Du valde Te");
                    break;
                case Beverage.Vatten:
                    Console.WriteLine("Du valde Vatten");
                    break;
                case Beverage.Redbull:
                    Console.WriteLine("Du valde Redbull");
                    break;
                case Beverage.Juice:
                    Console.WriteLine("Du valde Juice");
                    break;
                default:
                    Console.WriteLine("Orange Juice kommer nu");
                    break;
            }
        }
    }
}