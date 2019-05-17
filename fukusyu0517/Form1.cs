using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace fukusyu0517
{
    public partial class Form1 : Form
    {
        int vx = 0;
        int vy = 0;
        
        public Form1()

        {
            InitializeComponent();
        }

        private void up_button_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "-5";
            //textBox1.Text = "0";

            //vx = 0;
            vy = -5;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //label1.Left += int.Parse(textBox1.Text);
            //label1.Top += int.Parse(textBox2.Text);
            //labelの初期型は文字列型
            //int.Parseでint型に変更して += で足す

            label1.Left += vx;
            label1.Top += vy;
        }

        private void left_button_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "-5";
            //textBox2.Text = "0";

            vx = -5;
            vy = 0;

            label1.Text = "＼('ω'＼)ｳﾜｧｧｧ     ◝(‘ω’◝)";
        }

        private void down_button_Click(object sender, EventArgs e)
        {
            //textBox2.Text = "5";
            //textBox1.Text = "0";

            //vx = 0;
            vy = 5;
        }

        private void right_button_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "5";
            //textBox2.Text = "0";

            vx = 5;
            vy = 0;

            label1.Text = "(◟’ω’)◟     ｳﾜｧｧｧ(／'ω')／";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void reset_button_Click(object sender, EventArgs e)
        {
            //textBox1.Text = "0";
            //textBox2.Text = "0";
            
            label1.Location = new Point(240, 160);

            vx = 0;
            vy = 0;

            label1.Text = "('ω')";
        }

        
        
        //ここから授業の説明
        
        private void button1_Click(object sender, EventArgs e)
        {
            int vx = 5;
            //上で一回vxを宣言しているが{int vx; {int vx;}}だとばぐらない
            //↑intを消すと最初に宣言したvxに代入されるから次のbutton2の処理にもここのvxの値が使用される
            //この{}内でint vx;をもう一度やったらこの{}だけで代入される
            //ただし、同じ変数名を出来るだけ使わないように！！
            
            
            //MessageBox.Show(vx); 初期が文字列型設定だからint型は表示できない
            
            
            MessageBox.Show("" + vx);
            //こっちを実行（メッセージボックスを表示）している間、下の処理は実行されない
            
            
            vx = 10;
            MessageBox.Show("" + vx);
            //上のメッセージボックスを閉じた後、このメッセージボックスが実行される
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("" + vx);
            //この{}内ではvxを宣言していないから使えない
            //{int vx; {} }なら中の{}でも宣言されている
            //ただし１つの{}の中では同じ名前の変数は宣言できない
            //int vx = "1";
            //int vx = "2";
            //↑これはだめ
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vx += 5;
            //外側のvxに５を足した

            MessageBox.Show("" + vx);
        }
    }
}
