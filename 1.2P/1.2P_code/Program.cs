using System;

namespace HelloWorld {

    class MainClass {

        public static void Main (string[] args) {

            Message myMessage;
            myMessage = new Message ("Hello World - from Message Object");
            myMessage.Print();
            
            Console.WriteLine("Enter name: ");
            string name = Console.ReadLine() ?? "unknown";

            Message messageOne;
            Message messageTwo;
            Message messageThree;
            Message messageFour;
            Message messageFive;

            messageOne = new Message ("Welcome back!");
            messageTwo = new Message ("What a lovely name");
            messageThree = new Message ("Great name");
            messageFour = new Message ("Oh hi!");
            messageFive = new Message ("You don't have a name?");

            Message[] messageArray = {messageOne, messageTwo, messageThree, messageFour, messageFive};
            

            
            switch (name.ToLower()) {
                case "charlie":
                    messageArray[0].Print();
                    break;
                case "jakob":
                    messageArray[1].Print();
                    break;
                case "kizzie":
                    messageArray[2].Print();
                    break;
                case "rex":
                    messageArray[3].Print();
                    break;
                case "unknown":
                    messageArray[4].Print();
                    break;
                default:
                    Console.WriteLine("That is a silly name");
                    break;
            }
                
            

            

        }
    }
}