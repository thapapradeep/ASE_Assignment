namespace ASE_Assignment
{
    partial class ComparisionForm
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.fileName1 = new System.Windows.Forms.TextBox();
            this.fileName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl2 = new ZedGraph.ZedGraphControl();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.zedGraphControl3 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl4 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl5 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl6 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl7 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl8 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl9 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl10 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl11 = new ZedGraph.ZedGraphControl();
            this.zedGraphControl12 = new ZedGraph.ZedGraphControl();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(3, 3);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1224, 642);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.button4);
            this.tabPage1.Controls.Add(this.dataGridView2);
            this.tabPage1.Controls.Add(this.dataGridView1);
            this.tabPage1.Controls.Add(this.button3);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.fileName1);
            this.tabPage1.Controls.Add(this.fileName);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1216, 616);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Compare Files";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.dataGridView2.Location = new System.Drawing.Point(3, 300);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(747, 260);
            this.dataGridView2.TabIndex = 6;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DividerWidth = 3;
            this.dataGridViewTextBoxColumn1.HeaderText = "Heart Rate";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 7;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DividerWidth = 3;
            this.dataGridViewTextBoxColumn2.HeaderText = "Speed";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DividerWidth = 3;
            this.dataGridViewTextBoxColumn3.HeaderText = "Cadence";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DividerWidth = 3;
            this.dataGridViewTextBoxColumn4.HeaderText = "Altitude";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DividerWidth = 3;
            this.dataGridViewTextBoxColumn5.HeaderText = "Power";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Power Balancing";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.HeaderText = "Time in (HH:MM:SS)";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6,
            this.Column7,
            this.Column8});
            this.dataGridView1.Location = new System.Drawing.Point(0, 72);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(747, 192);
            this.dataGridView1.TabIndex = 5;
            // 
            // Column2
            // 
            this.Column2.DividerWidth = 3;
            this.Column2.HeaderText = "Heart Rate";
            this.Column2.MinimumWidth = 7;
            this.Column2.Name = "Column2";
            this.Column2.Resizable = System.Windows.Forms.DataGridViewTriState.False;
            // 
            // Column3
            // 
            this.Column3.DividerWidth = 3;
            this.Column3.HeaderText = "Speed";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DividerWidth = 3;
            this.Column4.HeaderText = "Cadence";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DividerWidth = 3;
            this.Column5.HeaderText = "Altitude";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.DividerWidth = 3;
            this.Column6.HeaderText = "Power";
            this.Column6.Name = "Column6";
            // 
            // Column7
            // 
            this.Column7.HeaderText = "Power Balancing";
            this.Column7.Name = "Column7";
            // 
            // Column8
            // 
            this.Column8.HeaderText = "Time in (HH:MM:SS)";
            this.Column8.Name = "Column8";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(372, 15);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 4;
            this.button3.Text = "Compare";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(280, 29);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 3;
            this.button2.Text = "Browse";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(280, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // fileName1
            // 
            this.fileName1.Location = new System.Drawing.Point(6, 29);
            this.fileName1.Name = "fileName1";
            this.fileName1.Size = new System.Drawing.Size(258, 20);
            this.fileName1.TabIndex = 1;
            // 
            // fileName
            // 
            this.fileName.Location = new System.Drawing.Point(6, 3);
            this.fileName.Name = "fileName";
            this.fileName.Size = new System.Drawing.Size(258, 20);
            this.fileName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.zedGraphControl2);
            this.tabPage2.Controls.Add(this.zedGraphControl1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1216, 616);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Full Graph";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.panel1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1216, 616);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Individual Graphs";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.Location = new System.Drawing.Point(7, 51);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(547, 464);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // zedGraphControl2
            // 
            this.zedGraphControl2.Location = new System.Drawing.Point(584, 51);
            this.zedGraphControl2.Name = "zedGraphControl2";
            this.zedGraphControl2.ScrollGrace = 0D;
            this.zedGraphControl2.ScrollMaxX = 0D;
            this.zedGraphControl2.ScrollMaxY = 0D;
            this.zedGraphControl2.ScrollMaxY2 = 0D;
            this.zedGraphControl2.ScrollMinX = 0D;
            this.zedGraphControl2.ScrollMinY = 0D;
            this.zedGraphControl2.ScrollMinY2 = 0D;
            this.zedGraphControl2.Size = new System.Drawing.Size(547, 464);
            this.zedGraphControl2.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(166, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 24);
            this.label1.TabIndex = 2;
            this.label1.Text = "Graph of First File";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(744, 24);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Graph of Second File";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(463, 15);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(75, 23);
            this.button4.TabIndex = 7;
            this.button4.Text = "Cancel";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.zedGraphControl12);
            this.panel1.Controls.Add(this.zedGraphControl11);
            this.panel1.Controls.Add(this.zedGraphControl10);
            this.panel1.Controls.Add(this.zedGraphControl9);
            this.panel1.Controls.Add(this.zedGraphControl8);
            this.panel1.Controls.Add(this.zedGraphControl7);
            this.panel1.Controls.Add(this.zedGraphControl6);
            this.panel1.Controls.Add(this.zedGraphControl5);
            this.panel1.Controls.Add(this.zedGraphControl4);
            this.panel1.Controls.Add(this.zedGraphControl3);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1205, 610);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // zedGraphControl3
            // 
            this.zedGraphControl3.Location = new System.Drawing.Point(3, 20);
            this.zedGraphControl3.Name = "zedGraphControl3";
            this.zedGraphControl3.ScrollGrace = 0D;
            this.zedGraphControl3.ScrollMaxX = 0D;
            this.zedGraphControl3.ScrollMaxY = 0D;
            this.zedGraphControl3.ScrollMaxY2 = 0D;
            this.zedGraphControl3.ScrollMinX = 0D;
            this.zedGraphControl3.ScrollMinY = 0D;
            this.zedGraphControl3.ScrollMinY2 = 0D;
            this.zedGraphControl3.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl3.TabIndex = 0;
            // 
            // zedGraphControl4
            // 
            this.zedGraphControl4.Location = new System.Drawing.Point(3, 245);
            this.zedGraphControl4.Name = "zedGraphControl4";
            this.zedGraphControl4.ScrollGrace = 0D;
            this.zedGraphControl4.ScrollMaxX = 0D;
            this.zedGraphControl4.ScrollMaxY = 0D;
            this.zedGraphControl4.ScrollMaxY2 = 0D;
            this.zedGraphControl4.ScrollMinX = 0D;
            this.zedGraphControl4.ScrollMinY = 0D;
            this.zedGraphControl4.ScrollMinY2 = 0D;
            this.zedGraphControl4.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl4.TabIndex = 1;
            // 
            // zedGraphControl5
            // 
            this.zedGraphControl5.Location = new System.Drawing.Point(0, 451);
            this.zedGraphControl5.Name = "zedGraphControl5";
            this.zedGraphControl5.ScrollGrace = 0D;
            this.zedGraphControl5.ScrollMaxX = 0D;
            this.zedGraphControl5.ScrollMaxY = 0D;
            this.zedGraphControl5.ScrollMaxY2 = 0D;
            this.zedGraphControl5.ScrollMinX = 0D;
            this.zedGraphControl5.ScrollMinY = 0D;
            this.zedGraphControl5.ScrollMinY2 = 0D;
            this.zedGraphControl5.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl5.TabIndex = 2;
            // 
            // zedGraphControl6
            // 
            this.zedGraphControl6.Location = new System.Drawing.Point(3, 676);
            this.zedGraphControl6.Name = "zedGraphControl6";
            this.zedGraphControl6.ScrollGrace = 0D;
            this.zedGraphControl6.ScrollMaxX = 0D;
            this.zedGraphControl6.ScrollMaxY = 0D;
            this.zedGraphControl6.ScrollMaxY2 = 0D;
            this.zedGraphControl6.ScrollMinX = 0D;
            this.zedGraphControl6.ScrollMinY = 0D;
            this.zedGraphControl6.ScrollMinY2 = 0D;
            this.zedGraphControl6.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl6.TabIndex = 3;
            // 
            // zedGraphControl7
            // 
            this.zedGraphControl7.Location = new System.Drawing.Point(3, 907);
            this.zedGraphControl7.Name = "zedGraphControl7";
            this.zedGraphControl7.ScrollGrace = 0D;
            this.zedGraphControl7.ScrollMaxX = 0D;
            this.zedGraphControl7.ScrollMaxY = 0D;
            this.zedGraphControl7.ScrollMaxY2 = 0D;
            this.zedGraphControl7.ScrollMinX = 0D;
            this.zedGraphControl7.ScrollMinY = 0D;
            this.zedGraphControl7.ScrollMinY2 = 0D;
            this.zedGraphControl7.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl7.TabIndex = 4;
            // 
            // zedGraphControl8
            // 
            this.zedGraphControl8.Location = new System.Drawing.Point(626, 20);
            this.zedGraphControl8.Name = "zedGraphControl8";
            this.zedGraphControl8.ScrollGrace = 0D;
            this.zedGraphControl8.ScrollMaxX = 0D;
            this.zedGraphControl8.ScrollMaxY = 0D;
            this.zedGraphControl8.ScrollMaxY2 = 0D;
            this.zedGraphControl8.ScrollMinX = 0D;
            this.zedGraphControl8.ScrollMinY = 0D;
            this.zedGraphControl8.ScrollMinY2 = 0D;
            this.zedGraphControl8.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl8.TabIndex = 5;
            // 
            // zedGraphControl9
            // 
            this.zedGraphControl9.Location = new System.Drawing.Point(626, 245);
            this.zedGraphControl9.Name = "zedGraphControl9";
            this.zedGraphControl9.ScrollGrace = 0D;
            this.zedGraphControl9.ScrollMaxX = 0D;
            this.zedGraphControl9.ScrollMaxY = 0D;
            this.zedGraphControl9.ScrollMaxY2 = 0D;
            this.zedGraphControl9.ScrollMinX = 0D;
            this.zedGraphControl9.ScrollMinY = 0D;
            this.zedGraphControl9.ScrollMinY2 = 0D;
            this.zedGraphControl9.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl9.TabIndex = 6;
            // 
            // zedGraphControl10
            // 
            this.zedGraphControl10.Location = new System.Drawing.Point(626, 451);
            this.zedGraphControl10.Name = "zedGraphControl10";
            this.zedGraphControl10.ScrollGrace = 0D;
            this.zedGraphControl10.ScrollMaxX = 0D;
            this.zedGraphControl10.ScrollMaxY = 0D;
            this.zedGraphControl10.ScrollMaxY2 = 0D;
            this.zedGraphControl10.ScrollMinX = 0D;
            this.zedGraphControl10.ScrollMinY = 0D;
            this.zedGraphControl10.ScrollMinY2 = 0D;
            this.zedGraphControl10.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl10.TabIndex = 7;
            // 
            // zedGraphControl11
            // 
            this.zedGraphControl11.Location = new System.Drawing.Point(626, 676);
            this.zedGraphControl11.Name = "zedGraphControl11";
            this.zedGraphControl11.ScrollGrace = 0D;
            this.zedGraphControl11.ScrollMaxX = 0D;
            this.zedGraphControl11.ScrollMaxY = 0D;
            this.zedGraphControl11.ScrollMaxY2 = 0D;
            this.zedGraphControl11.ScrollMinX = 0D;
            this.zedGraphControl11.ScrollMinY = 0D;
            this.zedGraphControl11.ScrollMinY2 = 0D;
            this.zedGraphControl11.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl11.TabIndex = 8;
            // 
            // zedGraphControl12
            // 
            this.zedGraphControl12.Location = new System.Drawing.Point(624, 898);
            this.zedGraphControl12.Name = "zedGraphControl12";
            this.zedGraphControl12.ScrollGrace = 0D;
            this.zedGraphControl12.ScrollMaxX = 0D;
            this.zedGraphControl12.ScrollMaxY = 0D;
            this.zedGraphControl12.ScrollMaxY2 = 0D;
            this.zedGraphControl12.ScrollMinX = 0D;
            this.zedGraphControl12.ScrollMinY = 0D;
            this.zedGraphControl12.ScrollMinY2 = 0D;
            this.zedGraphControl12.Size = new System.Drawing.Size(527, 190);
            this.zedGraphControl12.TabIndex = 9;
            // 
            // ComparisionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1227, 650);
            this.Controls.Add(this.tabControl1);
            this.Name = "ComparisionForm";
            this.Text = "ComparisionForm";
            this.Load += new System.EventHandler(this.ComparisionForm_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox fileName1;
        private System.Windows.Forms.TextBox fileName;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column8;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private ZedGraph.ZedGraphControl zedGraphControl2;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Panel panel1;
        private ZedGraph.ZedGraphControl zedGraphControl5;
        private ZedGraph.ZedGraphControl zedGraphControl4;
        private ZedGraph.ZedGraphControl zedGraphControl3;
        private ZedGraph.ZedGraphControl zedGraphControl12;
        private ZedGraph.ZedGraphControl zedGraphControl11;
        private ZedGraph.ZedGraphControl zedGraphControl10;
        private ZedGraph.ZedGraphControl zedGraphControl9;
        private ZedGraph.ZedGraphControl zedGraphControl8;
        private ZedGraph.ZedGraphControl zedGraphControl7;
        private ZedGraph.ZedGraphControl zedGraphControl6;
    }
}