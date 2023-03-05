namespace Indexer
{
    class Program
    {
        public const int Size = 15;  // global variable
        class ClubMembers
        {
            private string[] clubMembers = new string[Size];
            public string ClubType { get; set; }
            public string ClubLocation { get; set; }
            public string MeetingDate { get; set; }

            //constructor
            public ClubMembers()
            {
                for (int i = 0; i < Size; i++)
                {
                    clubMembers[i] = string.Empty;
                }
                ClubType= string.Empty;
                ClubLocation= string.Empty;
                MeetingDate= string.Empty;
            }

            public string this[int index]
            {
                get
                {
                    string tmp;

                    if (index >= 0 && index <= Size - 1)
                    {
                        tmp = clubMembers[index];
                    }
                    else
                    {
                        tmp = "";
                    }

                    return (tmp);
                }
                set
                {
                    if (index >= 0 && index <= Size - 1)
                    {
                        clubMembers[index] = value;
                    }
                }

            }
        }
        static void Main(string[] args)
        {
            ClubMembers Member = new ClubMembers();
            bool end = false;
            while (!end)
            {
                int sub=0;
                while (sub < 1 || sub > Size)
                {
                    Console.WriteLine($"Which club member do you want to enter (enter 1-{Size})?");
                    while (!int.TryParse(Console.ReadLine(), out sub))
                        Console.WriteLine($"Enter a value between 1-{Size}");
                }
                Console.WriteLine("Enter the name of the club member");
                Member[sub-1] = Console.ReadLine();
                Console.WriteLine("Press any key to continue, q to stop");
                string stop = Console.ReadLine();
                if (stop =="q")
                    end=true;                
            }
            Console.WriteLine("What is the member's club type?");
            Member.ClubType = Console.ReadLine();
            Console.WriteLine("Where is the club's location?");
            Member.ClubLocation = Console.ReadLine();
            Console.WriteLine("When is the club member's meeting date?");
            Member.MeetingDate = Console.ReadLine();

            Console.WriteLine($"Here is information on the club members");
            Console.WriteLine($"Club Members");
            for (int i = 0; i < Size; i++)
            {
                if (Member[i] != string.Empty) 
                    Console.WriteLine(Member[i]);
            }
            Console.WriteLine($"Club Type: {Member.ClubType}");
            Console.WriteLine($"Club Location: {Member.ClubLocation}");
            Console.WriteLine($"Meeting Date: {Member.MeetingDate}");
        }
    }
}
