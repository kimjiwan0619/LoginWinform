using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 윈폼연습
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void login_button_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\김지완\Documents\Data.mdf;Integrated Security=True;Connect Timeout=30");

            SqlDataAdapter sda = new SqlDataAdapter("Select Count(*)from USERINFO where USERNAME='"+ID_txt.Text+"'and PASSWORD='"+PW_txt.Text+"'",con);
            //이런조건맞는 객체들의 개수를 세어주세요

            DataTable newTable = new DataTable();

            sda.Fill(newTable);

            if(newTable.Rows[0][0].ToString()=="1")
            {
                //로그인이 성공한경우
                this.Hide();//로그인창 없애고

                MainForm mainForm1 = new MainForm();//객체를 만들고
                mainForm1.Show();//보여준다
            }
            else
            {
                //로그인 실패시
                MessageBox.Show("아이디와 비밀번호를 확인해주세요");
            }
        }

        
    }
}
