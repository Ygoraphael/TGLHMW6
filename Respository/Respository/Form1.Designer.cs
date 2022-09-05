namespace Respository
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TabPage = new System.Windows.Forms.TabControl();
            this.tbEf = new System.Windows.Forms.TabPage();
            this.btnEfInsert = new System.Windows.Forms.Button();
            this.tbRedis = new System.Windows.Forms.TabPage();
            this.button7 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.tbDapper = new System.Windows.Forms.TabPage();
            this.btnPpopularTables = new System.Windows.Forms.Button();
            this.btnDeleteTables = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.TabPage.SuspendLayout();
            this.tbEf.SuspendLayout();
            this.tbRedis.SuspendLayout();
            this.tbDapper.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabPage
            // 
            this.TabPage.Controls.Add(this.tbEf);
            this.TabPage.Controls.Add(this.tbRedis);
            this.TabPage.Controls.Add(this.tbDapper);
            this.TabPage.Location = new System.Drawing.Point(12, 12);
            this.TabPage.Name = "TabPage";
            this.TabPage.SelectedIndex = 0;
            this.TabPage.Size = new System.Drawing.Size(312, 181);
            this.TabPage.TabIndex = 0;
            // 
            // tbEf
            // 
            this.tbEf.Controls.Add(this.btnEfInsert);
            this.tbEf.Location = new System.Drawing.Point(4, 24);
            this.tbEf.Name = "tbEf";
            this.tbEf.Padding = new System.Windows.Forms.Padding(3);
            this.tbEf.Size = new System.Drawing.Size(304, 153);
            this.tbEf.TabIndex = 0;
            this.tbEf.Text = "Entity Framework";
            this.tbEf.UseVisualStyleBackColor = true;
            // 
            // btnEfInsert
            // 
            this.btnEfInsert.Location = new System.Drawing.Point(6, 6);
            this.btnEfInsert.Name = "btnEfInsert";
            this.btnEfInsert.Size = new System.Drawing.Size(75, 23);
            this.btnEfInsert.TabIndex = 0;
            this.btnEfInsert.Text = "Insert Data";
            this.btnEfInsert.UseVisualStyleBackColor = true;
            this.btnEfInsert.Click += new System.EventHandler(this.btnEfInsert_Click);
            // 
            // tbRedis
            // 
            this.tbRedis.Controls.Add(this.button7);
            this.tbRedis.Controls.Add(this.button3);
            this.tbRedis.Controls.Add(this.button4);
            this.tbRedis.Location = new System.Drawing.Point(4, 24);
            this.tbRedis.Name = "tbRedis";
            this.tbRedis.Padding = new System.Windows.Forms.Padding(3);
            this.tbRedis.Size = new System.Drawing.Size(304, 153);
            this.tbRedis.TabIndex = 1;
            this.tbRedis.Text = "Redis";
            this.tbRedis.UseVisualStyleBackColor = true;
            // 
            // button7
            // 
            this.button7.Location = new System.Drawing.Point(168, 6);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(75, 23);
            this.button7.TabIndex = 4;
            this.button7.Text = "Delete Key";
            this.button7.UseVisualStyleBackColor = true;
            this.button7.Click += new System.EventHandler(this.button7_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(87, 6);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 3;
            this.button3.Text = "Show Data";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(6, 6);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 2;
            this.button4.Text = "Insert Data";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // tbDapper
            // 
            this.tbDapper.Controls.Add(this.btnPpopularTables);
            this.tbDapper.Controls.Add(this.btnDeleteTables);
            this.tbDapper.Controls.Add(this.button6);
            this.tbDapper.Location = new System.Drawing.Point(4, 24);
            this.tbDapper.Name = "tbDapper";
            this.tbDapper.Padding = new System.Windows.Forms.Padding(3);
            this.tbDapper.Size = new System.Drawing.Size(304, 153);
            this.tbDapper.TabIndex = 2;
            this.tbDapper.Text = "Dapper";
            this.tbDapper.UseVisualStyleBackColor = true;
            this.tbDapper.Click += new System.EventHandler(this.btnCreateTableAsync);
            // 
            // btnPpopularTables
            // 
            this.btnPpopularTables.Location = new System.Drawing.Point(106, 6);
            this.btnPpopularTables.Name = "btnPpopularTables";
            this.btnPpopularTables.Size = new System.Drawing.Size(103, 23);
            this.btnPpopularTables.TabIndex = 6;
            this.btnPpopularTables.Text = "Popular Tables";
            this.btnPpopularTables.UseVisualStyleBackColor = true;
            this.btnPpopularTables.Click += new System.EventHandler(this.btnPpopularTables_Click);
            // 
            // btnDeleteTables
            // 
            this.btnDeleteTables.Location = new System.Drawing.Point(215, 6);
            this.btnDeleteTables.Name = "btnDeleteTables";
            this.btnDeleteTables.Size = new System.Drawing.Size(75, 23);
            this.btnDeleteTables.TabIndex = 5;
            this.btnDeleteTables.Text = "Drop Table";
            this.btnDeleteTables.UseVisualStyleBackColor = true;
            this.btnDeleteTables.Click += new System.EventHandler(this.btnDeleteTables_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(6, 6);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(94, 23);
            this.button6.TabIndex = 4;
            this.button6.Text = "Create Table";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.btnCreateTableAsync);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 201);
            this.Controls.Add(this.TabPage);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.TabPage.ResumeLayout(false);
            this.tbEf.ResumeLayout(false);
            this.tbRedis.ResumeLayout(false);
            this.tbDapper.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl TabPage;
        private TabPage tbEf;
        private Button btnEfInsert;
        private TabPage tbRedis;
        private Button button3;
        private Button button4;
        private TabPage tbDapper;
        private Button btnDeleteTables;
        private Button button6;
        private Button button7;
        private Button btnPpopularTables;
    }
}