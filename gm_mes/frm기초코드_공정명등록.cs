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
    public partial class frm기초코드_공정명등록 : Form
    {
        String sql = "";
        public frm기초코드_공정명등록()
        {
            InitializeComponent();
        }

        private void frm기초코드_공정명등록_Load(object sender, EventArgs e)
        {
            초기화();
            조회();
            조회2();
            조회3();

        }

        private void 조회()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();

            sql = "EXEC s_a101_공정명_대분류_조회 '1','','' ";

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
        }

        private void 등록()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_대분류_저장] '1'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회();
            초기화();
        }
        private void 수정()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_대분류_저장] '2'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회();

        }
        private void 삭제()
        {
            DialogResult dr;
            dr = MessageBox.Show("데이타를 삭제하시겠습니까?", "데이타삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;


            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_대분류_저장] '3'";
            sql = sql + "   ,'" + txt1.Text + "' ";
            sql = sql + "   ,'" + txt2.Text + "' ";
            sql = sql + "   ,'" + txt3.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회();
        }
        private void 초기화()
        {

            txt1.Text = "";
            txt2.Text = "";
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
            tb.BackColor = Color.Yellow;
        }

        private void txt_Leave(object sender, EventArgs e)
        {
            TextBox tb = (TextBox)sender;
            tb.BackColor = Color.White;

        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt1.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt2.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt3.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;

            txt21.Text = txt2.Text;
            txt23.Text = "";
            txt22.Text = "";
            txt31.Text = txt2.Text;

            조회2();
            조회3();
        }
        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb등급_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn조회2_Click(object sender, EventArgs e)
        {
            조회2();
        }

        private void btn등록2_Click(object sender, EventArgs e)
        {
            등록2();
        }

        private void bnt수정2_Click(object sender, EventArgs e)
        {
            수정2();
        }

        private void btn삭제2_Click(object sender, EventArgs e)
        {
            삭제2();
        }


        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();

            sql = "EXEC s_a101_공정명_중분류_조회 '1','" + txt21.Text + "','','' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }

        private void 등록2()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_중분류_저장] '1'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if ( !ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회2();
            초기화();
        }
        private void 수정2()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_중분류_저장] '2'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회2();

        }
        private void 삭제2()
        {
            DialogResult dr;
            dr = MessageBox.Show("데이타를 삭제하시겠습니까?", "데이타삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;


            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_중분류_저장] '3'";
            sql = sql + "   ,'" + txt21.Text + "' ";
            sql = sql + "   ,'" + txt23.Text + "' ";
            sql = sql + "   ,'" + txt22.Text + "' ";
            sql = sql + "   ,'" + txt24.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회2();
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt22.Text = spr2.ActiveSheet.Cells[e.Row, 1].Text;
            txt23.Text = spr2.ActiveSheet.Cells[e.Row, 0].Text;
            txt24.Text = spr2.ActiveSheet.Cells[e.Row, 2].Text;

            txt32.Text = txt22.Text ;
            txt33.Text = "";
            txt34.Text = "";
            txt35.Text = "";
            조회3();
        }

        private void btn조회3_Click(object sender, EventArgs e)
        {
            조회3();
        }


        private void 조회3()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();

            sql = "EXEC s_a101_공정명_소분류_조회 '1','" + txt31.Text + "','" + txt32.Text  +"','' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr3.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt3.Text = ds.Tables[0].Rows.Count.ToString();
            spr3.DataSource = ds;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).Locked = true;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr3.Sheets[0].Cells.Get(0, 0, spr3.Sheets[0].RowCount - 1, spr3.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr3.Sheets[0]);
            lblCnt3.Text = spr3.ActiveSheet.RowCount.ToString();
        }

        private void 등록3()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_소분류_저장] '1'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt34.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            sql = sql + "   ,'" + txt35.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if ( !ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회3();
            초기화();
        }
        private void 수정3()
        {
            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_소분류_저장] '2'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt34.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            sql = sql + "   ,'" + txt35.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회3();

        }
        private void 삭제3()
        {
            DialogResult dr;
            dr = MessageBox.Show("데이타를 삭제하시겠습니까?", "데이타삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No) return;


            sql = " ";
            sql = sql + "EXEC [s_a101_공정명_소분류_저장] '3'";
            sql = sql + "   ,'" + txt31.Text + "' ";
            sql = sql + "   ,'" + txt32.Text + "' ";
            sql = sql + "   ,'" + txt34.Text + "' ";
            sql = sql + "   ,'" + txt33.Text + "' ";
            sql = sql + "   ,'" + txt35.Text + "' ";
            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }
            조회3();
        }

        private void btn등록3_Click(object sender, EventArgs e)
        {
            등록3();
        }

        private void btn수정3_Click(object sender, EventArgs e)
        {
            수정3();
        }

        private void btn삭제3_Click(object sender, EventArgs e)
        {
            삭제3();
        }

        private void spr3_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr3.ActiveSheet);
        }

        private void spr3_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt33.Text = spr3.ActiveSheet.Cells[e.Row, 1].Text;
            txt34.Text = spr3.ActiveSheet.Cells[e.Row, 0].Text;
            txt35.Text = spr3.ActiveSheet.Cells[e.Row, 2].Text;

        }
    }
}
