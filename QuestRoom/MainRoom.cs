

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
                    Console.WriteLine("You are brave enough to enter Quest Room... So, you' ve entered the Main room. You see " +
                        "three doors. Two of them, on the right and on the left, are opened and waiting for visitors. The door" +
                        " in front of you has lock with the password. Wich one you'll try?");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[Left]");
                    Console.WriteLine("[Right]");
                    Console.WriteLine("[Front]");
                    Console.ForegroundColor = ConsoleColor.White;
                    door = Console.ReadLine();
                    i++;
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

                }
                else if (door == "Front")
                {
                    Console.WriteLine("You are near the front door. You see the lock, where code need to be inputed. Type the code or return to" +
                        "start of the Main Room");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine("[Main Room]");
                    Console.ForegroundColor = ConsoleColor.White;
                    string exitCode = Console.ReadLine();
                if (exitCode == "1234")
                {
                    Console.WriteLine("You've exit Quest Room");
                }
                else if (exitCode == "Main Room")
                {
                    Enter();
                }
                else 
                {
                    Console.WriteLine("Password is invalid");
                }

                }
            } 
    }
}
