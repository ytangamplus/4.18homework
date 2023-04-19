using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _4._18homework
{
    public partial class Form1 : Form
    {
        Player mplayer1;
        Player mplayer2;
        public Form1()
        {
            InitializeComponent();
            this.mplayer1 = new("太郎", 500, 10);
            this.mplayer2 = new("花子", 100, 80);
        }

        private void btnAtk1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate > 50)
                this.txtResult.Text = this.mplayer1.Attack() + "現在" + this.mplayer2.name + "のHP:" + (this.mplayer2.hp - this.mplayer1.atk);
            else
            {
                this.txtResult.Text = this.mplayer1.Attack() + "無効だった。";
            }

        }

        private void btnDef1_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate < 50)
            {
                this.txtResult.Text = this.mplayer1.Defence() + "無効だった。" + this.mplayer1.name + "のHP:" + (this.mplayer1.hp - this.mplayer2.atk);
            }
            else
            {
                this.txtResult.Text = this.mplayer1.Defence() + "成功だった。";
            }
        }

        private void btnAtk2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate > 50)
                this.txtResult.Text = this.mplayer2.Attack() + "現在" + this.mplayer1.name + "のHP:" + (this.mplayer1.hp - this.mplayer2.atk);
            else
            {
                this.txtResult.Text = this.mplayer2.Attack() + "無効だった。";
            }
        }

        private void btnDef2_Click(object sender, EventArgs e)
        {
            Random rnd = new Random();
            int rate = rnd.Next(1, 101);
            if (rate < 50)
            {
                this.txtResult.Text = this.mplayer2.Defence() + "無効だった。" + this.mplayer2.name + "のHP:" + (this.mplayer2.hp - this.mplayer1.atk);
            }
            else
            {
                this.txtResult.Text = this.mplayer2.Defence() + "成功だった。";
            }
        }
    }

}
