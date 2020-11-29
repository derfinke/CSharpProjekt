using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using winows_forms;

namespace winows_forms
{
    public partial class Form1 : Form
    {
        private Maze maze = new Maze();
        public Player player;
        
        public Form1()
        {
            InitializeComponent();
            this.maze = new Maze();
            this.player = new Player(maze.getStartRoom());
            Use_Button.Click += Use_Button_Click;
            updateRoom();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            movePlayer('N');
            updateRoom();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            movePlayer('E');
            updateRoom();
        }

        private void hurensohn_Click_1(object sender, EventArgs e)
        {
            movePlayer('S');
            updateRoom();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            movePlayer('W');
            updateRoom();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void updateRoom()
        {

            this.roomLabel.Text = this.player.getCurrentRoom().getName();
            this.Room_Items.Items.Clear();
            foreach (Item it in player.getCurrentRoom().getContent())
            {
                this.Room_Items.Items.Add(it);
            }

        }

        private void movePlayer(char direction)
        {
            if (player.move(direction) == true)
            {
                if (this.player.getCurrentRoom() == maze.getWinningRoom())
                {
                    updateRoom();
                    MessageBox.Show("Congratulations you have found the holy pepe");
                    Close();
                }
                else if (this.player.getCurrentRoom() == maze.getLosingRoom())
                {
                    updateRoom();
                    MessageBox.Show("You died and became a filthy Casual");
                    Close();
                }
            }
            else
            {
                MessageBox.Show("you cannot move in this direction");
            }
        }

        private void PickUp()
        {

        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Pickup_Button_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.Room_Items.SelectedItem;
            if (this.Room_Items.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Item");
            }
            else if (it.isPickable() == true)
            {
                this.Player_Items.Items.Add(it);
                this.player.addItemToBag(it);
                this.Room_Items.Items.Remove(it);
                this.player.getCurrentRoom().getContent().Remove(it);
            }
            else
            {
                MessageBox.Show("This Item is too heavy to pick up");
            }
        }

        private void Drop_Button_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.Player_Items.SelectedItem;
            if (this.Player_Items.SelectedItem == null)
            {
                MessageBox.Show("Please Select a Item");
            }
            else
            {
                this.Room_Items.Items.Add(it);
                this.player.getCurrentRoom().addItemToRoom(it);
                this.Player_Items.Items.Remove(it);
                this.player.getBag().Remove(it);
            }
        }

        private void Room_Items_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (Room_Items.SelectedIndex == -1)
            {
                Pickup_Button.Enabled = false;
            }
            else
            {
                Pickup_Button.Enabled = true;
            }
        }

        private void Player_Items_SelectedIndexChanged(object sender, EventArgs e)
        {


            if (Player_Items.SelectedIndex == -1)
            {
                Drop_Button.Enabled = false;
                Use_Button.Enabled = false;
            }
            else
            {
                Drop_Button.Enabled = true;
                Use_Button.Enabled = true;
            }

        }

        private void Use_Button_Click(object sender, EventArgs e)
        {
            Item it = (Item)this.Player_Items.SelectedItem;
            ListBox list = this.Player_Items;
            if (this.Player_Items.SelectedItem == null)
            {
                MessageBox.Show("Please select an Item to use");
            }
            else
            {
                it.use(list);
                updateRoom();
            }
        }
        public ListBox getListbox()
        {
            return this.Player_Items;
        }
    }
    

}
