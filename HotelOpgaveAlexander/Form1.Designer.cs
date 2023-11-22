namespace HotelOpgaveAlexander
{
    partial class Form1
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
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button7 = new System.Windows.Forms.Button();
            this.Facility_ID_Textbox = new System.Windows.Forms.TextBox();
            this.Hotel_No_Textbox = new System.Windows.Forms.TextBox();
            this.Facility_Name_Textbox = new System.Windows.Forms.TextBox();
            this.Search_Textbox = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(45, 256);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(143, 72);
            this.button1.TabIndex = 0;
            this.button1.Text = "Insert";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(247, 258);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(140, 70);
            this.button2.TabIndex = 1;
            this.button2.Text = "Update";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(438, 258);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(140, 70);
            this.button3.TabIndex = 2;
            this.button3.Text = "Delete";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(45, 397);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(143, 67);
            this.button4.TabIndex = 3;
            this.button4.Text = "Show All";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.Color.Red;
            this.button5.ForeColor = System.Drawing.Color.White;
            this.button5.Location = new System.Drawing.Point(438, 397);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(140, 67);
            this.button5.TabIndex = 4;
            this.button5.Text = "Exit";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Facility_ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(40, 104);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Hotel_No";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(-4, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(148, 25);
            this.label3.TabIndex = 8;
            this.label3.Text = "Facility_Name";
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.Color.LimeGreen;
            this.button7.ForeColor = System.Drawing.Color.White;
            this.button7.Location = new System.Drawing.Point(1230, 20);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(138, 55);
            this.button7.TabIndex = 9;
            this.button7.Text = "Find";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // Facility_ID_Textbox
            // 
            this.Facility_ID_Textbox.Location = new System.Drawing.Point(150, 35);
            this.Facility_ID_Textbox.Name = "Facility_ID_Textbox";
            this.Facility_ID_Textbox.Size = new System.Drawing.Size(428, 31);
            this.Facility_ID_Textbox.TabIndex = 10;
            // 
            // Hotel_No_Textbox
            // 
            this.Hotel_No_Textbox.Location = new System.Drawing.Point(150, 104);
            this.Hotel_No_Textbox.Name = "Hotel_No_Textbox";
            this.Hotel_No_Textbox.Size = new System.Drawing.Size(428, 31);
            this.Hotel_No_Textbox.TabIndex = 11;
            // 
            // Facility_Name_Textbox
            // 
            this.Facility_Name_Textbox.Location = new System.Drawing.Point(150, 175);
            this.Facility_Name_Textbox.Name = "Facility_Name_Textbox";
            this.Facility_Name_Textbox.Size = new System.Drawing.Size(428, 31);
            this.Facility_Name_Textbox.TabIndex = 12;
            // 
            // Search_Textbox
            // 
            this.Search_Textbox.Location = new System.Drawing.Point(658, 35);
            this.Search_Textbox.Name = "Search_Textbox";
            this.Search_Textbox.Size = new System.Drawing.Size(524, 31);
            this.Search_Textbox.TabIndex = 13;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(652, 129);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 82;
            this.dataGridView1.RowTemplate.Height = 33;
            this.dataGridView1.Size = new System.Drawing.Size(716, 335);
            this.dataGridView1.TabIndex = 14;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1380, 497);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.Search_Textbox);
            this.Controls.Add(this.Facility_Name_Textbox);
            this.Controls.Add(this.Hotel_No_Textbox);
            this.Controls.Add(this.Facility_ID_Textbox);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.TextBox Facility_ID_Textbox;
        private System.Windows.Forms.TextBox Hotel_No_Textbox;
        private System.Windows.Forms.TextBox Facility_Name_Textbox;
        private System.Windows.Forms.TextBox Search_Textbox;
        private System.Windows.Forms.DataGridView dataGridView1;
    }
}

