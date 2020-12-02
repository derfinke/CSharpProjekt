using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace winows_forms

{
    
    public class Room
    {
        #region Room

        private string name;
        private Room north;
        private Room south;
        private Room east;
        private Room west;
        private List<Item> content;
        private char direction;
        private Room RoomToRemove;
       
        #endregion
        //constructer of a Room
        public Room(string name)
        {
            this.name = name;
            content = new List<Item>();
        }
        //sets the Rooms that Connect to each other in the corresponding directions
        public void setConnectedRooms(Room north, Room east, Room south, Room west)
        {
            this.north = north;
            this.south = south;
            this.west = west;
            this.east = east;
        }
        //returns the Name of the Room
        public String getName()
        {
            return this.name;
        }
        //returns the Room that is connected in the given direction
        public Room getConnectedRoom(char direction)
        {
            switch (direction)
            {
                case 'N':
                    
                     return this.north;
                     break;
                   

                case 'S':
                   
                    return this.south;
                    break;
                   

                case 'E':
                    
                    return this.east;
                    break;
                    

                case 'W':
                    return this.west;
                    break;

                default:
                    return null;
                    break;
            }
        }
        //returns the Content of the Player Inventory
        public List<Item> getContent()
        {
            return this.content;
        }
        //adds an Item to a Room
        public void addItemToRoom(Item itemToAdd)
        { 
            this.content.Add(itemToAdd);
        }
        //removes an Item from a Room
        public void removeItemFromRoom(Item itemToRemove)
        {
            this.content.Remove(itemToRemove);
        }
        //sets a connected Room in just one direction
        public void setConnectedRoomInEast(Room east)
        {
            this.east = east;   
        }
        public void setConnectedRoomInWest(Room west)
        {
            this.west = west;
        }
        public void setConnectedRoomInNorth(Room north)
        {
            this.north = north;
        }
        public void setConnectedRoomInSouth(Room south)
        {
            this.south = south;
        }
        //removes the connection to a Room in the given direction
        public void removeRoom(char direction, Room RoomToRemove)
        {
            this.direction = direction;
            switch (direction)
            {
                case 'N':
                    this.north = null;
                    break;
                case 'E':
                    this.east = null;
                    break;
                case 'S':
                    this.south= null;
                    break;
                case 'W':
                    this.west = null;
                    break;
                default:
                    this.RoomToRemove = null;
                    break;
            }
        }
    }
}