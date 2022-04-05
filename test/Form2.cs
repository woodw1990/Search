using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using System.Collections;
using System.IO;

namespace test
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            Getfreeset();
        }
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
            cbFreeset.Items.Add("추가 생성");

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


        private void button5_Click(object sender, EventArgs e)
        {
            string hdstring = TxtColumn.Text.ToString();
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
                SearchCondition += "And/";
            }
            else
            {
                SearchCondition += "Or/";
            }
            //포함관계
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


            SQLTEXT = SearchCondition;
            SearchCondition += txtsearch.Text;
            //문자열 구분자로 나눔(/)
            string[] SearchArray = SearchCondition.Split('/');
            //row추가하기(맨앞 check여부 1은 true 0은 false,나머지는 조건입력 순서대로)
            dtsearch.Rows.Add(0, SearchArray[0].ToString(), SearchArray[1].ToString(), SearchArray[2].ToString(), SearchArray[3].ToString(), SearchArray[4].ToString(), SearchArray[5].ToString());
        }


        private void button4_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < dtsearch.Rows.Count; i++)
            {
                string tmp = null;
                tmp = dtsearch.Rows[i].Cells[0].FormattedValue.ToString();
                if (tmp.Equals("True"))
                {
                    dtsearch.Rows.Remove(dtsearch.Rows[i]);
                }
            }
        }


        private void btnsave_Click(object sender, EventArgs e)
        {
            try
            {
                string filename = "";
                string rstdata1 = "";
                string rstdata2 = "";

                if (label13.Visible == false)
                {
                    filename = cbFreeset.Text.Replace(".xml", "");
                }
                else
                {
                    filename = txtfreesetsave.Text;
                }


                string path = @"C:\UMPTEST\" + filename + ".xml";


                for (int i = 0; i < dtsearch.Rows.Count - 1; i++)
                {
                    for (int j = 0; j < 7; j++)
                    {

                        rstdata1 += dtsearch.Rows[i].Cells[j].FormattedValue.ToString() + "|";

                    }
                    rstdata2 += rstdata1 + "^";
                    rstdata1 = "";
                }



                if (File.Exists(path) == false)
                {
                    using (File.Create(path))
                    {
                        MessageBox.Show("성공");
                    }
                }


                XmlWriterSettings settings = new XmlWriterSettings();
                settings.Indent = true;
                XmlWriter writer = XmlWriter.Create(path, settings);
                writer.WriteStartElement("setdata");
                writer.WriteValue(rstdata2);
                writer.WriteEndElement();
                writer.Close();
                MessageBox.Show("저장되었습니다.");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void cbFreeset_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string filename = cbFreeset.SelectedItem.ToString();
                string[] arr1;
                string[] arr2;
                string setdata = "";
                dtsearch.Rows.Clear();

                if (filename != "")
                {
                    if (filename != "추가 생성")
                    {
                        txtfreesetsave.Visible = false;
                        label13.Visible = false;

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
                    else
                    {
                        txtfreesetsave.Visible = true;
                        label13.Visible = true;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            dtsearch.Rows.Clear();
        }
    }
}
