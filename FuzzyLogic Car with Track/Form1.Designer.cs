namespace FuzzyLogic_Car_with_Track
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
            this.temperatureTrackBar = new System.Windows.Forms.TrackBar();
            this.waterLevelTrackbar = new System.Windows.Forms.TrackBar();
            this.temperatureLabel = new System.Windows.Forms.Label();
            this.waterLevelLabel = new System.Windows.Forms.Label();
            this.heatKnobLabel = new System.Windows.Forms.Label();
            this.statusLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.temperatureTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevelTrackbar)).BeginInit();
            this.SuspendLayout();
            // 
            // temperatureTrackBar
            // 
            this.temperatureTrackBar.Location = new System.Drawing.Point(12, 25);
            this.temperatureTrackBar.Maximum = 100;
            this.temperatureTrackBar.Name = "temperatureTrackBar";
            this.temperatureTrackBar.Size = new System.Drawing.Size(304, 45);
            this.temperatureTrackBar.TabIndex = 0;
            this.temperatureTrackBar.Value = 15;
            this.temperatureTrackBar.ValueChanged += new System.EventHandler(this.temperatureTrackBar_ValueChanged);
            // 
            // waterLevelTrackbar
            // 
            this.waterLevelTrackbar.Location = new System.Drawing.Point(12, 95);
            this.waterLevelTrackbar.Name = "waterLevelTrackbar";
            this.waterLevelTrackbar.Size = new System.Drawing.Size(304, 45);
            this.waterLevelTrackbar.TabIndex = 1;
            this.waterLevelTrackbar.Value = 2;
            this.waterLevelTrackbar.ValueChanged += new System.EventHandler(this.waterLevelTrackbar_ValueChanged);
            // 
            // temperatureLabel
            // 
            this.temperatureLabel.AutoSize = true;
            this.temperatureLabel.Location = new System.Drawing.Point(113, 9);
            this.temperatureLabel.Name = "temperatureLabel";
            this.temperatureLabel.Size = new System.Drawing.Size(104, 13);
            this.temperatureLabel.TabIndex = 2;
            this.temperatureLabel.Text = "Temperature = 0.0 C";
            // 
            // waterLevelLabel
            // 
            this.waterLevelLabel.AutoSize = true;
            this.waterLevelLabel.Location = new System.Drawing.Point(116, 79);
            this.waterLevelLabel.Name = "waterLevelLabel";
            this.waterLevelLabel.Size = new System.Drawing.Size(101, 13);
            this.waterLevelLabel.TabIndex = 3;
            this.waterLevelLabel.Text = "Water Level = 0.0 L";
            // 
            // heatKnobLabel
            // 
            this.heatKnobLabel.AutoSize = true;
            this.heatKnobLabel.Location = new System.Drawing.Point(52, 179);
            this.heatKnobLabel.Name = "heatKnobLabel";
            this.heatKnobLabel.Size = new System.Drawing.Size(69, 13);
            this.heatKnobLabel.TabIndex = 4;
            this.heatKnobLabel.Text = "Heat knob = ";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(52, 212);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(56, 13);
            this.statusLabel.TabIndex = 5;
            this.statusLabel.Text = "Detection:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 261);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.heatKnobLabel);
            this.Controls.Add(this.waterLevelLabel);
            this.Controls.Add(this.temperatureLabel);
            this.Controls.Add(this.waterLevelTrackbar);
            this.Controls.Add(this.temperatureTrackBar);
            this.Name = "Form1";
            this.Text = "Fuzzy Set";
            ((System.ComponentModel.ISupportInitialize)(this.temperatureTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.waterLevelTrackbar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar temperatureTrackBar;
        private System.Windows.Forms.TrackBar waterLevelTrackbar;
        private System.Windows.Forms.Label temperatureLabel;
        private System.Windows.Forms.Label waterLevelLabel;
        private System.Windows.Forms.Label heatKnobLabel;
        private System.Windows.Forms.Label statusLabel;
    }
}

