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

        public Maze()
        {
            Room Kitchen = new Room("Kitchen");
            Room LivingRoom = new Room("Living Room");
            Room Bathroom = new Room("Bathroom");
            Room Bedroom = new Room("Bedroom");
            Room TourtureChamber = new Room("Torture Chamber");
            Room Exit = new Room("Exit");

            Kitchen.setConnectedRooms(null, LivingRoom, Bathroom, null);
            Bathroom.setConnectedRooms(Kitchen, Bedroom, null, null);
            Bedroom.setConnectedRooms(LivingRoom, null, TourtureChamber, Bathroom);
            LivingRoom.setConnectedRooms(null, Exit, Bedroom, Kitchen);
            TourtureChamber.setConnectedRooms(Bedroom, null, null, null);
            Exit.setConnectedRooms(null, LivingRoom, null, null);

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
            LivingRoom.addItemToRoom(Pascal);
            LivingRoom.addItemToRoom(woodenStick);


        }

        public Room getStartRoom()
        {
            return this.startRoom;
        }

        public Room getWinningRoom()
        {
            return this.winningRoom;
        }

        public Room getLosingRoom()
        {
            return this.losingRoom;
        }


    }
}