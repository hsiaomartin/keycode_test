using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace keycode_WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            XY_label.Text = String.Format("{0},{1}", (character_label.Location.X-9).ToString(), (character_label.Location.Y-24).ToString());
        }



        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            int charX = character_label.Location.X;
            int charY = character_label.Location.Y;
            int movePoint = 1;
            int moveSpeed = int.Parse(speed_domainUpDown.Text);
            int moveArrow = 1;
            int moving = movePoint * moveSpeed*moveArrow;
            
            switch (key)
            {

                case Keys.Up:
                    up_button.BackColor = Color.Yellow;
                    arrowKey_textBox.Text = "up";
                    if(charY-moving> map_richTextBox.Location.Y)
                        character_label.Location = new Point(charX,charY- moving);
                    break;
                case Keys.Down:
                    down_button.BackColor = Color.Yellow;
                    arrowKey_textBox.Text = "down";
                    if (charY + moving<(map_richTextBox.Size.Height+map_richTextBox.Location.Y)-character_label.Size.Height)
                        character_label.Location = new Point(charX, charY + moving);
                    break;
                case Keys.Left:
                    left_button.BackColor = Color.Yellow;
                    arrowKey_textBox.Text = "left";
                    if (charX-moving  > map_richTextBox.Location.X)
                        character_label.Location = new Point(charX- moving, charY );
                    break;
                case Keys.Right:
                    right_button.BackColor = Color.Yellow;
                    arrowKey_textBox.Text = "right";
                    if (charX+ moving < (map_richTextBox.Size.Width + map_richTextBox.Location.X) - character_label.Size.Width)
                        character_label.Location = new Point(charX+ moving, charY );
                    break;
            }
            XY_label.Text = String.Format("{0},{1}", (charX-9).ToString(), (charY-24).ToString());

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Up:
                    up_button.BackColor = System.Drawing.SystemColors.Control;
                    //up_button.Enabled = true;
                    break;
                case Keys.Down:
                    down_button.BackColor = System.Drawing.SystemColors.Control;
                    break;
                case Keys.Left:
                    left_button.BackColor = System.Drawing.SystemColors.Control;
                    break;
                case Keys.Right:
                    right_button.BackColor = System.Drawing.SystemColors.Control;
                    break;
            }
            arrowKey_textBox.Text = "";
        }
    }
}
