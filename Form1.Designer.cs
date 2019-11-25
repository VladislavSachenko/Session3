namespace Session3
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button4 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.bookFlight = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.passengers = new System.Windows.Forms.MaskedTextBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.downCB = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.topCB = new System.Windows.Forms.CheckBox();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.returnDate = new System.Windows.Forms.MaskedTextBox();
            this.outBoundDate = new System.Windows.Forms.MaskedTextBox();
            this.apply = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.oneWayRB = new System.Windows.Forms.RadioButton();
            this.returnRB = new System.Windows.Forms.RadioButton();
            this.cabinTypeCB = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.toCB = new System.Windows.Forms.ComboBox();
            this.fromCB = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1137, 32);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(5, 5);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(119, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Search for flights";
            // 
            // button1
            // 
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Location = new System.Drawing.Point(1096, -1);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(41, 32);
            this.button1.TabIndex = 0;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.groupBox2);
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Controls.Add(this.downCB);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Controls.Add(this.topCB);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(0, 32);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1137, 660);
            this.panel2.TabIndex = 1;
            // 
            // button4
            // 
            this.button4.Cursor = System.Windows.Forms.Cursors.No;
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(805, 606);
            this.button4.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(80, 28);
            this.button4.TabIndex = 23;
            this.button4.Text = "Exit";
            this.button4.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.button4.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.bookFlight);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.passengers);
            this.groupBox2.Location = new System.Drawing.Point(251, 580);
            this.groupBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox2.Size = new System.Drawing.Size(524, 65);
            this.groupBox2.TabIndex = 21;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Confirm booking for";
            // 
            // bookFlight
            // 
            this.bookFlight.Cursor = System.Windows.Forms.Cursors.No;
            this.bookFlight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.bookFlight.Location = new System.Drawing.Point(364, 26);
            this.bookFlight.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bookFlight.Name = "bookFlight";
            this.bookFlight.Size = new System.Drawing.Size(111, 28);
            this.bookFlight.TabIndex = 15;
            this.bookFlight.Text = "Book Flight";
            this.bookFlight.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.bookFlight.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(148, 32);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(83, 17);
            this.label9.TabIndex = 22;
            this.label9.Text = "Passengers";
            // 
            // passengers
            // 
            this.passengers.Location = new System.Drawing.Point(60, 28);
            this.passengers.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passengers.Name = "passengers";
            this.passengers.Size = new System.Drawing.Size(79, 22);
            this.passengers.TabIndex = 15;
            this.passengers.ValidatingType = typeof(System.DateTime);
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView2.Location = new System.Drawing.Point(28, 391);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.Size = new System.Drawing.Size(1080, 160);
            this.dataGridView2.TabIndex = 20;
            // 
            // downCB
            // 
            this.downCB.AutoSize = true;
            this.downCB.Location = new System.Drawing.Point(840, 351);
            this.downCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.downCB.Name = "downCB";
            this.downCB.Size = new System.Drawing.Size(253, 21);
            this.downCB.TabIndex = 19;
            this.downCB.Text = "Display three days before and after";
            this.downCB.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(24, 352);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 17);
            this.label8.TabIndex = 18;
            this.label8.Text = "Return flight details:";
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.dataGridView1.Location = new System.Drawing.Point(28, 177);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.Size = new System.Drawing.Size(1080, 160);
            this.dataGridView1.TabIndex = 17;
            // 
            // topCB
            // 
            this.topCB.AutoSize = true;
            this.topCB.Location = new System.Drawing.Point(840, 138);
            this.topCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.topCB.Name = "topCB";
            this.topCB.Size = new System.Drawing.Size(253, 21);
            this.topCB.TabIndex = 16;
            this.topCB.Text = "Display three days before and after";
            this.topCB.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 138);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(154, 17);
            this.label7.TabIndex = 15;
            this.label7.Text = "Outbound flight details:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.returnDate);
            this.groupBox1.Controls.Add(this.outBoundDate);
            this.groupBox1.Controls.Add(this.apply);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.oneWayRB);
            this.groupBox1.Controls.Add(this.returnRB);
            this.groupBox1.Controls.Add(this.cabinTypeCB);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.toCB);
            this.groupBox1.Controls.Add(this.fromCB);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Location = new System.Drawing.Point(28, 22);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(1080, 101);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Parameters";
            // 
            // returnDate
            // 
            this.returnDate.Location = new System.Drawing.Point(743, 64);
            this.returnDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnDate.Mask = "00/00/0000";
            this.returnDate.Name = "returnDate";
            this.returnDate.Size = new System.Drawing.Size(160, 22);
            this.returnDate.TabIndex = 14;
            this.returnDate.ValidatingType = typeof(System.DateTime);
            // 
            // outBoundDate
            // 
            this.outBoundDate.Location = new System.Drawing.Point(404, 63);
            this.outBoundDate.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.outBoundDate.Mask = "00/00/0000";
            this.outBoundDate.Name = "outBoundDate";
            this.outBoundDate.Size = new System.Drawing.Size(160, 22);
            this.outBoundDate.TabIndex = 13;
            this.outBoundDate.ValidatingType = typeof(System.DateTime);
            // 
            // apply
            // 
            this.apply.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.apply.Location = new System.Drawing.Point(965, 62);
            this.apply.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.apply.Name = "apply";
            this.apply.Size = new System.Drawing.Size(100, 28);
            this.apply.TabIndex = 12;
            this.apply.Text = "Apply";
            this.apply.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(645, 66);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(51, 17);
            this.label6.TabIndex = 10;
            this.label6.Text = "Return";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(308, 66);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "Outbound";
            // 
            // oneWayRB
            // 
            this.oneWayRB.AutoSize = true;
            this.oneWayRB.Location = new System.Drawing.Point(171, 64);
            this.oneWayRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.oneWayRB.Name = "oneWayRB";
            this.oneWayRB.Size = new System.Drawing.Size(84, 21);
            this.oneWayRB.TabIndex = 7;
            this.oneWayRB.TabStop = true;
            this.oneWayRB.Text = "One way";
            this.oneWayRB.UseVisualStyleBackColor = true;
            // 
            // returnRB
            // 
            this.returnRB.AutoSize = true;
            this.returnRB.Location = new System.Drawing.Point(37, 64);
            this.returnRB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.returnRB.Name = "returnRB";
            this.returnRB.Size = new System.Drawing.Size(72, 21);
            this.returnRB.TabIndex = 6;
            this.returnRB.TabStop = true;
            this.returnRB.Text = "Return";
            this.returnRB.UseVisualStyleBackColor = true;
            // 
            // cabinTypeCB
            // 
            this.cabinTypeCB.FormattingEnabled = true;
            this.cabinTypeCB.Location = new System.Drawing.Point(743, 21);
            this.cabinTypeCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cabinTypeCB.Name = "cabinTypeCB";
            this.cabinTypeCB.Size = new System.Drawing.Size(160, 24);
            this.cabinTypeCB.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(639, 25);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 17);
            this.label4.TabIndex = 4;
            this.label4.Text = "Cabin Type";
            // 
            // toCB
            // 
            this.toCB.FormattingEnabled = true;
            this.toCB.Location = new System.Drawing.Point(404, 21);
            this.toCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toCB.Name = "toCB";
            this.toCB.Size = new System.Drawing.Size(160, 24);
            this.toCB.TabIndex = 3;
            // 
            // fromCB
            // 
            this.fromCB.FormattingEnabled = true;
            this.fromCB.Location = new System.Drawing.Point(99, 21);
            this.fromCB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromCB.Name = "fromCB";
            this.fromCB.Size = new System.Drawing.Size(160, 24);
            this.fromCB.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(353, 25);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 17);
            this.label3.TabIndex = 1;
            this.label3.Text = "To";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 17);
            this.label2.TabIndex = 0;
            this.label2.Text = "From";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1137, 692);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.MaskedTextBox returnDate;
        private System.Windows.Forms.MaskedTextBox outBoundDate;
        private System.Windows.Forms.Button apply;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton oneWayRB;
        private System.Windows.Forms.RadioButton returnRB;
        private System.Windows.Forms.ComboBox cabinTypeCB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox toCB;
        private System.Windows.Forms.ComboBox fromCB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button bookFlight;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.MaskedTextBox passengers;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.CheckBox downCB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.CheckBox topCB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button button4;
    }
}

