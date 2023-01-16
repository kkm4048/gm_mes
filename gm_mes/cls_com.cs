using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.SqlClient;
using System.Runtime.InteropServices;
using System.Data;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;
using System.Drawing;
using System.Drawing.Printing;
using System.Drawing.Drawing2D;

namespace gm_mes
{
    class cls_com
    {
        public static string g시스템명 = "gm_mes";
        public static string g상호 = "광명산업";

        public static string sql;
        // public static string gConn_String0 = "Provider=SQLOLEDB.1;Persist Security Info=False;User ID=fwms13;Password=fwms5132;Initial Catalog=SYST_IP;Data Source=211.239.157.71\\FWMS13,51809";
        //         public static string gConn_String0 = "Data Source=211.239.157.71\\FWMS13,51809;Initial Catalog=SYST_IP;User Id=fwms13;Password=fwms5132";
        public static string gConn_String = "Data Source=49.1.232.110,5000;Initial Catalog=syst_gm;User Id=syst5132;Password=tltmxm5132!@#";
        public static SqlConnection gConn = null;
        public static string gPath = Environment.CurrentDirectory;
        public static string Speadinifile = Environment.CurrentDirectory + "\\Spread.ini";
        public static string ConfigIniFile = Environment.CurrentDirectory + "\\Config.ini";
        public static string gOKFile = Environment.CurrentDirectory + "\\OK.wav";
        public static string gFailFile = Environment.CurrentDirectory + "\\Fail.wav";
        public static string g프린터 = "";

        [DllImport("user32.dll", SetLastError = true)]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, out uint lpdwProcessId);
        [DllImport("user32.dll")]
        public static extern uint GetWindowThreadProcessId(IntPtr hWnd, IntPtr ProcessId);
        [DllImport("user32.dll")]
        private static extern IntPtr GetForegroundWindow();

        [DllImport("kernel32")]
        public static extern int WritePrivateProfileString(string lpAppName, string lpKeyName, string lpString, string lpFileName);
        [DllImport("kernel32")]
        public static extern uint GetPrivateProfileInt(string lpAppName, string lpKeyName, int nDefault, string lpFileName);
        [DllImport("kernel32")]
        public static extern int GetPrivateProfileString(string lpAppName, string lpKeyName, string lpDefault, StringBuilder lpReturnedString, int nSize, string lpFileName);
        [DllImport("winspool.drv", CharSet = CharSet.Auto, SetLastError = true)]
        public static extern bool SetDefaultPrinter(string Name);
        [DllImport("winmm")]
        private static extern int PlaySound(string szSound, IntPtr hModule, int flags);

        private enum PlaySoundFlags : int
        {
            SND_SYNC = 0x0,             // play synchronously (default)
            SND_ASYNC = 0x1,            // play asynchronously
            SND_NODEFAULT = 0x2,        // silence (!default) if sound not found
            SND_MEMORY = 0x4,           // pszSound points to a memory file
            SND_LOOP = 0x8,             // loop the sound until next sndPlaySound
            SND_NOSTOP = 0x10,          // don't stop any currently playing sound
            SND_NOWAIT = 0x2000,        // don't wait if the driver is busy
            SND_ALIAS = 0x10000,        // name is a registry alias
            SND_ALIAS_ID = 0x110000,    // alias is a predefined ID
            SND_FILENAME = 0x20000,     // name is file name
            SND_RESOURCE = 0x40004,     // name is resource name or atom
        };
        //로그인 사용자 정보


        public struct s사용자
        {
            public static string 아이디 = "";
            public static string 암호 = "";
            public static string 성명 = "";
            public static string 연락처 = "";
            public static string 부서 = "";
            public static string 등급 = "";
            public static string 등록일 = "";
            public static string 로그인일 = "";
        }


