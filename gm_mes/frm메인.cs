using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace gm_mes
{
    public partial class frm메인 : Form
    {
        public frm메인()
        {
            InitializeComponent();
        }

        private void frm메인_Load(object sender, EventArgs e)
        {
            초기화();
        }
        private void 초기화()
        {
            ts1.Text = cls_com.s사용자.아이디 + " " + cls_com.s사용자.성명;
            ts1.Text = ts1.Text + " " + cls_com.s사용자.등급 + " ";
        }

        protected void FrmShow(Form frm)
        {
            bool FrmisExist = new bool();
            FrmisExist = false;

            foreach (Form form1 in Application.OpenForms)
            {
                if (form1.GetType() == frm.GetType())
                {

                    form1.Activate();
                    form1.Focus();
                    FrmisExist = true;
                }
            }

            // 폼존재여부에 따라서 생성과 파기
            if (!FrmisExist)
            {

                frm.MdiParent = this;
                frm.WindowState = FormWindowState.Maximized;
                frm.Show();
                frm.Activate();
                frm.Focus();
                frm.BringToFront();
            }
            else
            {
                frm.Dispose();
            }

        }

        private void m파일_종료_Click(object sender, EventArgs e)
        {
            종료();
        }
        private void 종료()
        {
            DialogResult dr = MessageBox.Show("종료 하시겠습니까?", "종료", MessageBoxButtons.YesNo);
            if (dr == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void m기초코드_생산구분코드_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_생산구분코드());
        }

        private void m기초코드_고객사등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_고객사등록());
        }

        private void m라벨출력_라벨출력_Click(object sender, EventArgs e)
        {
            FrmShow(new frm라벨출력_라벨출력());
        }

        private void m기초코드_공정명등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_공정명등록());
        }

        private void m제조관리_생산실적등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm제조관리_생산실적등록());
        }

        private void m공정메인_Click(object sender, EventArgs e)
        {
            FrmShow(new frm공정메인());
        }

        private void m기준정보_공정별검사항목등록_Click(object sender, EventArgs e)
        {
            FrmShow(new frm기초코드_공정별검사항목등록());
        }

        private void m품질관리_품질판정조회_Click(object sender, EventArgs e)
        {
            FrmShow(new frm품질관리_품질판정조회());
        }

        private void m품질관리_계측기관리_Click(object sender, EventArgs e)
        {

        }
    }
}
