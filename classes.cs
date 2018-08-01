using System;
using System.Collections.Generic;

namespace game{
    public class Player{
        public string name;
    }
    public class Item{
        public string name;
        public Person owner;
        public Item(string newName, Person newOwner){
            newName 
        }
    }
    public class Room{
        public string name {get; set;}
        public string description {get; set;}
        public List<Room> neighbors {get; set;}
        public List<Item> itemStores {get; set;}

        public Room(string newName, string newDesc, List<Item> newItem){
            name = newName;
            description = newDesc;
            itemStores = newItem; 
        }

        public void AddRoom(Room newRoom){
            System.Console.WriteLine(newRoom);
            this.neighbors.Add(newRoom);
        }
    }
    public class Person{
        public string name {get; set;}
        public string stack {get; set;}
        public Room location {get; set;}
        public bool hungry {get; set;}
        public bool tired {get; set;}
        public string response {get; set;}
        public Person(string newName, string newStack, Room newRoom, bool newHungry, bool newTired){
            name = newName;
            stack = newStack;
            location = newRoom;
            hungry = newHungry;
            tired = newTired;
        }
        public void Move(Room newRoom){
            location = newRoom;
        }
        public void Search(){
            System.Console.WriteLine(location.description);
        }
        public void Talk(Person talkingTo){
            System.Console.WriteLine(talkingTo.response);
        }
    }
}

