namespace gm_mes
{
    partial class frm품질관리_품질판정조회_상세조회
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm품질관리_품질판정조회_상세조회));
            this.panel1 = new System.Windows.Forms.Panel();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmb공정명중분류 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmb공정명소분류 = new System.Windows.Forms.ComboBox();
            this.cmb공정명대분류 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dtp2 = new System.Windows.Forms.DateTimePicker();
            this.dtp1 = new System.Windows.Forms.DateTimePicker();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.dtp = new System.Windows.Forms.DateTimePicker();
            this.txt공정명대분류 = new System.Windows.Forms.TextBox();
            this.txt공정명중분류 = new System.Windows.Forms.TextBox();
            this.txt공정명소분류 = new System.Windows.Forms.TextBox();
            this.txt모델2 = new System.Windows.Forms.TextBox();
            this.txtLotNo2 = new System.Windows.Forms.TextBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.cmb공정명중분류);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.cmb공정명소분류);
            this.panel1.Controls.Add(this.cmb공정명대분류);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.lblCnt);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1311, 117);
            this.panel1.TabIndex = 100;
            // 
            // txt2
            // 
            this.txt2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt2.Location = new System.Drawing.Point(615, 51);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(345, 26);
            this.txt2.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(537, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 16);
            this.label2.TabIndex = 117;
            this.label2.Text = "LOT NO";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb공정명중분류
            // 
            this.cmb공정명중분류.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb공정명중분류.FormattingEnabled = true;
            this.cmb공정명중분류.Location = new System.Drawing.Point(486, 13);
            this.cmb공정명중분류.Name = "cmb공정명중분류";
            this.cmb공정명중분류.Size = new System.Drawing.Size(215, 24);
            this.cmb공정명중분류.TabIndex = 115;
            this.cmb공정명중분류.SelectedIndexChanged += new System.EventHandler(this.cmb공정명_중분류_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(363, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 114;
            this.label1.Text = "공정명(중분류)";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // cmb공정명소분류
            // 
            this.cmb공정명소분류.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb공정명소분류.FormattingEnabled = true;
            this.cmb공정명소분류.Location = new System.Drawing.Point(828, 13);
            this.cmb공정명소분류.Name = "cmb공정명소분류";
            this.cmb공정명소분류.Size = new System.Drawing.Size(269, 24);
            this.cmb공정명소분류.TabIndex = 113;
            this.cmb공정명소분류.SelectedIndexChanged += new System.EventHandler(this.cmb공정명_소분류_SelectedIndexChanged);
            // 
            // cmb공정명대분류
            // 
            this.cmb공정명대분류.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.cmb공정명대분류.FormattingEnabled = true;
            this.cmb공정명대분류.Location = new System.Drawing.Point(142, 13);
            this.cmb공정명대분류.Name = "cmb공정명대분류";
            this.cmb공정명대분류.Size = new System.Drawing.Size(216, 24);
            this.cmb공정명대분류.TabIndex = 112;
            this.cmb공정명대분류.SelectedIndexChanged += new System.EventHandler(this.cmb공정명_대분류_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label6.Location = new System.Drawing.Point(698, 17);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 16);
            this.label6.TabIndex = 111;
            this.label6.Text = "공정명(소분류)";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label5.Location = new System.Drawing.Point(12, 17);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 16);
            this.label5.TabIndex = 110;
            this.label5.Text = "공정명(대분류)";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(3, 93);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt1
            // 
            this.txt1.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.txt1.Location = new System.Drawing.Point(142, 51);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(345, 26);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(30, 56);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 16);
            this.label3.TabIndex = 60;
            this.label3.Text = "모델";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.dtp2);
            this.panel2.Controls.Add(this.dtp1);
            this.panel2.Controls.Add(this.btn초기화);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1311, 50);
            this.panel2.TabIndex = 99;
            // 
            // dtp2
            // 
            this.dtp2.Location = new System.Drawing.Point(858, 13);
            this.dtp2.Name = "dtp2";
            this.dtp2.Size = new System.Drawing.Size(153, 21);
            this.dtp2.TabIndex = 105;
            // 
            // dtp1
            // 
            this.dtp1.Location = new System.Drawing.Point(692, 13);
            this.dtp1.Name = "dtp1";
            this.dtp1.Size = new System.Drawing.Size(153, 21);
            this.dtp1.TabIndex = 104;
            // 
            // btn초기화
            // 
            this.btn초기화.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn초기화.Image = ((System.Drawing.Image)(resources.GetObject("btn초기화.Image")));
            this.btn초기화.Location = new System.Drawing.Point(299, 9);
            this.btn초기화.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn초기화.Name = "btn초기화";
            this.btn초기화.Size = new System.Drawing.Size(90, 32);
            this.btn초기화.TabIndex = 40;
            this.btn초기화.Text = "   초기화";
            this.btn초기화.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn초기화.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn초기화.UseVisualStyleBackColor = true;
            this.btn초기화.Click += new System.EventHandler(this.btn초기화_Click);
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(114, 9);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(90, 32);
            this.btn조회.TabIndex = 39;
            this.btn조회.Text = "    조 회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
            // 
            // btn닫기
            // 
            this.btn닫기.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn닫기.Image = ((System.Drawing.Image)(resources.GetObject("btn닫기.Image")));
            this.btn닫기.Location = new System.Drawing.Point(11, 9);
            this.btn닫기.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn닫기.Name = "btn닫기";
            this.btn닫기.Size = new System.Drawing.Size(90, 32);
            this.btn닫기.TabIndex = 27;
            this.btn닫기.Text = "    닫 기";
            this.btn닫기.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn닫기.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn닫기.UseVisualStyleBackColor = true;
            this.btn닫기.Click += new System.EventHandler(this.btn닫기_Click);
            // 
            // spr
            // 
            this.spr.AccessibleDescription = "spr, Sheet1, Row 0, Column 0, ";
            this.spr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr.Location = new System.Drawing.Point(0, 0);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(442, 525);
            this.spr.TabIndex = 98;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged_1);
            this.spr.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr_CellClick);
            // 
            // spr_Sheet1
            // 
            this.spr_Sheet1.Reset();
            spr_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc.Location = new System.Drawing.Point(0, 167);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.spr);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.spr2);
            this.sc.Panel2.Controls.Add(this.panel3);
            this.sc.Size = new System.Drawing.Size(1311, 525);
            this.sc.SplitterDistance = 442;
            this.sc.TabIndex = 101;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "spr, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 62);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(865, 463);
            this.spr2.TabIndex = 99;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet2";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.spr2_Sheet1.ActiveSkin = new FarPoint.Win.Spread.SheetSkin("CustomSkin1", System.Drawing.SystemColors.Control, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.LightGray, FarPoint.Win.Spread.GridLines.Both, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.Empty, System.Drawing.Color.WhiteSmoke, false, false, false, true, true, "ColumnHeaderEnhanced", "RowHeaderEnhanced", "DataAreaDefault", "CornerEnhanced");
            this.spr2_Sheet1.ColumnHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.ColumnHeader.DefaultStyle.Parent = "ColumnHeaderEnhanced";
            this.spr2_Sheet1.ColumnHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.spr2_Sheet1.RowHeader.Columns.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderEnhanced";
            this.spr2_Sheet1.RowHeader.Rows.Default.VisualStyles = FarPoint.Win.VisualStyles.Auto;
            this.spr2_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.spr2_Sheet1.SheetCornerStyle.Parent = "CornerEnhanced";
            this.spr2_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // panel3
            // 
            this.panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel3.Controls.Add(this.txtLotNo2);
            this.panel3.Controls.Add(this.txt모델2);
            this.panel3.Controls.Add(this.txt공정명소분류);
            this.panel3.Controls.Add(this.txt공정명중분류);
            this.panel3.Controls.Add(this.txt공정명대분류);
            this.panel3.Controls.Add(this.lblCnt2);
            this.panel3.Controls.Add(this.dtp);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(865, 62);
            this.panel3.TabIndex = 0;
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(13, 46);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 102;
            this.lblCnt2.Text = "0";
            // 
            // dtp
            // 
            this.dtp.Location = new System.Drawing.Point(699, 14);
            this.dtp.Name = "dtp";
            this.dtp.Size = new System.Drawing.Size(153, 21);
            this.dtp.TabIndex = 101;
            // 
            // txt공정명대분류
            // 
            this.txt공정명대분류.Location = new System.Drawing.Point(59, 6);
            this.txt공정명대분류.Name = "txt공정명대분류";
            this.txt공정명대분류.Size = new System.Drawing.Size(184, 21);
            this.txt공정명대분류.TabIndex = 103;
            // 
            // txt공정명중분류
            // 
            this.txt공정명중분류.Location = new System.Drawing.Point(255, 6);
            this.txt공정명중분류.Name = "txt공정명중분류";
            this.txt공정명중분류.Size = new System.Drawing.Size(184, 21);
            this.txt공정명중분류.TabIndex = 104;
            // 
            // txt공정명소분류
            // 
            this.txt공정명소분류.Location = new System.Drawing.Point(445, 3);
            this.txt공정명소분류.Name = "txt공정명소분류";
            this.txt공정명소분류.Size = new System.Drawing.Size(184, 21);
            this.txt공정명소분류.TabIndex = 105;
            // 
            // txt모델2
            // 
            this.txt모델2.Location = new System.Drawing.Point(59, 33);
            this.txt모델2.Name = "txt모델2";
            this.txt모델2.Size = new System.Drawing.Size(184, 21);
            this.txt모델2.TabIndex = 106;
            // 
            // txtLotNo2
            // 
            this.txtLotNo2.Location = new System.Drawing.Point(255, 33);
            this.txtLotNo2.Name = "txtLotNo2";
            this.txtLotNo2.Size = new System.Drawing.Size(184, 21);
            this.txtLotNo2.TabIndex = 107;
            // 
            // frm품질관리_품질판정조회_상세조회
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1311, 692);
            this.Controls.Add(this.sc);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm품질관리_품질판정조회_상세조회";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "검사 상세 조회";
            this.Activated += new System.EventHandler(this.frm제조관리_생산실적등록_Activated);
            this.Load += new System.EventHandler(this.frm품질관리_품질판정조회_상세조회_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.ComboBox cmb공정명소분류;
        private System.Windows.Forms.ComboBox cmb공정명대분류;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmb공정명중분류;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.SplitContainer sc;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.DateTimePicker dtp;
        private System.Windows.Forms.DateTimePicker dtp2;
        private System.Windows.Forms.DateTimePicker dtp1;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.TextBox txtLotNo2;
        private System.Windows.Forms.TextBox txt모델2;
        private System.Windows.Forms.TextBox txt공정명소분류;
        private System.Windows.Forms.TextBox txt공정명중분류;
        private System.Windows.Forms.TextBox txt공정명대분류;
    }
}