namespace BakuLondonTask
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
            this.Time = new System.Windows.Forms.Button();
            this.clock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Time
            // 
            this.Time.FlatAppearance.BorderColor = System.Drawing.Color.DarkGray;
            this.Time.Location = new System.Drawing.Point(327, 173);
            this.Time.Name = "Time";
            this.Time.Size = new System.Drawing.Size(129, 54);
            this.Time.TabIndex = 1;
            this.Time.Text = "London";
            this.Time.UseVisualStyleBackColor = true;
            this.Time.Click += new System.EventHandler(this.Time_Click);
            // 
            // clock
            // 
            this.clock.Location = new System.Drawing.Point(343, 78);
            this.clock.Name = "clock";
            this.clock.Size = new System.Drawing.Size(83, 47);
            this.clock.TabIndex = 3;
            this.clock.Text = "label1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.clock);
            this.Controls.Add(this.Time);
            this.Name = "Form1";
            this.Text = "Clock";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Time;
        private System.Windows.Forms.Label clock;
    }
}

