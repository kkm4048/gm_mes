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
    public partial class frm품질관리_품질판정조회_상세조회 : Form
    {
        String sql = "";
        public frm품질관리_품질판정조회_상세조회()
        {
            InitializeComponent();
        }

        private void frm품질관리_품질판정조회_상세조회_Load(object sender, EventArgs e)
        {
            초기화();
            Add공정명_대분류();
            Add공정명_중분류();
            Add공정명_소분류();
            조회();
            조회2();
            txt1.Focus();
            dtp.Value = cls_com.GetDate();
            sc.SplitterDistance = cls_com.Val(cls_com.ConfigLoad(this.Name + "_sc넓이", "500"));

        }
        private void Add공정명_대분류()
        {
            sql = " exec s_a101_공정명_대분류_조회 '1' ,'',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명대분류.Items.Clear();
            cmb공정명대분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명대분류.Items.Add(ds.Tables[0].Rows[i]["공정명_대분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_대분류");
            cmb공정명대분류.Text = d;
        }
        private void Add공정명_중분류()
        {
            sql = " exec s_a101_공정명_중분류_조회 '1' ,'" + cmb공정명대분류.Text + "','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명중분류.Items.Clear();
            cmb공정명중분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명중분류.Items.Add(ds.Tables[0].Rows[i]["공정명_중분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_중분류");
            cmb공정명중분류.Text = d;
        }
        private void Add공정명_소분류()
        {
            sql = " exec s_a101_공정명_소분류_조회 '1' ,'" + cmb공정명대분류.Text + "','" + cmb공정명중분류.Text + "' ,''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb공정명소분류.Items.Clear();
            cmb공정명소분류.Items.Add("");
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb공정명소분류.Items.Add(ds.Tables[0].Rows[i]["공정명_소분류"].ToString());
            }
            string d;
            d = cls_com.ConfigLoad(this.Name + "_공정명_소분류");
            cmb공정명소분류.Text = d;

        }
        private void 조회()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();
            sql = "EXEC s_a401_품질관리_검사조회_조회 '1','" + cls_com.GetDate(dtp1.Value) + "','" + cls_com.GetDate(dtp2.Value) + "','','','"
                +  cmb공정명대분류.Text + "','" + cmb공정명중분류.Text + "','" + cmb공정명소분류.Text + "','' ";

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
        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();
            sql = "EXEC s_a401_품질관리_검사조회_상세조회_조회 '1','" + cls_com.GetDate(dtp.Value) + "','" + cls_com.GetDate(dtp.Value) + "','"  + txt모델2.Text + "','"  + txtLotNo2.Text  +"','"
                    + txt공정명대분류.Text + "','" + txt공정명중분류.Text + "','" + txt공정명소분류.Text + "', '' ";
            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;
            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            헤드( ds );
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
    
        private void 초기화()
        {

            txt1.Text = "";
            txt1.Focus();
        }

        private void 닫기()
        {
            Close();
        }


        private void 헤드(DataSet ds)
        {
            int i;
            string 검사명 = "";
            int col1, col2;
            spr2.ActiveSheet.ColumnHeader.RowCount = 2;
            spr2.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            spr2.ActiveSheet.ColumnHeader.Rows[1].Height = 50;

            for (i = 0; i < 5; i ++ )
            {
                spr2.ActiveSheet.ColumnHeader.Cells[0, i].Text = ds.Tables[0].Columns[i].ColumnName.ToString();
                spr2.ActiveSheet.AddColumnHeaderSpanCell(0, i, 2, 1);
            }
            col1 = 5;
            col2 = 5; 

            for(i = 5; i < ds.Tables[0].Columns.Count; i ++)
            {
                string[] arr = ds.Tables[0].Columns[i].ColumnName.ToString().Split('_');
                
                if ( arr.Length == 2 )
                {
                    spr2.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[0];
                    spr2.ActiveSheet.ColumnHeader.Cells[1, i].Text = arr[1];
                    if(arr[0].Equals(검사명))
                    {
                        col2 = i;
                    } else
                    {
                        spr2.ActiveSheet.AddColumnHeaderSpanCell(0, col1, 1, col2 - col1+1);
                        col1 = i;
                        col2 = i;
                        검사명 = arr[0];
                    }
                }
                else
                {
                    spr2.ActiveSheet.ColumnHeader.Cells[0, i].Text = arr[0];

                }
            }
        }

        private void btn초기화_Click(object sender, EventArgs e)
        {
            초기화();
        }

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
            조회2();
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
            txt공정명대분류.Text = spr.ActiveSheet.Cells[e.Row, 0].Text;
            txt공정명중분류.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt공정명소분류.Text = spr.ActiveSheet.Cells[e.Row, 2].Text;
            txt모델2.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            txtLotNo2.Text = spr.ActiveSheet.Cells[e.Row, 4].Text;

            조회2();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void cmb등급_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void cmb공정명_대분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_공정명_대분류", cmb공정명대분류.Text);
            Add공정명_중분류();
        }

        private void cmb공정명_소분류_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_공정명_소분류", cmb공정명소분류.Text);
            조회();
            txt1.Focus();
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
            cls_com.ConfigSave(this.Name + "_공정명_중분류", cmb공정명중분류.Text);
            Add공정명_소분류();
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString());

        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }
    }
}
