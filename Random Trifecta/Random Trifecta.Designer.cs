using System.Windows.Forms;

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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.box = new System.Windows.Forms.PictureBox();
            this.lock1 = new System.Windows.Forms.Label();
            this.lock2 = new System.Windows.Forms.Label();
            this.lock3 = new System.Windows.Forms.Label();
            this.select = new System.Windows.Forms.Button();
            this.lift = new System.Windows.Forms.Button();
            this.num1 = new System.Windows.Forms.Label();
            this.num2 = new System.Windows.Forms.Label();
            this.num3 = new System.Windows.Forms.Label();
            this.setting_button = new System.Windows.Forms.Button();
            this.list = new System.Windows.Forms.CheckedListBox();
            this.memo = new System.Windows.Forms.Button();
            this.generate = new System.Windows.Forms.Button();
            this.value = new System.Windows.Forms.NumericUpDown();
            this.memo_img = new System.Windows.Forms.Label();
            this.memo_button = new System.Windows.Forms.Button();
            this.reset_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.box)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.value)).BeginInit();
            this.SuspendLayout();
            // 
            // box
            // 
            this.box.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.box.Location = new System.Drawing.Point(167, 91);
            this.box.Name = "box";
            this.box.Size = new System.Drawing.Size(416, 88);
            this.box.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.box.TabIndex = 1;
            this.box.TabStop = false;
            this.box.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.Box_MouseDoubleClick);
            // 
            // lock1
            // 
            this.lock1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lock1.AutoSize = true;
            this.lock1.BackColor = System.Drawing.Color.Transparent;
            this.lock1.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock1.Location = new System.Drawing.Point(180, 25);
            this.lock1.Name = "lock1";
            this.lock1.Size = new System.Drawing.Size(62, 48);
            this.lock1.TabIndex = 2;
            this.lock1.Text = "🔒";
            this.lock1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock1.Visible = false;
            // 
            // lock2
            // 
            this.lock2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lock2.AutoSize = true;
            this.lock2.BackColor = System.Drawing.Color.Transparent;
            this.lock2.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock2.Location = new System.Drawing.Point(180, 25);
            this.lock2.Name = "lock2";
            this.lock2.Size = new System.Drawing.Size(62, 48);
            this.lock2.TabIndex = 3;
            this.lock2.Text = "🔒";
            this.lock2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock2.Visible = false;
            // 
            // lock3
            // 
            this.lock3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.lock3.AutoSize = true;
            this.lock3.BackColor = System.Drawing.Color.Transparent;
            this.lock3.Font = new System.Drawing.Font("MS UI Gothic", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.lock3.Location = new System.Drawing.Point(180, 25);
            this.lock3.Name = "lock3";
            this.lock3.Size = new System.Drawing.Size(62, 48);
            this.lock3.TabIndex = 4;
            this.lock3.Text = "🔒";
            this.lock3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lock3.Visible = false;
            // 
            // select
            // 
            this.select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.select.Location = new System.Drawing.Point(16, 312);
            this.select.Name = "select";
            this.select.Size = new System.Drawing.Size(44, 23);
            this.select.TabIndex = 7;
            this.select.Text = "選択";
            this.select.UseVisualStyleBackColor = true;
            this.select.Click += new System.EventHandler(this.select_Click);
            // 
            // lift
            // 
            this.lift.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lift.Location = new System.Drawing.Point(66, 312);
            this.lift.Name = "lift";
            this.lift.Size = new System.Drawing.Size(44, 23);
            this.lift.TabIndex = 8;
            this.lift.Text = "解除";
            this.lift.UseVisualStyleBackColor = true;
            this.lift.Click += new System.EventHandler(this.lift_Click);
            // 
            // num1
            // 
            this.num1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num1.BackColor = System.Drawing.Color.Transparent;
            this.num1.CausesValidation = false;
            this.num1.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num1.Location = new System.Drawing.Point(156, 92);
            this.num1.Name = "num1";
            this.num1.Size = new System.Drawing.Size(114, 84);
            this.num1.TabIndex = 9;
            this.num1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num1.Visible = false;
            this.num1.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num1_MouseDoubleClick);
            // 
            // num2
            // 
            this.num2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num2.BackColor = System.Drawing.Color.Transparent;
            this.num2.CausesValidation = false;
            this.num2.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num2.Location = new System.Drawing.Point(313, 92);
            this.num2.Name = "num2";
            this.num2.Size = new System.Drawing.Size(114, 84);
            this.num2.TabIndex = 10;
            this.num2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num2.Visible = false;
            this.num2.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num2_MouseDoubleClick);
            // 
            // num3
            // 
            this.num3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.num3.BackColor = System.Drawing.Color.Transparent;
            this.num3.CausesValidation = false;
            this.num3.Font = new System.Drawing.Font("MS UI Gothic", 60F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.num3.Location = new System.Drawing.Point(471, 92);
            this.num3.Name = "num3";
            this.num3.Size = new System.Drawing.Size(114, 84);
            this.num3.TabIndex = 11;
            this.num3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.num3.Visible = false;
            this.num3.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.num3_MouseDoubleClick);
            // 
            // setting_button
            // 
            this.setting_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.setting_button.Font = new System.Drawing.Font("MS UI Gothic", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.setting_button.Location = new System.Drawing.Point(589, -12);
            this.setting_button.Name = "setting_button";
            this.setting_button.Size = new System.Drawing.Size(43, 49);
            this.setting_button.TabIndex = 12;
            this.setting_button.Text = "⚙";
            this.setting_button.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.setting_button.UseVisualStyleBackColor = true;
            this.setting_button.Click += new System.EventHandler(this.setting_button_Click);
            // 
            // list
            // 
            this.list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.list.Cursor = System.Windows.Forms.Cursors.Default;
            this.list.Font = new System.Drawing.Font("MS UI Gothic", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.list.FormattingEnabled = true;
            this.list.Location = new System.Drawing.Point(12, 12);
            this.list.Name = "list";
            this.list.Size = new System.Drawing.Size(103, 294);
            this.list.TabIndex = 0;
            // 
            // memo
            // 
            this.memo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.memo.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memo.Location = new System.Drawing.Point(589, 24);
            this.memo.Name = "memo";
            this.memo.Size = new System.Drawing.Size(43, 49);
            this.memo.TabIndex = 13;
            this.memo.Text = "📝";
            this.memo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.memo.UseVisualStyleBackColor = true;
            this.memo.Click += new System.EventHandler(this.Memo_Click);
            // 
            // generate
            // 
            this.generate.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.generate.AutoSize = true;
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
            this.value.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.value.AutoSize = true;
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
            this.value.Size = new System.Drawing.Size(107, 71);
            this.value.TabIndex = 6;
            this.value.Value = new decimal(new int[] {
            18,
            0,
            0,
            0});
            this.value.ValueChanged += new System.EventHandler(this.value_ValueChanged);
            // 
            // memo_img
            // 
            this.memo_img.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.memo_img.AutoSize = true;
            this.memo_img.Font = new System.Drawing.Font("MS UI Gothic", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memo_img.Location = new System.Drawing.Point(302, 218);
            this.memo_img.Name = "memo_img";
            this.memo_img.Size = new System.Drawing.Size(91, 64);
            this.memo_img.TabIndex = 15;
            this.memo_img.Text = "✍";
            // 
            // memo_button
            // 
            this.memo_button.Anchor = System.Windows.Forms.AnchorStyles.Bottom;
            this.memo_button.AutoSize = true;
            this.memo_button.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.memo_button.Location = new System.Drawing.Point(309, 272);
            this.memo_button.Name = "memo_button";
            this.memo_button.Size = new System.Drawing.Size(74, 34);
            this.memo_button.TabIndex = 14;
            this.memo_button.Text = "記録";
            this.memo_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.memo_button.UseVisualStyleBackColor = true;
            this.memo_button.Click += new System.EventHandler(this.memo_button_Click);
            // 
            // reset_button
            // 
            this.reset_button.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.reset_button.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.reset_button.ForeColor = System.Drawing.Color.Red;
            this.reset_button.Location = new System.Drawing.Point(589, 313);
            this.reset_button.Name = "reset_button";
            this.reset_button.Size = new System.Drawing.Size(43, 49);
            this.reset_button.TabIndex = 16;
            this.reset_button.Text = "↻";
            this.reset_button.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.reset_button.UseVisualStyleBackColor = true;
            this.reset_button.Click += new System.EventHandler(this.reset_button_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(627, 351);
            this.Controls.Add(this.reset_button);
            this.Controls.Add(this.memo_button);
            this.Controls.Add(this.memo_img);
            this.Controls.Add(this.setting_button);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.list);
            this.Controls.Add(this.lift);
            this.Controls.Add(this.select);
            this.Controls.Add(this.value);
            this.Controls.Add(this.generate);
            this.Controls.Add(this.lock3);
            this.Controls.Add(this.lock2);
            this.Controls.Add(this.lock1);
            this.Controls.Add(this.num3);
            this.Controls.Add(this.num2);
            this.Controls.Add(this.num1);
            this.Controls.Add(this.box);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimumSize = new System.Drawing.Size(643, 390);
            this.Name = "Main";
            this.Text = "Random Trifecta";
            this.TransparencyKey = System.Drawing.Color.Silver;
            this.Load += new System.EventHandler(this.Main_Load);
            this.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Main_MouseClick);
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
        private System.Windows.Forms.Button select;
        private System.Windows.Forms.Button lift;
        private System.Windows.Forms.Label num1;
        private System.Windows.Forms.Label num2;
        private System.Windows.Forms.Label num3;
        private Button setting_button;
        public CheckedListBox list;
        private Button memo;
        private Button generate;
        private NumericUpDown value;
        private Label memo_img;
        private Button memo_button;
        private Button reset_button;
    }
}

