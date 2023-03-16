namespace App
{
    partial class AdminForm
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
            this.components = new System.ComponentModel.Container();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.userRole = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.nameUserName = new System.Windows.Forms.Label();
            this.booksBtn = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::App.Properties.Resources.admin;
            this.pictureBox1.Location = new System.Drawing.Point(243, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(268, 242);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // userRole
            // 
            this.userRole.AutoSize = true;
            this.userRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userRole.Location = new System.Drawing.Point(394, 15);
            this.userRole.Name = "userRole";
            this.userRole.Size = new System.Drawing.Size(148, 37);
            this.userRole.TabIndex = 3;
            this.userRole.Text = "UserRole";
            this.userRole.Click += new System.EventHandler(this.nameLabel_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(210, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 37);
            this.label1.TabIndex = 4;
            this.label1.Text = "Ваша роль:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // nameUserName
            // 
            this.nameUserName.AutoSize = true;
            this.nameUserName.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.nameUserName.Location = new System.Drawing.Point(236, 331);
            this.nameUserName.Name = "nameUserName";
            this.nameUserName.Size = new System.Drawing.Size(144, 31);
            this.nameUserName.TabIndex = 5;
            this.nameUserName.Text = "UserName";
            this.nameUserName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // booksBtn
            // 
            this.booksBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.booksBtn.Location = new System.Drawing.Point(12, 400);
            this.booksBtn.Name = "booksBtn";
            this.booksBtn.Size = new System.Drawing.Size(157, 38);
            this.booksBtn.TabIndex = 6;
            this.booksBtn.Text = "Таблицы";
            this.booksBtn.UseVisualStyleBackColor = true;
            this.booksBtn.Click += new System.EventHandler(this.booksBtn_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(631, 400);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 38);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выйти";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // AdminForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.booksBtn);
            this.Controls.Add(this.nameUserName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.userRole);
            this.Controls.Add(this.pictureBox1);
            this.Name = "AdminForm";
            this.Text = "AdminForm";
            this.Load += new System.EventHandler(this.AdminForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label userRole;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label nameUserName;
        private System.Windows.Forms.Button booksBtn;
        private System.Windows.Forms.Button button1;
    }
}