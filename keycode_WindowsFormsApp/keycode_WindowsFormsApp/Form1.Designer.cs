namespace keycode_WindowsFormsApp
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.up_button = new System.Windows.Forms.Button();
            this.arrowKey_textBox = new System.Windows.Forms.TextBox();
            this.map_richTextBox = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.left_button = new System.Windows.Forms.Button();
            this.down_button = new System.Windows.Forms.Button();
            this.right_button = new System.Windows.Forms.Button();
            this.character_label = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.XY_label = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.speed_domainUpDown = new System.Windows.Forms.DomainUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.X_button = new System.Windows.Forms.Button();
            this.Z_button = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // up_button
            // 
            this.up_button.Enabled = false;
            this.up_button.Location = new System.Drawing.Point(40, 21);
            this.up_button.Name = "up_button";
            this.up_button.Size = new System.Drawing.Size(30, 30);
            this.up_button.TabIndex = 0;
            this.up_button.Text = " ↑";
            this.up_button.UseVisualStyleBackColor = false;
            // 
            // arrowKey_textBox
            // 
            this.arrowKey_textBox.Enabled = false;
            this.arrowKey_textBox.Location = new System.Drawing.Point(6, 89);
            this.arrowKey_textBox.Name = "arrowKey_textBox";
            this.arrowKey_textBox.ReadOnly = true;
            this.arrowKey_textBox.Size = new System.Drawing.Size(100, 22);
            this.arrowKey_textBox.TabIndex = 1;
            // 
            // map_richTextBox
            // 
            this.map_richTextBox.Location = new System.Drawing.Point(6, 21);
            this.map_richTextBox.Name = "map_richTextBox";
            this.map_richTextBox.ReadOnly = true;
            this.map_richTextBox.Size = new System.Drawing.Size(210, 243);
            this.map_richTextBox.TabIndex = 2;
            this.map_richTextBox.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Z_button);
            this.groupBox1.Controls.Add(this.X_button);
            this.groupBox1.Controls.Add(this.left_button);
            this.groupBox1.Controls.Add(this.down_button);
            this.groupBox1.Controls.Add(this.right_button);
            this.groupBox1.Controls.Add(this.up_button);
            this.groupBox1.Controls.Add(this.arrowKey_textBox);
            this.groupBox1.Location = new System.Drawing.Point(240, 164);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(111, 118);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Arrow keys";
            // 
            // left_button
            // 
            this.left_button.Enabled = false;
            this.left_button.Location = new System.Drawing.Point(7, 53);
            this.left_button.Name = "left_button";
            this.left_button.Size = new System.Drawing.Size(30, 30);
            this.left_button.TabIndex = 4;
            this.left_button.Text = "←";
            this.left_button.UseVisualStyleBackColor = false;
            // 
            // down_button
            // 
            this.down_button.Enabled = false;
            this.down_button.Location = new System.Drawing.Point(40, 53);
            this.down_button.Name = "down_button";
            this.down_button.Size = new System.Drawing.Size(30, 30);
            this.down_button.TabIndex = 3;
            this.down_button.Text = " ↓";
            this.down_button.UseVisualStyleBackColor = false;
            // 
            // right_button
            // 
            this.right_button.Enabled = false;
            this.right_button.Location = new System.Drawing.Point(73, 53);
            this.right_button.Name = "right_button";
            this.right_button.Size = new System.Drawing.Size(30, 30);
            this.right_button.TabIndex = 2;
            this.right_button.Text = "→";
            this.right_button.UseVisualStyleBackColor = false;
            // 
            // character_label
            // 
            this.character_label.AutoSize = true;
            this.character_label.Location = new System.Drawing.Point(9, 24);
            this.character_label.Name = "character_label";
            this.character_label.Size = new System.Drawing.Size(17, 12);
            this.character_label.TabIndex = 4;
            this.character_label.Text = "█";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.character_label);
            this.groupBox2.Controls.Add(this.map_richTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(222, 270);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Display Area";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.comboBox1);
            this.groupBox3.Controls.Add(this.XY_label);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.speed_domainUpDown);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(240, 13);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(111, 145);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(17, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 12);
            this.label3.TabIndex = 7;
            this.label3.Text = "Color：";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(63, 53);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(43, 20);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.DrawItem += new System.Windows.Forms.DrawItemEventHandler(this.comboBox1_DrawItem);
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // XY_label
            // 
            this.XY_label.AutoSize = true;
            this.XY_label.Location = new System.Drawing.Point(61, 38);
            this.XY_label.Name = "XY_label";
            this.XY_label.Size = new System.Drawing.Size(20, 12);
            this.XY_label.TabIndex = 5;
            this.XY_label.Text = "0,0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(7, 38);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 12);
            this.label2.TabIndex = 3;
            this.label2.Text = "Position：";
            // 
            // speed_domainUpDown
            // 
            this.speed_domainUpDown.Enabled = false;
            this.speed_domainUpDown.Items.Add("0");
            this.speed_domainUpDown.Items.Add("1");
            this.speed_domainUpDown.Items.Add("2");
            this.speed_domainUpDown.Items.Add("3");
            this.speed_domainUpDown.Items.Add("4");
            this.speed_domainUpDown.Items.Add("5");
            this.speed_domainUpDown.Items.Add("6");
            this.speed_domainUpDown.Items.Add("7");
            this.speed_domainUpDown.Items.Add("8");
            this.speed_domainUpDown.Items.Add("9");
            this.speed_domainUpDown.Items.Add("10");
            this.speed_domainUpDown.Location = new System.Drawing.Point(67, 13);
            this.speed_domainUpDown.Name = "speed_domainUpDown";
            this.speed_domainUpDown.ReadOnly = true;
            this.speed_domainUpDown.Size = new System.Drawing.Size(36, 22);
            this.speed_domainUpDown.TabIndex = 2;
            this.speed_domainUpDown.Text = "5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "Speed：";
            // 
            // X_button
            // 
            this.X_button.Enabled = false;
            this.X_button.Location = new System.Drawing.Point(73, 21);
            this.X_button.Name = "X_button";
            this.X_button.Size = new System.Drawing.Size(30, 30);
            this.X_button.TabIndex = 5;
            this.X_button.Text = "X";
            this.X_button.UseVisualStyleBackColor = false;
            // 
            // Z_button
            // 
            this.Z_button.Enabled = false;
            this.Z_button.Location = new System.Drawing.Point(7, 21);
            this.Z_button.Name = "Z_button";
            this.Z_button.Size = new System.Drawing.Size(30, 30);
            this.Z_button.TabIndex = 6;
            this.Z_button.Text = "Z";
            this.Z_button.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 298);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "Form1";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button up_button;
        private System.Windows.Forms.TextBox arrowKey_textBox;
        private System.Windows.Forms.RichTextBox map_richTextBox;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button left_button;
        private System.Windows.Forms.Button down_button;
        private System.Windows.Forms.Button right_button;
        private System.Windows.Forms.Label character_label;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DomainUpDown speed_domainUpDown;
        private System.Windows.Forms.Label XY_label;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Z_button;
        private System.Windows.Forms.Button X_button;
    }
}

