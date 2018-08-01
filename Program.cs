using System;
using System.Collections.Generic;

namespace game
{
    class Program
    {
        static void Main(string[] args)
        {
            Room Entryway = new Room("EntryWay", "Welcome to the Dojo", null);
            Room Storage = new Room("Storage", "Boxes and boxes and boxes ohhhh my", null);
            Room Mean = new Room("Mean", "Bullies r here", null);
            Room LowerKitchen = new Room("Lower Kitchen", "Feeding grounds for C# students", null);
            Room WebFund = new Room("Website Fundamentals", "A bunch of babies come here", null);
            
            Person Riley = new Person("Riley", "Csharp", Storage, true, false);
            Person Tim = new Person("Tim", "Csharp", Entryway, true, false);
            Tim.Search();
            
            Item PingPongPaddle = new Item("Ping Pong Paddle", Riley);

            Storage.Add(PingPongPaddle);

            Entryway.AddRoom(Storage);

            // Entryway.neighbors.Add(Storage);
            // Entryway.neighbors.Add(LowerKitchen);
            // Storage.neighbors.Add(Entryway);


            
        }
    }
}
