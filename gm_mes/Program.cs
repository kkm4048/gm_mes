using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Data;
using System.Data.Odbc;

namespace gm_mes
{
    static class Program
    {
        static string sql;
        /// <summary>
        /// 해당 응용 프로그램의 주 진입점입니다.
        /// </summary>
        [STAThread]
        static void Main()
        {


            string[] d;

            string[] args = Environment.GetCommandLineArgs();
            if (args.Length <= 1)
            {

                cls_com.s사용자.아이디 = "1";
                cls_com.s사용자.암호 = "1";
                //   cls_com.g아이디 = "2";
                //   cls_com.g암호 = "2";
                //cls_com.g아이디 = "a";
                //cls_com.g암호 = "a";


                //MessageBox.Show("로그인을 실행하세요");
                //Application.Exit();
                //return;
            }
            else
            {
                d = args[1].Split(',');

                // cls_com.g상호 = d[0];
                cls_com.s사용자.아이디 = d[0];
                cls_com.s사용자.암호 = d[1];
            }


            //  로그인0();  // 회사 로그인 
            if (로그인())
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                초기화();
                Application.Run(new frm메인());
            }
            else
            {
                Application.Exit();
            }

        }

        private static void 초기화()
        {
        }


        /*
        private static void 로그인0()
        {
            sql = "EXEC DBO.[S_아이피서버_조회] '1','" + cls_com.g시스템명 + "','" + cls_com.g상호 + "' ";
            DataSet ds = cls_com.Select_Query0(sql);

            if (ds.Tables[0].Rows.Count > 0)
            {
                if (ds.Tables[0].Rows[0]["MSG"].ToString().Equals(""))
                {
                    cls_com.sDB.아이디 = ds.Tables[0].Rows[0]["아이디"].ToString();
                    cls_com.sDB.암호 = ds.Tables[0].Rows[0]["암호"].ToString();
                    cls_com.sDB.아이피 = ds.Tables[0].Rows[0]["아이피"].ToString();
                    cls_com.sDB.포트 = ds.Tables[0].Rows[0]["포트"].ToString();
                    cls_com.sDB.외부아이피 = ds.Tables[0].Rows[0]["외부아이피"].ToString();
                    cls_com.sDB.외부포트 = ds.Tables[0].Rows[0]["외부포트"].ToString();
                    cls_com.sDB.DB = ds.Tables[0].Rows[0]["DB"].ToString();

                    //                    cls_com.gConn_String = "Data Source=" + cls_com.sDB.아이피 + "," + cls_com.sDB.포트 + ";Initial Catalog=" + cls_com.sDB.DB + ";User Id=" + cls_com.sDB.아이디 + ";Password=" + cls_com.sDB.암호;


                    cls_com.gConn_String = "";
                    cls_com.gConn_String = cls_com.gConn_String + "Data Source=" + ds.Tables[0].Rows[0]["외부아이피"].ToString() + "," + ds.Tables[0].Rows[0]["외부포트"].ToString() + "; ";
                    cls_com.gConn_String = cls_com.gConn_String + "Initial Catalog=" + ds.Tables[0].Rows[0]["DB"].ToString() + ";";
                    cls_com.gConn_String = cls_com.gConn_String + "User Id=" + ds.Tables[0].Rows[0]["아이디"].ToString() + "; " ;
                    cls_com.gConn_String = cls_com.gConn_String + "Password=" + ds.Tables[0].Rows[0]["암호"].ToString() + ";";


                //    cls_com.gConn_String = "Data Source=106.241.30.215,5000;Initial Catalog=seowon_mes;User Id=sa2;Password=sql";


                }
                else
                {
                    MessageBox.Show(ds.Tables[0].Rows[0]["MSG"].ToString());
                    Application.Exit();

                }

            }
            else
            {
                MessageBox.Show("미등록 상호입니다. ");
                Application.Exit();

            }
        }
         **/
        private static bool 로그인()
        {



            sql = "exec  S_a101_로그인_조회  '1','" + cls_com.s사용자.아이디 + "','" + cls_com.s사용자.암호 + "'    ";

            DataSet ds = cls_com.Select_Query(sql);



            if (ds.Tables[0].Rows.Count > 0)
            {

                cls_com.s사용자.아이디 = ds.Tables[0].Rows[0]["아이디"].ToString();
                cls_com.s사용자.암호 = ds.Tables[0].Rows[0]["암호"].ToString();
                cls_com.s사용자.성명 = ds.Tables[0].Rows[0]["성명"].ToString();
                cls_com.s사용자.부서 = ds.Tables[0].Rows[0]["부서"].ToString();
                cls_com.s사용자.등급 = ds.Tables[0].Rows[0]["등급"].ToString();
                cls_com.s사용자.연락처 = ds.Tables[0].Rows[0]["연락처"].ToString();
                cls_com.s사용자.등록일 = ds.Tables[0].Rows[0]["등록일"].ToString();
                cls_com.s사용자.로그인일 = ds.Tables[0].Rows[0]["로그인일"].ToString();
                return true;
            }
            else
            {
                MessageBox.Show("아이디 및 암호 확인하세요. ");
                return false;
            }
        }
    }
}
