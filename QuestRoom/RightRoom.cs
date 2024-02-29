
namespace QuestRoom
{
    public class RightRoom
    {
        private static RightRoom instance;
        public static RightRoom GetInstance()
        {
            if (instance == null)
            {
                instance = new RightRoom();
            }

            return instance;
        }

        public int i = 0;

        public void Enter()
        {
            if (i == 0)
            {
                Console.WriteLine("So you've decided to go to the Right door. In the center of the table you've found paper " +
                    "with question on it: Who lives in pineapple under the sea? Type the answer or return to Main Room");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Main Room]");
                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine();

                var answer = Console.ReadLine();
                if (answer == "SpongeBob SquarePants")
                {
                    i++;
                    Console.WriteLine("The riddle is resolved! You've received second part of the exit code: 10. " +
                        "Now you can go back to Main Room");
                    ReturnToMainRoomOption();

                }
                else if (answer == "Main Room")
                {
                    MainRoomInstance();
                } 
                else
                {
                    Console.WriteLine("Answer is incorrect or check the spelling");
                    Enter();
                }
            }
            else
            {
                Console.WriteLine("You've already resolved the riddle and get first part of the code: '10'. " +
                    "You can return to the Main Room");
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
            } else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Are you ok? You've said something insane");
                Console.ForegroundColor = ConsoleColor.White;
                ReturnToMainRoomOption();
            }
        }
    }
}
