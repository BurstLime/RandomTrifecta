namespace Random_Trifecta
{
    partial class Main
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージド リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.list = new System.Windows.Forms.CheckedListBox();
            this.box = new System.Windows.Forms.PictureBox();
            this.lock1 = new System.Windows.Forms.Label();
            this.lock2 = new System.Windows.Forms.Label();
            this.lock3 = new System.Windows.Forms.Label();
            this.generate = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.select = new System.Windows.Forms.Button();
            this.lift = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.SuspendLayout();
            // 
            // list
            // 
            this.list.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(103, 294);
            this.list.TabIndex = 0;
            // 
            // box
            // 
            this.box.Location = new System.Drawing.Point(167, 73);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(416, 88);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.box.TabIndex = 1;
            this.box.TabStop = false;
            this.box.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDoubleClick);
            // 
            // lock1
            // 
            this.lock1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lock1.AutoSize = true;
            this.lock1.BackColor = System.Drawing.Color.Transparent;
            this.lock1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock1.Location = new System.Drawing.Point(179, 12);
            this.lock1.Name = "lock1";
            this.lock1.Size = new System.Drawing.Size(62, 48);
            this.lock1.TabIndex = 2;
            this.lock1.Text = "🔒";
            this.lock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock1.Visible = false;
            // 
            // lock2
            // 
            this.lock2.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lock2.AutoSize = true;
            this.lock2.BackColor = System.Drawing.Color.Transparent;
            this.lock2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock2.Location = new System.Drawing.Point(179, 12);
            this.lock2.Name = "lock2";
            this.lock2.Size = new System.Drawing.Size(62, 48);
            this.lock2.TabIndex = 3;
            this.lock2.Text = "🔒";
            this.lock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock2.Visible = false;
            // 
            // lock3
            // 
            this.lock3.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lock3.AutoSize = true;
            this.lock3.BackColor = System.Drawing.Color.Transparent;
            this.lock3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock3.Location = new System.Drawing.Point(179, 12);
            this.lock3.Name = "lock3";
            this.lock3.Size = new System.Drawing.Size(62, 48);
            this.lock3.TabIndex = 4;
            this.lock3.Text = "🔒";
            this.lock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock3.Visible = false;
            // 
            // generate
            // 
            this.generate.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.generate.Location = new System.Drawing.Point(413, 235);
            this.generate.Name = "generate";
            this.generate.Size = new System.Drawing.Size(159, 71);
            this.generate.TabIndex = 5;
            this.generate.Text = "生成";
            this.generate.UseVisualStyleBackColor = true;
            this.generate.Click += new System.EventHandler(this.generate_Click);
            // 
            // value
            // 
            this.value.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.value.Location = new System.Drawing.Point(167, 235);
            this.value.Maximum = new decimal(new int[] {
            99,
            0,
            0,
            0});
            this.value.Minimum = new decimal(new int[] {
            3,
            0,
            0,
            0});
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(90, 71);
            this.value.TabIndex = 6;
            this.value.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.value.ValueChanged += new System.EventHandler(this.value_ValueChanged);
            // 
            // select
            // 
            this.select.Location = new System.Drawing.Point(15, 312);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(44, 23);
            this.select.TabIndex = 7;
            this.select.Text = "選択";
            this.select.UseVisualStyleBackColor = true;
            // 
            // lift
            // 
            this.lift.Location = new System.Drawing.Point(65, 312);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(44, 23);
            this.lift.TabIndex = 8;
            this.lift.Text = "解除";
            this.lift.UseVisualStyleBackColor = true;
            // 
            // num1
            // 
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.CausesValidation = false;
            this.num1.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num1.Location = new System.Drawing.Point(156, 74);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(114, 84);
            this.num1.TabIndex = 9;
            this.num1.Text = "1";
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1.Visible = false;
            this.num1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num1_MouseDoubleClick);
            // 
            // num2
            // 
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.CausesValidation = false;
            this.num2.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num2.Location = new System.Drawing.Point(315, 74);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(114, 84);
            this.num2.TabIndex = 10;
            this.num2.Text = "2";
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2.Visible = false;
            this.num2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num2_MouseDoubleClick);
            // 
            // num3
            // 
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.CausesValidation = false;
            this.num3.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num3.Location = new System.Drawing.Point(473, 74);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(114, 84);
            this.num3.TabIndex = 11;
            this.num3.Text = "3";
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3.Visible = false;
            this.num3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num3_MouseDoubleClick);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(627, 343);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.select);
            this.Controls.Add(this.value);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.lock3);
            this.Controls.Add(this.lock2);
            this.Controls.Add(this.lock1);
            this.Controls.Add(this.list);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.box);
            this.Name = "Main";
            this.ShowIcon = false;
            this.Text = "Random Trifecta";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Main_Load);
            ((System.ComponentModel.ISupportInitialize)(this.box)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        public System.Windows.Forms.PictureBox box;
        private System.Windows.Forms.Label lock1;
        private System.Windows.Forms.Label lock2;
        private System.Windows.Forms.Label lock3;
        private System.Windows.Forms.Button generate;
        private System.Windows.Forms.NumericUpDown value;
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button lift;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        public System.Windows.Forms.CheckedListBox list;
    }
}

