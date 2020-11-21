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
            Console.WriteLine(id);
            string pw = srPW.ReadLine();
            Console.WriteLine(pw);

            srID.Close();
            srPW.Close();

            if (txtId.Text == id && txtPw.Text == pw)
            {
                MessageBox.Show("정상적으로 로그인 되었습니다.");
                Form1 frm = new Form1(this);
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("로그인 정보를 다시 확인 해 주세요.");
            }
        }
    }
}
