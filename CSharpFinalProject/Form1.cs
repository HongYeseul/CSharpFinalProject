using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinalProject
{
    public partial class Form1 : Form
    {
        loginForm login_form;
        List<Friend> listFriends = new List<Friend>();
        String stdDetails = "{0, -10}{1, 0}{2, 10}{3, 15}";

        enum Search
        {
            닉네임오름차순,
            나이오름차순,
            친한친구
        }
        private Search selectSearch;

        public Form1()
        {
            InitializeComponent();
        }

        public Form1(loginForm login_form)
        {
            InitializeComponent();
            this.login_form = login_form;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            listFriends.Add(new Friend("Onion", "deliciousOnion", 15, false));
            listFriends.Add(new Friend("Chemi", "Queen_Chemi", 17, false));
            listFriends.Add(new Friend("mikong", "GoMiko45", 19, false));
            listFriends.Add(new Friend("Nacho", "Nacho_0101", 31, false));
            listFriends.Add(new Friend("Onga", "OngChan99", 22, false));
            listFriends.Add(new Friend("Sara", "OwO_OwO", 21, false));
            listFriends.Add(new Friend("bunny", "Rabbit12", 28, false));
            listFriends.Add(new Friend("choco", "ChocoChan", 17, false));
            listFriends.Add(new Friend("Mitte", "mitteLOVE", 21, false));

            //유저 정보 불러오기
            StreamReader srInfo = new StreamReader(new FileStream("userInfo.txt", FileMode.OpenOrCreate));

            string name = srInfo.ReadLine();
            Console.WriteLine(name);
            srInfo.Close();
            labelName.Text = name;

            //저장되어 있는 글 불러오기
            StreamReader srContent = new StreamReader(new FileStream("content.txt", FileMode.OpenOrCreate));

            while(srContent.EndOfStream == false)
            {
                txtContent.Text += srContent.ReadLine();
                txtContent.Text += "\n";
            }
            srContent.Close();

            //리스트에 친구 목록 띄우기
            listBoxFriends.Items.Add(String.Format(stdDetails, "닉네임", "아이디", "나이", "친한친구"));
            foreach (Friend n in listFriends)
            {
                listBoxFriends.Items.Add(String.Format(stdDetails, n.Name, n.Id, n.Age.ToString(), n.BestFriend.ToString()));
            }
        }

        private void btnWrite_Click(object sender, EventArgs e)
        {
            //내용 저장하기
            StreamWriter swContent = new StreamWriter(new FileStream("content.txt", FileMode.OpenOrCreate));
            swContent.Write(txtContent.Text);
            swContent.Close();
        }

        private void Form1_FormClosed(object sender, FormClosedEventArgs e)
        {
            login_form.Close();
        }

        private void btnFriends_Click(object sender, EventArgs e)
        {
            // 라디오 버튼 클릭 -> 친구 목록에서 찾아서 리스트박스에 띄우기
            Console.WriteLine("Click");
            if (radioBtnAge.Checked == false && radioBtnBF.Checked == false && radioBtnNick.Checked == false)
                return;
            switch (selectSearch)
            {
                case Search.닉네임오름차순:
                    Console.WriteLine("닉네임 오름차순 정렬");
                    var lista = from correct in listFriends
                                orderby correct.Name
                                select correct;

                    // 리스트 초기화
                    listBoxFriends.Items.Clear();
                    listBoxFriends.Items.Add(String.Format(stdDetails, "닉네임", "아이디", "나이", "친한친구"));
                    foreach (var a in lista)
                    {
                        listBoxFriends.Items.Add(String.Format(stdDetails, a.Name, a.Id, a.Age.ToString(), a.BestFriend.ToString()));
                    }
                    break;

                case Search.나이오름차순:
                    Console.WriteLine("나이 오름차순");
                    var listb = from correct in listFriends
                                orderby correct.Age
                                select correct;
                    // 리스트 초기화
                    listBoxFriends.Items.Clear();
                    listBoxFriends.Items.Add(String.Format(stdDetails, "닉네임", "아이디", "나이", "친한친구"));
                    foreach (var a in listb)
                    {
                        listBoxFriends.Items.Add(String.Format(stdDetails, a.Name, a.Id, a.Age.ToString(), a.BestFriend.ToString()));
                    }
                    break;

                case Search.친한친구:
                    Console.WriteLine("친한친구 유무");
                    var listc = from correct in listFriends
                                where correct.BestFriend == true
                                select correct;
                    //리스트 초기화
                    listBoxFriends.Items.Clear();
                    listBoxFriends.Items.Add(String.Format(stdDetails, "닉네임", "아이디", "나이", "친한친구"));
                    foreach (var a in listc)
                    {
                        listBoxFriends.Items.Add(String.Format(stdDetails, a.Name, a.Id, a.Age.ToString(), a.BestFriend.ToString()));
                    }
                    break;
            }
        }

        private void radioBtnNick_CheckedChanged(object sender, EventArgs e)
        {
            this.selectSearch = Search.닉네임오름차순;
        }

        private void radioBtnAge_CheckedChanged(object sender, EventArgs e)
        {
            this.selectSearch = Search.나이오름차순;
        }
        private void radioBtnBF_CheckedChanged(object sender, EventArgs e)
        {
            this.selectSearch = Search.친한친구;
        }

        DateTime dtDelayStart;
        sting obj = new sting();
        private void btnClickFriend_Click(object sender, EventArgs e)
        {
            //////////////// 스레드 사용해서 찌르기 버튼 사용하기
            Console.WriteLine(stingNum.Value.ToString());
            
            int a = Int32.Parse(stingNum.Value.ToString());
            Thread[] th = new Thread[a];

            for(int i =0; i< a; i++)
            {
                th[i] = new Thread(new ThreadStart(obj.numberCount));
                //Console.WriteLine("HELLO");
            }

            for (int i=0; i<a; i++)
            {
                th[i].Start();
                //Console.WriteLine("찌르기");
            }

            
        }

        private void DelaySystem(int MS)
        { 
           /* 함수명 : DelaySystem 
           * 1000ms = 1초 
           * 전달인자 : 얼마나 지연시킬것인가에 대한 변수 
           * */
            DateTime dtAfter = DateTime.Now; 
            TimeSpan dtDuration = new TimeSpan(0, 0, 0, 0, MS); 
            DateTime dtThis = dtAfter.Add(dtDuration); 
            
            while (dtThis >= dtAfter)
            { 
                //DoEvent () 를 사용 해서 지연 시간 동안 
                //버튼 클릭 이벤트 및 다른 윈도우 이벤트를 받을 수 있게끔 하는 역할 
                //없으면 지연 동안 다른 이벤트를 받지 못함... 
                System.Windows.Forms.Application.DoEvents(); 
                //현재 시간 얻어 오기... 
                dtAfter = DateTime.Now; 
            } 
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            login_form.Show();
            this.Hide();
        }

        private void btnStingResult_Click(object sender, EventArgs e)
        {
            labelTest.Text = obj.number.ToString() + "번 찌르셨습니다.";
            //찌르기 버튼을 누르면 몇 번 찔렀다는 걸 잠시 띄우고 사라지게 할 수 있는 코드
            labelTest.Visible = true;

            dtDelayStart = DateTime.Now;
            DelaySystem(3000);

            labelTest.Visible = false;
            obj.number = 0;
        }
    }

    class sting
    {
        public int number = 0;

        public void numberCount()
        {
            lock (this)
            {
                Console.WriteLine("1증가 시키기");
                Console.WriteLine("증가 전" + number);
                number++;
                Console.WriteLine("증가 후 " + number);
                //return number;
            }
        }
    }
}
