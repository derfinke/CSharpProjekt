using Microsoft.Win32;
using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Media;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Windows.Forms;
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
