using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.OleDb;
using System.Collections;
//using Microsoft.Office.Interop.Excel;


namespace test
{

    public partial class SEARCHER : Form
    {
        //전역 DT
        DataTable dt = new DataTable();
        DataTable dt_header = new DataTable();
        DataTable dt_new = new DataTable();
        DataTable dt_excel = new DataTable();
        string file_path = null;
        public SEARCHER()
        {
            InitializeComponent();
            Getfreeset();
        }
        private string Excel03ConString = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        private string Excel07ConString = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties='Excel 8.0;HDR={1}'";
        public void Getfreeset()
        {
            string folderpath = @"C:\UMPTEST";
            DirectoryInfo dis = new DirectoryInfo(folderpath);
            if (dis.Exists == false)
            {
                dis.Create();
            }

            string path = @"C:\UMPTEST\";

            cbFreeset.Items.Clear();
            cbFreeset.Items.Add("프리셋 없음");

            ArrayList arr = new ArrayList();

            if (System.IO.Directory.Exists(path))
            {
                //DirectoryInfo 객체 생성

                System.IO.DirectoryInfo di = new System.IO.DirectoryInfo(path);

                //해당 폴더에 있는 파일이름을 출력

                foreach (var item in di.GetFiles())

                {
                    if (item.Name.IndexOf(".xml") != -1)
                    {
                        arr.Add(item.Name);
                    }

                }

            }
            for (int i = 0; i < arr.Count; i++)
            {
                cbFreeset.Items.Add(arr[i]);

            }
            cbFreeset.SelectedIndex = 0;
        }
        //화면정리
        private void button1_Click(object sender, EventArgs e)
        {
            dtsearch.Rows.Clear();
        }
        //불러오기
        private void btnload_Click(object sender, EventArgs e)
        {
            try
            {
                dt = new DataTable();
                textBox1.Clear();

                //기본파일경로 설정(변경가능)
                openFileDialog1.InitialDirectory = "C:\\";
                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    file_path = openFileDialog1.FileName;
                    textBox1.Text = file_path.Split('\\')[file_path.Split('\\').Length - 1];
                }
                else
                {
                    return;
                }
                string fileExtension = Path.GetExtension(file_path);
                string header = "Yes";
                string connectionString = string.Empty;
                string sheetName = string.Empty;

                // 확장자로 구분하여 커넥션 스트링을 가져옮
                switch (fileExtension)
                {
                    case ".xls":    //Excel 97-03
                        connectionString = string.Format(Excel03ConString, file_path, header);
                        break;
                    case ".xlsx":  //Excel 07
                        connectionString = string.Format(Excel07ConString, file_path, header);
                        break;
                }

                // 첫 번째 시트의 이름을 가져옮
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        cmd.Connection = con;
                        con.Open();
                        DataTable dtExcelSchema = con.GetOleDbSchemaTable(OleDbSchemaGuid.Tables, null);
                        sheetName = dtExcelSchema.Rows[0]["TABLE_NAME"].ToString();
                        con.Close();
                    }
                }
                Console.WriteLine("sheetName = " + sheetName);

                // 첫 번째 쉬트의 데이타를 읽어서 datagridview 에 보이게 함.
                using (OleDbConnection con = new OleDbConnection(connectionString))
                {
                    using (OleDbCommand cmd = new OleDbCommand())
                    {
                        using (OleDbDataAdapter oda = new OleDbDataAdapter())
                        {

                            cmd.CommandText = "SELECT * From [" + sheetName + "]";
                            cmd.Connection = con;
                            con.Open();
                            oda.SelectCommand = cmd;
                            oda.Fill(dt);
                            con.Close();
                            //Populate DataGridView.
                            //dtsearch.DataSource = dt;
                        }
                    }
                }
                //칼럼헤더 콤보박스 만드는 LINQ(LINQ를 많이 써야됨)
                string[] colnm = dt.Columns.Cast<DataColumn>().Select(x => x.ColumnName).ToArray();
                //칼럼헤더 체크(특수문자여부)
                string problemhead = "";
                for (int i = 0; i < colnm.Length - 1; i++)
                {
                    string a = colnm[i].ToString();
                    if (chkspecial(a) == true)
                    {
                        problemhead += a+",";
                    }

                }
                if (problemhead.Length > 0)
                {
                    MessageBox.Show("헤더 : " + problemhead + " 특수문자가 존재합니다");
                }

