namespace MotionSimulator.Main
{
    partial class Simulator
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
            this.glSimulation = new OpenTK.GLControl();
            this.SuspendLayout();
            // 
            // glSimulation
            // 
            this.glSimulation.BackColor = System.Drawing.Color.Black;
            this.glSimulation.Location = new System.Drawing.Point(12, 12);
            this.glSimulation.Name = "glSimulation";
            this.glSimulation.Size = new System.Drawing.Size(760, 538);
            this.glSimulation.TabIndex = 0;
            this.glSimulation.VSync = false;
            this.glSimulation.Load += new System.EventHandler(this.glSimulation_Load);
            this.glSimulation.Paint += new System.Windows.Forms.PaintEventHandler(this.glSimulation_Paint);
            this.glSimulation.KeyDown += new System.Windows.Forms.KeyEventHandler(this.glSimulation_KeyDown);
            // 
            // Simulator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 562);
            this.Controls.Add(this.glSimulation);
            this.Name = "Simulator";
            this.Text = "Simulator";
            this.ResumeLayout(false);

        }

        #endregion

        private OpenTK.GLControl glSimulation;

    }
}