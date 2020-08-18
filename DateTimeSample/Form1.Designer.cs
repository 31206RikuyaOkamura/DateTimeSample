namespace DateTimeSample
{
    partial class Form1
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
            this.btNow = new System.Windows.Forms.Button();
            this.tbNowDisp = new System.Windows.Forms.TextBox();
            this.nudDayBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.btBefore = new System.Windows.Forms.Button();
            this.btAfter = new System.Windows.Forms.Button();
            this.tbBeforeAfterDisp = new System.Windows.Forms.TextBox();
            this.nudMonthBeforeAfter = new System.Windows.Forms.NumericUpDown();
            this.label2 = new System.Windows.Forms.Label();
            this.tbLeapYear = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btAns = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tbAns = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.mcBirthDay = new System.Windows.Forms.MonthCalendar();
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btNow
            // 
            this.btNow.Location = new System.Drawing.Point(24, 54);
            this.btNow.Name = "btNow";
            this.btNow.Size = new System.Drawing.Size(129, 39);
            this.btNow.TabIndex = 0;
            this.btNow.Text = "現在日時";
            this.btNow.UseVisualStyleBackColor = true;
            this.btNow.Click += new System.EventHandler(this.btNow_Click);
            // 
            // tbNowDisp
            // 
            this.tbNowDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbNowDisp.Location = new System.Drawing.Point(159, 54);
            this.tbNowDisp.Name = "tbNowDisp";
            this.tbNowDisp.Size = new System.Drawing.Size(564, 39);
            this.tbNowDisp.TabIndex = 1;
            // 
            // nudDayBeforeAfter
            // 
            this.nudDayBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudDayBeforeAfter.Location = new System.Drawing.Point(348, 127);
            this.nudDayBeforeAfter.Name = "nudDayBeforeAfter";
            this.nudDayBeforeAfter.Size = new System.Drawing.Size(111, 39);
            this.nudDayBeforeAfter.TabIndex = 2;
            this.nudDayBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.Location = new System.Drawing.Point(465, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 33);
            this.label1.TabIndex = 3;
            this.label1.Text = "日";
            // 
            // btBefore
            // 
            this.btBefore.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btBefore.Location = new System.Drawing.Point(159, 204);
            this.btBefore.Name = "btBefore";
            this.btBefore.Size = new System.Drawing.Size(74, 46);
            this.btBefore.TabIndex = 4;
            this.btBefore.Text = "前";
            this.btBefore.UseVisualStyleBackColor = true;
            this.btBefore.Click += new System.EventHandler(this.btBefore_Click);
            // 
            // btAfter
            // 
            this.btAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAfter.Location = new System.Drawing.Point(249, 204);
            this.btAfter.Name = "btAfter";
            this.btAfter.Size = new System.Drawing.Size(74, 46);
            this.btAfter.TabIndex = 4;
            this.btAfter.Text = "後";
            this.btAfter.UseVisualStyleBackColor = true;
            this.btAfter.Click += new System.EventHandler(this.btAfter_Click);
            // 
            // tbBeforeAfterDisp
            // 
            this.tbBeforeAfterDisp.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbBeforeAfterDisp.Location = new System.Drawing.Point(159, 294);
            this.tbBeforeAfterDisp.Name = "tbBeforeAfterDisp";
            this.tbBeforeAfterDisp.Size = new System.Drawing.Size(564, 39);
            this.tbBeforeAfterDisp.TabIndex = 1;
            // 
            // nudMonthBeforeAfter
            // 
            this.nudMonthBeforeAfter.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.nudMonthBeforeAfter.Location = new System.Drawing.Point(159, 127);
            this.nudMonthBeforeAfter.Name = "nudMonthBeforeAfter";
            this.nudMonthBeforeAfter.Size = new System.Drawing.Size(111, 39);
            this.nudMonthBeforeAfter.TabIndex = 2;
            this.nudMonthBeforeAfter.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.Location = new System.Drawing.Point(276, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 33);
            this.label2.TabIndex = 3;
            this.label2.Text = "ヵ月";
            // 
            // tbLeapYear
            // 
            this.tbLeapYear.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbLeapYear.Location = new System.Drawing.Point(159, 339);
            this.tbLeapYear.Name = "tbLeapYear";
            this.tbLeapYear.Size = new System.Drawing.Size(564, 39);
            this.tbLeapYear.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.Location = new System.Drawing.Point(10, 342);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(143, 33);
            this.label3.TabIndex = 3;
            this.label3.Text = "閏年判定";
            // 
            // btAns
            // 
            this.btAns.Font = new System.Drawing.Font("MS UI Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.btAns.Location = new System.Drawing.Point(219, 30);
            this.btAns.Name = "btAns";
            this.btAns.Size = new System.Drawing.Size(186, 86);
            this.btAns.TabIndex = 0;
            this.btAns.Text = "日数計算";
            this.btAns.UseVisualStyleBackColor = true;
            this.btAns.Click += new System.EventHandler(this.btAns_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label9.Location = new System.Drawing.Point(219, 159);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(172, 33);
            this.label9.TabIndex = 3;
            this.label9.Text = "生まれてから";
            // 
            // tbAns
            // 
            this.tbAns.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.tbAns.Location = new System.Drawing.Point(397, 156);
            this.tbAns.Name = "tbAns";
            this.tbAns.Size = new System.Drawing.Size(181, 39);
            this.tbAns.TabIndex = 1;
            this.tbAns.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("MS UI Gothic", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label10.Location = new System.Drawing.Point(584, 159);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(153, 33);
            this.label10.TabIndex = 3;
            this.label10.Text = "日目です。";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox1.Controls.Add(this.mcBirthDay);
            this.groupBox1.Controls.Add(this.btAns);
            this.groupBox1.Controls.Add(this.tbAns);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Font = new System.Drawing.Font("MS UI Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.groupBox1.Location = new System.Drawing.Point(16, 396);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 208);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "誕生日";
            // 
            // mcBirthDay
            // 
            this.mcBirthDay.Location = new System.Drawing.Point(8, 30);
            this.mcBirthDay.MaxSelectionCount = 1;
            this.mcBirthDay.Name = "mcBirthDay";
            this.mcBirthDay.ShowToday = false;
            this.mcBirthDay.ShowTodayCircle = false;
            this.mcBirthDay.TabIndex = 6;
            this.mcBirthDay.TodayDate = new System.DateTime(2000, 1, 1, 0, 0, 0, 0);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 616);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btAfter);
            this.Controls.Add(this.btBefore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.nudMonthBeforeAfter);
            this.Controls.Add(this.nudDayBeforeAfter);
            this.Controls.Add(this.tbLeapYear);
            this.Controls.Add(this.tbBeforeAfterDisp);
            this.Controls.Add(this.tbNowDisp);
            this.Controls.Add(this.btNow);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.nudDayBeforeAfter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudMonthBeforeAfter)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btNow;
        private System.Windows.Forms.TextBox tbNowDisp;
        private System.Windows.Forms.NumericUpDown nudDayBeforeAfter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btBefore;
        private System.Windows.Forms.Button btAfter;
        private System.Windows.Forms.TextBox tbBeforeAfterDisp;
        private System.Windows.Forms.NumericUpDown nudMonthBeforeAfter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbLeapYear;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btAns;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tbAns;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MonthCalendar mcBirthDay;
    }
}

