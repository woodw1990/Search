namespace test
{
    partial class SEARCHER
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SEARCHER));
            this.pnlTop1 = new System.Windows.Forms.Panel();
            this.btnload = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pnlmid1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton3 = new System.Windows.Forms.RadioButton();
            this.panel4 = new System.Windows.Forms.Panel();
            this.rdoIn = new System.Windows.Forms.RadioButton();
            this.rdoEql = new System.Windows.Forms.RadioButton();
            this.rdoLike = new System.Windows.Forms.RadioButton();
            this.label9 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.rdoAnd = new System.Windows.Forms.RadioButton();
            this.rdoOr = new System.Windows.Forms.RadioButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.rdoAdd = new System.Windows.Forms.RadioButton();
            this.rdoExc = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rdotext = new System.Windows.Forms.RadioButton();
            this.rdonumber = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.btnadd = new System.Windows.Forms.Button();
            this.검색문구 = new System.Windows.Forms.Label();
            this.txtsearch = new System.Windows.Forms.TextBox();
            this.cbheader = new System.Windows.Forms.ComboBox();
            this.lbcount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btntoexcel = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.basemaster = new System.Windows.Forms.ToolStripMenuItem();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.dtsearch = new System.Windows.Forms.DataGridView();
            this.Column7 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.cbFreeset = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.pnlTop1.SuspendLayout();
            this.pnlmid1.SuspendLayout();
            this.panel5.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsearch)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlTop1
            // 
            this.pnlTop1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTop1.Controls.Add(this.btnload);
            this.pnlTop1.Controls.Add(this.textBox1);
            this.pnlTop1.Location = new System.Drawing.Point(19, 47);
            this.pnlTop1.Name = "pnlTop1";
            this.pnlTop1.Size = new System.Drawing.Size(672, 47);
            this.pnlTop1.TabIndex = 0;
            // 
            // btnload
            // 
            this.btnload.Location = new System.Drawing.Point(318, 13);
            this.btnload.Name = "btnload";
            this.btnload.Size = new System.Drawing.Size(93, 19);
            this.btnload.TabIndex = 1;
            this.btnload.Text = "불러오기";
            this.btnload.UseVisualStyleBackColor = true;
            this.btnload.Click += new System.EventHandler(this.btnload_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(18, 13);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(284, 21);
            this.textBox1.TabIndex = 0;
            // 
            // pnlmid1
            // 
            this.pnlmid1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlmid1.Controls.Add(this.cbFreeset);
            this.pnlmid1.Controls.Add(this.label10);
            this.pnlmid1.Controls.Add(this.panel5);
            this.pnlmid1.Controls.Add(this.panel4);
            this.pnlmid1.Controls.Add(this.label9);
            this.pnlmid1.Controls.Add(this.panel3);
            this.pnlmid1.Controls.Add(this.panel2);
            this.pnlmid1.Controls.Add(this.panel1);
            this.pnlmid1.Controls.Add(this.button2);
            this.pnlmid1.Controls.Add(this.label8);
            this.pnlmid1.Controls.Add(this.label7);
            this.pnlmid1.Controls.Add(this.label6);
            this.pnlmid1.Controls.Add(this.label5);
            this.pnlmid1.Controls.Add(this.btnadd);
            this.pnlmid1.Controls.Add(this.검색문구);
            this.pnlmid1.Controls.Add(this.txtsearch);
            this.pnlmid1.Controls.Add(this.cbheader);
            this.pnlmid1.Location = new System.Drawing.Point(19, 113);
            this.pnlmid1.Name = "pnlmid1";
            this.pnlmid1.Size = new System.Drawing.Size(672, 138);
            this.pnlmid1.TabIndex = 1;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.radioButton2);
            this.panel5.Controls.Add(this.radioButton3);
            this.panel5.Location = new System.Drawing.Point(391, 22);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(68, 66);
            this.panel5.TabIndex = 22;
            this.panel5.Visible = false;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(8, 4);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(31, 16);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = ">";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton3
            // 
            this.radioButton3.AutoSize = true;
            this.radioButton3.Location = new System.Drawing.Point(8, 26);
            this.radioButton3.Name = "radioButton3";
            this.radioButton3.Size = new System.Drawing.Size(31, 16);
            this.radioButton3.TabIndex = 2;
            this.radioButton3.TabStop = true;
            this.radioButton3.Text = "<";
            this.radioButton3.UseVisualStyleBackColor = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.rdoIn);
            this.panel4.Controls.Add(this.rdoEql);
            this.panel4.Controls.Add(this.rdoLike);
            this.panel4.Location = new System.Drawing.Point(391, 22);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(68, 66);
            this.panel4.TabIndex = 21;
            // 
            // rdoIn
            // 
            this.rdoIn.AutoSize = true;
            this.rdoIn.Location = new System.Drawing.Point(8, 46);
            this.rdoIn.Name = "rdoIn";
            this.rdoIn.Size = new System.Drawing.Size(35, 16);
            this.rdoIn.TabIndex = 3;
            this.rdoIn.TabStop = true;
            this.rdoIn.Text = "IN";
            this.rdoIn.UseVisualStyleBackColor = true;
            // 
            // rdoEql
            // 
            this.rdoEql.AutoSize = true;
            this.rdoEql.Location = new System.Drawing.Point(8, 4);
            this.rdoEql.Name = "rdoEql";
            this.rdoEql.Size = new System.Drawing.Size(29, 16);
            this.rdoEql.TabIndex = 1;
            this.rdoEql.TabStop = true;
            this.rdoEql.Text = "=";
            this.rdoEql.UseVisualStyleBackColor = true;
            // 
            // rdoLike
            // 
            this.rdoLike.AutoSize = true;
            this.rdoLike.Location = new System.Drawing.Point(8, 26);
            this.rdoLike.Name = "rdoLike";
            this.rdoLike.Size = new System.Drawing.Size(49, 16);
            this.rdoLike.TabIndex = 2;
            this.rdoLike.TabStop = true;
            this.rdoLike.Text = "LIKE";
            this.rdoLike.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(391, 7);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(53, 12);
            this.label9.TabIndex = 21;
            this.label9.Text = "포함관계";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.rdoAnd);
            this.panel3.Controls.Add(this.rdoOr);
            this.panel3.Location = new System.Drawing.Point(317, 22);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(68, 66);
            this.panel3.TabIndex = 20;
            // 
            // rdoAnd
            // 
            this.rdoAnd.AutoSize = true;
            this.rdoAnd.Location = new System.Drawing.Point(13, 4);
            this.rdoAnd.Name = "rdoAnd";
            this.rdoAnd.Size = new System.Drawing.Size(45, 16);
            this.rdoAnd.TabIndex = 1;
            this.rdoAnd.TabStop = true;
            this.rdoAnd.Text = "And";
            this.rdoAnd.UseVisualStyleBackColor = true;
            // 
            // rdoOr
            // 
            this.rdoOr.AutoSize = true;
            this.rdoOr.Location = new System.Drawing.Point(13, 26);
            this.rdoOr.Name = "rdoOr";
            this.rdoOr.Size = new System.Drawing.Size(40, 16);
            this.rdoOr.TabIndex = 2;
            this.rdoOr.TabStop = true;
            this.rdoOr.Text = "OR";
            this.rdoOr.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.rdoAdd);
            this.panel2.Controls.Add(this.rdoExc);
            this.panel2.Location = new System.Drawing.Point(247, 22);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(68, 66);
            this.panel2.TabIndex = 20;
            // 
            // rdoAdd
            // 
            this.rdoAdd.AutoSize = true;
            this.rdoAdd.Location = new System.Drawing.Point(8, 4);
            this.rdoAdd.Name = "rdoAdd";
            this.rdoAdd.Size = new System.Drawing.Size(47, 16);
            this.rdoAdd.TabIndex = 1;
            this.rdoAdd.TabStop = true;
            this.rdoAdd.Text = "추가";
            this.rdoAdd.UseVisualStyleBackColor = true;
            // 
            // rdoExc
            // 
            this.rdoExc.AutoSize = true;
            this.rdoExc.Location = new System.Drawing.Point(8, 26);
            this.rdoExc.Name = "rdoExc";
            this.rdoExc.Size = new System.Drawing.Size(47, 16);
            this.rdoExc.TabIndex = 2;
            this.rdoExc.TabStop = true;
            this.rdoExc.Text = "제외";
            this.rdoExc.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.rdotext);
            this.panel1.Controls.Add(this.rdonumber);
            this.panel1.Location = new System.Drawing.Point(173, 22);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(68, 66);
            this.panel1.TabIndex = 19;
            // 
            // rdotext
            // 
            this.rdotext.AutoSize = true;
            this.rdotext.Location = new System.Drawing.Point(8, 4);
            this.rdotext.Name = "rdotext";
            this.rdotext.Size = new System.Drawing.Size(47, 16);
            this.rdotext.TabIndex = 1;
            this.rdotext.TabStop = true;
            this.rdotext.Text = "문자";
            this.rdotext.UseVisualStyleBackColor = true;
            // 
            // rdonumber
            // 
            this.rdonumber.AutoSize = true;
            this.rdonumber.Location = new System.Drawing.Point(8, 26);
            this.rdonumber.Name = "rdonumber";
            this.rdonumber.Size = new System.Drawing.Size(47, 16);
            this.rdonumber.TabIndex = 2;
            this.rdonumber.TabStop = true;
            this.rdonumber.Text = "숫자";
            this.rdonumber.UseVisualStyleBackColor = true;
            this.rdonumber.CheckedChanged += new System.EventHandler(this.rdonumber_CheckedChanged);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(476, 90);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(165, 35);
            this.button2.TabIndex = 18;
            this.button2.Text = "조건삭제";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(16, 7);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 12);
            this.label8.TabIndex = 17;
            this.label8.Text = "칼럼 헤더 명";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(332, 7);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 12);
            this.label7.TabIndex = 16;
            this.label7.Text = "And/Or";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(239, 7);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(83, 12);
            this.label6.TabIndex = 15;
            this.label6.Text = "추가/제외선택";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(179, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 12);
            this.label5.TabIndex = 14;
            this.label5.Text = "조건타입";
            // 
            // btnadd
            // 
            this.btnadd.Location = new System.Drawing.Point(476, 49);
            this.btnadd.Name = "btnadd";
            this.btnadd.Size = new System.Drawing.Size(165, 35);
            this.btnadd.TabIndex = 9;
            this.btnadd.Text = "조건추가";
            this.btnadd.UseVisualStyleBackColor = true;
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // 검색문구
            // 
            this.검색문구.AutoSize = true;
            this.검색문구.Location = new System.Drawing.Point(479, 7);
            this.검색문구.Name = "검색문구";
            this.검색문구.Size = new System.Drawing.Size(69, 12);
            this.검색문구.TabIndex = 5;
            this.검색문구.Text = "검색할 내용";
            // 
            // txtsearch
            // 
            this.txtsearch.Location = new System.Drawing.Point(476, 22);
            this.txtsearch.Name = "txtsearch";
            this.txtsearch.Size = new System.Drawing.Size(165, 21);
            this.txtsearch.TabIndex = 4;
            this.txtsearch.TextChanged += new System.EventHandler(this.txtsearch_TextChanged);
            // 
            // cbheader
            // 
            this.cbheader.FormattingEnabled = true;
            this.cbheader.Location = new System.Drawing.Point(18, 22);
            this.cbheader.Name = "cbheader";
            this.cbheader.Size = new System.Drawing.Size(149, 20);
            this.cbheader.TabIndex = 0;
            // 
            // lbcount
            // 
            this.lbcount.AutoSize = true;
            this.lbcount.Font = new System.Drawing.Font("굴림", 13F, System.Drawing.FontStyle.Bold);
            this.lbcount.Location = new System.Drawing.Point(110, 487);
            this.lbcount.Name = "lbcount";
            this.lbcount.Size = new System.Drawing.Size(193, 18);
            this.lbcount.TabIndex = 8;
            this.lbcount.Text = "조건을 만족하는 건수";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(28, 487);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "총 건수 :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(36, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 12);
            this.label1.TabIndex = 6;
            this.label1.Text = "파일 불러오기";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(35, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 12);
            this.label2.TabIndex = 7;
            this.label2.Text = "검색";
            // 
            // btntoexcel
            // 
            this.btntoexcel.Location = new System.Drawing.Point(286, 522);
            this.btntoexcel.Name = "btntoexcel";
            this.btntoexcel.Size = new System.Drawing.Size(124, 40);
            this.btntoexcel.TabIndex = 8;
            this.btntoexcel.Text = "To Excel";
            this.btntoexcel.UseVisualStyleBackColor = true;
            this.btntoexcel.Click += new System.EventHandler(this.btntoexcel_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(426, 522);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(124, 40);
            this.button1.TabIndex = 9;
            this.button1.Text = "화면정리";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(724, 24);
            this.menuStrip2.TabIndex = 11;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // ToolStripMenuItem
            // 
            this.ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.basemaster});
            this.ToolStripMenuItem.Name = "ToolStripMenuItem";
            this.ToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.ToolStripMenuItem.Text = "메뉴";
            // 
            // basemaster
            // 
            this.basemaster.Name = "basemaster";
            this.basemaster.Size = new System.Drawing.Size(122, 22);
            this.basemaster.Text = "기초코드";
            this.basemaster.Click += new System.EventHandler(this.basemaster_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // dtsearch
            // 
            this.dtsearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtsearch.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column7,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.Column6});
            this.dtsearch.Location = new System.Drawing.Point(21, 287);
            this.dtsearch.Name = "dtsearch";
            this.dtsearch.RowTemplate.Height = 23;
            this.dtsearch.Size = new System.Drawing.Size(670, 183);
            this.dtsearch.TabIndex = 10;
            // 
            // Column7
            // 
            this.Column7.HeaderText = "";
            this.Column7.Name = "Column7";
            this.Column7.Width = 30;
            // 
            // Column1
            // 
            this.Column1.HeaderText = "헤더명";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.HeaderText = "조건타입";
            this.Column2.Name = "Column2";
            this.Column2.Width = 80;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "추가제외";
            this.Column3.Name = "Column3";
            this.Column3.Width = 80;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "AND및OR";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "포함관계";
            this.Column5.Name = "Column5";
            // 
            // Column6
            // 
            this.Column6.HeaderText = "검색할내용";
            this.Column6.Name = "Column6";
            this.Column6.Width = 140;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 271);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 12);
            this.label4.TabIndex = 12;
            this.label4.Text = "조회조건";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(150, 523);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 40);
            this.button3.TabIndex = 13;
            this.button3.Text = "조회";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(567, 522);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(124, 40);
            this.button4.TabIndex = 14;
            this.button4.Text = "종료";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cbFreeset
            // 
            this.cbFreeset.FormattingEnabled = true;
            this.cbFreeset.Location = new System.Drawing.Point(18, 105);
            this.cbFreeset.Name = "cbFreeset";
            this.cbFreeset.Size = new System.Drawing.Size(149, 20);
            this.cbFreeset.TabIndex = 25;
            this.cbFreeset.SelectedIndexChanged += new System.EventHandler(this.cbFreeset_SelectedIndexChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(16, 90);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(41, 12);
            this.label10.TabIndex = 24;
            this.label10.Text = "프리셋";
            // 
            // SEARCHER
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(724, 591);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dtsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btntoexcel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pnlmid1);
            this.Controls.Add(this.lbcount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.pnlTop1);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SEARCHER";
            this.Text = "DaTa Search";
            this.pnlTop1.ResumeLayout(false);
            this.pnlTop1.PerformLayout();
            this.pnlmid1.ResumeLayout(false);
            this.pnlmid1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtsearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlTop1;
        private System.Windows.Forms.Button btnload;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Panel pnlmid1;
        private System.Windows.Forms.Label lbcount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label 검색문구;
        private System.Windows.Forms.TextBox txtsearch;
        private System.Windows.Forms.RadioButton rdonumber;
        private System.Windows.Forms.RadioButton rdotext;
        private System.Windows.Forms.ComboBox cbheader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btntoexcel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem basemaster;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnadd;
        private System.Windows.Forms.DataGridView dtsearch;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.RadioButton rdoAnd;
        private System.Windows.Forms.RadioButton rdoOr;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.RadioButton rdoAdd;
        private System.Windows.Forms.RadioButton rdoExc;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.RadioButton rdoIn;
        private System.Windows.Forms.RadioButton rdoEql;
        private System.Windows.Forms.RadioButton rdoLike;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn Column7;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column6;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton3;
        private System.Windows.Forms.ComboBox cbFreeset;
        private System.Windows.Forms.Label label10;
    }
}

