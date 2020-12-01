using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;

namespace winows_forms
{
    public class Player
    {
        private Room currentRoom;
        public List<Item> bag;
        //Constructor of a Player
        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
            this.bag = new List<Item>();
        }
        //returns the Current Position of the Player
        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }
        //checks if there is another Room for the Player to move to, or if it is a wall
        public bool move(char direction)
        {
            currentRoom.getConnectedRoom(direction);
            if(currentRoom.getConnectedRoom(direction) == null)
            {
                return false;
            }
               
            else
            {
                currentRoom = currentRoom.getConnectedRoom(direction);
                return true;
            }
        }
        //adds an Item to the Players Inventory
        public void addItemToBag(Item ItemToAdd)
        {
            this.bag.Add(ItemToAdd);
        }
        //returns the Content of the Players Inventory
        public List<Item> getBag()
        {
            return this.bag;
        }
        //removes Item from the Players Inventory
        public void removeItemFromBag(Item ItemToRemove)
        {
            this.bag.Remove(ItemToRemove);
        }
    }
}