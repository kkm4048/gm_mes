using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;

namespace gm_mes
{
    public partial class frm라벨출력_라벨출력 : Form
    {
        string sql = "";
        public string 바코드 = "", 바코드문자 = "", 바코드문자2 = "",바코드2 ="" ;
        public static PrintDocument pd = new PrintDocument();
        public static PrintDocument pd12 = new PrintDocument();
        public frm라벨출력_라벨출력()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txt바코드_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void frm라벨출력_라벨출력_Load(object sender, EventArgs e)
        {
            Add프린터();
            Add생산호기();
            Add생산구분();
            초기화();
            조회();
        }
        private void Add프린터()
        {
            String d = "";
            cmb라벨프린터.Items.Clear();
            PrinterSettings settings = new PrinterSettings();

            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                d = printer;

                try
                {
                    cmb라벨프린터.Items.Add(printer);

                }
                catch (Exception e)
                {
                    MessageBox.Show("프린터에러 : " + d + " > " + e.Message);
                }

            }
            cmb라벨프린터.Text = cls_com.ConfigLoad("라벨프린터");

        }

        private void Add생산호기()
        {
            sql = "EXEC s_a101_생산호기_조회 '1','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb생산호기.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb생산호기.Items.Add(ds.Tables[0].Rows[i]["호기코드"].ToString() + " " + ds.Tables[0].Rows[i]["호기"].ToString() ) ;
            }
                        
        }
        private void Add생산구분()
        {
            sql = "EXEC s_a101_생산구분_조회 '1','',''";
            DataSet ds = cls_com.Select_Query(sql);
            cmb생산구분.Items.Clear();
            for (int i = 0; i < ds.Tables[0].Rows.Count; i++)
            {
                cmb생산구분.Items.Add(ds.Tables[0].Rows[i]["구분코드"].ToString() + " " + ds.Tables[0].Rows[i]["구분"].ToString());
            }

            cmb생산구분.Text = cmb생산구분.Items[0].ToString() ;

        }
        private void 초기화()
        {
            dtp.Value = cls_com.GetDate();
            dtp1.Value = cls_com.GetDate();
            dtp2.Value = cls_com.GetDate();

        }
   

        private void btn조회_Click(object sender, EventArgs e)
        {
            조회();
        }

        private void 조회()
        {
            FarPoint.Win.Spread.CellType.ImageCellType ict = new FarPoint.Win.Spread.CellType.ImageCellType();
            FarPoint.Win.Spread.CellType.NumberCellType inc = new FarPoint.Win.Spread.CellType.NumberCellType();

            inc.DecimalPlaces = 0; 

            sql = "EXEC s_a201_라벨출력_조회 '1','" +  cls_com.GetDate(dtp1.Value) + "','" + cls_com.GetDate(dtp2.Value) + "','" + txt조회_고객사.Text + "','" + txt조회_생산호기.Text + "','" + txt조회_길이.Text  +"' ";

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
                spr.Sheets[0].Cells.Get(0, 0, spr.Sheets[0].RowCount - 1, 0).CellType = inc;
                


            }
            Cursor.Current = Cursors.Default;
            cls_com.SpreadLoad(this, spr.Sheets[0]);
            lblCnt.Text = spr.ActiveSheet.RowCount.ToString();
        }

        private void spr_ColumnWidthChanged(object sender, FarPoint.Win.Spread.ColumnWidthChangedEventArgs e)
        {
            cls_com.SpreadSave(this, spr.ActiveSheet);
        }

        private void txt거치번호_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void 바코드생성()
        {
            string 바코드 = "";
            bool 에러 = false;
            if (txt거치번호.Text.Length <= 0)
            {
                에러 = true;
            }
            if (txt금형번호.Text.Length <= 0)
            {
                에러 = true;
            }
            if (cmb생산호기.Text.Length <= 0)
            {
                에러 = true;
            }
            if (txt인치.Text.Length <= 0)
            {
                에러 = true;
            }
            if (txt두께.Text.Length <= 0)
            {
                에러 = true;
            }
            if (txt길이.Text.Length <= 0)
            {
                에러 = true;
            }
            if (txt고객사코드.Text.Length <= 0)
            {
                에러 = true;
            }
            if (cmb생산구분.Text.Length <= 0)
            {
                에러 = true;
            }


            
            바코드 = cls_com.GetDate(dtp.Value);
            바코드 = 바코드.Substring(2, 2) + 바코드.Substring(5, 2) + 바코드.Substring(8, 2);


            바코드 = 바코드 + cls_com.Right("00" + cls_com.Val(txt거치번호.Text).ToString(), 2);
            바코드 = 바코드 + cls_com.Right("00" + cls_com.Val(txt금형번호.Text).ToString(), 2);
            바코드 = 바코드 + cls_com.GetCode(cmb생산호기.Text);
            바코드 = 바코드 + cls_com.Right("0000" + cls_com.Val(txt인치.Text).ToString(), 4);
            바코드 = 바코드 + cls_com.Right("00" + cls_com.Val(txt두께.Text).ToString(), 2);
            바코드 = 바코드 + cls_com.Right("0000" + cls_com.Val(txt길이.Text).ToString(), 4);
            바코드 = 바코드 + txt고객사코드.Text;
            바코드 = 바코드 + cls_com.GetCode(cmb생산구분.Text);


            txt바코드.Text = 바코드;
            if (에러)
            {
                txt바코드.ForeColor = Color.Red;
            }
            else
            {
                txt바코드.ForeColor = Color.Black;
            }

        }

        private void cmb생산호기_SelectedIndexChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void dtp_ValueChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void dtp_CloseUp(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void txt금형번호_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void txt인치_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void txt두께_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void txt길이_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void txt고객사코드_TextChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void cmb생산구분_SelectedIndexChanged(object sender, EventArgs e)
        {
            바코드생성();
        }

        private void btn고객사_Click(object sender, EventArgs e)
        {
            frm기타_고객사 frm기타_고객사 = new frm기타_고객사();
            frm기타_고객사.ShowDialog();
            txt고객사코드.Text = frm기타_고객사.고객사코드;
            txt고객사.Text = frm기타_고객사.고객사;

        }

        private void btn출력_Click(object sender, EventArgs e)
        {
            출력();
        }

        private void 출력()
        {
            string 금형번호 = "" ;

            if (txt바코드.ForeColor == Color.Red)
            {
                MessageBox.Show("데이타를 확인 하세요");
                return;
            }
            for (int i = cls_com.Val(txt금형번호1.Text); i <= cls_com.Val(txt금형번호2.Text); i++)
            {
                금형번호 = i.ToString() ;
                txt금형번호.Text = 금형번호;
                출력2();
            }
            조회();
        }
        private void 출력2()
        {

            for (int i = 0; i < cls_com.Val(txt출력수량.Text); i++)
            {
                바코드2 = "L" + (i + 1).ToString();
                출력3();
                저장();
            }
        }

        private void 저장()
        {
            sql = "";
            sql = sql = sql + " exec s_a201_라벨출력_저장 '1' ";
            sql = sql = sql + " ,'' ";
            sql = sql = sql + " ,'" + cls_com.GetDate(dtp.Value) + "' ";
            sql = sql = sql + " ,'" + txt거치번호.Text + "' ";
            sql = sql = sql + " ,'" + txt금형번호.Text + "' ";
            sql = sql = sql + " ,'" + cls_com.GetCode(cmb생산호기.Text) + "' ";
            sql = sql = sql + " ,'" + txt인치.Text + "' ";
            sql = sql = sql + " ,'" + txt두께.Text + "' ";
            sql = sql = sql + " ,'" + txt길이.Text + "' ";
            sql = sql = sql + " ,'" + txt고객사코드.Text + "' ";
            sql = sql = sql + " ,'" + cls_com.GetCode(cmb생산구분.Text) + "' ";
            sql = sql = sql + " ,'" + txt바코드.Text + 바코드2   + "'  ";
            sql = sql = sql + " ,'" + txt출력수량.Text + "' ";
            sql = sql = sql + " ,'" + cls_com.s사용자.성명 + "' ";

            DataSet ds = cls_com.Select_Query(sql);
            if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
            {
                MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
            }


        }


        private void btn거치번호_Click(object sender, EventArgs e)
        {
            frm기타_거치번호 frm기타_거치번호 = new frm기타_거치번호();
            frm기타_거치번호.ShowDialog();
            txt거치번호.Text = frm기타_거치번호.거치번호;
            txt금형번호1.Text = frm기타_거치번호.금형번호1;
            txt금형번호2.Text = frm기타_거치번호.금형번호2;
            txt인치.Text = frm기타_거치번호.인치;
            txt두께.Text = frm기타_거치번호.두께;
            txt길이.Text = frm기타_거치번호.길이;

            txt금형번호.Text = txt금형번호1.Text;
        }

        private void txt금형번호_TextChanged_1(object sender, EventArgs e)
        {
            바코드생성();

        }

        private void dtp1_ValueChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void dtp2_ValueChanged(object sender, EventArgs e)
        {
            조회();
        }

        private   void 출력3()
        {
            string print;
            
            바코드 = txt바코드.Text  ;
            바코드문자 = txt바코드.Text.Substring(0, 10);
            바코드문자2 = txt바코드.Text.Substring(11);

            pd12.PrintPage += new PrintPageEventHandler(pd_PrintPage12);
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cmb라벨프린터.Text);

            PrinterSettings settings = new PrinterSettings();
            //settings.Copies = Convert.ToInt16(txt출력수량.Text) ; //I put number 2 here
            settings.Copies = 1;
            pd12.PrinterSettings = settings;
            Application.DoEvents();

                pd12.Print();
            Application.DoEvents();
            cls_com.SetDefaultPrinter(print);


        }
        /*
        public  void pd_PrintPage12(object sender, PrintPageEventArgs e)
        {

            //            String 기호="",현장명="",품명="",색상="",핸들위치외관도="",W="",H="",위치="" ;
            //          string 바코드 = "";
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2;

            ifont = new Font("HY견고딕", 8, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 12,GraphicsUnit.Pixel);
            //cls_com.PrintText(e, "품목명", ifont, "CENTER", "0", 85, 20, 1, 1);
            //            cls_com.PrintText(e, "취득일자", ifont, "CENTER", "0", 85, 60, 1, 1);


            cls_com.PrintBarcode(e, 바코드, 2, 2, 100, 100, "0", "False", ifont2, bcType);
           
            cls_com.PrintText(e, 바코드문자, ifont2, "LEFT", "0", 110, 10, 1, 1);
            cls_com.PrintText(e, 바코드문자2, ifont, "LEFT", "0",110, 50, 1, 1);

        }
        */
        public void pd_PrintPage12(object sender, PrintPageEventArgs e)
        {

            //            String 기호="",현장명="",품명="",색상="",핸들위치외관도="",W="",H="",위치="" ;
            //          string 바코드 = "";
            Fath.bcType bcType = Fath.bcType.QRCode;
            Font ifont, ifont2;

            ifont = new Font("HY견고딕", 8, GraphicsUnit.Pixel);
            ifont2 = new Font("HY견고딕", 11, GraphicsUnit.Pixel);
            //cls_com.PrintText(e, "품목명", ifont, "CENTER", "0", 85, 20, 1, 1);
            //            cls_com.PrintText(e, "취득일자", ifont, "CENTER", "0", 85, 60, 1, 1);


            cls_com.PrintBarcode(e, 바코드 + 바코드2, 1, 2, 150, 150, "0", "False", ifont2, bcType);

            cls_com.PrintText(e, 바코드문자, ifont2, "LEFT", "0", 150, 10,1, 2);
            cls_com.PrintText(e, 바코드문자2 + 바코드2 , ifont, "LEFT", "0", 150, 40, 1, 2);

        }
        private void cmb라벨프린터_SelectedIndexChanged(object sender, EventArgs e)
        {
            cls_com.ConfigSave("라벨프린터", cmb라벨프린터.Text);
        }

        private void spr_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (e.Row < 0) return;
            txt바코드2.Text = spr.ActiveSheet.Cells[e.Row ,13].Text;


        }

        private void btn출력2_Click(object sender, EventArgs e)
        {

            int row1, row2;
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = spr.ActiveSheet.GetSelection(0);

            row1 = cr.Row;
            row2 = cr.Row + cr.RowCount;
            for (int i = row1; i < row2; i++)
            {
                txt바코드2.Text =   spr.ActiveSheet.Cells[i, 13].Text;
                Application.DoEvents();

                재발행();
                

            }

           
           
        }

        private void 재발행()
        {
            string print;

            if ( txt바코드2.Text.Length == 26 ) {
                바코드  = txt바코드2.Text.Substring(0,24)  ;
                바코드2 = txt바코드2.Text.Substring(24,2)  ;
                바코드문자 = txt바코드2.Text.Substring(0, 10);
                바코드문자2 = txt바코드2.Text.Substring(11,13);
            }
            else
            {
                바코드 = txt바코드2.Text.Substring(0, 24);
                바코드2 = txt바코드2.Text.Substring(24,3)  ;
                바코드문자 = txt바코드2.Text.Substring(0, 10);
                바코드문자2 = txt바코드2.Text.Substring(11,13);
            }


            pd12.PrintPage += new PrintPageEventHandler(pd_PrintPage12);
            print = cls_com.GetDefaultPrinter();
            cls_com.SetDefaultPrinter(cmb라벨프린터.Text);

            PrinterSettings settings = new PrinterSettings();
            settings.Copies = Convert.ToInt16(txt출력수량.Text) ; //I put number 2 here
            pd12.PrinterSettings = settings;
            Application.DoEvents();
            pd12.Print();
            Application.DoEvents();
            cls_com.SetDefaultPrinter(print);
        }

        private void txt조회_고객사_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_생산호기_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void txt조회_길이_TextChanged(object sender, EventArgs e)
        {
            조회();
        }

        private void btn선택삭제_Click(object sender, EventArgs e)
        {
            선택삭제();
        }
        private void 선택삭제()
        {

            int row1,row2 ;
            string 번호;
            FarPoint.Win.Spread.Model.CellRange cr;
            cr = spr.ActiveSheet.GetSelection(0);

            row1 = cr.Row ;
            row2 = cr.Row + cr.RowCount  ;

            DialogResult dr = MessageBox.Show("선택 삭제 " + cr.RowCount.ToString() + " 건 하시겠습니까 ?", "선택삭제", MessageBoxButtons.YesNo);
            if (dr == DialogResult.No ) return ;
            for (int i = row1; i < row2; i++)
            {

                번호 = spr.ActiveSheet.Cells[i, 0].Text;

                sql = "";
                sql = sql = sql + " exec s_a201_라벨출력_저장 '3' ";
                sql = sql = sql + " ,'" + 번호 + "' ";
                sql = sql = sql + " ,'" + cls_com.GetDate(dtp.Value) + "' ";
                sql = sql = sql + " ,'" + txt거치번호.Text + "' ";
                sql = sql = sql + " ,'" + txt금형번호.Text + "' ";
                sql = sql = sql + " ,'" + cls_com.GetCode(cmb생산호기.Text) + "' ";
                sql = sql = sql + " ,'" + txt인치.Text + "' ";
                sql = sql = sql + " ,'" + txt두께.Text + "' ";
                sql = sql = sql + " ,'" + txt길이.Text + "' ";
                sql = sql = sql + " ,'" + txt고객사코드.Text + "' ";
                sql = sql = sql + " ,'" + cls_com.GetCode(cmb생산구분.Text) + "' ";
                sql = sql = sql + " ,'" + txt바코드.Text + "' ";
                sql = sql = sql + " ,'" + txt출력수량.Text + "' ";
                sql = sql = sql + " ,'" + cls_com.s사용자.성명 + "' ";

                DataSet ds = cls_com.Select_Query(sql);
                if (!ds.Tables[0].Rows[0]["msg"].ToString().Equals(""))
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["msg"].ToString());
                }
            }

            MessageBox.Show("삭제 완료");
            조회();
        }

        private void txt바코드2_TextChanged(object sender, EventArgs e)
        {

        }


    }
}
