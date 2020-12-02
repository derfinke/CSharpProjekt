using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Text;
using System.Windows.Forms;
using winows_forms;


namespace winows_forms

{
    public class Maze
    {
        private Room startRoom;
        private Room winningRoom;
        private Room losingRoom;
        private List<Item> playerBag = new List<Item>();
        //creates the Maze, adds Items to Different Rooms and declares the Start-,Winning- and Losing Room
        public Maze()
        {
            Room Kitchen = new Room("Kitchen");
            Room LivingRoom = new Room("Living Room");
            Room Bathroom = new Room("Bathroom");
            Room Bedroom = new Room("Bedroom");
            Room TourtureChamber = new Room("Torture Chamber");
            Room Exit = new Room("Exit");
            Door LivingRoomDoor = new Door("Blue", true, 'W', 'E', LivingRoom, Exit);
            Key LivingRoomKey = new Key("Blue", LivingRoomDoor, LivingRoom, Exit);
            Door BedRoomDoor = new Door("Red", true, 'E', 'W', Bathroom, Bedroom);
            Key BedRoomDoorKey = new Key("Red", BedRoomDoor, Bedroom, Bathroom);
            
            Kitchen.setConnectedRooms(null, LivingRoom, Bathroom, null);
            Bathroom.setConnectedRooms(Kitchen,null,null,null);
            Bedroom.setConnectedRooms(LivingRoom, null, TourtureChamber, null);
            LivingRoom.setConnectedRooms(null, null, Bedroom, Kitchen);
            TourtureChamber.setConnectedRooms(Bedroom, null, null, null);
            Exit.setConnectedRooms(null, null, null, null);
            LivingRoom.addItemToRoom(LivingRoomDoor);
            Bathroom.addItemToRoom(BedRoomDoor);
            Bedroom.addItemToRoom(BedRoomDoor);
            Bathroom.addItemToRoom(BedRoomDoorKey);

            startRoom = Bathroom;
            winningRoom = Exit;
            losingRoom = TourtureChamber;

            Item Whip = new Item("Whip", true);
            Item Hoe = new Item("Magic Hoe", true);
            Item Book = new Item("Magic Book: Loyality", true);
            Item Pascal = new Item("fucking useless piece of shit", false);
            Woodenstick woodenStick = new Woodenstick();

            Bathroom.addItemToRoom(Whip);
            Kitchen.addItemToRoom(Hoe);
            Bedroom.addItemToRoom(Book);
            Kitchen.addItemToRoom(Pascal);
            Kitchen.addItemToRoom(woodenStick);
            Bathroom.addItemToRoom(LivingRoomKey);
        }
        //returns the Start Room
        public Room getStartRoom()
        {
            return this.startRoom;
        }
        //returns the Winning Room
        public Room getWinningRoom()
        { 
            return this.winningRoom;
        }
        //returns the Losing Room
        public Room getLosingRoom()
        {
            return this.losingRoom;
        }
    }
}