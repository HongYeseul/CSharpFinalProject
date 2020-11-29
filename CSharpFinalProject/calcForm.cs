using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharpFinalProject
{
    public partial class calcForm : Form
    {
        delegate int CalcPlus(int a, int b); // 익명 메소드를 만들기 위한 델리게이트
        delegate int CalcMinus(int a, int b);
        delegate int CalcMul(int a, int b);
        delegate int CalcDiv(int a, int b);
        public calcForm()
        {
            InitializeComponent();
        }

        private void btnCalc_Click(object sender, EventArgs e)
        {
            CalcPlus DoPlus = (a, b) => a + b; // 익명 메소드를 람다식으로 구현
            CalcMinus DoMinus = (a, b) =>
            {
                return a - b;
            };
            CalcMul DoMul = (a, b) => a * b;
            CalcPlus CalcDiv = (a, b) => a / b;

            Console.WriteLine(comboBoxCalc.SelectedItem);
            switch (comboBoxCalc.SelectedIndex)
            {
                case 0:
                    Console.WriteLine("Plus");
                    string result = DoPlus(Int32.Parse(txtFirstNum.Value.ToString()), Int32.Parse(txtSecondNum.Value.ToString())).ToString();
                    txtResult.Text = result;
                    Console.WriteLine("Result : " + result);
                    break;
                case 1:
                    txtResult.Text = DoMinus(Int32.Parse(txtFirstNum.Value.ToString()), Int32.Parse(txtSecondNum.Value.ToString())).ToString();
                    break;
                case 2:
                    txtResult.Text = DoMul(Int32.Parse(txtFirstNum.Value.ToString()), Int32.Parse(txtSecondNum.Value.ToString())).ToString();
                    break;
                case 3:
                    txtResult.Text = CalcDiv(Int32.Parse(txtFirstNum.Value.ToString()), Int32.Parse(txtSecondNum.Value.ToString())).ToString();
                    break;
            }
            
        }
    }
}
