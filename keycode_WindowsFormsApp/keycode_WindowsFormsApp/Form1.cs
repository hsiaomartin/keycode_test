using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;
using myColor_class;
namespace keycode_WindowsFormsApp
{

    public partial class Form1 : Form
    {

        Label zLabel = new Label();
        Label xLabel = new Label();
        public Form1()
        {
            InitializeComponent();

            setComboBox_color();

            XY_label.Text = String.Format("{0},{1}", (character_label.Location.X-9).ToString(), (character_label.Location.Y-24).ToString());

            this.Activated += new EventHandler(delegate (object o, EventArgs e)
            {
                this.map_richTextBox.Focus();
            });
            setLabel();
        }

        void setLabel()
        {
            zLabel.Name = "zLabel";
            zLabel.Text = "/";
            zLabel.Size = character_label.Size;
            zLabel.Location = new Point(0, 0);
           
            this.Controls.Add(zLabel);
            zLabel.BringToFront();
            zLabel.Visible = false;
            zLabel.Enabled = false;

            xLabel.Name = "xLabel";
            xLabel.Text = "D";
            xLabel.Size = character_label.Size;
            xLabel.Location = new Point(0, 0);
           
            this.Controls.Add(xLabel);
            xLabel.BringToFront();
            xLabel.Visible = false;
            xLabel.Enabled = false;
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
            arrowKey_textBox.Text =  key.ToString() ;
            switch (key)
            {

                case Keys.Up:
                    up_button.BackColor = Color.Yellow;

                    if(charY-moving> map_richTextBox.Location.Y)
                        character_label.Location = new Point(charX,charY- moving);
                    break;
                case Keys.Down:
                    down_button.BackColor = Color.Yellow;

                    if (charY + moving<(map_richTextBox.Size.Height+map_richTextBox.Location.Y)-character_label.Size.Height)
                        character_label.Location = new Point(charX, charY + moving);
                    break;
                case Keys.Left:
                    left_button.BackColor = Color.Yellow;

                    if (charX-moving  > map_richTextBox.Location.X)
                        character_label.Location = new Point(charX- moving, charY );
                    break;
                case Keys.Right:
                    right_button.BackColor = Color.Yellow;

                    if (charX+ moving < (map_richTextBox.Size.Width + map_richTextBox.Location.X) - character_label.Size.Width)
                        character_label.Location = new Point(charX+ moving, charY );
                    break;

                case Keys.Z:
                    zLabel.Location = new Point(charX + 9 + zLabel.Size.Width, charY + zLabel.Size.Height);
                    zLabel.Visible = true;
                    zLabel.Enabled = true;
                    break;
                case Keys.X:
                    xLabel.Location = new Point(charX + 9 + zLabel.Size.Width, charY + zLabel.Size.Height);
                    xLabel.Visible = true;
                    xLabel.Enabled = true;
                    break;
            }
            //arrowKey_textBox.Text += zLabel.Location.X +""+ zLabel.Location.Y;
            XY_label.Text = String.Format("{0},{1}", (charX-9).ToString(), (charY-24).ToString());

        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            Keys key = e.KeyCode;
            switch (key)
            {
                case Keys.Up:
                    up_button.BackColor =SystemColors.Control;
                    //up_button.Enabled = true;
                    break;
                case Keys.Down:
                    down_button.BackColor = SystemColors.Control;
                    break;
                case Keys.Left:
                    left_button.BackColor = SystemColors.Control;
                    break;
                case Keys.Right:
                    right_button.BackColor = SystemColors.Control;
                    break;
                case Keys.Z:
                    zLabel.Visible = false;
                    zLabel.Enabled = false;
                    break;
                case Keys.X:
                    xLabel.Visible = false;
                    xLabel.Enabled = false;
                    break;


            }

            arrowKey_textBox.Text = "";
        }

        public void setComboBox_color()
        {
            this.comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            this.comboBox1.DrawMode = DrawMode.OwnerDrawVariable;
            foreach (var item in (new myColor()).brush)
            {
                this.comboBox1.Items.Add(item);
            }
            foreach (var item in (new myColor()).color)
            {
                this.comboBox1.Items.Add(item);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
       
           // character_label.ForeColor = Color.FromName(comboBox1.Text);
            if (sender == null)
                return;
            ComboBox comboBox = (ComboBox)sender;
            SolidBrush brush = null;
            if (comboBox.SelectedItem is SolidBrush)
            {
                brush = (SolidBrush)comboBox.SelectedItem;
                character_label.ForeColor = brush.Color;
            }
            else if (comboBox.SelectedItem is Color)
            {
                brush = new SolidBrush((Color)comboBox.SelectedItem);
                character_label.ForeColor = brush.Color;
            }
        }

        private void comboBox1_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index == -1)
                return;
            if (sender == null)
                return;
            e.DrawBackground();
            e.DrawFocusRectangle();
            ComboBox comboBox = (ComboBox)sender;
            Graphics graphics = e.Graphics;
            //取出ComboBox裡的顏色
            SolidBrush brush = null;//建立筆刷
            if (comboBox.Items[e.Index] is SolidBrush)
            {
                brush = (SolidBrush)comboBox.Items[e.Index];
            }
            else if (comboBox.Items[e.Index] is Color)
            {
                brush = new SolidBrush((Color)comboBox.Items[e.Index]);
            }
            //畫出預覽框，用黑色
            Rectangle rect = e.Bounds;
            rect.Offset(1, 1);
            rect.Width = 15;
            rect.Height -= 4;
            graphics.DrawRectangle(new Pen(Color.Black), rect);
            //將顏色填入預覽框，為了不讓黑色框框被蓋到，填顏色時需要調一下位置跟大小
            rect.Offset(1, 1);
            rect.Width -= 1;
            rect.Height -= 1;
            graphics.FillRectangle(brush, rect);
            //畫出顏色名稱，用黑色寫字，定義其位置
            // graphics.DrawString(brush.Color.Name.ToString(), e.Font, new SolidBrush(Color.Black), e.Bounds.X + 60, e.Bounds.Y + 3);

        }





    }

 
}
