
namespace Arcade_Game
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.playButton = new System.Windows.Forms.Button();
            this.countdownLabel3 = new System.Windows.Forms.Label();
            this.countdownLabel2 = new System.Windows.Forms.Label();
            this.labelCountdown1 = new System.Windows.Forms.Label();
            this.labelGo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // playButton
            // 
            this.playButton.FlatAppearance.BorderSize = 5;
            this.playButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Blue;
            this.playButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.playButton.Font = new System.Drawing.Font("Garamond", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.playButton.Location = new System.Drawing.Point(124, 68);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(145, 40);
            this.playButton.TabIndex = 0;
            this.playButton.Text = "PLAY GAME";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // countdownLabel3
            // 
            this.countdownLabel3.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel3.Location = new System.Drawing.Point(124, 111);
            this.countdownLabel3.Name = "countdownLabel3";
            this.countdownLabel3.Size = new System.Drawing.Size(145, 23);
            this.countdownLabel3.TabIndex = 1;
            this.countdownLabel3.Text = "Game initiates in: 3";
            this.countdownLabel3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel3.Visible = false;
            // 
            // countdownLabel2
            // 
            this.countdownLabel2.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countdownLabel2.Location = new System.Drawing.Point(124, 134);
            this.countdownLabel2.Name = "countdownLabel2";
            this.countdownLabel2.Size = new System.Drawing.Size(145, 23);
            this.countdownLabel2.TabIndex = 2;
            this.countdownLabel2.Text = "Game initiates in: 2";
            this.countdownLabel2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.countdownLabel2.Visible = false;
            // 
            // labelCountdown1
            // 
            this.labelCountdown1.Font = new System.Drawing.Font("Garamond", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCountdown1.Location = new System.Drawing.Point(124, 157);
            this.labelCountdown1.Name = "labelCountdown1";
            this.labelCountdown1.Size = new System.Drawing.Size(145, 23);
            this.labelCountdown1.TabIndex = 3;
            this.labelCountdown1.Text = "Game initiates in: 1";
            this.labelCountdown1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.labelCountdown1.Visible = false;
            // 
            // labelGo
            // 
            this.labelGo.Font = new System.Drawing.Font("Garamond", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelGo.Location = new System.Drawing.Point(127, 180);
            this.labelGo.Name = "labelGo";
            this.labelGo.Size = new System.Drawing.Size(142, 23);
            this.labelGo.TabIndex = 4;
            this.labelGo.Text = "BEGIN!";
            this.labelGo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.labelGo.Visible = false;
            this.labelGo.Click += new System.EventHandler(this.labelGo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.ClientSize = new System.Drawing.Size(403, 450);
            this.Controls.Add(this.labelGo);
            this.Controls.Add(this.labelCountdown1);
            this.Controls.Add(this.countdownLabel2);
            this.Controls.Add(this.countdownLabel3);
            this.Controls.Add(this.playButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Arcade Game";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Label countdownLabel3;
        private System.Windows.Forms.Label countdownLabel2;
        private System.Windows.Forms.Label labelCountdown1;
        private System.Windows.Forms.Label labelGo;
    }
}

