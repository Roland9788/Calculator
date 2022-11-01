namespace Калькулятор
{
    public partial class Form1 : Form
    {
        Calc _calc = new Calc();
        bool otvet = false;
        int fontsize = 48;
        string number = "";
        public Form1()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void bt1_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "1";
            number += "1";
            otvet = false;
        }

        private void bt2_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "2";
            number += "2";
            otvet = false;
        }

        private void bt3_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "3";
            number += "3";
            otvet = false;
        }

        private void bt4_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "4";
            number += "4";
            otvet = false;
        }

        private void bt5_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }

            label1.Text += "5";
            number += "5";
            otvet = false;
        }

        private void bt6_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "6";
            number += "6";
            otvet = false;
        }

        private void bt7_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "7";
            number += "7";
            otvet = false;
        }

        private void bt8_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "8";
            number += "8";
            otvet = false;
        }

        private void bt9_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "9";
            number += "9";
            otvet = false;
        }
        private void bt0_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "0";
            number += "0";
            otvet = false;
        }
        private void btscOp_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "(";
            _calc.addnote(number);
            number = "";
            _calc.addnote("(");
            otvet = false;
        }

        private void btscCl_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += ")";
            _calc.addnote(number);
            number = "";
            _calc.addnote(")");
            otvet = false;
        }

        private void btmlt_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "*";
            _calc.addnote(number);
            number = "";
            _calc.addnote("*");
            otvet = false;

        }

        private void btdiv_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "/";
            _calc.addnote(number);
            number = "";
            _calc.addnote("/");
            otvet = false;
        }

        private void btsub_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "-";
            _calc.addnote(number);
            number = "";
            _calc.addnote("-");
            otvet = false;
        }

        private void btadd_Click(object sender, EventArgs e)
        {
            if (otvet == true) { label1.Text = ""; }
            label1.Text += "+";
            _calc.addnote(number);
            number = "";
            _calc.addnote("+");
            otvet = false;
        }



        private void btClear_Click(object sender, EventArgs e)
        {
            label1.Text = "";
            label1.Font = new Font(label1.Font.Name, 48, label1.Font.Style);
            _calc = new Calc();
        }

        private void btrez_Click(object sender, EventArgs e)
        {
            _calc.addnote(number);
            number = "";
            _calc.raschet();
            label1.Text = (_calc.GetRezult()).ToString();
            otvet = true;
            _calc = new Calc();
        }

        private void label1_TextChanged(object sender, EventArgs e){}

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (label1.Size.Width >= this.Width)
            {
                if (fontsize >= 14)
                {
                    label1.Font = new Font(label1.Font.Name, fontsize -= 6, label1.Font.Style);
                }
            }
        }
    }
}