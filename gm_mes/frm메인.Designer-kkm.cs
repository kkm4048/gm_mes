namespace gm_mes
{
    partial class frm메인
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
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마십시오.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.파일ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m파일_설정 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripSeparator();
            this.m파일_종료 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.m기초코드_고객사등록 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripSeparator();
            this.m기초코드_생산구분코드 = new System.Windows.Forms.ToolStripMenuItem();
            this.라벨출력ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.m라벨출력_라벨출력 = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.ts1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.파일ToolStripMenuItem,
            this.toolStripMenuItem2,
            this.라벨출력ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1266, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 파일ToolStripMenuItem
            // 
            this.파일ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m파일_설정,
            this.toolStripMenuItem1,
            this.m파일_종료});
            this.파일ToolStripMenuItem.Name = "파일ToolStripMenuItem";
            this.파일ToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.파일ToolStripMenuItem.Text = "파 일";
            // 
            // m파일_설정
            // 
            this.m파일_설정.Name = "m파일_설정";
            this.m파일_설정.Size = new System.Drawing.Size(102, 22);
            this.m파일_설정.Text = "설 정";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(99, 6);
            // 
            // m파일_종료
            // 
            this.m파일_종료.Name = "m파일_종료";
            this.m파일_종료.Size = new System.Drawing.Size(102, 22);
            this.m파일_종료.Text = "종 료";
            this.m파일_종료.Click += new System.EventHandler(this.m파일_종료_Click);
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m기초코드_고객사등록,
            this.toolStripMenuItem3,
            this.m기초코드_생산구분코드});
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(71, 20);
            this.toolStripMenuItem2.Text = "기초 코드";
            // 
            // m기초코드_고객사등록
            // 
            this.m기초코드_고객사등록.Name = "m기초코드_고객사등록";
            this.m기초코드_고객사등록.Size = new System.Drawing.Size(154, 22);
            this.m기초코드_고객사등록.Text = "고객사 등록";
            this.m기초코드_고객사등록.Click += new System.EventHandler(this.m기초코드_고객사등록_Click);
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(151, 6);
            // 
            // m기초코드_생산구분코드
            // 
            this.m기초코드_생산구분코드.Name = "m기초코드_생산구분코드";
            this.m기초코드_생산구분코드.Size = new System.Drawing.Size(154, 22);
            this.m기초코드_생산구분코드.Text = "생산 구분 코드";
            this.m기초코드_생산구분코드.Click += new System.EventHandler(this.m기초코드_생산구분코드_Click);
            // 
            // 라벨출력ToolStripMenuItem
            // 
            this.라벨출력ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.m라벨출력_라벨출력});
            this.라벨출력ToolStripMenuItem.Name = "라벨출력ToolStripMenuItem";
            this.라벨출력ToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.라벨출력ToolStripMenuItem.Text = "라벨 출력";
            // 
            // m라벨출력_라벨출력
            // 
            this.m라벨출력_라벨출력.Name = "m라벨출력_라벨출력";
            this.m라벨출력_라벨출력.Size = new System.Drawing.Size(126, 22);
            this.m라벨출력_라벨출력.Text = "라벨 출력";
            this.m라벨출력_라벨출력.Click += new System.EventHandler(this.m라벨출력_라벨출력_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ts1});
            this.statusStrip1.Location = new System.Drawing.Point(0, 778);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1266, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // ts1
            // 
            this.ts1.Name = "ts1";
            this.ts1.Size = new System.Drawing.Size(121, 17);
            this.ts1.Text = "toolStripStatusLabel1";
            // 
            // frm메인
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 800);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frm메인";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[D] 광명산업 mes 2021.12.24 01.18 01.20 01.26 04.06 221117";
            this.Load += new System.EventHandler(this.frm메인_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 파일ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m파일_설정;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem m파일_종료;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem m기초코드_고객사등록;
        private System.Windows.Forms.ToolStripSeparator toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem m기초코드_생산구분코드;
        private System.Windows.Forms.ToolStripMenuItem 라벨출력ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem m라벨출력_라벨출력;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel ts1;
    }
}

