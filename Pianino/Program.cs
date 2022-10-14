class Program
{
    static void Main()
    {
        Console.WriteLine("Переключение между окавами F5 и F6");
        ConsoleKeyInfo octava = Console.ReadKey();
        if (octava.Key == ConsoleKey.F5)
        {
            Console.WriteLine("5 октава");
            octava5();
            
        }
        if (octava.Key == ConsoleKey.F6)
        {
            Console.WriteLine("6 октава");
            octava6();
            
        }
        else if (octava.Key == ConsoleKey.Escape)
        {
            Console.WriteLine("Выход");
        }
    }   
        
    static void octava5()
    {
        int[] mass = { 266, 279, 299, 318, 324, 342, 378, 391, 417, 449, 464, 498 };
        int V = 250;

        while (true)
        {
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.Q:
                    Console.Beep(mass[7], V);
                    break;
                case ConsoleKey.W:
                    Console.Beep(mass[8], V);
                    break;
                case ConsoleKey.E:
                    Console.Beep(mass[9], V);
                    break;
                case ConsoleKey.T:
                    Console.Beep(mass[10], V);
                    break;
                case ConsoleKey.Y:
                    Console.Beep(mass[11], V);
                    break;
                case ConsoleKey.U:
                    Console.Beep(mass[12], V);
                    break;
            }
        }

    }
    static void octava6()
    {
        int[] massive = { 261, 277, 293, 311, 329, 349, 370, 392, 415, 440, 466, 493 };
        int V = 250;

        while (true)
        {
            
            switch (Console.ReadKey().Key)
            {
                case ConsoleKey.A:
                    Console.Beep(massive[0], V);
                    break;
                case ConsoleKey.S:
                    Console.Beep(massive[1], V);
                    break;
                case ConsoleKey.D:
                    Console.Beep(massive[2], V);
                    break;
                case ConsoleKey.F:
                    Console.Beep(massive[3], V);
                    break;
                case ConsoleKey.G:
                    Console.Beep(massive[4], V);
                    break;
                case ConsoleKey.H:
                    Console.Beep(massive[5], V);
                    break;
            }
        }

    }

}