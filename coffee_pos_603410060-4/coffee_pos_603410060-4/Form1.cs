using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace coffee_pos_603410060_4
{
   
    public partial class Form1 : Form
    {
        string O_R = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments);
        double Rung;
        public Form1()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Coffee_op("Esspresso(Hot)", "35");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Coffee_op("Esspresso(Ice)", "45");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Coffee_op("Esspresso(Frappe)", "50");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Coffee_op("Americano(Hot)", "35");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            T_P.Controls.Remove(pay_m);
        }
        public void Coffee_op(string menu, string bath)
        {
            string[] OO = { menu, bath };
            var l_v = new ListViewItem(OO);
            list_V.Items.Add(l_v);
            L_P();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Coffee_op("Americano(Ice)", "45");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            Coffee_op("Americano(Frappe)", "0");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            Coffee_op("Latte(Hot)", "35");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            Coffee_op("Latte(Ice)", "45");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            Coffee_op("Latte(Frappe)", "50");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Coffee_op("Mocha(Hot)", "35");
        }

        private void button14_Click(object sender, EventArgs e)
        {
            Coffee_op("Mocha(Ice)", "45");
        }

        private void button15_Click(object sender, EventArgs e)
        {
            Coffee_op("Mocha(Frappe)", "50");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            Coffee_op("Cappuccino(Hot)", "35");
        }

        private void button17_Click(object sender, EventArgs e)
        {
            Coffee_op("Cappuccino(Ice)", "45");
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Coffee_op("Cappuccino(Frappe)", "50");
        }

        private void button19_Click(object sender, EventArgs e)
        {
            Coffee_op("GreeTea(Hot)", "20");
        }

        private void button20_Click(object sender, EventArgs e)
        {
            Coffee_op("GreeTea(Ice)", "25");
        }

        private void button21_Click(object sender, EventArgs e)
        {
            Coffee_op("GreeTea(Frappe)", "30");
        }

        private void button22_Click(object sender, EventArgs e)
        {
            Coffee_op("ThaiTea(Hot)", "20");
        }

        private void button23_Click(object sender, EventArgs e)
        {
            Coffee_op("ThaiTea(Ice)", "25");
        }

        private void button24_Click(object sender, EventArgs e)
        {
            Coffee_op("ThaiTea(Frappe)", "30");
        }

        private void button25_Click(object sender, EventArgs e)
        {
            Coffee_op("CoCoa(Hot)", "20");
        }

        private void button26_Click(object sender, EventArgs e)
        {
            Coffee_op("CoCoa(Ice)", "25");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void button27_Click(object sender, EventArgs e)
        {
            Coffee_op("CoCoa(Frappe)", "30");
        }

        private void button28_Click(object sender, EventArgs e)
        {
            Coffee_op("Milk(Hot)", "20");
        }

        private void button29_Click(object sender, EventArgs e)
        {
            Coffee_op("Milk(Ice)", "25");
        }

        private void button30_Click(object sender, EventArgs e)
        {
            Coffee_op("Milk(Frappe)", "30");
        }

        private void button31_Click(object sender, EventArgs e)
        {
            Coffee_op("MilkTea(Hot)", "0");
        }

        private void button32_Click(object sender, EventArgs e)
        {
            Coffee_op("MilkTea(Ice)", "25");
        }

        private void button33_Click(object sender, EventArgs e)
        {
            Coffee_op("MilkTea(Frappe)", "30");
        }

        private void button34_Click(object sender, EventArgs e)
        {
            Coffee_op("LemonTea(Hot)", "0");
        }

        private void button35_Click(object sender, EventArgs e)
        {
            Coffee_op("LemonTea(Ice)", "25");
        }

        private void button36_Click(object sender, EventArgs e)
        {
            Coffee_op("LemonTea(Frappe)", "30");
        }

        private void button42_Click(object sender, EventArgs e)
        {
            Coffee_op("Milo(Hot)", "20");
        }

        private void button39_Click(object sender, EventArgs e)
        {
            Coffee_op("Milo(Ice)", "25");
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Coffee_op("Milo(Frappe)", "30");
        }

        private void button41_Click(object sender, EventArgs e)
        {
            Coffee_op("Nescafe(Hot)", "20");
        }

        private void button38_Click(object sender, EventArgs e)
        {
            Coffee_op("Nescafe(Ice)", "25");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Coffee_op("Nescafe(Frappe)", "30");
        }

        private void button40_Click(object sender, EventArgs e)
        {
            Coffee_op("NesteaTea(Hot)", "20");
        }

        private void button37_Click(object sender, EventArgs e)
        {
            Coffee_op("NesteaTea(Ice)", "25");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Coffee_op("NesteaTea(Frappe)", "30");
        }

        private void button43_Click(object sender, EventArgs e)
        {
            Coffee_op("Cantaloupe(Ice)", "25");
        }

        private void button46_Click(object sender, EventArgs e)
        {
            Coffee_op("Red lime Soda(Ice)", "25");
        }

        private void button44_Click(object sender, EventArgs e)
        {
            Coffee_op("BlueHawai(Ice)", "25");
        }

        private void button47_Click(object sender, EventArgs e)
        {
            Coffee_op("Apple(Ice)", "25");
        }

        private void button45_Click(object sender, EventArgs e)
        {
            Coffee_op("Strawbery(Ice)", "25");
        }

        private void button48_Click(object sender, EventArgs e)
        {
            Coffee_op("Honey lime Soda(Ice)", "25");
        }
        public string[] L_P()
        {
            Rung = 0;
            string[] RR = new string[list_V.Items.Count];
            int R = list_V.Items.Count;
            for (int i = 0; i < R; i++)
            {
                Rung += double.Parse(list_V.Items[i].SubItems[1].Text);
                RR[i] = list_V.Items[i].SubItems[0].Text.ToString();
            }
            textBox.Text = Rung.ToString();
            return RR;
        }
        public string[] IN_P()
        {
            string[] RR = new string[list_V.Items.Count];
            int R = list_V.Items.Count;
            for (int i = 0; i < R; i++)
            {
                RR[i] = list_V.Items[i].SubItems[1].Text.ToString();
            }
            return RR;
        }
        public void R_U()
        {
            string[] OR = L_P();
            label35.Text = "";
            string[] KK = IN_P();
            string file = "O_coffee" + DateTime.Now.ToString("hhmmss_dd_mm_yyyy");
            string F_bill = "O_coffee";
            F_bill += "\r\n" + DateTime.Now.ToString("hh:mm:ss") + "\r\n" + DateTime.Now.ToString("dd//mm//yyyy");
            F_bill += "Menu" + "\r\n";
            for (int i = 0; i < list_V.Items.Count; i++)
            {
                F_bill += OR[i] + new string(' ', 20) + KK[i] + "Bath" + "\r\n";
            }
            F_bill += "\r\n";
            F_bill += "Totai price :" + textBox.Text;
            System.IO.File.WriteAllText(O_R + @"\" + file + "txt", F_bill);
            label35.Text += F_bill + "\r\n" + "\r\n" + "\r\n" + "Save File at" + O_R + @"\" + file + ".txt";
        }

        private void Cle_Click(object sender, EventArgs e)
        {
            list_V.Items.Clear();
            OO_PP = false;
            T_P.Controls.Remove(pay_m);
            textBox.Text = "";
        }
        bool OO_PP = false;
        private void paymen_t_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
            if (OO_PP == false)
            {
                T_P.TabPages.Insert(1, pay_m);
                OO_PP = true;
                T_P.SelectedTab = pay_m;
            }
            else T_P.SelectedTab = pay_m;
            if (list_V.Items.Count > 0)
                R_U();
        }

        private void list_V_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void close_Click(object sender, EventArgs e)
        {
            Close();
            Environment.Exit(0);

        }

        private void T_P_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label50_Click(object sender, EventArgs e)
        {

        }
    }
}


