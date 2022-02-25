namespace AmongUsExternal
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
            this.components = new System.ComponentModel.Container();
            this.GameOpenLabel = new System.Windows.Forms.Label();
            this.GameTimer = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.RoleLabel = new System.Windows.Forms.Label();
            this.NameLabel = new System.Windows.Forms.Label();
            this.SpeedLabel = new System.Windows.Forms.Label();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SpeedTB = new System.Windows.Forms.TrackBar();
            this.FullbrightBox = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.NameChangeBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.ListTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTB)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // GameOpenLabel
            // 
            this.GameOpenLabel.AutoSize = true;
            this.GameOpenLabel.ForeColor = System.Drawing.Color.Red;
            this.GameOpenLabel.Location = new System.Drawing.Point(3, 282);
            this.GameOpenLabel.Name = "GameOpenLabel";
            this.GameOpenLabel.Size = new System.Drawing.Size(91, 13);
            this.GameOpenLabel.TabIndex = 1;
            this.GameOpenLabel.Text = "Game: Not Found";
            // 
            // GameTimer
            // 
            this.GameTimer.Tick += new System.EventHandler(this.GameTimer_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(16, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Local Player";
            // 
            // RoleLabel
            // 
            this.RoleLabel.AutoSize = true;
            this.RoleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RoleLabel.ForeColor = System.Drawing.Color.Cyan;
            this.RoleLabel.Location = new System.Drawing.Point(16, 43);
            this.RoleLabel.Name = "RoleLabel";
            this.RoleLabel.Size = new System.Drawing.Size(48, 18);
            this.RoleLabel.TabIndex = 3;
            this.RoleLabel.Text = "Role:";
            // 
            // NameLabel
            // 
            this.NameLabel.AutoSize = true;
            this.NameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameLabel.ForeColor = System.Drawing.Color.Cyan;
            this.NameLabel.Location = new System.Drawing.Point(16, 25);
            this.NameLabel.Name = "NameLabel";
            this.NameLabel.Size = new System.Drawing.Size(62, 18);
            this.NameLabel.TabIndex = 4;
            this.NameLabel.Text = "Name: ";
            // 
            // SpeedLabel
            // 
            this.SpeedLabel.AutoSize = true;
            this.SpeedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SpeedLabel.ForeColor = System.Drawing.Color.Cyan;
            this.SpeedLabel.Location = new System.Drawing.Point(16, 79);
            this.SpeedLabel.Name = "SpeedLabel";
            this.SpeedLabel.Size = new System.Drawing.Size(65, 18);
            this.SpeedLabel.TabIndex = 5;
            this.SpeedLabel.Text = "Speed: ";
            // 
            // listBox1
            // 
            this.listBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.listBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox1.CausesValidation = false;
            this.listBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox1.ForeColor = System.Drawing.Color.Cyan;
            this.listBox1.FormattingEnabled = true;
            this.listBox1.ItemHeight = 15;
            this.listBox1.Location = new System.Drawing.Point(197, 12);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(251, 270);
            this.listBox1.TabIndex = 6;
            this.listBox1.SelectedValueChanged += new System.EventHandler(this.listBox1_SelectedValueChanged);
            // 
            // SpeedTB
            // 
            this.SpeedTB.AutoSize = false;
            this.SpeedTB.Location = new System.Drawing.Point(16, 102);
            this.SpeedTB.Maximum = 500;
            this.SpeedTB.Minimum = 1;
            this.SpeedTB.Name = "SpeedTB";
            this.SpeedTB.Size = new System.Drawing.Size(144, 14);
            this.SpeedTB.TabIndex = 7;
            this.SpeedTB.TickStyle = System.Windows.Forms.TickStyle.None;
            this.SpeedTB.Value = 1;
            this.SpeedTB.Scroll += new System.EventHandler(this.SpeedTB_Scroll);
            // 
            // FullbrightBox
            // 
            this.FullbrightBox.AutoSize = true;
            this.FullbrightBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FullbrightBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.FullbrightBox.Location = new System.Drawing.Point(19, 122);
            this.FullbrightBox.Name = "FullbrightBox";
            this.FullbrightBox.Size = new System.Drawing.Size(117, 28);
            this.FullbrightBox.TabIndex = 8;
            this.FullbrightBox.Text = "Fullbright";
            this.FullbrightBox.UseVisualStyleBackColor = true;
            this.FullbrightBox.CheckedChanged += new System.EventHandler(this.FullbrightBox_CheckedChanged);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Controls.Add(this.NameChangeBox);
            this.panel2.Controls.Add(this.button1);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.PositionLabel);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.FullbrightBox);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.RoleLabel);
            this.panel2.Controls.Add(this.SpeedTB);
            this.panel2.Controls.Add(this.NameLabel);
            this.panel2.Controls.Add(this.SpeedLabel);
            this.panel2.Location = new System.Drawing.Point(6, 12);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(185, 270);
            this.panel2.TabIndex = 11;
            // 
            // NameChangeBox
            // 
            this.NameChangeBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.NameChangeBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.NameChangeBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NameChangeBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.NameChangeBox.Location = new System.Drawing.Point(19, 246);
            this.NameChangeBox.Name = "NameChangeBox";
            this.NameChangeBox.Size = new System.Drawing.Size(141, 22);
            this.NameChangeBox.TabIndex = 13;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.Color.Cyan;
            this.button1.Location = new System.Drawing.Point(19, 217);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 23);
            this.button1.TabIndex = 12;
            this.button1.Text = "Change Nickname";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox2.Location = new System.Drawing.Point(19, 183);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(121, 28);
            this.checkBox2.TabIndex = 11;
            this.checkBox2.Text = "Free Chat";
            this.checkBox2.UseVisualStyleBackColor = true;
            this.checkBox2.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PositionLabel.ForeColor = System.Drawing.Color.Cyan;
            this.PositionLabel.Location = new System.Drawing.Point(16, 61);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(48, 18);
            this.PositionLabel.TabIndex = 10;
            this.PositionLabel.Text = "Pos: ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.checkBox1.Location = new System.Drawing.Point(19, 151);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(92, 28);
            this.checkBox1.TabIndex = 9;
            this.checkBox1.Text = "NoClip";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // ListTimer
            // 
            this.ListTimer.Tick += new System.EventHandler(this.ListTimer_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Silver;
            this.ClientSize = new System.Drawing.Size(457, 296);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.listBox1);
            this.Controls.Add(this.GameOpenLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.Text = "Among Us Hack v2.0.1  By: Glatrix  2022";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.Wheat;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.SpeedTB)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label GameOpenLabel;
        private System.Windows.Forms.Timer GameTimer;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label RoleLabel;
        private System.Windows.Forms.Label NameLabel;
        private System.Windows.Forms.Label SpeedLabel;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.TrackBar SpeedTB;
        private System.Windows.Forms.CheckBox FullbrightBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Timer ListTimer;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.TextBox NameChangeBox;
        private System.Windows.Forms.Button button1;
    }
}

