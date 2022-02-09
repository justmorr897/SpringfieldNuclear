namespace SpringfieldNuclear
{
    partial class background
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(background));
            this.titleLabel = new System.Windows.Forms.Label();
            this.reactor2Label = new System.Windows.Forms.Label();
            this.reactor1Label = new System.Windows.Forms.Label();
            this.reactor1StateLabel = new System.Windows.Forms.Label();
            this.reactor2StateLabel = new System.Windows.Forms.Label();
            this.outputLabel = new System.Windows.Forms.Label();
            this.enableButton = new System.Windows.Forms.Button();
            this.radiationLabel = new System.Windows.Forms.Label();
            this.iconLabel1 = new System.Windows.Forms.Label();
            this.iconLabel2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.Font = new System.Drawing.Font("Constantia", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(53, 42);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(1358, 57);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Nuclear Reactor Control ";
            this.titleLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.titleLabel.Click += new System.EventHandler(this.label1_Click);
            // 
            // reactor2Label
            // 
            this.reactor2Label.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor2Label.Location = new System.Drawing.Point(841, 209);
            this.reactor2Label.Name = "reactor2Label";
            this.reactor2Label.Size = new System.Drawing.Size(209, 46);
            this.reactor2Label.TabIndex = 1;
            this.reactor2Label.Text = "Reactor 2";
            // 
            // reactor1Label
            // 
            this.reactor1Label.Font = new System.Drawing.Font("Consolas", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reactor1Label.Location = new System.Drawing.Point(402, 212);
            this.reactor1Label.Name = "reactor1Label";
            this.reactor1Label.Size = new System.Drawing.Size(228, 43);
            this.reactor1Label.TabIndex = 2;
            this.reactor1Label.Text = "Reactor 1";
            this.reactor1Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // reactor1StateLabel
            // 
            this.reactor1StateLabel.BackColor = System.Drawing.Color.Lime;
            this.reactor1StateLabel.Location = new System.Drawing.Point(457, 286);
            this.reactor1StateLabel.Name = "reactor1StateLabel";
            this.reactor1StateLabel.Size = new System.Drawing.Size(137, 127);
            this.reactor1StateLabel.TabIndex = 3;
            this.reactor1StateLabel.Click += new System.EventHandler(this.label3_Click);
            // 
            // reactor2StateLabel
            // 
            this.reactor2StateLabel.BackColor = System.Drawing.Color.Lime;
            this.reactor2StateLabel.Location = new System.Drawing.Point(848, 286);
            this.reactor2StateLabel.Name = "reactor2StateLabel";
            this.reactor2StateLabel.Size = new System.Drawing.Size(133, 127);
            this.reactor2StateLabel.TabIndex = 5;
            // 
            // outputLabel
            // 
            this.outputLabel.BackColor = System.Drawing.Color.Honeydew;
            this.outputLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.outputLabel.Location = new System.Drawing.Point(461, 545);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(520, 68);
            this.outputLabel.TabIndex = 6;
            this.outputLabel.Text = "Reactors Stable";
            this.outputLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // enableButton
            // 
            this.enableButton.BackColor = System.Drawing.Color.Turquoise;
            this.enableButton.Font = new System.Drawing.Font("Consolas", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enableButton.Location = new System.Drawing.Point(599, 459);
            this.enableButton.Name = "enableButton";
            this.enableButton.Size = new System.Drawing.Size(251, 53);
            this.enableButton.TabIndex = 7;
            this.enableButton.Text = "Start Reactor";
            this.enableButton.UseVisualStyleBackColor = false;
            this.enableButton.Click += new System.EventHandler(this.enableButton_Click);
            // 
            // radiationLabel
            // 
            this.radiationLabel.AutoSize = true;
            this.radiationLabel.BackColor = System.Drawing.Color.Red;
            this.radiationLabel.Font = new System.Drawing.Font("Cooper Black", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiationLabel.Location = new System.Drawing.Point(515, 130);
            this.radiationLabel.Name = "radiationLabel";
            this.radiationLabel.Size = new System.Drawing.Size(413, 36);
            this.radiationLabel.TabIndex = 8;
            this.radiationLabel.Text = "Radiation Leak Detected";
            this.radiationLabel.Visible = false;
            // 
            // iconLabel1
            // 
            this.iconLabel1.Image = ((System.Drawing.Image)(resources.GetObject("iconLabel1.Image")));
            this.iconLabel1.Location = new System.Drawing.Point(58, 32);
            this.iconLabel1.Name = "iconLabel1";
            this.iconLabel1.Size = new System.Drawing.Size(347, 339);
            this.iconLabel1.TabIndex = 9;
            this.iconLabel1.Visible = false;
            // 
            // iconLabel2
            // 
            this.iconLabel2.Image = ((System.Drawing.Image)(resources.GetObject("iconLabel2.Image")));
            this.iconLabel2.Location = new System.Drawing.Point(1017, 32);
            this.iconLabel2.Name = "iconLabel2";
            this.iconLabel2.Size = new System.Drawing.Size(347, 339);
            this.iconLabel2.TabIndex = 10;
            this.iconLabel2.Visible = false;
            // 
            // background
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(1303, 643);
            this.Controls.Add(this.iconLabel2);
            this.Controls.Add(this.iconLabel1);
            this.Controls.Add(this.radiationLabel);
            this.Controls.Add(this.enableButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.reactor2StateLabel);
            this.Controls.Add(this.reactor1StateLabel);
            this.Controls.Add(this.reactor1Label);
            this.Controls.Add(this.reactor2Label);
            this.Controls.Add(this.titleLabel);
            this.Name = "background";
            this.StartPosition = System.Windows.Forms.FormStartPosition.WindowsDefaultBounds;
            this.Text = "Springfield Nuclear Power Plant";
            this.Load += new System.EventHandler(this.background_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label reactor2Label;
        private System.Windows.Forms.Label reactor1Label;
        private System.Windows.Forms.Label reactor1StateLabel;
        private System.Windows.Forms.Label reactor2StateLabel;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button enableButton;
        private System.Windows.Forms.Label radiationLabel;
        private System.Windows.Forms.Label iconLabel1;
        private System.Windows.Forms.Label iconLabel2;
    }
}

