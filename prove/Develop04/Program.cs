class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Select an activity:");
            Console.WriteLine("1. Breathing Activity");
            Console.WriteLine("2. Reflection Activity");
            Console.WriteLine("3. Listing Activity");
            Console.WriteLine("4. Pondering Activity");
            Console.WriteLine("5. Quit");

            Console.Write("Enter your choice: ");
            int choice;
            while (!int.TryParse(Console.ReadLine(), out choice) || choice < 1 || choice > 5)
            {
                Console.Write("Invalid input. Please enter a number from 1 to 5: ");
            }

            if (choice == 5)
                break;

            Console.Write("Enter the duration of the activity in seconds: ");
            int duration;
            while (!int.TryParse(Console.ReadLine(), out duration) || duration <= 0)
            {
                Console.Write("Invalid input. Please enter a positive integer value for duration: ");
            }

            Activity activity = null;
            switch (choice)
            {
                case 1:
                    activity = new BreathingActivity(duration);
                    break;
                case 2:
                    activity = new ReflectionActivity(duration);
                    break;
                case 3:
                    activity = new ListingActivity(duration);
                    break;
                case 4:
                    activity = new PonderingActivity(duration);
                    break;
            }

            activity.Run();
        }
    }
}