        public static DataSet Select_Query(string sQuery)
        {
            try
            {

                SqlConnection con = new SqlConnection(gConn_String);
                DataSet ds = new DataSet();
                SqlDataAdapter sqlAdapter = new SqlDataAdapter(sQuery, con);
                sqlAdapter.Fill(ds);
                con.Close();
                return ds;
            }
            catch (SqlException ex)
            {
                System.Windows.Forms.MessageBox.Show("[Select_Query]" + ex.Message);
                return null;
            }
        }
        public static string ExcuteNonQuery(string sQuery)
        {
            try
            {
                SqlConnection con = new SqlConnection(gConn_String);
                con.Open();
                SqlCommand com = new SqlCommand(sQuery, con);
                com.ExecuteNonQuery();
                con.Close();
                string sResult = "success";
                return sResult;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(sQuery + Keys.Enter + "[ExcuteNonQuery]" + ex.Message);
                return "[ExcuteNonQuery]" + ex.Message;
            }
        }



        public static void SpreadSave(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                string sData = "";
                for (int i = 0; i < iSpread.ColumnCount; ++i)
                {
                    sData = sData + Convert.ToString(iSpread.ColumnHeader.Cells.Get(0, i).Column.Width) + "|";
                }

                WritePrivateProfileString(sSection, ikey, sData, Speadinifile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static void SpreadSave(Form iForm, FarPoint.Win.Spread.SheetView iSpread, string 구분)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName + "_" + 구분;
                string sSection = "SPREAD_WIDTH";
                string sData = "";
                for (int i = 0; i < iSpread.ColumnCount; ++i)
                {
                    sData = sData + Convert.ToString(iSpread.ColumnHeader.Cells.Get(0, i).Column.Width) + "|";
                }

                WritePrivateProfileString(sSection, ikey, sData, Speadinifile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static void SpreadLoad(Form iForm, FarPoint.Win.Spread.SheetView iSpread)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName;
                string sSection = "SPREAD_WIDTH";
                StringBuilder sData = new StringBuilder(512);

                GetPrivateProfileString(sSection, ikey, "", sData, 512, Speadinifile);
                string arr = sData.ToString();
                if (arr.Length != 0)
                {
                    string[] arrSplit = arr.Split('|');
                    for (int i = 0; i < arrSplit.Length - 1; ++i)
                    {
                        if (i == iSpread.ColumnCount) break;
                        iSpread.ColumnHeader.Cells.Get(0, i).Column.Width = Convert.ToInt32(arrSplit[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
            }
        }
        public static void SpreadLoad(Form iForm, FarPoint.Win.Spread.SheetView iSpread, string 구분)
        {
            try
            {
                string ikey = iForm.Name + "/" + iSpread.SheetName + "_" + 구분;
                string sSection = "SPREAD_WIDTH";
                StringBuilder sData = new StringBuilder(512);

                GetPrivateProfileString(sSection, ikey, "", sData, 512, Speadinifile);
                string arr = sData.ToString();
                if (arr.Length != 0)
                {
                    string[] arrSplit = arr.Split('|');
                    for (int i = 0; i < arrSplit.Length - 1; ++i)
                    {
                        if (i == iSpread.ColumnCount) break;
                        iSpread.ColumnHeader.Cells.Get(0, i).Column.Width = Convert.ToInt32(arrSplit[i]);
                    }
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);

            }
            finally
            {
            }
        }
        public static void ConfigSave(string iKey, string iData)
        {
            try
            {
                string sSection = "CONFIG";
                WritePrivateProfileString(sSection, iKey, iData, ConfigIniFile);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
            }
        }
        public static string ConfigLoad(string iKey)
        {
            string sSection = "CONFIG";
            StringBuilder sData = new StringBuilder(512);
            string iData;
            GetPrivateProfileString(sSection, iKey, "", sData, 512, ConfigIniFile);
            iData = sData.ToString();
            return iData;
        }
        public static string ConfigLoad(string iKey, string 기본값)
        {
            string sSection = "CONFIG";
            StringBuilder sData = new StringBuilder(512);
            string iData;
            GetPrivateProfileString(sSection, iKey, "", sData, 512, ConfigIniFile);
            iData = sData.ToString();
            if (iData.Equals(""))
            {
                iData = 기본값;
            }
            return iData;
        }



        public static DateTime GetDate()
        {
            DateTime DT;
            DT = DateTime.Now;
            sql = "";
            sql = sql + " SELECT Convert(nvarchar(10),getdate(),121)  DT_TM ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return DT;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                return DT;
            }
            DT = DateTime.Parse(ds.Tables[0].Rows[0]["DT_TM"].ToString());
            ds.Dispose();
            return DT;
        }
        public static String GetDate2()
        {
            String Dt = "";
            sql = "";
            sql = sql + " SELECT Convert(nvarchar(19),getdate(),121)  DT_TM ";
            DataSet ds = cls_com.Select_Query(sql);
            if (ds == null) return Dt;
            if (ds.Tables[0].Rows.Count <= 0)
            {
                return Dt;
            }
            Dt = ds.Tables[0].Rows[0]["DT_TM"].ToString().Substring(0, 10);
            ds.Dispose();
            return Dt;
        }
        public static string GetDate_년월일(String dt)
        {
            //SPEC
            String d = "";
            d = dt.Substring(0, 4) + "년 " + dt.Substring(5, 2) + "월 " + dt.Substring(8, 2) + "일";
            return d;
        }
        public static String GetCode(String cb)
        {
            String[] a;
            String d = "";
            a = cb.Split(' ');
            if (a.Length > 0)
            {
                d = a[0];
            }
            return d;
        }
        public static String GetName(String cb)
        {
            String d = "";
            int ipos = cb.IndexOf(' ');

            if (ipos >= 0)
            {
                d = cb.Substring(ipos).Trim();
            }
            return d;
        }
        public static String GetDate(DateTime dt)
        {
            return String.Format("{0:yyyy-MM-dd}", dt);
        }
        public static String GetDate_현재일(String dt)
        {
            String d = "";
            try
            {
                return String.Format("{0:yyyy-MM-dd}", dt);
            }
            catch
            {
                d = String.Format("{0:yyyy-MM-dd}", DateTime.Now);
                return d;
            }

        }
        public static string GetTime()
        {
            return String.Format("{0:HH:mm:ss}", DateTime.Now);
        }

        public static string Left(string target, int length)
        {


            if (target.Length < length) return target;
            return target.Substring(0, length);

        }
        public static string Right(string target, int length)
        {
            if (length <= target.Length)
            {
                return target.Substring(target.Length - length);
            }
            return target;
        }

        public static string Val2(string d)
        {
            string d2;
            if (String.IsNullOrEmpty(d)) return "0";
            d2 = d.Replace(",", "");

            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            return d2;
        }

        public static int Val(string d)
        {
            string d2;
            int d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");


            if (numericCheck(d2))
            {
            }
            else
            {
                d2 = "0";
            }
            d3 = (int)Convert.ToDouble(d2);
            return d3;
        }

        public static double Val3(string d)
        {
            string d2;
            double d3;
            try
            {
                if (String.IsNullOrEmpty(d))
                {
                    d = "0";
                }
                d2 = d.Replace(",", "");



                d3 = Convert.ToDouble(d2);
                return d3;
            }
            catch (Exception e)
            {
                Trace.Write(e.Message);
                return 0;
            }
        }

        public static string Val_c(string d)
        {
            string d2;
            string d3;

            if (String.IsNullOrEmpty(d))
            {
                d = "0";
            }
            d2 = d.Replace(",", "");



            d3 = String.Format("{0:#,0}", Convert.ToDouble(d2));
            return d3;
        }




        //숫자여부 체크
        public static bool numericCheck(string strNumber)
        {
            try
            {
                double iNumber = Convert.ToDouble(strNumber);
                return true;
            }
            catch
            {
                return false;
            }
        }
        public static string 숫자(string 값)
        {
            string d;
            d = 값.Replace(",", "").Trim();
            if (numericCheck(값))
            {
                return String.Format("{0:#,0}", Convert.ToInt32(d));
            }
            else
            {
                return "0";
            }
        }
        public static string 숫자만(string 값)
        {
            string d = "";
            for (int i = 0; i < 값.Length; i++)
            {
                if ((cls_com.Val(값.Substring(i, 1)) >= 0) && (cls_com.Val(값.Substring(i, 1)) <= 9))
                {
                    d = d + 값.Substring(i, 1);
                }
            }
            return d;
        }



        public static string 계산(string d)
        {
            try
            {
                d = d.Replace(",", "");
                sql = " SELECT " + d + " 값 ";
                DataSet ds = cls_com.Select_Query(sql);

                if (ds.Tables[0].Rows.Count > 0)
                {
                    return ds.Tables[0].Rows[0][0].ToString();
                }
                else
                {
                    return "";
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
                return "";
            }

        }
        public static bool 날짜여부(String d)
        {

            try
            {
                DateTime date = DateTime.Parse(d);

                if (d.Equals(String.Format("{0:yyyy-MM-dd}", date)))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
                return false;
            }
        }
        // 월요일 기준
        public static int WeekDay(String 일자)
        {
            int i = 1;
            DayOfWeek 요일;
            요일 = Convert.ToDateTime(일자).DayOfWeek;

            if (요일.ToString().Equals("Monday"))
            {
                i = 1;
            }
            else if (요일.ToString().Equals("Tuesday"))
            {
                i = 2;
            }
            else if (요일.ToString().Equals("Wednesday"))
            {
                i = 3;
            }
            else if (요일.ToString().Equals("Thursday"))
            {
                i = 4;
            }
            else if (요일.ToString().Equals("Friday"))
            {
                i = 5;
            }
            else if (요일.ToString().Equals("Saturday"))
            {
                i = 6;
            }
            else if (요일.ToString().Equals("Sunday"))
            {
                i = 7;
            }
            return i;
        }

        public static void Excel_Process_Kill(IntPtr handle)
        {

            uint pid = 0;

            cls_com.GetWindowThreadProcessId((IntPtr)handle, out pid); // 핸들로 프로세스아이디 얻어옴 
            Process[] AllProcesses = Process.GetProcessesByName("excel");
            foreach (Process excelProcess in AllProcesses)
            {
                if (excelProcess.Id == pid)
                {
                    excelProcess.Kill();
                }
            }

        }
        public static string GetDefaultPrinter()
        {
            PrinterSettings settings = new PrinterSettings();
            foreach (string printer in PrinterSettings.InstalledPrinters)
            {
                settings.PrinterName = printer;
                if (settings.IsDefaultPrinter)
                    return printer;
            }
            return string.Empty;
        }

        public static String Comma(String d)
        {
            String d2 = "";
            int i;
            d2 = d.Replace(",", "");
            if (d2.Equals("")) return "0";
            i = cls_com.Val(d2);
            return String.Format("{0:#,0}", i);

        }

        public static void Sort표시(FarPoint.Win.Spread.SheetView iSpread)
        {

            for (int i = 0; i < iSpread.ColumnCount; i++)
            {
                FarPoint.Win.Spread.Column col;
                col = iSpread.Columns[i];
                col.SortIndicator = FarPoint.Win.Spread.Model.SortIndicator.Descending;
                col.ShowSortIndicator = true;
                col.AllowAutoSort = true;
            }
        }

        public static string Numeric2Alpabet(int d)
        {
            String d2 = "";
            byte j;
            j = (byte)(d + 64);
            d2 = Encoding.ASCII.GetString(new byte[] { j });

            return d2;
        }

        // 프린터 텍스트
        public static void PrintText(System.Drawing.Printing.PrintPageEventArgs e, string iData, Font iFont, string iAlign, string iDir, int iX, int iY, int iW, int iH)
        {
            int iWidth;
            if (iData == "") return;

            iX = Convert.ToInt32(iX * 0.3937);
            iY = Convert.ToInt32(iY * 0.3937);

            iWidth = Convert.ToInt32(e.Graphics.MeasureString(iData, iFont).Width);

            if (iDir == "0")
            {

                if (iAlign == "CENTER")
                {
                    iX = iX - (iWidth / 2);

                }
                else if (iAlign == "RIGHT")
                {
                    iX = iX - iWidth;
                }
                else
                {


                }
                // e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);



                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(0, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);


                e.Graphics.Transform = origin;

            }
            else if (iDir == "90")
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(90, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;



            }
            else if (iDir == "180")
            {


                Matrix matrix = new Matrix();

                //글자를 180도 회전
                matrix.RotateAt(180, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;

            }
            else
            {


                Matrix matrix = new Matrix();

                //글자를 270도 회전
                matrix.RotateAt(270, new PointF(iX, iY));
                matrix.Scale(iW, iH);
                Matrix origin = e.Graphics.Transform;
                e.Graphics.Transform = matrix;
                e.Graphics.DrawString(iData, iFont, Brushes.Black, iX, iY);
                e.Graphics.Transform = origin;
            }



        }
        public static void PrintBarcode(System.Drawing.Printing.PrintPageEventArgs e, string iData, int iX, int iY, decimal iWidth, decimal iHeight, string iDir, string show, Font font, Fath.bcType bctype)
        {
            //int i;
            if (iData == "") return;
            Font ifont = new Font("굴림체", 18);

            Fath.BarcodeX BarcodeX1 = new Fath.BarcodeX();


            BarcodeX1.Font = ifont;
            if (show.Equals("True"))
            {
                BarcodeX1.ShowText = true;
                BarcodeX1.Font = font;
            }
            else
            {
                BarcodeX1.ShowText = false;
            }

            BarcodeX1.Symbology = (Fath.bcType)bctype;

            BarcodeX1.Orientation = Convert.ToInt32(iDir);

            //     iData = "\xb0\xa1\xb0\xa2\xb0\xa3";
            //   iData = "가나다";
            //byte[] eb = System.Text.Encoding.Unicode.GetBytes(iData);
            System.Text.Encoding utf8 = System.Text.Encoding.UTF8;
            System.Text.Encoding e949 = Encoding.GetEncoding(949);
            byte[] utf8Bytes = e949.GetBytes(iData);

            byte[] eb = System.Text.Encoding.UTF8.GetBytes(iData);
            String bv2 = "";
            bv2 = Convert.ToBase64String(eb).ToString();
            string decodedStringByUTF8 = utf8.GetString(utf8Bytes);


            BarcodeX1.Data = iData;

            //  BarcodeX1.Data = bv;
            //  BarcodeX1.Data = decodedStringByUTF8;




            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            //  원본
            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);

            //BarcodeX1.Width = (int)(iWidth * (decimal)0.003937 * (int)150);
            //BarcodeX1.Height = (int)(iHeight * (decimal)0.003937 * (int)150);

            //System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003937 * 100), (int)(iHeight * (decimal)0.003937 * 100));
            //e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003937) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003937) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
            // BarcodeX1 샘플 소스 수정 (0.3937 -> 0.3779)
            // config값 mm 로 변환

            //iX = Convert.ToInt32(iX * 10 * 0.3779);
            //iY = Convert.ToInt32(iY * 10 * 0.3779);                                  // 1 mm = 3.779 px

            //iX = Convert.ToInt32(iX * 0.3937);
            //iY = Convert.ToInt32(iY * 0.3937);                                     // 1 cm = 0.3937 inch     

            BarcodeX1.Width = (int)(iWidth * (decimal)0.003779 * (int)150);          // 0.003937
            BarcodeX1.Height = (int)(iHeight * (decimal)0.003779 * (int)150);

            System.Drawing.Rectangle rc = new System.Drawing.Rectangle(iX, iY, (int)(iWidth * (decimal)0.003779 * 100), (int)(iHeight * (decimal)0.003779 * 100));
            e.Graphics.DrawImage(BarcodeX1.Image((int)((float)(iWidth * (decimal)0.003779) * e.Graphics.DpiX), (int)((float)(iHeight * (decimal)0.003779) * e.Graphics.DpiY)), rc);

            ///////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        }

        public static  void FrmShow(Form frm)
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

    }
}
