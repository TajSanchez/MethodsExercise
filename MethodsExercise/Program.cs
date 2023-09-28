namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hi! What is your name?");

            string UserName = Console.ReadLine();


            Console.WriteLine("Nice name! What is your favorite color?");

            string FavColor = Console.ReadLine();


            Console.WriteLine("Ohhh that is a beautiful color!");

            Console.WriteLine("What is your favorite animal?");

            string FavAnimal = Console.ReadLine();


            Console.WriteLine("Lovely, I those are cool too. Last question I promise!");

            Console.WriteLine("What is your favorite band?");

            string FavBand = Console.ReadLine();

            Console.WriteLine("Erm not my favorite, but glad you like it. Now let's make a story with your fav things!");

            Console.WriteLine($"Hi my name is {UserName}. I like to go on adventures in my {FavColor} tunic with my fellow {FavAnimal}. They are pretty cool to explore the world with. We listen to {FavBand} while we fight our enemies, give us a little more motivation to succeed.");
        }


    }
}
