namespace TestOrganiser.ClassView
{
    partial class AssignmentEntry
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
            this.checkBox = new System.Windows.Forms.CheckBox();
            this.texxt = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // checkBox
            // 
            this.checkBox.AutoSize = true;
            this.checkBox.Dock = System.Windows.Forms.DockStyle.Right;
            this.checkBox.Location = new System.Drawing.Point(278, 0);
            this.checkBox.Name = "checkBox";
            this.checkBox.Size = new System.Drawing.Size(52, 30);
            this.checkBox.TabIndex = 0;
            this.checkBox.Text = "Done";
            this.checkBox.UseVisualStyleBackColor = true;
            // 
            // texxt
            // 
            this.texxt.AutoSize = true;
            this.texxt.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.texxt.Location = new System.Drawing.Point(3, 8);
            this.texxt.Name = "texxt";
            this.texxt.Size = new System.Drawing.Size(246, 13);
            this.texxt.TabIndex = 1;
            this.texxt.Text = "Some writing task or something | due: 21 March P4";
            // 
            // AssignmentEntry
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.texxt);
            this.Controls.Add(this.checkBox);
            this.Name = "AssignmentEntry";
            this.Size = new System.Drawing.Size(330, 30);
            this.Load += new System.EventHandler(this.AssignmentEntry_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox checkBox;
        private System.Windows.Forms.Label texxt;
    }
}
