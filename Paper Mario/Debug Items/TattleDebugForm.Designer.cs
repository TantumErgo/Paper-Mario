namespace Paper_Mario
{
    partial class TattleDebugForm
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
            this.tattleTestButton = new System.Windows.Forms.Button();
            this.tattleLogDebugButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // tattleTestButton
            // 
            this.tattleTestButton.Location = new System.Drawing.Point(101, 108);
            this.tattleTestButton.Name = "tattleTestButton";
            this.tattleTestButton.Size = new System.Drawing.Size(75, 23);
            this.tattleTestButton.TabIndex = 0;
            this.tattleTestButton.Text = "Tattle";
            this.tattleTestButton.UseVisualStyleBackColor = true;
            //this.tattleTestButton.Click += new System.EventHandler(this.tattleTestButton_Click);
            // 
            // tattleLogDebugButton
            // 
            this.tattleLogDebugButton.Location = new System.Drawing.Point(101, 169);
            this.tattleLogDebugButton.Name = "tattleLogDebugButton";
            this.tattleLogDebugButton.Size = new System.Drawing.Size(75, 23);
            this.tattleLogDebugButton.TabIndex = 1;
            this.tattleLogDebugButton.Text = "Tattle Log";
            this.tattleLogDebugButton.UseVisualStyleBackColor = true;
            this.tattleLogDebugButton.Click += new System.EventHandler(this.tattleLogDebugButton_Click);
            // 
            // TattleDebugForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.tattleLogDebugButton);
            this.Controls.Add(this.tattleTestButton);
            this.Name = "TattleDebugForm";
            this.Text = "TattleDebugForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button tattleTestButton;
        private System.Windows.Forms.Button tattleLogDebugButton;
    }
}