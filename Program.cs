namespace UserRegistration
{
    class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the user registration program");

            UserRegistrationPr cd = new UserRegistrationPr();

            Console.WriteLine("Enter the First name :");

            string FName = Console.ReadLine();

            Console.WriteLine("Enter the Last Name : ");
            string LName = Console.ReadLine();

            Console.WriteLine("Enter Your Email Id : ");
            string MailId = Console.ReadLine();

            Console.WriteLine("Enter Mobile number : ");
            string Mobile = Console.ReadLine();

            Console.WriteLine(cd.ValidateFName(FName));
            Console.WriteLine(cd.ValidateLName(LName));
            Console.WriteLine(cd.ValidateMailId(MailId));
            Console.WriteLine(cd.ValidateMobile(Mobile));
        }
    }
}