namespace Random_Trifecta
{
    partial class memo
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
            this.memo_list = new System.Windows.Forms.ListBox();
            this.remove = new System.Windows.Forms.Button();
            this.reset = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // memo_list
            // 
            this.memo_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.memo_list.Font = new System.Drawing.Font("MS UI Gothic", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memo_list.FormattingEnabled = true;
            this.memo_list.ItemHeight = 37;
            this.memo_list.Location = new System.Drawing.Point(7, 7);
            this.memo_list.Name = "memo_list";
            this.memo_list.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.memo_list.Size = new System.Drawing.Size(161, 263);
            this.memo_list.TabIndex = 0;
            // 
            // remove
            // 
            this.remove.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.remove.Location = new System.Drawing.Point(12, 276);
            this.remove.Name = "remove";
            this.remove.Size = new System.Drawing.Size(72, 29);
            this.remove.TabIndex = 1;
            this.remove.Text = "削除";
            this.remove.UseVisualStyleBackColor = true;
            this.remove.Click += new System.EventHandler(this.remove_Click);
            // 
            // reset
            // 
            this.reset.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.reset.ForeColor = System.Drawing.Color.Red;
            this.reset.Location = new System.Drawing.Point(92, 276);
            this.reset.Name = "reset";
            this.reset.Size = new System.Drawing.Size(72, 29);
            this.reset.TabIndex = 2;
            this.reset.Text = "リセット";
            this.reset.UseVisualStyleBackColor = true;
            this.reset.Click += new System.EventHandler(this.reset_Click);
            // 
            // memo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(176, 312);
            this.Controls.Add(this.reset);
            this.Controls.Add(this.remove);
            this.Controls.Add(this.memo_list);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(192, 351);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(192, 351);
            this.Name = "memo";
            this.ShowIcon = false;
            this.Text = "記録";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.memo_FormClosing);
            this.Load += new System.EventHandler(this.memo_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button remove;
        private System.Windows.Forms.Button reset;
        public System.Windows.Forms.ListBox memo_list;
    }
}