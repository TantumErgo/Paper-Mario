namespace Paper_Mario
{
    partial class BattleFormDebug
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
            this.battleDebugPicturebox = new System.Windows.Forms.PictureBox();
            this.debugDisplayPictureButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.battleDebugPicturebox)).BeginInit();
            this.SuspendLayout();
            // 
            // battleDebugPicturebox
            // 
            this.battleDebugPicturebox.Location = new System.Drawing.Point(102, 68);
            this.battleDebugPicturebox.Name = "battleDebugPicturebox";
            this.battleDebugPicturebox.Size = new System.Drawing.Size(100, 50);
            this.battleDebugPicturebox.TabIndex = 0;
            this.battleDebugPicturebox.TabStop = false;
            // 
            // debugDisplayPictureButton
            // 
            this.debugDisplayPictureButton.Location = new System.Drawing.Point(301, 248);
            this.debugDisplayPictureButton.Name = "debugDisplayPictureButton";
            this.debugDisplayPictureButton.Size = new System.Drawing.Size(75, 55);
            this.debugDisplayPictureButton.TabIndex = 1;
            this.debugDisplayPictureButton.Text = "Display Picture";
            this.debugDisplayPictureButton.UseVisualStyleBackColor = true;
            this.debugDisplayPictureButton.Click += new System.EventHandler(this.debugDisplayPictureButton_Click);
            // 
            // BattleFormDebug
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 424);
            this.Controls.Add(this.debugDisplayPictureButton);
            this.Controls.Add(this.battleDebugPicturebox);
            this.Name = "BattleFormDebug";
            this.Text = "BattleFormDebug";
            ((System.ComponentModel.ISupportInitialize)(this.battleDebugPicturebox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox battleDebugPicturebox;
        private System.Windows.Forms.Button debugDisplayPictureButton;
    }
}