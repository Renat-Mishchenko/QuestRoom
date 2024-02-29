

namespace QuestRoom
{
    public class MainRoom
    {
        private static MainRoom instance;
        public static MainRoom GetInstance()
        {
            if (instance == null)
            {
                instance = new MainRoom();
            }

            return instance;
        }

        public int i = 0;
        public string door;

        public void Enter()
        {
            if (i == 0)
            {
                i++;
                Console.WriteLine("You are brave enough to enter Quest Room, Well DOne! You are in the Main room. You see " +
                        "three doors. The left one is painted with different colors. The right one has holes like cheese " +
                        "or something like that. The door in front of you has some mechanism wich locking the door and 'Exit' " +
                        "above it. Wich one you'll try?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Left]");
                Console.WriteLine("[Right]");
                Console.WriteLine("[Front]");
                Console.ForegroundColor = ConsoleColor.White;
                door = Console.ReadLine();
                DoorChoosing(door);
            }
            else
            {
                Console.WriteLine("You are it the Main Room. Wich door will you choose?");
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("[Left]");
                Console.WriteLine("[Right]");
                Console.WriteLine("[Front]");
                Console.ForegroundColor = ConsoleColor.White;
                door = Console.ReadLine();
                DoorChoosing(door);
            }
        }

        public void DoorChoosing(string door)
        {
            if (door == "Left")
            {
                LeftRoom leftRoom = LeftRoom.GetInstance();
                leftRoom.Enter();

            }
            else if (door == "Right")
            {
                RightRoom rightRoom = RightRoom.GetInstance();
                rightRoom.Enter();
            }
            else if (door == "Front")
            {
                FrontDoorOpening(); 

            }
        }

        void FrontDoorOpening()
        {
            Console.WriteLine("You are near the Front Door. You see the lock and the plate with numbers. " +
            "Type the code [****] to open the door or return to start of the Main Room");
            Console.WriteLine("");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("[Main Room]");
            Console.ForegroundColor = ConsoleColor.White;
            string exitCode = Console.ReadLine();
            if (exitCode == "2210")
            {
                Console.WriteLine("You've exit Quest Room");
            }
            else if (exitCode == "Main Room")
            {
                Enter();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Password is invalid. Maybe, you should visit other rooms before?");
                Console.ForegroundColor = ConsoleColor.White;
                FrontDoorOpening();
            }
        }
    }
}
