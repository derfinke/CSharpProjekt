using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace winows_forms
{
    public partial class Form2 : Form
    {
        
        public Form2()
        {
            InitializeComponent();
            playMusic();
            this.Location = new Point(0, 0);
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Start_Button_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            
            
        }

        private void Exit_Button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void playMusic()
        {
             SoundPlayer MainMusic = new SoundPlayer(@"C:\Users\finke\source\repos\winows forms\winows forms\Resources\The Great National Anthem of Kekistan.wav");
             MainMusic.Play();
        }
    }
}
