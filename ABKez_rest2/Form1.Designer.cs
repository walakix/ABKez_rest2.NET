namespace ABKez_rest2
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
            this.btn_Quit = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_APIKey = new System.Windows.Forms.TextBox();
            this.btn_getall = new System.Windows.Forms.Button();
            this.btn_getlast = new System.Windows.Forms.Button();
            this.num_id = new System.Windows.Forms.NumericUpDown();
            this.btn_getone = new System.Windows.Forms.Button();
            this.btn_deleteone = new System.Windows.Forms.Button();
            this.num_intdata = new System.Windows.Forms.NumericUpDown();
            this.num_floatdata = new System.Windows.Forms.NumericUpDown();
            this.num_booldata = new System.Windows.Forms.NumericUpDown();
            this.tb_comment = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btn_writeone = new System.Windows.Forms.Button();
            this.updateone = new System.Windows.Forms.Button();
            this.lv_datas = new System.Windows.Forms.ListView();
            this.id = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.intdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.floatdata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.booldata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.datedata = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.comment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ss_Status = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.memo = new System.Windows.Forms.RichTextBox();
            this.cbWithApiKey = new System.Windows.Forms.CheckBox();
            this.cbLinks = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_intdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_floatdata)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_booldata)).BeginInit();
            this.ss_Status.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Quit
            // 
            this.btn_Quit.Location = new System.Drawing.Point(956, 2);
            this.btn_Quit.Name = "btn_Quit";
            this.btn_Quit.Size = new System.Drawing.Size(75, 23);
            this.btn_Quit.TabIndex = 0;
            this.btn_Quit.Text = "Quit";
            this.btn_Quit.UseVisualStyleBackColor = true;
            this.btn_Quit.Click += new System.EventHandler(this.btn_Quit_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Link:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(275, 4);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "API Key:";
            // 
            // tb_APIKey
            // 
            this.tb_APIKey.Location = new System.Drawing.Point(278, 20);
            this.tb_APIKey.Name = "tb_APIKey";
            this.tb_APIKey.PasswordChar = '*';
            this.tb_APIKey.Size = new System.Drawing.Size(111, 20);
            this.tb_APIKey.TabIndex = 4;
            // 
            // btn_getall
            // 
            this.btn_getall.Location = new System.Drawing.Point(6, 46);
            this.btn_getall.Name = "btn_getall";
            this.btn_getall.Size = new System.Drawing.Size(75, 23);
            this.btn_getall.TabIndex = 5;
            this.btn_getall.Text = "getall";
            this.btn_getall.UseVisualStyleBackColor = true;
            this.btn_getall.Click += new System.EventHandler(this.btn_getall_Click);
            // 
            // btn_getlast
            // 
            this.btn_getlast.Location = new System.Drawing.Point(87, 46);
            this.btn_getlast.Name = "btn_getlast";
            this.btn_getlast.Size = new System.Drawing.Size(75, 23);
            this.btn_getlast.TabIndex = 6;
            this.btn_getlast.Text = "getlast";
            this.btn_getlast.UseVisualStyleBackColor = true;
            this.btn_getlast.Click += new System.EventHandler(this.btn_getlast_Click);
            // 
            // num_id
            // 
            this.num_id.Location = new System.Drawing.Point(169, 48);
            this.num_id.Maximum = new decimal(new int[] {
            -1,
            0,
            0,
            0});
            this.num_id.Name = "num_id";
            this.num_id.Size = new System.Drawing.Size(58, 20);
            this.num_id.TabIndex = 7;
            // 
            // btn_getone
            // 
            this.btn_getone.Location = new System.Drawing.Point(233, 46);
            this.btn_getone.Name = "btn_getone";
            this.btn_getone.Size = new System.Drawing.Size(75, 23);
            this.btn_getone.TabIndex = 8;
            this.btn_getone.Text = "getone";
            this.btn_getone.UseVisualStyleBackColor = true;
            this.btn_getone.Click += new System.EventHandler(this.btn_getone_Click);
            // 
            // btn_deleteone
            // 
            this.btn_deleteone.Location = new System.Drawing.Point(314, 46);
            this.btn_deleteone.Name = "btn_deleteone";
            this.btn_deleteone.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteone.TabIndex = 9;
            this.btn_deleteone.Text = "deleteone";
            this.btn_deleteone.UseVisualStyleBackColor = true;
            this.btn_deleteone.Click += new System.EventHandler(this.btn_deleteone_Click);
            // 
            // num_intdata
            // 
            this.num_intdata.Location = new System.Drawing.Point(395, 49);
            this.num_intdata.Maximum = new decimal(new int[] {
            2147483647,
            0,
            0,
            0});
            this.num_intdata.Minimum = new decimal(new int[] {
            -2147483648,
            0,
            0,
            -2147483648});
            this.num_intdata.Name = "num_intdata";
            this.num_intdata.Size = new System.Drawing.Size(66, 20);
            this.num_intdata.TabIndex = 10;
            // 
            // num_floatdata
            // 
            this.num_floatdata.DecimalPlaces = 25;
            this.num_floatdata.Location = new System.Drawing.Point(467, 49);
            this.num_floatdata.Maximum = new decimal(new int[] {
            1644167168,
            -1317587057,
            1843143,
            0});
            this.num_floatdata.Minimum = new decimal(new int[] {
            1644167168,
            -1317587057,
            1843143,
            -2147483648});
            this.num_floatdata.Name = "num_floatdata";
            this.num_floatdata.Size = new System.Drawing.Size(120, 20);
            this.num_floatdata.TabIndex = 11;
            // 
            // num_booldata
            // 
            this.num_booldata.Location = new System.Drawing.Point(593, 49);
            this.num_booldata.Maximum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_booldata.Name = "num_booldata";
            this.num_booldata.Size = new System.Drawing.Size(40, 20);
            this.num_booldata.TabIndex = 12;
            // 
            // tb_comment
            // 
            this.tb_comment.Location = new System.Drawing.Point(639, 48);
            this.tb_comment.Name = "tb_comment";
            this.tb_comment.Size = new System.Drawing.Size(307, 20);
            this.tb_comment.TabIndex = 14;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(392, 33);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "intdata:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(464, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 13);
            this.label4.TabIndex = 16;
            this.label4.Text = "floatdata:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(590, 33);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 13);
            this.label5.TabIndex = 17;
            this.label5.Text = "booldata:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(636, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(53, 13);
            this.label7.TabIndex = 19;
            this.label7.Text = "comment:";
            // 
            // btn_writeone
            // 
            this.btn_writeone.Location = new System.Drawing.Point(956, 28);
            this.btn_writeone.Name = "btn_writeone";
            this.btn_writeone.Size = new System.Drawing.Size(75, 23);
            this.btn_writeone.TabIndex = 20;
            this.btn_writeone.Text = "writeone";
            this.btn_writeone.UseVisualStyleBackColor = true;
            this.btn_writeone.Click += new System.EventHandler(this.btn_writeone_Click);
            // 
            // updateone
            // 
            this.updateone.Location = new System.Drawing.Point(956, 50);
            this.updateone.Name = "updateone";
            this.updateone.Size = new System.Drawing.Size(75, 23);
            this.updateone.TabIndex = 21;
            this.updateone.Text = "updateone";
            this.updateone.UseVisualStyleBackColor = true;
            this.updateone.Click += new System.EventHandler(this.updateone_Click);
            // 
            // lv_datas
            // 
            this.lv_datas.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.id,
            this.intdata,
            this.floatdata,
            this.booldata,
            this.datedata,
            this.comment});
            this.lv_datas.FullRowSelect = true;
            this.lv_datas.HideSelection = false;
            this.lv_datas.Location = new System.Drawing.Point(6, 75);
            this.lv_datas.MultiSelect = false;
            this.lv_datas.Name = "lv_datas";
            this.lv_datas.Size = new System.Drawing.Size(1025, 352);
            this.lv_datas.TabIndex = 22;
            this.lv_datas.UseCompatibleStateImageBehavior = false;
            this.lv_datas.View = System.Windows.Forms.View.Details;
            this.lv_datas.Click += new System.EventHandler(this.lv_datas_Click);
            // 
            // id
            // 
            this.id.Text = "id";
            this.id.Width = 40;
            // 
            // intdata
            // 
            this.intdata.Text = "intdata";
            // 
            // floatdata
            // 
            this.floatdata.Text = "floatdata";
            this.floatdata.Width = 74;
            // 
            // booldata
            // 
            this.booldata.Text = "booldata";
            this.booldata.Width = 56;
            // 
            // datedata
            // 
            this.datedata.Text = "datedata";
            this.datedata.Width = 121;
            // 
            // comment
            // 
            this.comment.Text = "comment";
            this.comment.Width = 649;
            // 
            // ss_Status
            // 
            this.ss_Status.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.toolStripStatusLabel2});
            this.ss_Status.Location = new System.Drawing.Point(0, 618);
            this.ss_Status.Name = "ss_Status";
            this.ss_Status.Size = new System.Drawing.Size(1034, 22);
            this.ss_Status.TabIndex = 23;
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(13, 17);
            this.toolStripStatusLabel1.Text = "0";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(12, 17);
            this.toolStripStatusLabel2.Text = "-";
            // 
            // memo
            // 
            this.memo.HideSelection = false;
            this.memo.Location = new System.Drawing.Point(6, 433);
            this.memo.Name = "memo";
            this.memo.ReadOnly = true;
            this.memo.Size = new System.Drawing.Size(1025, 182);
            this.memo.TabIndex = 24;
            this.memo.Text = "";
            // 
            // cbWithApiKey
            // 
            this.cbWithApiKey.AutoSize = true;
            this.cbWithApiKey.Location = new System.Drawing.Point(395, 4);
            this.cbWithApiKey.Name = "cbWithApiKey";
            this.cbWithApiKey.Size = new System.Drawing.Size(81, 17);
            this.cbWithApiKey.TabIndex = 25;
            this.cbWithApiKey.Text = "WithApiKey";
            this.cbWithApiKey.UseVisualStyleBackColor = true;
            // 
            // cbLinks
            // 
            this.cbLinks.FormattingEnabled = true;
            this.cbLinks.Items.AddRange(new object[] {
            "http://walaki.infora.hu/AB/api/v0.1/",
            "http://141.147.47.82/AB/api/v0.1/"});
            this.cbLinks.Location = new System.Drawing.Point(6, 19);
            this.cbLinks.Name = "cbLinks";
            this.cbLinks.Size = new System.Drawing.Size(266, 21);
            this.cbLinks.TabIndex = 26;
            this.cbLinks.Text = "http://walaki.infora.hu/AB/api/v0.1/";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 640);
            this.Controls.Add(this.cbLinks);
            this.Controls.Add(this.cbWithApiKey);
            this.Controls.Add(this.memo);
            this.Controls.Add(this.ss_Status);
            this.Controls.Add(this.lv_datas);
            this.Controls.Add(this.updateone);
            this.Controls.Add(this.btn_writeone);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_comment);
            this.Controls.Add(this.num_booldata);
            this.Controls.Add(this.num_floatdata);
            this.Controls.Add(this.num_intdata);
            this.Controls.Add(this.btn_deleteone);
            this.Controls.Add(this.btn_getone);
            this.Controls.Add(this.num_id);
            this.Controls.Add(this.btn_getlast);
            this.Controls.Add(this.btn_getall);
            this.Controls.Add(this.tb_APIKey);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Quit);
            this.Name = "Form1";
            this.Text = "ABKez_rest2";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.num_id)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_intdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_floatdata)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.num_booldata)).EndInit();
            this.ss_Status.ResumeLayout(false);
            this.ss_Status.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_Quit;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_APIKey;
        private System.Windows.Forms.Button btn_getall;
        private System.Windows.Forms.Button btn_getlast;
        private System.Windows.Forms.NumericUpDown num_id;
        private System.Windows.Forms.Button btn_getone;
        private System.Windows.Forms.Button btn_deleteone;
        private System.Windows.Forms.NumericUpDown num_intdata;
        private System.Windows.Forms.NumericUpDown num_floatdata;
        private System.Windows.Forms.NumericUpDown num_booldata;
        private System.Windows.Forms.TextBox tb_comment;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btn_writeone;
        private System.Windows.Forms.Button updateone;
        private System.Windows.Forms.ListView lv_datas;
        private System.Windows.Forms.StatusStrip ss_Status;
        private System.Windows.Forms.RichTextBox memo;
        private System.Windows.Forms.ColumnHeader id;
        private System.Windows.Forms.ColumnHeader intdata;
        private System.Windows.Forms.ColumnHeader floatdata;
        private System.Windows.Forms.ColumnHeader booldata;
        private System.Windows.Forms.ColumnHeader datedata;
        private System.Windows.Forms.ColumnHeader comment;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.CheckBox cbWithApiKey;
        private System.Windows.Forms.ComboBox cbLinks;
    }
}

