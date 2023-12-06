
namespace Project_86_Casino
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
            this.lbFormSize = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.Dice = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.SumDice = new System.Windows.Forms.Label();
            this.Dice1 = new System.Windows.Forms.Label();
            this.Dice2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // lbFormSize
            // 
            this.lbFormSize.AutoSize = true;
            this.lbFormSize.BackColor = System.Drawing.Color.OldLace;
            this.lbFormSize.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.lbFormSize.Location = new System.Drawing.Point(3, 443);
            this.lbFormSize.Name = "lbFormSize";
            this.lbFormSize.Size = new System.Drawing.Size(84, 18);
            this.lbFormSize.TabIndex = 0;
            this.lbFormSize.Text = "lbFormSize";
            this.lbFormSize.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.button1.Location = new System.Drawing.Point(794, 566);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(200, 100);
            this.button1.TabIndex = 1;
            this.button1.Text = "แปลงร่าง";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Dice
            // 
            this.Dice.AutoSize = true;
            this.Dice.BackColor = System.Drawing.SystemColors.Window;
            this.Dice.Font = new System.Drawing.Font("Algerian", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dice.Location = new System.Drawing.Point(373, 9);
            this.Dice.Name = "Dice";
            this.Dice.Size = new System.Drawing.Size(282, 55);
            this.Dice.TabIndex = 2;
            this.Dice.Text = "Dice Game";
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.button2.Location = new System.Drawing.Point(368, 341);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(300, 120);
            this.button2.TabIndex = 3;
            this.button2.Text = "ทอยลูกเต๋า";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Linen;
            this.pictureBox1.Image = global::Project_86_Casino.Properties.Resources.d1;
            this.pictureBox1.Location = new System.Drawing.Point(102, 96);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(211, 200);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Linen;
            this.pictureBox2.Image = global::Project_86_Casino.Properties.Resources.d7;
            this.pictureBox2.Location = new System.Drawing.Point(412, 96);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(211, 200);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 5;
            this.pictureBox2.TabStop = false;
            this.pictureBox2.Click += new System.EventHandler(this.pictureBox2_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Linen;
            this.pictureBox3.Image = global::Project_86_Casino.Properties.Resources.d1;
            this.pictureBox3.Location = new System.Drawing.Point(703, 96);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(211, 200);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 6;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // SumDice
            // 
            this.SumDice.AutoSize = true;
            this.SumDice.BackColor = System.Drawing.Color.FloralWhite;
            this.SumDice.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.SumDice.Location = new System.Drawing.Point(750, 22);
            this.SumDice.Name = "SumDice";
            this.SumDice.Size = new System.Drawing.Size(139, 39);
            this.SumDice.TabIndex = 7;
            this.SumDice.Text = " ทอยก่อน";
            // 
            // Dice1
            // 
            this.Dice1.AutoSize = true;
            this.Dice1.BackColor = System.Drawing.Color.FloralWhite;
            this.Dice1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Dice1.Location = new System.Drawing.Point(191, 341);
            this.Dice1.Name = "Dice1";
            this.Dice1.Size = new System.Drawing.Size(35, 39);
            this.Dice1.TabIndex = 8;
            this.Dice1.Text = ": ";
            // 
            // Dice2
            // 
            this.Dice2.AutoSize = true;
            this.Dice2.BackColor = System.Drawing.Color.FloralWhite;
            this.Dice2.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(222)));
            this.Dice2.Location = new System.Drawing.Point(783, 341);
            this.Dice2.Name = "Dice2";
            this.Dice2.Size = new System.Drawing.Size(35, 39);
            this.Dice2.TabIndex = 9;
            this.Dice2.Text = ": ";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.BackgroundImage = global::Project_86_Casino.Properties.Resources.Color_Hunt_Palette_ffc8c8ff9999444f5a3e4149;
            this.ClientSize = new System.Drawing.Size(1006, 486);
            this.Controls.Add(this.Dice2);
            this.Controls.Add(this.Dice1);
            this.Controls.Add(this.SumDice);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.Dice);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lbFormSize);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ทอยลูกเต๋า";
            this.Load += new System.EventHandler(this.label1_load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbFormSize;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label Dice;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label SumDice;
        private System.Windows.Forms.Label Dice1;
        private System.Windows.Forms.Label Dice2;
    }
}

