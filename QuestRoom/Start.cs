

namespace QuestRoom
{
    public class Start 
    {
        static void Main()
        {
            string startUserMessage = "";
            FirstStep(startUserMessage);
            void FirstStep(string startUserMessage)
            {
                Console.WriteLine("Hello! Type [Start] to enter the Quest Room, type [Exit] if you are scarried chicken");

                startUserMessage = Console.ReadLine();
                CheckStart(startUserMessage);
            }


            void CheckStart(string startUserMessage)
            {
                if (startUserMessage == "Start")
                {
                    MainRoom mainRoom = MainRoom.GetInstance();
                    mainRoom.Enter();
                }
                else if (startUserMessage == "Exit")
                {
                    Console.WriteLine("You are the chicken! But you need to start the game");
                    startUserMessage = Console.ReadLine();
                    CheckStart(startUserMessage);
                } 
                else
                {
                    Console.WriteLine("Are you ok? You've said something insane. You should start the game");
                    CheckStart(startUserMessage);
                }
            }
        }
    }    
}
