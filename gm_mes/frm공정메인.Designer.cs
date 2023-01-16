namespace gm_mes
{
    partial class frm공정메인
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm공정메인));
            this.pan11 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt조회1 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.pan공정표 = new System.Windows.Forms.Panel();
            this.pan데이타 = new System.Windows.Forms.Panel();
            this.spr2 = new FarPoint.Win.Spread.FpSpread();
            this.spr2_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel4 = new System.Windows.Forms.Panel();
            this.txt공정명_소분류 = new System.Windows.Forms.TextBox();
            this.txt공정명_대분류 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt조회2 = new System.Windows.Forms.TextBox();
            this.lbl타이틀1 = new System.Windows.Forms.Label();
            this.lblCnt2 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.sc = new System.Windows.Forms.SplitContainer();
            this.pan11.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.pan공정표.SuspendLayout();
            this.pan데이타.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sc)).BeginInit();
            this.sc.Panel1.SuspendLayout();
            this.sc.Panel2.SuspendLayout();
            this.sc.SuspendLayout();
            this.SuspendLayout();
            // 
            // pan11
            // 
            this.pan11.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pan11.Controls.Add(this.label1);
            this.pan11.Controls.Add(this.lblCnt);
            this.pan11.Controls.Add(this.txt조회1);
            this.pan11.Dock = System.Windows.Forms.DockStyle.Top;
            this.pan11.Location = new System.Drawing.Point(0, 0);
            this.pan11.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.pan11.Name = "pan11";
            this.pan11.Size = new System.Drawing.Size(457, 65);
            this.pan11.TabIndex = 100;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(8, 4);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 21);
            this.label1.TabIndex = 99;
            this.label1.Text = "공정표";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt
            // 
            this.lblCnt.AutoSize = true;
            this.lblCnt.Location = new System.Drawing.Point(9, 37);
            this.lblCnt.Name = "lblCnt";
            this.lblCnt.Size = new System.Drawing.Size(11, 12);
            this.lblCnt.TabIndex = 98;
            this.lblCnt.Text = "0";
            // 
            // txt조회1
            // 
            this.txt조회1.Location = new System.Drawing.Point(159, 7);
            this.txt조회1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회1.MaxLength = 0;
            this.txt조회1.Name = "txt조회1";
            this.txt조회1.Size = new System.Drawing.Size(69, 21);
            this.txt조회1.TabIndex = 0;
            this.txt조회1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt조회1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn초기화);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1381, 50);
            this.panel2.TabIndex = 99;
            // 
            // btn조회
            // 
            this.btn조회.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn조회.Image = ((System.Drawing.Image)(resources.GetObject("btn조회.Image")));
            this.btn조회.Location = new System.Drawing.Point(159, 9);
            this.btn조회.Margin = new System.Windows.Forms.Padding(10, 12, 10, 12);
            this.btn조회.Name = "btn조회";
            this.btn조회.Size = new System.Drawing.Size(72, 32);
            this.btn조회.TabIndex = 41;
            this.btn조회.Text = "    조회";
            this.btn조회.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn조회.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn조회.UseVisualStyleBackColor = true;
            this.btn조회.Click += new System.EventHandler(this.btn조회_Click);
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
            this.spr.Location = new System.Drawing.Point(0, 65);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(457, 573);
            this.spr.TabIndex = 98;
            this.spr.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr_ColumnWidthChanged);
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
            // pan공정표
            // 
            this.pan공정표.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan공정표.Controls.Add(this.spr);
            this.pan공정표.Controls.Add(this.pan11);
            this.pan공정표.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan공정표.Location = new System.Drawing.Point(0, 0);
            this.pan공정표.Name = "pan공정표";
            this.pan공정표.Size = new System.Drawing.Size(459, 640);
            this.pan공정표.TabIndex = 101;
            // 
            // pan데이타
            // 
            this.pan데이타.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pan데이타.Controls.Add(this.spr2);
            this.pan데이타.Controls.Add(this.panel4);
            this.pan데이타.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pan데이타.Location = new System.Drawing.Point(0, 0);
            this.pan데이타.Name = "pan데이타";
            this.pan데이타.Size = new System.Drawing.Size(916, 640);
            this.pan데이타.TabIndex = 102;
            // 
            // spr2
            // 
            this.spr2.AccessibleDescription = "spr, Sheet1, Row 0, Column 0, ";
            this.spr2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.spr2.Location = new System.Drawing.Point(0, 64);
            this.spr2.Name = "spr2";
            this.spr2.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr2_Sheet1});
            this.spr2.Size = new System.Drawing.Size(914, 574);
            this.spr2.TabIndex = 98;
            this.spr2.ColumnWidthChanged += new FarPoint.Win.Spread.ColumnWidthChangedEventHandler(this.spr2_ColumnWidthChanged);
            this.spr2.CellClick += new FarPoint.Win.Spread.CellClickEventHandler(this.spr2_CellClick);
            // 
            // spr2_Sheet1
            // 
            this.spr2_Sheet1.Reset();
            spr2_Sheet1.SheetName = "Sheet3";
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
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel4.Controls.Add(this.txt공정명_소분류);
            this.panel4.Controls.Add(this.txt공정명_대분류);
            this.panel4.Controls.Add(this.label2);
            this.panel4.Controls.Add(this.txt조회2);
            this.panel4.Controls.Add(this.lbl타이틀1);
            this.panel4.Controls.Add(this.lblCnt2);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel4.Location = new System.Drawing.Point(0, 0);
            this.panel4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(914, 64);
            this.panel4.TabIndex = 100;
            // 
            // txt공정명_소분류
            // 
            this.txt공정명_소분류.Enabled = false;
            this.txt공정명_소분류.Location = new System.Drawing.Point(569, 9);
            this.txt공정명_소분류.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt공정명_소분류.MaxLength = 0;
            this.txt공정명_소분류.Name = "txt공정명_소분류";
            this.txt공정명_소분류.Size = new System.Drawing.Size(248, 21);
            this.txt공정명_소분류.TabIndex = 103;
            // 
            // txt공정명_대분류
            // 
            this.txt공정명_대분류.Enabled = false;
            this.txt공정명_대분류.Location = new System.Drawing.Point(159, 9);
            this.txt공정명_대분류.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt공정명_대분류.MaxLength = 0;
            this.txt공정명_대분류.Name = "txt공정명_대분류";
            this.txt공정명_대분류.Size = new System.Drawing.Size(248, 21);
            this.txt공정명_대분류.TabIndex = 102;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(413, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(150, 21);
            this.label2.TabIndex = 101;
            this.label2.Text = "공정명 소분류";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt조회2
            // 
            this.txt조회2.Location = new System.Drawing.Point(65, 36);
            this.txt조회2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt조회2.MaxLength = 0;
            this.txt조회2.Name = "txt조회2";
            this.txt조회2.Size = new System.Drawing.Size(221, 21);
            this.txt조회2.TabIndex = 100;
            // 
            // lbl타이틀1
            // 
            this.lbl타이틀1.AutoSize = true;
            this.lbl타이틀1.Font = new System.Drawing.Font("굴림", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.lbl타이틀1.ForeColor = System.Drawing.Color.Blue;
            this.lbl타이틀1.Location = new System.Drawing.Point(3, 9);
            this.lbl타이틀1.Name = "lbl타이틀1";
            this.lbl타이틀1.Size = new System.Drawing.Size(150, 21);
            this.lbl타이틀1.TabIndex = 99;
            this.lbl타이틀1.Text = "공정명 대분류";
            this.lbl타이틀1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblCnt2
            // 
            this.lblCnt2.AutoSize = true;
            this.lblCnt2.Location = new System.Drawing.Point(4, 46);
            this.lblCnt2.Name = "lblCnt2";
            this.lblCnt2.Size = new System.Drawing.Size(11, 12);
            this.lblCnt2.TabIndex = 98;
            this.lblCnt2.Text = "0";
            // 
            // panel5
            // 
            this.panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel5.Controls.Add(this.sc);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel5.Location = new System.Drawing.Point(0, 50);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1381, 642);
            this.panel5.TabIndex = 103;
            // 
            // sc
            // 
            this.sc.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sc.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.sc.Location = new System.Drawing.Point(0, 0);
            this.sc.Name = "sc";
            // 
            // sc.Panel1
            // 
            this.sc.Panel1.Controls.Add(this.pan공정표);
            // 
            // sc.Panel2
            // 
            this.sc.Panel2.Controls.Add(this.pan데이타);
            this.sc.Size = new System.Drawing.Size(1379, 640);
            this.sc.SplitterDistance = 459;
            this.sc.TabIndex = 103;
            this.sc.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.sc_SplitterMoved);
            // 
            // frm공정메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1381, 692);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel2);
            this.Name = "frm공정메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "공정 메인";
            this.Load += new System.EventHandler(this.frm공정메인_Load);
            this.pan11.ResumeLayout(false);
            this.pan11.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.pan공정표.ResumeLayout(false);
            this.pan데이타.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr2_Sheet1)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.sc.Panel1.ResumeLayout(false);
            this.sc.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sc)).EndInit();
            this.sc.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pan11;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt조회1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
        private System.Windows.Forms.Panel pan공정표;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel pan데이타;
        private FarPoint.Win.Spread.FpSpread spr2;
        private FarPoint.Win.Spread.SheetView spr2_Sheet1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label lbl타이틀1;
        private System.Windows.Forms.Label lblCnt2;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox txt조회2;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.SplitContainer sc;
        private System.Windows.Forms.TextBox txt공정명_소분류;
        private System.Windows.Forms.TextBox txt공정명_대분류;
        private System.Windows.Forms.Label label2;
    }
}