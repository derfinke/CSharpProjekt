using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using winows_forms;

public class Item
{
	private string name;
	private bool pickable;
	
	public Item(string name, bool pickable)
	{
		this.name = name;
		this.pickable = pickable;
	}
	public override string ToString()
	{
		return this.name;
	}
	public bool isPickable()
	{
		return this.pickable;
	}

	public virtual void use(Player user, ListBox list)
	{

	}
}
public class Woodenstick : Item
{
	public Woodenstick() : base("Wooden Stick", true) { }
	public override void use(Player user, ListBox list)
	{
		Woodenstick woodenstick = new Woodenstick();
		list.Items.Add(woodenstick);
	}
}
public class Door : Item
{
	private bool locked;
	private char direction1;
	private char direction2;
	private Room Room1;
	private Room Room2;
	private string name;
	public Door(string name, bool locked, char direction1, char direction2, Room Room1, Room Room2) : base(name + "Door", false)
	{
		this.locked = locked;
		this.direction1 = direction1;
		this.direction2 = direction2;
		this.Room1 = Room1;
		this.Room2 = Room2;
		this.name = name;
	}

	public void toggleLock()
	{
		if (this.locked == true)
		{
			this.locked = false;
			switch (direction1)
			{
				case 'E':
					Room1.setConnectedRoomInEast(Room2);
					Room2.setConnectedRoomInWest(Room1);
					MessageBox.Show("The Door has been unlocked");
					break;


				case 'W':
					Room2.setConnectedRoomInWest(Room1);
					Room1.setConnectedRoomInEast(Room2);
					MessageBox.Show("The Door has been unlocked");
					break;


				case 'N':
					Room1.setConnectedRoomInNorth(Room2);
					Room2.setConnectedRoomInSouth(Room1);
					MessageBox.Show("The Door has been unlocked");
					break;

				case 'S':
					Room2.setConnectedRoomInNorth(Room1);
					Room1.setConnectedRoomInSouth(Room2);
					MessageBox.Show("The Door has been unlocked");
					break;
			}
		}
		else
		{
			this.locked = true;
			Room1.removeRoom('E',Room2);
			Room2.removeRoom('W',Room1);
			MessageBox.Show("The Door has been locked");
		}
	}
}
public class Key : Item
{
	private Door DoorToUnlock;
	private Room RoomWithDoor;
	private Room RoomWithDoor2;
	private string name;
	public Key(string name, Door DoorToUnlock, Room RoomWithDoor,Room RoomWithDoor2) : base(name + "Key", true)
	{
		this.DoorToUnlock = DoorToUnlock;
		this.RoomWithDoor = RoomWithDoor;
		this.RoomWithDoor2 = RoomWithDoor2;
		this.name = name;
	}
	public override void use(Player user, ListBox list)
	{
		if(RoomWithDoor == user.getCurrentRoom())
		{
			DoorToUnlock.toggleLock();
		}
		else if(RoomWithDoor2 == user.getCurrentRoom())
		{
			DoorToUnlock.toggleLock();
		}
		else
		{
			MessageBox.Show("I cann see nothing to use the key with");
		}
	}
}
