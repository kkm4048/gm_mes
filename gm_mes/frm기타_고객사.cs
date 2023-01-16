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
    public partial class frm기타_고객사 : Form
    {
        String sql = "";
        public string 고객사코드 = "", 고객사 = "";
        public frm기타_고객사()
        {
            InitializeComponent();
        }

        private void frm기타_고객사_Load(object sender, EventArgs e)
        {
            초기화();
            조회();
        }
        private void 초기화()
        {

        }
        private void 조회()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();

            sql = "EXEC s_a101_고객사_조회 '2','','" + txt조회.Text + "','' ";

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
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void 닫기()
        {
            Close();
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


        }



        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb등급_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txt조회_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void spr_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            고객사코드 = spr.ActiveSheet.Cells[e.Row, 0].Text;
            고객사 = spr.ActiveSheet.Cells[e.Row, 1].Text;
            Close();
        }



    }
}
