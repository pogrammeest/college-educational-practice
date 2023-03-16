namespace App
{
    partial class Otchet
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
            this.chartTypeRB = new System.Windows.Forms.RadioButton();
            this.tableTypeRB = new System.Windows.Forms.RadioButton();
            this.exitBtn = new System.Windows.Forms.Button();
            this.previewDGV = new System.Windows.Forms.DataGridView();
            this.saveToExcelBtn = new System.Windows.Forms.Button();
            this.saveToPdfBtn = new System.Windows.Forms.Button();
            this.kindCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.endDTP = new System.Windows.Forms.DateTimePicker();
            this.startDTP = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.previewDGV)).BeginInit();
            this.SuspendLayout();
            // 
            // chartTypeRB
            // 
            this.chartTypeRB.AutoSize = true;
            this.chartTypeRB.Location = new System.Drawing.Point(614, 42);
            this.chartTypeRB.Name = "chartTypeRB";
            this.chartTypeRB.Size = new System.Drawing.Size(63, 17);
            this.chartTypeRB.TabIndex = 26;
            this.chartTypeRB.TabStop = true;
            this.chartTypeRB.Text = "График";
            this.chartTypeRB.UseVisualStyleBackColor = true;
            // 
            // tableTypeRB
            // 
            this.tableTypeRB.AutoSize = true;
            this.tableTypeRB.Location = new System.Drawing.Point(540, 42);
            this.tableTypeRB.Name = "tableTypeRB";
            this.tableTypeRB.Size = new System.Drawing.Size(68, 17);
            this.tableTypeRB.TabIndex = 25;
            this.tableTypeRB.TabStop = true;
            this.tableTypeRB.Text = "Таблица";
            this.tableTypeRB.UseVisualStyleBackColor = true;
            // 
            // exitBtn
            // 
            this.exitBtn.Location = new System.Drawing.Point(713, 417);
            this.exitBtn.Name = "exitBtn";
            this.exitBtn.Size = new System.Drawing.Size(75, 23);
            this.exitBtn.TabIndex = 24;
            this.exitBtn.Text = "Выйти";
            this.exitBtn.UseVisualStyleBackColor = true;
            // 
            // previewDGV
            // 
            this.previewDGV.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.previewDGV.Location = new System.Drawing.Point(12, 68);
            this.previewDGV.Name = "previewDGV";
            this.previewDGV.Size = new System.Drawing.Size(776, 343);
            this.previewDGV.TabIndex = 23;
            // 
            // saveToExcelBtn
            // 
            this.saveToExcelBtn.Location = new System.Drawing.Point(142, 417);
            this.saveToExcelBtn.Name = "saveToExcelBtn";
            this.saveToExcelBtn.Size = new System.Drawing.Size(117, 23);
            this.saveToExcelBtn.TabIndex = 22;
            this.saveToExcelBtn.Text = "Сохранить в Excel";
            this.saveToExcelBtn.UseVisualStyleBackColor = true;
            // 
            // saveToPdfBtn
            // 
            this.saveToPdfBtn.Location = new System.Drawing.Point(12, 417);
            this.saveToPdfBtn.Name = "saveToPdfBtn";
            this.saveToPdfBtn.Size = new System.Drawing.Size(117, 23);
            this.saveToPdfBtn.TabIndex = 21;
            this.saveToPdfBtn.Text = "Сохранить в PDF";
            this.saveToPdfBtn.UseVisualStyleBackColor = true;
            // 
            // kindCB
            // 
            this.kindCB.FormattingEnabled = true;
            this.kindCB.Location = new System.Drawing.Point(539, 14);
            this.kindCB.Name = "kindCB";
            this.kindCB.Size = new System.Drawing.Size(249, 21);
            this.kindCB.TabIndex = 20;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(471, 44);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 19;
            this.label4.Text = "Тип отчёта:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Вид отчёта:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(238, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(21, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "По";
            // 
            // endDTP
            // 
            this.endDTP.Location = new System.Drawing.Point(265, 11);
            this.endDTP.Name = "endDTP";
            this.endDTP.Size = new System.Drawing.Size(200, 20);
            this.endDTP.TabIndex = 16;
            // 
            // startDTP
            // 
            this.startDTP.Location = new System.Drawing.Point(32, 11);
            this.startDTP.Name = "startDTP";
            this.startDTP.Size = new System.Drawing.Size(200, 20);
            this.startDTP.TabIndex = 15;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(14, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "С";
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.chartTypeRB);
            this.Controls.Add(this.tableTypeRB);
            this.Controls.Add(this.exitBtn);
            this.Controls.Add(this.previewDGV);
            this.Controls.Add(this.saveToExcelBtn);
            this.Controls.Add(this.saveToPdfBtn);
            this.Controls.Add(this.kindCB);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.endDTP);
            this.Controls.Add(this.startDTP);
            this.Controls.Add(this.label1);
            this.Name = "Otchet";
            this.Text = "Otchet";
            ((System.ComponentModel.ISupportInitialize)(this.previewDGV)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton chartTypeRB;
        private System.Windows.Forms.RadioButton tableTypeRB;
        private System.Windows.Forms.Button exitBtn;
        private System.Windows.Forms.DataGridView previewDGV;
        private System.Windows.Forms.Button saveToExcelBtn;
        private System.Windows.Forms.Button saveToPdfBtn;
        private System.Windows.Forms.ComboBox kindCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker endDTP;
        private System.Windows.Forms.DateTimePicker startDTP;
        private System.Windows.Forms.Label label1;
    }
}