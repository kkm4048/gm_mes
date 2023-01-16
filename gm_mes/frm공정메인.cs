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
using System.Resources;
using System.Drawing.Imaging;

namespace gm_mes
{
    public partial class frm공정메인 : Form
    {
        String sql = "";
        public frm공정메인()
        {
            InitializeComponent();
        }

        private void frm공정메인_Load(object sender, EventArgs e)
        {
            초기화();
            조회();
            조회2();
            sc.SplitterDistance = cls_com.Val(cls_com.ConfigLoad(this.Name + "_sc넓이", "500"));

        }

        private void 조회()
        {
            FarPoint.Win.Spread.CellType.NumberCellType nc = new FarPoint.Win.Spread.CellType.NumberCellType();
            nc.ShowSeparator = true;
            nc.DecimalPlaces = 0;
            sql = "EXEC s_a301_공정메인_공정_조회 '1','','','','','' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt.Text = ds.Tables[0].Rows.Count.ToString();
            spr.DataSource = ds;
            spr.ActiveSheet.ColumnHeader.Rows[0].Height = 30;
            if (ds.Tables[0].Rows.Count > 0)
            {

                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).Locked = true;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, spr.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                spr.Sheets[0].Cells.Get(0, 4, spr.Sheets[0].RowCount - 1, 4).CellType = nc;
                spr.Sheets[0].Cells.Get(0, 4, spr.Sheets[0].RowCount - 1, 4).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Right;


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
            
        }

       
        private void 초기화()
        {

            txt조회1.Text = "";
            txt조회1.Focus();
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
            txt공정명_대분류.Text = spr.ActiveSheet.Cells[e.Row, 1].Text;
            txt공정명_소분류.Text = spr.ActiveSheet.Cells[e.Row, 3].Text;
            조회2();
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

       

        private void 조회2()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();

            sql = "EXEC s_a301_공정메인_공정_데이타_조회 '1','','','" + txt공정명_대분류.Text + "','" +  txt공정명_소분류.Text + "','' ";

            DataSet ds = cls_com.Select_Query(sql);
            spr2.Sheets[0].RowCount = 0;

            if (ds == null) return;
            Cursor.Current = Cursors.WaitCursor;
            lblCnt2.Text = ds.Tables[0].Rows.Count.ToString();
            spr2.DataSource = ds;
            spr2.ActiveSheet.ColumnHeader.Rows[0].Height = 30;

            if (ds.Tables[0].Rows.Count > 0)
            {

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).Locked = true;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).VerticalAlignment = FarPoint.Win.Spread.CellVerticalAlignment.Center;
                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, spr2.Sheets[0].ColumnCount - 1).HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Left;

                spr2.Sheets[0].Cells.Get(0, 0, spr2.Sheets[0].RowCount - 1, 0).CellType = ict;

                for (int i= 0; i < spr2.ActiveSheet.Rows.Count;i++)
                {
                    Byte[] bb;
                    if (i == 0)
                    {
                        bb = ImageToByteArray( Properties.Resources.대기중_16_16);

                    } else if (i == 1 ) 
                    {
                        bb = ImageToByteArray(Properties.Resources.작업중_16_16);
                    }
                    else
                    {
                        bb = ImageToByteArray(Properties.Resources.인계_16_16);
                    }
                    spr2.ActiveSheet.Cells[i, 0].Value = bb;
                    spr2.ActiveSheet.Cells[i, 0].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                }
            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr2.Sheets[0]);
            lblCnt2.Text = spr2.ActiveSheet.RowCount.ToString();
        }
        public Bitmap CopyDataToBitmap(byte[] data)
        {
            //I
            Bitmap bmp = new Bitmap(352, 288, PixelFormat.Format24bppRgb);

            //Here the code to put data array into Bitmap 
            //Unfortunatelly i dont know how :(  

            //Return the bitmap 
            return bmp;

        }
        public byte[] ImageToByteArray(System.Drawing.Image imageIn)
        {
            using (var ms = new MemoryStream())
            {
                imageIn.Save(ms, imageIn.RawFormat);
                return ms.ToArray();
            }
        }

        private void spr2_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr2.ActiveSheet);
        }

        private void spr2_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
        }

        private void sc_SplitterMoved(object sender, SplitterEventArgs e)
        {
            cls_com.ConfigSave(this.Name + "_sc넓이", sc.SplitterDistance.ToString());
        }
    }
}
