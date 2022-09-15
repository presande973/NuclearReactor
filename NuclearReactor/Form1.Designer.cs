namespace NuclearReactor
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Perpetua Titling MT", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(12, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(554, 51);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(150, 71);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(100, 23);
            this.reactor1Label.TabIndex = 1;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(331, 71);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(100, 23);
            this.reactor2Label.TabIndex = 2;
            this.reactor2Label.Text = "Reactor 2";
            this.reactor2Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor1StateLabel.Location = new System.Drawing.Point(151, 112);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(100, 93);
            this.reactor1StateLabel.TabIndex = 3;
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.LawnGreen;
            this.reactor2StateLabel.Location = new System.Drawing.Point(331, 112);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(100, 93);
            this.reactor2StateLabel.TabIndex = 4;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.White;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(54, 293);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(477, 36);
            this.outputLabel.TabIndex = 5;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startButton
            // 
            this.startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.Location = new System.Drawing.Point(211, 219);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(162, 49);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start Reactors";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.ClientSize = new System.Drawing.Size(578, 359);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.titleLabel);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nuclear Power Plant";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button startButton;
    }
}

