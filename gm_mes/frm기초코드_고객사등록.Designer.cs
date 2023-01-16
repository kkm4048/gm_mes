namespace gm_mes
{
    partial class frm기초코드_고객사등록
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frm기초코드_고객사등록));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.txt5 = new System.Windows.Forms.TextBox();
            this.txt4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.lblCnt = new System.Windows.Forms.Label();
            this.txt3 = new System.Windows.Forms.TextBox();
            this.txt2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txt1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn삭제 = new System.Windows.Forms.Button();
            this.btn등록 = new System.Windows.Forms.Button();
            this.btn수정 = new System.Windows.Forms.Button();
            this.btn초기화 = new System.Windows.Forms.Button();
            this.btn조회 = new System.Windows.Forms.Button();
            this.btn닫기 = new System.Windows.Forms.Button();
            this.spr = new FarPoint.Win.Spread.FpSpread();
            this.spr_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.spr)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.txt5);
            this.panel1.Controls.Add(this.txt4);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.lblCnt);
            this.panel1.Controls.Add(this.txt3);
            this.panel1.Controls.Add(this.txt2);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.txt1);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 50);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1142, 117);
            this.panel1.TabIndex = 100;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(12, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(41, 12);
            this.label9.TabIndex = 109;
            this.label9.Text = "담당자";
            this.label9.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txt5
            // 
            this.txt5.Location = new System.Drawing.Point(74, 66);
            this.txt5.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt5.MaxLength = 0;
            this.txt5.Name = "txt5";
            this.txt5.Size = new System.Drawing.Size(502, 21);
            this.txt5.TabIndex = 4;
            this.txt5.Enter += new System.EventHandler(this.txt_Enter);
            this.txt5.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt4
            // 
            this.txt4.Location = new System.Drawing.Point(310, 37);
            this.txt4.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt4.MaxLength = 0;
            this.txt4.Name = "txt4";
            this.txt4.Size = new System.Drawing.Size(266, 21);
            this.txt4.TabIndex = 3;
            this.txt4.Enter += new System.EventHandler(this.txt_Enter);
            this.txt4.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(260, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 12);
            this.label4.TabIndex = 100;
            this.label4.Text = "연락처";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopRight;
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
            // txt3
            // 
            this.txt3.Location = new System.Drawing.Point(74, 37);
            this.txt3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt3.MaxLength = 0;
            this.txt3.Name = "txt3";
            this.txt3.Size = new System.Drawing.Size(153, 21);
            this.txt3.TabIndex = 2;
            this.txt3.Enter += new System.EventHandler(this.txt_Enter);
            this.txt3.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // txt2
            // 
            this.txt2.Location = new System.Drawing.Point(310, 8);
            this.txt2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt2.MaxLength = 0;
            this.txt2.Name = "txt2";
            this.txt2.Size = new System.Drawing.Size(266, 21);
            this.txt2.TabIndex = 1;
            this.txt2.Enter += new System.EventHandler(this.txt_Enter);
            this.txt2.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 81;
            this.label2.Text = "고객사";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txt1
            // 
            this.txt1.Location = new System.Drawing.Point(74, 8);
            this.txt1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txt1.MaxLength = 0;
            this.txt1.Name = "txt1";
            this.txt1.Size = new System.Drawing.Size(153, 21);
            this.txt1.TabIndex = 0;
            this.txt1.Enter += new System.EventHandler(this.txt_Enter);
            this.txt1.Leave += new System.EventHandler(this.txt_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 12);
            this.label1.TabIndex = 70;
            this.label1.Text = "비고";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 60;
            this.label3.Text = "고객사코드";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.White;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btn삭제);
            this.panel2.Controls.Add(this.btn등록);
            this.panel2.Controls.Add(this.btn수정);
            this.panel2.Controls.Add(this.btn초기화);
            this.panel2.Controls.Add(this.btn조회);
            this.panel2.Controls.Add(this.btn닫기);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1142, 50);
            this.panel2.TabIndex = 99;
            // 
            // btn삭제
            // 
            this.btn삭제.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn삭제.Image = ((System.Drawing.Image)(resources.GetObject("btn삭제.Image")));
            this.btn삭제.Location = new System.Drawing.Point(574, 9);
            this.btn삭제.Name = "btn삭제";
            this.btn삭제.Size = new System.Drawing.Size(90, 32);
            this.btn삭제.TabIndex = 43;
            this.btn삭제.Text = "    삭 제";
            this.btn삭제.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn삭제.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn삭제.UseVisualStyleBackColor = true;
            this.btn삭제.Click += new System.EventHandler(this.btn삭제_Click);
            // 
            // btn등록
            // 
            this.btn등록.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn등록.Image = ((System.Drawing.Image)(resources.GetObject("btn등록.Image")));
            this.btn등록.Location = new System.Drawing.Point(396, 9);
            this.btn등록.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btn등록.Name = "btn등록";
            this.btn등록.Size = new System.Drawing.Size(90, 32);
            this.btn등록.TabIndex = 42;
            this.btn등록.Text = "    등 록";
            this.btn등록.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn등록.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn등록.UseVisualStyleBackColor = true;
            this.btn등록.Click += new System.EventHandler(this.btn등록_Click);
            // 
            // btn수정
            // 
            this.btn수정.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn수정.Image = ((System.Drawing.Image)(resources.GetObject("btn수정.Image")));
            this.btn수정.Location = new System.Drawing.Point(485, 9);
            this.btn수정.Name = "btn수정";
            this.btn수정.Size = new System.Drawing.Size(90, 32);
            this.btn수정.TabIndex = 41;
            this.btn수정.Text = "    수 정";
            this.btn수정.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn수정.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btn수정.UseVisualStyleBackColor = true;
            this.btn수정.Click += new System.EventHandler(this.btn수정_Click);
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
            this.spr.Location = new System.Drawing.Point(0, 167);
            this.spr.Name = "spr";
            this.spr.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.spr_Sheet1});
            this.spr.Size = new System.Drawing.Size(1142, 525);
            this.spr.TabIndex = 98;
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
            // frm기초코드_고객사등록
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1142, 692);
            this.Controls.Add(this.spr);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Name = "frm기초코드_고객사등록";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "고객사 등록";
            this.Load += new System.EventHandler(this.frm기초코드_고객사등록_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.spr)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spr_Sheet1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt5;
        private System.Windows.Forms.TextBox txt4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblCnt;
        private System.Windows.Forms.TextBox txt3;
        private System.Windows.Forms.TextBox txt2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn삭제;
        private System.Windows.Forms.Button btn등록;
        private System.Windows.Forms.Button btn수정;
        private System.Windows.Forms.Button btn초기화;
        private System.Windows.Forms.Button btn조회;
        private System.Windows.Forms.Button btn닫기;
        private FarPoint.Win.Spread.FpSpread spr;
        private FarPoint.Win.Spread.SheetView spr_Sheet1;
    }
}