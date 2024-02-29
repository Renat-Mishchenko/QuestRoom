
namespace QuestRoom
{
    public class LeftRoom
    {
        private static LeftRoom instance;
        public static LeftRoom GetInstance()
        {
            if (instance == null)
            {
                instance = new LeftRoom();
            }

            return instance;
        }

        public int i = 0;

        public void Enter()
        {
            if (i == 0)
            {
                Console.WriteLine("So you've decided to go to the Left door. Everything in this room situated on the left. " +
                    "On the wall you see some colorful text. Type the answer or return to Main Room");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write("Richard ");
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.Write("Of ");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("York ");
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("Gave ");
                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                Console.Write("Battle ");
                Console.ForegroundColor = ConsoleColor.DarkCyan;
                Console.Write("In ");
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.Write("Vain");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Main Room]");
                Console.ForegroundColor = ConsoleColor.White;

                var answer = Console.ReadLine();
                if (answer == "Red Orange Yellow Green Blue Indigo Violent")
                {
                    i++;
                    Console.WriteLine("The riddle is resolved! You've received first part of the exit code: 22. " +
                        "Now you can go back to Main Room");
                    ReturnToMainRoomOption();

                }
                else if (answer == "Main Room")
                {
                    MainRoomInstance();
                }
                {
                    Console.WriteLine("Try once more");
                    Enter();
                }
            }
            else
            {
                Console.WriteLine("You've already resolved the riddle and get first part of the code: '22'");
                ReturnToMainRoomOption();
            }
        }

        public void MainRoomInstance()
        {
            MainRoom mainRoom = MainRoom.GetInstance();
            mainRoom.Enter();
        }

        public void ReturnToMainRoomOption()
        {
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Main Room]");
            Console.ForegroundColor = ConsoleColor.White;
            string returnToMainRoom = Console.ReadLine();
            if (returnToMainRoom == "Main Room")
            {
                MainRoomInstance();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Are you ok? You've said something insane");
                Console.ForegroundColor = ConsoleColor.White;
                ReturnToMainRoomOption();
            }
        }
    }
}
