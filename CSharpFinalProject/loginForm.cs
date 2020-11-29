using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinalProject
{
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            StreamReader srID = new StreamReader(new FileStream("id.txt", FileMode.OpenOrCreate));
            StreamReader srPW = new StreamReader(new FileStream("password.txt", FileMode.OpenOrCreate));

            string id = srID.ReadLine();
            string id2 = srID.ReadLine();
            Console.WriteLine(id);
            string pw = srPW.ReadLine();
            string pw2 = srPW.ReadLine();
            Console.WriteLine(pw);

            srID.Close();
            srPW.Close();

            if (txtId.Text == id && txtPw.Text == pw || txtId.Text == id2 && txtPw.Text == pw2)
            {
                MessageBox.Show("정상적으로 로그인 되었습니다.");

                if(txtId.Text == id && txtPw.Text == pw)
                {
                    Form1 frm = new Form1(this, 1);
                    frm.Show();
                    this.Hide();
                }
                else
                {
                    Form1 frm = new Form1(this, 2);
                    frm.Show();
                    this.Hide();
                }
            }
            else
            {
                MessageBox.Show("로그인 정보를 다시 확인 해 주세요.");
            }

            txtId.Text = "";
            txtPw.Text = "";
        }
    }
}
