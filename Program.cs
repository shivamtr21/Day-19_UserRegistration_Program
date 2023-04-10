namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration program");

            UserRegistrationPr cd = new UserRegistrationPr();

            Console.WriteLine("Enter the first name :");

            string FName = Console.ReadLine();

            Console.WriteLine(cd.ValidateFName(FName));
        }
    }
}