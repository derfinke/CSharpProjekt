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

        public Player(Room currentRoom)
        {
            this.currentRoom = currentRoom;
            this.bag = new List<Item>();
        }

        public Room getCurrentRoom()
        {
            return this.currentRoom;
        }

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

        public void addItemToBag(Item ItemToAdd)
        {
            this.bag.Add(ItemToAdd);
        }

        public List<Item> getBag()
        {
            return this.bag;
        }
        public void removeItemFromBag(Item ItemToRemove)
        {
            this.bag.Remove(ItemToRemove);
        }
    }
}