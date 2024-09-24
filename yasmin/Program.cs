// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hello, World!");

int tal()
        {
            Random random = new Random();
            int a = random.Next(1, 101);
            return a;
        }

        void over50(int someNum)
        
        {
            if(someNum > 50){
            Console.WriteLine("Tallet er over 50");
            }
            else if (someNum < 50){
            Console.WriteLine("Tallet er under 50");
            }
            else{
            Console.WriteLine("Tallet er 50");
            }
            if(someNum % 2 == 0){
            Console.WriteLine("Tallet er lige");
            }
            if(someNum % 2 != 0){
            Console.WriteLine("Tallet er ikke lige");
            }
        }
            for (int i = 0; i < 10; i++)
            {


                Console.WriteLine(tal());
                over50(tal());
            }
