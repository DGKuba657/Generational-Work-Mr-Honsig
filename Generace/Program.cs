namespace Generations {
    class Program {
        public static void Main() {
            bool running = true;
            while (running) {
                int age = Operations.GetAge();
                string gen = Operations.Generation(age);
                Console.WriteLine($"Your generation is {gen}");
                
                Jarda.Kulicka();
                
                Console.WriteLine("Do you want to exit? (y/n)");
                string input = Console.ReadLine();

                if (input.ToLower() is "y" or "yes" or "yeah" or "ano") {
                        running = false;
                }
                
                Jarda.Kulicka();
                
                Jachym.Klir();
            }
            
        }
    }
}