                cbheader.DataSource = colnm;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        //20210813 wdw 헤더 특수문제 체크
        public bool chkspecial(string txt)
        {
            string strchk = @"[~!@\#$%^&*\()\=+|\\/:;?""<>']";
            System.Text.RegularExpressions.Regex rex = new System.Text.RegularExpressions.Regex(strchk);

            return rex.IsMatch(txt);
        }
        private void rdonumber_CheckedChanged(object sender, EventArgs e)
        {
            if (rdonumber.Checked == true)
            {
                panel5.Visible = true;
            }
            else panel5.Visible = false;

        }

        //즐겨찾기같은거
        private void basemaster_Click(object sender, EventArgs e)
        {
            Form2 baseform = new Form2();
            baseform.ShowDialog();
        }

        //종료
        private void button4_Click(object sender, EventArgs e)
        {
            Close();
        }
        //조건추가
        private void btnadd_Click(object sender, EventArgs e)
        {
            double chktext;
            if (rdotext.Checked == true)
            {
            }
            else
            {
                if (double.TryParse(txtsearch.Text.ToString(), out chktext))
                {
                    txtsearch.Text = chktext.ToString();
                }
                else if (txtsearch.Text.Equals(""))
                {
                }
                else
                {
                    MessageBox.Show("숫자타입으로 선택되어있습니다.");
                    return;
                }
            }


            string hdstring = cbheader.Text.ToString();
            string SearchCondition = null;

            string SQLTEXT = null;
            try
            {
                if (txtsearch.Text.Equals(""))
                {
                    MessageBox.Show("검색할 내용이 입력되지 않았습니다.");
                    return;
                }

                SearchCondition = hdstring + "/";
                //문자,숫자선택
                if (rdotext.Checked == true)
                {
                    SearchCondition += "TEXT/";
                }
                else
                {
                    SearchCondition += "NUM/";
                }
                //추가,제외선택
                if (rdoAdd.Checked == true)
                {
                    SearchCondition += "ADD/";
                }
                else
                {
                    SearchCondition += "NOT/";
                }
                //And,Or 선택
                if (rdoAnd.Checked == true)
                {
                    SearchCondition += "And/";
                }
                else
                {
                    SearchCondition += "OR/";
                }
                //포함관계
                if (rdotext.Checked == true)
                {
                    if (rdoEql.Checked == true)
                    {
                        SearchCondition += "EQUAL/";
                    }
                    else if (rdoLike.Checked == true)
                    {
                        SearchCondition += "LIKE/";
                    }
                    else
                    {
                        SearchCondition += "IN/";
                    }
                }
                else if (rdonumber.Checked == true)
                {
                    if (radioButton2.Checked == true)
                    {
                        SearchCondition += ">/";
                    }
                    else if (radioButton3.Checked == true)
                    {
                        SearchCondition += "</";
                    }
                }


                SQLTEXT = SearchCondition;
                SearchCondition += txtsearch.Text;
                //문자열 구분자로 나눔(/)
                //string[] SearchArray = SearchCondition.Split('/');
                // 스플릿을 딱 필요한만큼만하고 Txtsearch에 /가 들어가도 스플릿하지 않음.
                char[] Charseparators = new char[] { '/' };
                string[] SearchArray = SearchCondition.Split(Charseparators, 6, StringSplitOptions.None);
                //row추가하기(맨앞 check여부 1은 true 0은 false,나머지는 조건입력 순서대로)
                dtsearch.Rows.Add(0, SearchArray[0].ToString(), SearchArray[1].ToString(), SearchArray[2].ToString(), SearchArray[3].ToString(), SearchArray[4].ToString(), SearchArray[5].ToString());
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
                //throw ex;
            }
            finally
            {
                txtsearch.Text = "";
                txtsearch.Focus();
            }

        }
        //파라미터 확인용 label클릭
        private void label4_Click(object sender, EventArgs e)
        {

            string hdstring = cbheader.Text;
            string SearchCondition = null;

            string SQLTEXT = null;

            SearchCondition = hdstring + "/";
            //문자,숫자선택
            if (rdotext.Checked == true)
            {
                SearchCondition += "TEXT/";
            }
            else
            {
                SearchCondition += "NUM/";
            }
            //추가,제외선택
            if (rdoAdd.Checked == true)
            {
                SearchCondition += "ADD/";
            }
            else
            {
                SearchCondition += "NOT/";
            }
            //And,Or 선택
            if (rdoAnd.Checked == true)
            {
                SearchCondition += "AND/";
            }
            else
            {
                SearchCondition += "OR/";
            }
            //포함관계
            if (rdotext.Checked == true)
            {
                if (rdoEql.Checked == true)
                {
                    SearchCondition += "EQUAL/";
                }
                else if (rdoLike.Checked == true)
                {
                    SearchCondition += "LIKE/";
                }
                else
                {
                    SearchCondition += "IN/";
                }
            }
            else if (rdonumber.Checked == true)
            {
                if (radioButton2.Checked == true)
                {
                    SearchCondition += ">/";
                }
                else if (radioButton2.Checked == true)
                {
                    SearchCondition += "</";
                }
            }
            SearchCondition += txtsearch.Text;


            SQLTEXT = SearchCondition;
            MessageBox.Show(SQLTEXT);
            
        }
        //조회
        private void button3_Click1(object sender, EventArgs e)
        {
            //조건검색용 DT(매번 초기화)
            DataTable dt_new = new DataTable();
            string chgLike = "";
            try
            {
                
                //string liketxt = "";
                //string chglike = "";
                if (dtsearch.Rows.Count < 2)
                    for (int i = 0; i < dtsearch.Rows.Count - 1; i++)
                    {
                        //liketxt = chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString());
                        ////LIKE일떄 %처리
                        //if (liketxt.Equals("LIKE"))
                        //{
                        //    chglike = dtsearch.Rows[i].Cells[6].FormattedValue.ToString();
                        //    //select에 들어갈 조회문 만드는 곳
                        //    string k = dtsearch.Rows[i].Cells[1].FormattedValue.ToString()
                        //        //+ " " + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString())
                        //        + " " + liketxt
                        //        //+ " '" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                        //        + " '" + '%' + chglike + '%' + "'";
                        //    dt_new = dt.Select(k).CopyToDataTable();
                        //}
                        //else
                        //{
                        //    string k = dtsearch.Rows[i].Cells[1].FormattedValue.ToString()
                        //    + " " + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString())
                        //    //+ " " + liketxt
                        //    + " '" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString() + "'";
                        //    //+ " '" + '%' + chglike + '%' + "'";
                        //    dt_new = dt.Select(k).CopyToDataTable();
                        //}
                        if (chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()).Equals("LIKE"))
                        {
                            chgLike = '%' + dtsearch.Rows[i].Cells[6].FormattedValue.ToString() + '%';
                        }
                        else
                        {
                            chgLike = dtsearch.Rows[i].Cells[6].FormattedValue.ToString();
                        }

                        string k = dtsearch.Rows[i].Cells[1].FormattedValue.ToString()
                           + " " + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString())
                           + " '" + chgLike + "'";

                        dt_new = dt.Select(k).CopyToDataTable();
                        
                    }
                else
                {   //select에 들어갈 조회문 만드는 곳(무조건 처음row걸 조회해야함)
                    string k;

                    if (chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString()).Equals("IN"))
                    {
                        if (dtsearch.Rows[0].Cells[3].FormattedValue.ToString().Equals("NOT"))
                        {
                            k = dtsearch.Rows[0].Cells[1].FormattedValue.ToString()
                           + " "
                           + dtsearch.Rows[0].Cells[3].FormattedValue.ToString()
                           + " " + chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString())
                           + " ('" + dtsearch.Rows[0].Cells[6].FormattedValue.ToString()
                           + "')";
                        }
                        else
                        {
                            k = dtsearch.Rows[0].Cells[1].FormattedValue.ToString()
                       + " " + chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString())
                       + " ('" + dtsearch.Rows[0].Cells[6].FormattedValue.ToString()
                       + "')";
                        }
                    }
                    else
                    {
                        k = dtsearch.Rows[0].Cells[1].FormattedValue.ToString()
                       + " " + chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString())
                       + " '" + dtsearch.Rows[0].Cells[6].FormattedValue.ToString()
                       + "'";
                    }
                    dt_new = dt.Select(k).CopyToDataTable();
                    for (int i = 1; i < dtsearch.Rows.Count - 1; i++)
                    {
                        string k1 = null;
                        //select에 들어갈 조회문 만드는 곳(이건 조건 여러개일때dt_new 계속 호출하면서 조회)
                        //이쪽은 and조건 고려 X
                        //not in 조건만 하면됨
                        string tmp1 = null;
                        tmp1 = dtsearch.Rows[i].Cells[3].FormattedValue.ToString() + ' ' + dtsearch.Rows[i].Cells[4].FormattedValue.ToString();
                        if (tmp1.Equals("NOT IN"))
                        {
                            k1 = dtsearch.Rows[i].Cells[1].FormattedValue.ToString() + " "
                            + dtsearch.Rows[i].Cells[3].FormattedValue.ToString() + " "
                            + "('" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString()
                            + "')";
                            dt_new = dt_new.Select(k1).CopyToDataTable();
                        }
                        else if (tmp1.Equals("NOT LIKE"))
                        {

                        }
                        else
                        {
                            k1 = dtsearch.Rows[i].Cells[1].FormattedValue.ToString() + " "
                                + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString())
                                + "'" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString()
                                + "'";
                            dt_new = dt_new.Select(k1).CopyToDataTable();
                        }

                    }
                }
                dt_excel = dt_new.Copy();

                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //조건 where절이랑 다됨
            //dt_new = dt.Select("CHROM ='chr1'").CopyToDataTable();
            //검색갯수
            lbcount.Text = dt_new.Rows.Count.ToString();
        }

        //더미

        private void button3_Click(object sender, EventArgs e)
        {
            //조건검색용 DT(매번 초기화)
            DataTable dt_new = new DataTable();
            String ChgText = ""; // 검색할 문구 변환용 변수
            String SqlQueryText = "";
            try
            {
                if (dtsearch.Rows.Count < 3)
                {
                    if (dtsearch.Rows[0].Cells[4].FormattedValue.ToString().Equals("OR"))
                    {
                        MessageBox.Show("Or를 처음 조건으로 설정 할 수 없습니다.");
                    }
                    else
                    {
                        for (int i = 0; i < dtsearch.Rows.Count - 1; i++)
                        {
                            if (chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()).Equals("LIKE"))
                            {
                                ChgText = "'"+'%' + dtsearch.Rows[i].Cells[6].FormattedValue.ToString() + '%'+"'";
                            }
                            else if (chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()).Equals("IN"))
                            {
                                ChgText = "('" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString().Replace(",","','") + "')";
                            }
                            else
                            {
                                ChgText = "'"+dtsearch.Rows[i].Cells[6].FormattedValue.ToString()+"'";
                            }
                            SqlQueryText = dtsearch.Rows[i].Cells[1].FormattedValue.ToString() + " "
                              + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()) + " "
                              //+ "'"
                              + ChgText;
                              //+ "'";
                            dt_new = dt.Select(SqlQueryText).CopyToDataTable();
                        }
                      
                    }
                }
                else
                {
                      if (chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString()).Equals("LIKE"))
                        {
                            ChgText = "'"+'%' + dtsearch.Rows[0].Cells[6].FormattedValue.ToString() + '%'+"'";
                        }
                        else if (chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString()).Equals("IN"))
                        {
                        ChgText = "('" + dtsearch.Rows[0].Cells[6].FormattedValue.ToString().Replace(",", "','") + "')";
                    }
                        else
                        {
                            ChgText = "'"+dtsearch.Rows[0].Cells[6].FormattedValue.ToString()+"'";
                        }
                    SqlQueryText = dtsearch.Rows[0].Cells[1].FormattedValue.ToString() + " "
                      + chgmethod(dtsearch.Rows[0].Cells[5].FormattedValue.ToString()) + " "
                      //+ "'" 
                      + ChgText;
                          //+ "'";
                        dt_new = dt.Select(SqlQueryText).CopyToDataTable();
                   
                    for (int i = 1; i < dtsearch.Rows.Count-1; i++)
                    {
                        if (chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()).Equals("LIKE"))
                        {
                            ChgText = "'"+'%' + dtsearch.Rows[i].Cells[6].FormattedValue.ToString() + '%'+"'";
                        }
                        else if (chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()).Equals("IN"))
                        {
                            ChgText = "('" + dtsearch.Rows[i].Cells[6].FormattedValue.ToString().Replace(",", "','") + "')";
                        } 
                        else
                        {
                            ChgText = "'"+dtsearch.Rows[i].Cells[6].FormattedValue.ToString()+"'";
                        }
                        if (chgmethod(dtsearch.Rows[i].Cells[3].FormattedValue.ToString()).Equals("NOT"))
                        {
                            SqlQueryText = dtsearch.Rows[i].Cells[1].FormattedValue.ToString() + " "
                       + chgmethod(dtsearch.Rows[i].Cells[3].FormattedValue.ToString()) + " "
                       + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()) + " "
                       //+ "'" 
                       + ChgText;
                       //+ "'";
                        }
                        else {
                            SqlQueryText = dtsearch.Rows[i].Cells[1].FormattedValue.ToString() + " "
                          + chgmethod(dtsearch.Rows[i].Cells[5].FormattedValue.ToString()) + " "
                          //+ "'" 
                          + ChgText;
                          //+ "'";
                            }
                        dt_new = dt_new.Select(SqlQueryText).CopyToDataTable();
                    }
                }



                lbcount.Text = dt_new.Rows.Count.ToString();
                //202107019 추가
                dt_excel = dt_new.Copy();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }



            //조건 where절이랑 다됨
            //dt_new = dt.Select("CHROM ='chr1'").CopyToDataTable();
            //검색갯수
            lbcount.Text = dt_new.Rows.Count.ToString();
        }

        

        private void btntoexcel_Click(object sender, EventArgs e)
        {
            //dt_new = dt.Select("CHROM ='chr1'").CopyToDataTable();
            dt_excel.Clear();
            button3_Click(null,null);
            //검색갯수
            lbcount.Text = dt_new.Rows.Count.ToString();
            Toexcel(dt_excel);
        }
        //ToExcel
        private void Toexcel(System.Data.DataTable ds)
        {
            //파일명

            string folderpath = "C:\\UMPTEST";
            DirectoryInfo dis = new DirectoryInfo(folderpath);
            if (dis.Exists == false)
            {
                dis.Create();
            }
            try
            {
                string path = @"C:\UMPTEST\" + textBox1.Text.Replace(".xlsx", "") + "_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".xlsx";                
                var excelApp = new Microsoft.Office.Interop.Excel.Application();
                excelApp.Workbooks.Add();

                Microsoft.Office.Interop.Excel._Worksheet workSheet = (Microsoft.Office.Interop.Excel._Worksheet)excelApp.ActiveSheet;

                for (var i = 0; i < ds.Columns.Count; i++)
                {
                    workSheet.Cells[1, i + 1] = ds.Columns[i].ColumnName;
                }
                for (var i = 0; i < ds.Rows.Count; i++)
                {
                    for (var j = 0; j < ds.Columns.Count; j++)
                    {
                        workSheet.Cells[i + 2, j + 1] = ds.Rows[i][j];
                    }
                }
                if (File.Exists(path))
                {
                    File.Delete(path);
                }
                workSheet.SaveAs(path);
                excelApp.Quit();
            }
            catch (Exception ex) 
            {
                throw ex;
            }
        }
        //조건삭제 gridview에서 삭제
        private void button2_Click(object sender, EventArgs e)
        {
            int cnt = 0;
            try
            {
                for (int i = 0; i < dtsearch.Rows.Count - 1; i++)
                {
                    string tmp = null;
                    tmp = dtsearch.Rows[i].Cells[0].FormattedValue.ToString();
                    if (tmp.Equals("True"))
                    {
                        cnt++;
                    }

                }
                if (cnt == 0)
                {
                    MessageBox.Show("선택된 항목이 없습니다.");
                    return;
                }

                for (int i = 0; i < dtsearch.Rows.Count - 1; i++)
                {
                    string tmp = null;
                    tmp = dtsearch.Rows[i].Cells[0].FormattedValue.ToString();
                    if (tmp.Equals("True"))
                    {
                        //dtsearch.Rows.Remove(dtsearch.Rows[i]);
                        dtsearch.Rows.RemoveAt(i);
                        i = i - 1;
                    }
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
            txtsearch.Text = "";
            txtsearch.Focus();
        }

        private static string chgmethod(string str)
        {
            switch (str)
            {
                case "EQUAL":
                    return "=";
                case "LIKE":
                    return "LIKE";
                case "IN":
                    return "IN";
                case ">":
                    return ">";
                case "<":
                    return "<";
                case "NOT":
                    return "NOT";
                default:
                    return "FALSE";
            }
        }
        //숫자로 선택됬을 경우 숫자만 입력되도록
        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            //double chktext;
            //if (rdotext.Checked == true)
            //{
            //}
            //else
            //{
            //    if (double.TryParse(txtsearch.Text.ToString(), out chktext))
            //    {
            //        txtsearch.Text = chktext.ToString();
            //    }
            //    else if (txtsearch.Text.Equals(""))
            //    {
            //    }
            //    else
            //    {
            //        MessageBox.Show("숫자타입으로 선택되어있습니다.");
            //        return;
            //    }
            //}
        }
    }
    private void cbFreeset_SelectedIndexChanged(object sender, EventArgs e)
    {
        string filename = cbFreeset.SelectedItem.ToString();
        string[] arr1;
        string[] arr2;
        string setdata = "";
        dtsearch.Rows.Clear();

        if (filename != "")
        {
            if (filename != "프리셋 없음")
            {

                XmlReader reader = XmlReader.Create(@"C:\UMPTEST\" + filename);
                while (reader.Read())
                {
                    if (reader.IsStartElement())
                    {
                        setdata = reader.ReadString();
                        reader.Close();
                    }

                }

                arr1 = setdata.Split('^');
                for (int i = 0; i < arr1.Length - 1; i++)
                {
                    arr2 = arr1[i].Split('|');
                    dtsearch.Rows.Add(0, arr2[1].ToString(), arr2[2].ToString(), arr2[3].ToString(), arr2[4].ToString(), arr2[5].ToString(), arr2[6].ToString());
                }


            }
        }
    }
}
    //4. 숫자 >,<를 포함관계에대가 넣기

}
