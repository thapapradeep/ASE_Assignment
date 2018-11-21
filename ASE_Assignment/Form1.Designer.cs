namespace ASE_Assignment
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
        /// the contents of this method with the code editor.
        /// the contents of this method with the code editor.
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tab2 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_re = new System.Windows.Forms.Button();
            this.cmb_unit = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSummary = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.add = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.summary2 = new System.Windows.Forms.TextBox();
            this.zedGraphControl1 = new ZedGraph.ZedGraphControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.panel1 = new System.Windows.Forms.Panel();
            this.graph6 = new ZedGraph.ZedGraphControl();
            this.graph5 = new ZedGraph.ZedGraphControl();
            this.graph3 = new ZedGraph.ZedGraphControl();
            this.graph4 = new ZedGraph.ZedGraphControl();
            this.graph1 = new ZedGraph.ZedGraphControl();
            this.graph2 = new ZedGraph.ZedGraphControl();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.process1 = new System.Diagnostics.Process();
            this.tab2.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(965, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // tab2
            // 
            this.tab2.ContextMenuStrip = this.contextMenuStrip1;
            this.tab2.Controls.Add(this.tabPage2);
            this.tab2.Controls.Add(this.tabPage3);
            this.tab2.Controls.Add(this.tabPage4);
            this.tab2.Location = new System.Drawing.Point(0, 0);
            this.tab2.Name = "tab2";
            this.tab2.SelectedIndex = 0;
            this.tab2.Size = new System.Drawing.Size(971, 670);
            this.tab2.TabIndex = 1;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btn_re);
            this.tabPage2.Controls.Add(this.cmb_unit);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.txtSummary);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.add);
            this.tabPage2.Controls.Add(this.button1);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.label1);
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(963, 644);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Data View";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btn_re
            // 
            this.btn_re.Location = new System.Drawing.Point(436, 428);
            this.btn_re.Name = "btn_re";
            this.btn_re.Size = new System.Drawing.Size(130, 23);
            this.btn_re.TabIndex = 15;
            this.btn_re.Text = "Recalibrate";
            this.btn_re.UseVisualStyleBackColor = true;
            this.btn_re.Click += new System.EventHandler(this.btn_re_Click);
            // 
            // cmb_unit
            // 
            this.cmb_unit.FormattingEnabled = true;
            this.cmb_unit.Items.AddRange(new object[] {
            "km/hr",
            "miles/hr"});
            this.cmb_unit.Location = new System.Drawing.Point(436, 401);
            this.cmb_unit.Name = "cmb_unit";
            this.cmb_unit.Size = new System.Drawing.Size(121, 21);
            this.cmb_unit.TabIndex = 12;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(433, 385);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(124, 13);
            this.label7.TabIndex = 10;
            this.label7.Text = "Choose the unit ofSpeed";
            // 
            // txtSummary
            // 
            this.txtSummary.Enabled = false;
            this.txtSummary.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSummary.Location = new System.Drawing.Point(3, 396);
            this.txtSummary.Multiline = true;
            this.txtSummary.Name = "txtSummary";
            this.txtSummary.Size = new System.Drawing.Size(253, 245);
            this.txtSummary.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(3, 373);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(177, 25);
            this.label5.TabIndex = 8;
            this.label5.Text = "Summary of Data";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(3, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(228, 29);
            this.label4.TabIndex = 7;
            this.label4.Text = "Your Data Readings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(709, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(219, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Additional Information";
            // 
            // add
            // 
            this.add.CausesValidation = false;
            this.add.Enabled = false;
            this.add.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.add.Location = new System.Drawing.Point(684, 56);
            this.add.Multiline = true;
            this.add.Name = "add";
            this.add.Size = new System.Drawing.Size(276, 314);
            this.add.TabIndex = 5;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(65, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Browse";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textBox1
            // 
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(468, 5);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 20);
            this.textBox1.TabIndex = 3;
            this.textBox1.Text = "Select data file";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 29);
            this.label2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 459);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 29);
            this.label1.TabIndex = 1;
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
            this.Column7});
            this.dataGridView1.Location = new System.Drawing.Point(3, 56);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(645, 314);
            this.dataGridView1.TabIndex = 0;
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
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.label6);
            this.tabPage3.Controls.Add(this.summary2);
            this.tabPage3.Controls.Add(this.zedGraphControl1);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(963, 644);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Graphical View";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 410);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(109, 16);
            this.label6.TabIndex = 2;
            this.label6.Text = "Summary Data";
            // 
            // summary2
            // 
            this.summary2.Enabled = false;
            this.summary2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.summary2.Location = new System.Drawing.Point(0, 434);
            this.summary2.Multiline = true;
            this.summary2.Name = "summary2";
            this.summary2.Size = new System.Drawing.Size(348, 209);
            this.summary2.TabIndex = 1;
            // 
            // zedGraphControl1
            // 
            this.zedGraphControl1.BackColor = System.Drawing.Color.Maroon;
            this.zedGraphControl1.Location = new System.Drawing.Point(3, 3);
            this.zedGraphControl1.Name = "zedGraphControl1";
            this.zedGraphControl1.ScrollGrace = 0D;
            this.zedGraphControl1.ScrollMaxX = 0D;
            this.zedGraphControl1.ScrollMaxY = 0D;
            this.zedGraphControl1.ScrollMaxY2 = 0D;
            this.zedGraphControl1.ScrollMinX = 0D;
            this.zedGraphControl1.ScrollMinY = 0D;
            this.zedGraphControl1.ScrollMinY2 = 0D;
            this.zedGraphControl1.Size = new System.Drawing.Size(952, 404);
            this.zedGraphControl1.TabIndex = 0;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.panel1);
            this.tabPage4.Controls.Add(this.graph2);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(963, 644);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Detailed Graph View";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.Controls.Add(this.graph6);
            this.panel1.Controls.Add(this.graph5);
            this.panel1.Controls.Add(this.graph3);
            this.panel1.Controls.Add(this.graph4);
            this.panel1.Controls.Add(this.graph1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(960, 694);
            this.panel1.TabIndex = 0;
            // 
            // graph6
            // 
            this.graph6.Location = new System.Drawing.Point(3, 1029);
            this.graph6.Name = "graph6";
            this.graph6.ScrollGrace = 0D;
            this.graph6.ScrollMaxX = 0D;
            this.graph6.ScrollMaxY = 0D;
            this.graph6.ScrollMaxY2 = 0D;
            this.graph6.ScrollMinX = 0D;
            this.graph6.ScrollMinY = 0D;
            this.graph6.ScrollMinY2 = 0D;
            this.graph6.Size = new System.Drawing.Size(938, 400);
            this.graph6.TabIndex = 5;
            // 
            // graph5
            // 
            this.graph5.Location = new System.Drawing.Point(0, 1435);
            this.graph5.Name = "graph5";
            this.graph5.ScrollGrace = 0D;
            this.graph5.ScrollMaxX = 0D;
            this.graph5.ScrollMaxY = 0D;
            this.graph5.ScrollMaxY2 = 0D;
            this.graph5.ScrollMinX = 0D;
            this.graph5.ScrollMinY = 0D;
            this.graph5.ScrollMinY2 = 0D;
            this.graph5.Size = new System.Drawing.Size(946, 358);
            this.graph5.TabIndex = 4;
            // 
            // graph3
            // 
            this.graph3.Location = new System.Drawing.Point(0, 649);
            this.graph3.Name = "graph3";
            this.graph3.ScrollGrace = 0D;
            this.graph3.ScrollMaxX = 0D;
            this.graph3.ScrollMaxY = 0D;
            this.graph3.ScrollMaxY2 = 0D;
            this.graph3.ScrollMinX = 0D;
            this.graph3.ScrollMinY = 0D;
            this.graph3.ScrollMinY2 = 0D;
            this.graph3.Size = new System.Drawing.Size(954, 374);
            this.graph3.TabIndex = 2;
            // 
            // graph4
            // 
            this.graph4.Location = new System.Drawing.Point(3, 339);
            this.graph4.Name = "graph4";
            this.graph4.ScrollGrace = 0D;
            this.graph4.ScrollMaxX = 0D;
            this.graph4.ScrollMaxY = 0D;
            this.graph4.ScrollMaxY2 = 0D;
            this.graph4.ScrollMinX = 0D;
            this.graph4.ScrollMinY = 0D;
            this.graph4.ScrollMinY2 = 0D;
            this.graph4.Size = new System.Drawing.Size(946, 304);
            this.graph4.TabIndex = 1;
            // 
            // graph1
            // 
            this.graph1.Location = new System.Drawing.Point(3, 32);
            this.graph1.Name = "graph1";
            this.graph1.ScrollGrace = 0D;
            this.graph1.ScrollMaxX = 0D;
            this.graph1.ScrollMaxY = 0D;
            this.graph1.ScrollMaxY2 = 0D;
            this.graph1.ScrollMinX = 0D;
            this.graph1.ScrollMinY = 0D;
            this.graph1.ScrollMinY2 = 0D;
            this.graph1.Size = new System.Drawing.Size(946, 301);
            this.graph1.TabIndex = 0;
            // 
            // graph2
            // 
            this.graph2.Location = new System.Drawing.Point(-65, 629);
            this.graph2.Name = "graph2";
            this.graph2.ScrollGrace = 0D;
            this.graph2.ScrollMaxX = 0D;
            this.graph2.ScrollMaxY = 0D;
            this.graph2.ScrollMaxY2 = 0D;
            this.graph2.ScrollMinX = 0D;
            this.graph2.ScrollMinY = 0D;
            this.graph2.ScrollMinY2 = 0D;
            this.graph2.Size = new System.Drawing.Size(926, 150);
            this.graph2.TabIndex = 3;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Heart Rate";
            this.Column1.Name = "Column1";
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 666);
            this.Controls.Add(this.tab2);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Health Moniter";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tab2.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            this.tabPage4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TabControl tab2;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox add;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column7;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSummary;
        private System.Diagnostics.Process process1;
        private ZedGraph.ZedGraphControl zedGraphControl1;
        private System.Windows.Forms.Panel panel1;
        private ZedGraph.ZedGraphControl graph5;
        private ZedGraph.ZedGraphControl graph2;
        private ZedGraph.ZedGraphControl graph3;
        private ZedGraph.ZedGraphControl graph4;
        private ZedGraph.ZedGraphControl graph1;
        private ZedGraph.ZedGraphControl graph6;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox summary2;
        private System.Windows.Forms.Button btn_re;
        private System.Windows.Forms.ComboBox cmb_unit;
        private System.Windows.Forms.Label label7;
    }
}

