namespace winows_forms
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.Mission = new System.Windows.Forms.Label();
            this.Navigation = new System.Windows.Forms.Label();
            this.Room_info = new System.Windows.Forms.Label();
            this.roomLabel = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Room_Items = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Player_Items = new System.Windows.Forms.ListBox();
            this.Drop_Button = new System.Windows.Forms.Button();
            this.Pickup_Button = new System.Windows.Forms.Button();
            this.Use_Button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(839, 332);
            this.button1.Margin = new System.Windows.Forms.Padding(4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(31, 28);
            this.button1.TabIndex = 0;
            this.button1.Text = "N";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(870, 367);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(31, 28);
            this.button2.TabIndex = 1;
            this.button2.Text = "E";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(807, 367);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(31, 28);
            this.button4.TabIndex = 3;
            this.button4.Text = "W";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Mission
            // 
            this.Mission.AutoSize = true;
            this.Mission.Font = new System.Drawing.Font("LEMON MILK Bold", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Mission.Location = new System.Drawing.Point(41, 43);
            this.Mission.Name = "Mission";
            this.Mission.Size = new System.Drawing.Size(504, 76);
            this.Mission.TabIndex = 4;
            this.Mission.Text = "Your Mission:\r\nNavigate through the rooms of the kek dungeon and find\r\nthe holy p" +
    "epe. Avoid the normie chamber, or you will become \r\na filthy casual and die inst" +
    "antly.";
            this.Mission.Click += new System.EventHandler(this.label1_Click);
            // 
            // Navigation
            // 
            this.Navigation.AutoSize = true;
            this.Navigation.Location = new System.Drawing.Point(823, 291);
            this.Navigation.Name = "Navigation";
            this.Navigation.Size = new System.Drawing.Size(63, 14);
            this.Navigation.TabIndex = 5;
            this.Navigation.Text = "Navigation";
            // 
            // Room_info
            // 
            this.Room_info.AutoSize = true;
            this.Room_info.Font = new System.Drawing.Font("Arial Black", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Room_info.Location = new System.Drawing.Point(41, 142);
            this.Room_info.Name = "Room_info";
            this.Room_info.Size = new System.Drawing.Size(129, 15);
            this.Room_info.TabIndex = 6;
            this.Room_info.Text = "You are currently in:\r\n";
            // 
            // roomLabel
            // 
            this.roomLabel.AutoSize = true;
            this.roomLabel.Font = new System.Drawing.Font("LEMON MILK Bold", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roomLabel.Location = new System.Drawing.Point(53, 176);
            this.roomLabel.Name = "roomLabel";
            this.roomLabel.Size = new System.Drawing.Size(92, 30);
            this.roomLabel.TabIndex = 7;
            this.roomLabel.Text = "label1";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(839, 401);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(31, 28);
            this.button3.TabIndex = 8;
            this.button3.Text = "S";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.hurensohn_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(518, 265);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 9;
            this.label1.Text = "The room contains:\r\n";
            // 
            // Room_Items
            // 
            this.Room_Items.FormattingEnabled = true;
            this.Room_Items.ItemHeight = 14;
            this.Room_Items.Location = new System.Drawing.Point(522, 291);
            this.Room_Items.Name = "Room_Items";
            this.Room_Items.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Room_Items.Size = new System.Drawing.Size(165, 158);
            this.Room_Items.TabIndex = 10;
            this.Room_Items.SelectedIndexChanged += new System.EventHandler(this.Room_Items_SelectedIndexChanged_1);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Black", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(274, 265);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 22);
            this.label2.TabIndex = 11;
            this.label2.Text = "You have:\r\n";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Player_Items
            // 
            this.Player_Items.FormattingEnabled = true;
            this.Player_Items.ItemHeight = 14;
            this.Player_Items.Location = new System.Drawing.Point(239, 290);
            this.Player_Items.Name = "Player_Items";
            this.Player_Items.SelectionMode = System.Windows.Forms.SelectionMode.MultiSimple;
            this.Player_Items.Size = new System.Drawing.Size(165, 158);
            this.Player_Items.TabIndex = 12;
            this.Player_Items.SelectedIndexChanged += new System.EventHandler(this.Player_Items_SelectedIndexChanged);
            // 
            // Drop_Button
            // 
            this.Drop_Button.Enabled = false;
            this.Drop_Button.Location = new System.Drawing.Point(429, 337);
            this.Drop_Button.Name = "Drop_Button";
            this.Drop_Button.Size = new System.Drawing.Size(75, 23);
            this.Drop_Button.TabIndex = 13;
            this.Drop_Button.Text = "Drop >\r\n\r\n";
            this.Drop_Button.UseVisualStyleBackColor = true;
            this.Drop_Button.Click += new System.EventHandler(this.Drop_Button_Click);
            // 
            // Pickup_Button
            // 
            this.Pickup_Button.Enabled = false;
            this.Pickup_Button.Location = new System.Drawing.Point(429, 370);
            this.Pickup_Button.Name = "Pickup_Button";
            this.Pickup_Button.Size = new System.Drawing.Size(75, 23);
            this.Pickup_Button.TabIndex = 14;
            this.Pickup_Button.Text = "< Pick up\r\n";
            this.Pickup_Button.UseVisualStyleBackColor = true;
            this.Pickup_Button.Click += new System.EventHandler(this.Pickup_Button_Click);
            // 
            // Use_Button
            // 
            this.Use_Button.Enabled = false;
            this.Use_Button.Location = new System.Drawing.Point(278, 454);
            this.Use_Button.Name = "Use_Button";
            this.Use_Button.Size = new System.Drawing.Size(75, 23);
            this.Use_Button.TabIndex = 15;
            this.Use_Button.Text = "Use\r\n";
            this.Use_Button.UseVisualStyleBackColor = true;
            this.Use_Button.Click += new System.EventHandler(this.Use_Button_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 485);
            this.Controls.Add(this.Use_Button);
            this.Controls.Add(this.Pickup_Button);
            this.Controls.Add(this.Drop_Button);
            this.Controls.Add(this.Player_Items);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Room_Items);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.roomLabel);
            this.Controls.Add(this.Room_info);
            this.Controls.Add(this.Navigation);
            this.Controls.Add(this.Mission);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label Mission;
        private System.Windows.Forms.Label Navigation;
        private System.Windows.Forms.Label Room_info;
        private System.Windows.Forms.Label roomLabel;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox Room_Items;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Drop_Button;
        private System.Windows.Forms.Button Pickup_Button;
        private System.Windows.Forms.Button Use_Button;
        public System.Windows.Forms.ListBox Player_Items;
    }
}

