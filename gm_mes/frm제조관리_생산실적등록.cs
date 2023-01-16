using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace gm_mes
{
    public partial class frm제조관리_생산실적등록 : Form
    {
        String sql = "";
        public frm제조관리_생산실적등록()
        {
            InitializeComponent();
        }

        private void frm제조관리_생산실적등록_Load(object sender, EventArgs e)
        {
            초기화();
            Add공정명_대분류();
            Add공정명_중분류();
            Add공정명_소분류();
            조회();
            txt1.Focus();
        }
        private void Add공정명_대분류()
        {
            sql = " exec s_a101_공정명_대분류_조회 '1' ,'',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명_대분류.Items.Clear();
            cmb공정명_대분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명_대분류.Items.Add(ds.Tables[0].Rows[i]["공정명_대분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_대분류");
            cmb공정명_대분류.Text = d;
        }
        private void Add공정명_중분류()
        {
            sql = " exec s_a101_공정명_중분류_조회 '1' ,'" + cmb공정명_대분류.Text  +"','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명_중분류.Items.Clear();
            cmb공정명_중분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명_중분류.Items.Add(ds.Tables[0].Rows[i]["공정명_중분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_중분류");
            cmb공정명_중분류.Text = d;
        }
        private void Add공정명_소분류()
        {
            sql = " exec s_a101_공정명_소분류_조회 '1' ,'" + cmb공정명_대분류.Text + "','"  + cmb공정명_중분류.Text  +"' ,''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명_소분류.Items.Clear();
            cmb공정명_소분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명_소분류.Items.Add(ds.Tables[0].Rows[i]["공정명_소분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_소분류");
            cmb공정명_소분류.Text = d;

        }
        private void 조회()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();
            sql = "EXEC s_a301_생산실적_조회 '1','" + cls_com.GetDate()  + "','" + cls_com.GetDate() + "','" + cmb공정명_대분류.Text  +"','" + cmb공정명_중분류.Text  +"','" + cmb공정명_소분류.Text + "','','' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            txt1.Focus();
        }

        private void 등록()
        {
            sql = " ";
            sql = sql + "EXEC [s_a301_생산실적_저장] '1'";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + ""  + "' ";
            sql = sql + "   ,'" + cmb공정명_대분류.Text + "' ";
            sql = sql + "   ,'" + cmb공정명_중분류.Text + "' ";
            sql = sql + "   ,'" + cmb공정명_소분류.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0 )
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    포커스();
                    return;
                }
            }
            조회();
            포커스();
        }
        private void 수정()
        {
        

        }
        private void 삭제()
        {
            DialogResult dr;
            dr = MessageBox.Show("데이타를 삭제하시겠습니까?", "데이타삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;


            sql = " ";
            sql = sql + "EXEC [s_a301_생산실적_저장] '1'";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + "" + "' ";
            sql = sql + "   ,'" + cmb공정명_대분류.Text + "' ";
            sql = sql + "   ,'" + cmb공정명_중분류.Text + "' ";
            sql = sql + "   ,'" + cmb공정명_소분류.Text + "' ";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + cls_com.s사용자.성명 + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds.Tables[0].Rows.Count > 0)
            {
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                    return;
                }
            }
            조회();
        }
        private void 초기화()
        {

            txt1.Text = "";
            txt1.Focus();
        }
        
        private void 닫기()
        {
            Close();
        }


        private void btn등록_Click(object sender, EventArgs e)
        {
            등록();
        }

        private void btn수정_Click(object sender, EventArgs e)
        {
            수정();
        }

        private void btn삭제_Click(object sender, EventArgs e)
        {
            삭제();
        }

        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void btn닫기_Click(object sender, EventArgs e)
        {
            닫기();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void txt_Enter(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = cls_color.gColor_수정;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;

        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
          //  txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb등급_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb공정명_대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_공정명_대분류", cmb공정명_대분류.Text);
            Add공정명_중분류();
        }

        private void cmb공정명_소분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_공정명_소분류", cmb공정명_소분류.Text);
            조회();
            txt1.Focus();
        }

        private void txt1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                등록();
            }
        }

        private void frm제조관리_생산실적등록_Activated(object sender, EventArgs e)
        {
            txt1.Focus();
        }
        private void 포커스()
        {
            txt1.Text = "";
            txt1.Focus();
        }

        private void spr_ColumnWidthChanged_1(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void cmb공정명_중분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_공정명_중분류", cmb공정명_중분류.Text);
            Add공정명_소분류();
        }
    }
}
