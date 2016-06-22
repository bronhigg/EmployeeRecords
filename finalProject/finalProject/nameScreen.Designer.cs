namespace finalProject
{
    partial class nameScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nameBox = new System.Windows.Forms.TextBox();
            this.confirmName = new System.Windows.Forms.Button();
            this.tlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // nameBox
            // 
            this.nameBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(291, 353);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(219, 31);
            this.nameBox.TabIndex = 0;
            this.nameBox.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameBox_MouseClick);
            // 
            // confirmName
            // 
            this.confirmName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.confirmName.Location = new System.Drawing.Point(309, 186);
            this.confirmName.Name = "confirmName";
            this.confirmName.Size = new System.Drawing.Size(180, 60);
            this.confirmName.TabIndex = 1;
            this.confirmName.Text = "Confirm Name";
            this.confirmName.UseVisualStyleBackColor = true;
            this.confirmName.Click += new System.EventHandler(this.button1_Click);
            // 
            // tlabel
            // 
            this.tlabel.AutoSize = true;
            this.tlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tlabel.Location = new System.Drawing.Point(228, 41);
            this.tlabel.Name = "tlabel";
            this.tlabel.Size = new System.Drawing.Size(353, 51);
            this.tlabel.TabIndex = 2;
            this.tlabel.Text = "Bob Ross Clicker";
            // 
            // nameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::finalProject.Properties.Resources.nameScreen;
            this.Controls.Add(this.tlabel);
            this.Controls.Add(this.confirmName);
            this.Controls.Add(this.nameBox);
            this.Name = "nameScreen";
            this.Size = new System.Drawing.Size(800, 800);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.nameScreen_MouseClick);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button confirmName;
        private System.Windows.Forms.Label tlabel;
    }
}
