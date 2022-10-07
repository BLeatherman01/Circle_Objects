namespace Circle_Objects
{
    internal class Program
    {
        static void Main(string[] args)
        {

            //gets user number
            Console.WriteLine("please enter a radius.");

            int userTotal = 0;  
            double radius;

            bool KeepGoing = true;
            while (KeepGoing)
            {
                try
                {
                    radius = double.Parse(Console.ReadLine());
                    userTotal++;
                }
                catch(FormatException e)
                {
                    Console.WriteLine("Please enter a positive integer ");
                    continue;
                }
                
                Circle r = new Circle(radius);
               
                
                //calculates area  
                Console.WriteLine("The area is : " + r.CalculateArea());

                //circumference
                Console.WriteLine("The circumference is : " + r.CalculateCircumference());

                KeepGoing = GoAgain();
            }
            Console.WriteLine($"You measured: {userTotal} circles. \nGoodbye!");

        }
        public static bool GoAgain()
        {

            Console.WriteLine("\nWould you like to measure a new circle? Please enter Yes or No");
            string userInput = Console.ReadLine().ToLower().Trim();

          
            if (userInput == "yes" || userInput == "y")
            {
               
                return true;
             
            }
            else if (userInput == "no" || userInput == "n")
            {
                
                return false;
            }
            else
            {
                Console.WriteLine("Please enter Yes or No");
                return GoAgain();
            }
        }
    }
}