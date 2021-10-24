
namespace Game
{
    partial class FrStart
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrStart));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.btstart = new System.Windows.Forms.Button();
            this.lable1 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnHistory = new System.Windows.Forms.Button();
            this.lbHistory = new System.Windows.Forms.ListBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox2.Location = new System.Drawing.Point(0, 341);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(848, 161);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 0;
            this.pictureBox2.TabStop = false;
            // 
            // btstart
            // 
            this.btstart.Cursor = System.Windows.Forms.Cursors.PanNW;
            this.btstart.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btstart.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btstart.Location = new System.Drawing.Point(610, 167);
            this.btstart.Name = "btstart";
            this.btstart.Size = new System.Drawing.Size(226, 76);
            this.btstart.TabIndex = 1;
            this.btstart.Text = "Start";
            this.btstart.UseVisualStyleBackColor = true;
            this.btstart.Click += new System.EventHandler(this.btstart_Click);
            // 
            // lable1
            // 
            this.lable1.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lable1.Location = new System.Drawing.Point(13, 191);
            this.lable1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lable1.Name = "lable1";
            this.lable1.Size = new System.Drawing.Size(267, 64);
            this.lable1.TabIndex = 3;
            this.lable1.Text = "Enter Name:";
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.txtName.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.txtName.Location = new System.Drawing.Point(13, 259);
            this.txtName.Margin = new System.Windows.Forms.Padding(4);
            this.txtName.Multiline = true;
            this.txtName.Name = "txtName";
            this.txtName.PlaceholderText = "Enter up to 10 characters";
            this.txtName.Size = new System.Drawing.Size(469, 55);
            this.txtName.TabIndex = 4;
            this.txtName.TextChanged += new System.EventHandler(this.txtName_TextChanged);
            // 
            // btnHistory
            // 
            this.btnHistory.Font = new System.Drawing.Font("Snap ITC", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnHistory.Location = new System.Drawing.Point(609, 250);
            this.btnHistory.Margin = new System.Windows.Forms.Padding(4);
            this.btnHistory.Name = "btnHistory";
            this.btnHistory.Size = new System.Drawing.Size(226, 76);
            this.btnHistory.TabIndex = 6;
            this.btnHistory.Text = "History";
            this.btnHistory.UseVisualStyleBackColor = true;
            this.btnHistory.Click += new System.EventHandler(this.btnHistory_Click);
            // 
            // lbHistory
            // 
            this.lbHistory.FormattingEnabled = true;
            this.lbHistory.HorizontalScrollbar = true;
            this.lbHistory.ItemHeight = 30;
            this.lbHistory.Location = new System.Drawing.Point(13, 13);
            this.lbHistory.Margin = new System.Windows.Forms.Padding(4);
            this.lbHistory.Name = "lbHistory";
            this.lbHistory.ScrollAlwaysVisible = true;
            this.lbHistory.SelectionMode = System.Windows.Forms.SelectionMode.None;
            this.lbHistory.Size = new System.Drawing.Size(576, 454);
            this.lbHistory.TabIndex = 8;
            this.lbHistory.Visible = false;
            // 
            // FrStart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(848, 502);
            this.Controls.Add(this.lbHistory);
            this.Controls.Add(this.btnHistory);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lable1);
            this.Controls.Add(this.btstart);
            this.Controls.Add(this.pictureBox2);
            this.Name = "FrStart";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "startgame";
            this.Load += new System.EventHandler(this.startgame_Load);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.startgame_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button btstart;
        private System.Windows.Forms.Label lable1;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnHistory;
        private System.Windows.Forms.ListBox lbHistory;
    }
}