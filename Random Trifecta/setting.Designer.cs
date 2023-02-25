namespace Random_Trifecta
{
    partial class setting
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
            this.Top = new System.Windows.Forms.CheckBox();
            this.value_save = new System.Windows.Forms.RadioButton();
            this.value_reset = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.reset_num = new System.Windows.Forms.NumericUpDown();
            this.apply = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.Top_memo = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.reset_num)).BeginInit();
            this.SuspendLayout();
            // 
            // Top
            // 
            this.Top.AutoSize = true;
            this.Top.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Top.Location = new System.Drawing.Point(17, 53);
            this.Top.Name = "Top";
            this.Top.Size = new System.Drawing.Size(201, 20);
            this.Top.TabIndex = 0;
            this.Top.Text = "常にウィンドウを手前に表示";
            this.Top.UseVisualStyleBackColor = true;
            // 
            // value_save
            // 
            this.value_save.AutoSize = true;
            this.value_save.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.value_save.Location = new System.Drawing.Point(17, 164);
            this.value_save.Name = "value_save";
            this.value_save.Size = new System.Drawing.Size(168, 20);
            this.value_save.TabIndex = 1;
            this.value_save.TabStop = true;
            this.value_save.Text = "前回の数値を引き継ぐ";
            this.value_save.UseVisualStyleBackColor = true;
            this.value_save.CheckedChanged += new System.EventHandler(this.value_save_CheckedChanged);
            // 
            // value_reset
            // 
            this.value_reset.AutoSize = true;
            this.value_reset.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.value_reset.Location = new System.Drawing.Point(17, 199);
            this.value_reset.Name = "value_reset";
            this.value_reset.Size = new System.Drawing.Size(169, 20);
            this.value_reset.TabIndex = 2;
            this.value_reset.TabStop = true;
            this.value_reset.Text = "設定した数値にリセット";
            this.value_reset.UseVisualStyleBackColor = true;
            this.value_reset.CheckedChanged += new System.EventHandler(this.value_reset_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(129, 29);
            this.label1.TabIndex = 3;
            this.label1.Text = "画面設定";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(14, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 29);
            this.label2.TabIndex = 4;
            this.label2.Text = "数値設定";
            // 
            // reset_num
            // 
            this.reset_num.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset_num.Location = new System.Drawing.Point(36, 225);
            this.reset_num.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.reset_num.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.reset_num.Name = "reset_num";
            this.reset_num.Size = new System.Drawing.Size(56, 23);
            this.reset_num.TabIndex = 5;
            this.reset_num.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            // 
            // apply
            // 
            this.apply.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.apply.Location = new System.Drawing.Point(181, 256);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(59, 27);
            this.apply.TabIndex = 6;
            this.apply.Text = "保存";
            this.apply.UseVisualStyleBackColor = true;
            this.apply.Click += new System.EventHandler(this.apply_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(50, 270);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(125, 13);
            this.label3.TabIndex = 7;
            this.label3.Text = "再起動で適用されます";
            // 
            // Top_memo
            // 
            this.Top_memo.AutoSize = true;
            this.Top_memo.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.Top_memo.Location = new System.Drawing.Point(17, 83);
            this.Top_memo.Name = "Top_memo";
            this.Top_memo.Size = new System.Drawing.Size(240, 20);
            this.Top_memo.TabIndex = 8;
            this.Top_memo.Text = "常にウィンドウを手前に表示（メモ）";
            this.Top_memo.UseVisualStyleBackColor = true;
            // 
            // setting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(261, 292);
            this.Controls.Add(this.Top_memo);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.apply);
            this.Controls.Add(this.reset_num);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.value_reset);
            this.Controls.Add(this.value_save);
            this.Controls.Add(this.Top);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "setting";
            this.ShowIcon = false;
            this.Text = "設定";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.setting_Load);
            ((System.ComponentModel.ISupportInitialize)(this.reset_num)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox Top;
        private System.Windows.Forms.RadioButton value_save;
        private System.Windows.Forms.RadioButton value_reset;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown reset_num;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox Top_memo;
    }
}