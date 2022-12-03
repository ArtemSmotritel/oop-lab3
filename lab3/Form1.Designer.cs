namespace lab3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.circle_button = new System.Windows.Forms.Button();
            this.square_button = new System.Windows.Forms.Button();
            this.rhomb_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // circle_button
            // 
            this.circle_button.Location = new System.Drawing.Point(12, 12);
            this.circle_button.Name = "circle_button";
            this.circle_button.Size = new System.Drawing.Size(94, 29);
            this.circle_button.TabIndex = 0;
            this.circle_button.Text = "run circle";
            this.circle_button.UseVisualStyleBackColor = true;
            this.circle_button.Click += new System.EventHandler(this.circle_button_Click);
            // 
            // square_button
            // 
            this.square_button.Location = new System.Drawing.Point(112, 12);
            this.square_button.Name = "square_button";
            this.square_button.Size = new System.Drawing.Size(94, 29);
            this.square_button.TabIndex = 1;
            this.square_button.Text = "run square";
            this.square_button.UseVisualStyleBackColor = true;
            this.square_button.Click += new System.EventHandler(this.square_button_Click);
            // 
            // rhomb_button
            // 
            this.rhomb_button.Location = new System.Drawing.Point(212, 12);
            this.rhomb_button.Name = "rhomb_button";
            this.rhomb_button.Size = new System.Drawing.Size(94, 29);
            this.rhomb_button.TabIndex = 2;
            this.rhomb_button.Text = "run rhomb";
            this.rhomb_button.UseVisualStyleBackColor = true;
            this.rhomb_button.Click += new System.EventHandler(this.rhomb_button_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(998, 582);
            this.Controls.Add(this.rhomb_button);
            this.Controls.Add(this.square_button);
            this.Controls.Add(this.circle_button);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button circle_button;
        private Button square_button;
        private Button rhomb_button;
    }
}