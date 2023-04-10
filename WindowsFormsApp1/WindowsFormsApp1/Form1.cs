using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void tShirtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources._1;
            pb.Location = new Point(32, 81);
            pb.Size = new Size(100, 123);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb);

            Label lb = new Label();
            lb.Location = new Point(38, 219);
            lb.Text = "U Crew Neck Short-Sleeve T-Shirt ";
            this.panel1.Controls.Add(lb);

            Label hrg = new Label();
            hrg.Location = new Point(38, 240);
            hrg.Text = "Rp. 170.000";
            this.panel1.Controls.Add(hrg);

            Button btn = new Button();
            btn.Location = new Point(38, 270);
            btn.Text = "Add To Cart";
            btn.Click += btn1_Click;
            btn.Tag = lb.Text + "," + "170000";
            this.panel1.Controls.Add(btn);


            //KEDUA
            PictureBox pb2 = new PictureBox();
            pb2.Image = Properties.Resources._2;
            pb2.Location = new Point(147, 81);
            pb2.Size = new Size(100, 123);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb2);

            Label lb2 = new Label();
            lb2.Location = new Point(147, 219);
            lb2.Text = "DRY-EX Crew Neck Short-Sleeve T-Shirt ";
            this.panel1.Controls.Add(lb2);

            Label hrg2 = new Label();
            hrg2.Location = new Point(147, 240);
            hrg2.Text = "Rp. 220.000";
            this.panel1.Controls.Add(hrg2);

            Button btn2 = new Button();
            btn2.Location = new Point(147, 270);
            btn2.Text = "Add To Cart";
            btn2.Click += btn2_Click;
            this.panel1.Controls.Add(btn2);

            //KETIGA
            PictureBox pb3 = new PictureBox();
            pb3.Image = Properties.Resources._3;
            pb3.Location = new Point(266, 81);
            pb3.Size = new Size(100, 123);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb3);

            Label lb3 = new Label();
            lb3.Location = new Point(266, 219);
            lb3.Text = "Supima Cotton Crew Neck Short-Sleeve T-Shirt ";
            this.panel1.Controls.Add(lb3);

            Label hrg3 = new Label();
            hrg3.Location = new Point(266, 240);
            hrg3.Text = "Rp. 270.000";
            this.panel1.Controls.Add(hrg3);

            Button btn3 = new Button();
            btn3.Location = new Point(266, 270);
            btn3.Text = "Add To Cart";
            btn3.Click += btn3_Click;
            this.panel1.Controls.Add(btn3);
        }

        DataTable dt = new DataTable();
        int counter1 = 1;
        int total1 = 170000;
        private void btn1_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            string tag = btn.Tag.ToString();
            string[] words = tag.Split(',');

            string namaproduk = words[0];
            int harga = Convert.ToInt32(words[1]);
            dataGridView1.DataSource = dt;
            
            if(counter1 > 1)
            {
                foreach (DataGridViewRow roww in dataGridView1.Rows)
                {
                    if (roww.Cells[0].Value.ToString() == namaproduk)
                    {
                        dataGridView1.Rows.Remove(roww);
                    }
                }
                dt.Rows.Add(namaproduk, counter1, harga, total1);
            }
            else
            {
                dt.Rows.Add(namaproduk, counter1, harga, total1);
            }

            textBox_subtotal.Text = total1.ToString();
            int bb = total1 * 10 / 100;
            int totall = bb + total1;
            textBox_total.Text = totall.ToString();
            counter1++;
            total1 = total1 + harga;
        }

        int counter2 = 1;
        int total2 = 220000;
        private void btn2_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;

            if (counter2 > 1)
            {
                foreach (DataGridViewRow roww in dataGridView1.Rows)
                {
                    if (roww.Cells[0].Value.ToString() == "DRY-EX Crew Neck Short-Sleeve T-Shirt ")
                    {
                        dataGridView1.Rows.Remove(roww);
                    }
                }
                dt.Rows.Add("DRY-EX Crew Neck Short-Sleeve T-Shirt ", counter2, 220000, total2);
            }
            else
            {
                dt.Rows.Add("DRY-EX Crew Neck Short-Sleeve T-Shirt ", counter2, 220000, total2);
            }
            textBox_subtotal.Text = total2.ToString();
            int bb = total2 * 10 / 100;
            int totall = bb + total2;
            textBox_total.Text = totall.ToString();
            counter2++;
            total2 = total2 + 220000;
        }


        int counter3 = 1;
        int total3 = 220000;
        private void btn3_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;

            if (counter3 > 1)
            {
                foreach (DataGridViewRow roww in dataGridView1.Rows)
                {
                    if (roww.Cells[0].Value.ToString() == "Supima Cotton Crew Neck Short-Sleeve T-Shirt ")
                    {
                        dataGridView1.Rows.Remove(roww);
                    }
                }
                dt.Rows.Add("Supima Cotton Crew Neck Short-Sleeve T-Shirt ", counter3, 270000, total3);
            }
            else
            {
                dt.Rows.Add("Supima Cotton Crew Neck Short-Sleeve T-Shirt ", counter3, 270000, total3);
            }
            textBox_subtotal.Text = total3.ToString();
            int bb = total3 * 10 / 100;
            int totall = bb + total3;
            textBox_total.Text = totall.ToString();
            counter3++;
            total3 = total3 + 270000;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = dt;
            dt.Columns.Add("Item");
            dt.Columns.Add("Qty");
            dt.Columns.Add("Price");
            dt.Columns.Add("Total");
        }

        private void shirtToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources._11;
            pb.Location = new Point(32, 81);
            pb.Size = new Size(100, 123);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb);

            Label lb = new Label();
            lb.Location = new Point(38, 219);
            lb.Text = "Premium Linen Long-Sleeve Shirt";
            this.panel1.Controls.Add(lb);

            Label hrg = new Label();
            hrg.Location = new Point(38, 240);
            hrg.Text = "Rp. 350.000";
            this.panel1.Controls.Add(hrg);

            Button btn = new Button();
            btn.Location = new Point(38, 270);
            btn.Text = "Add To Cart";
            btn.Click += btn1_Click;
            this.panel1.Controls.Add(btn);


            //KEDUA
            PictureBox pb2 = new PictureBox();
            pb2.Image = Properties.Resources._21;
            pb2.Location = new Point(147, 81);
            pb2.Size = new Size(100, 123);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb2);

            Label lb2 = new Label();
            lb2.Location = new Point(147, 219);
            lb2.Text = "DRY-EX Short-Sleeve Polo Shirt";
            this.panel1.Controls.Add(lb2);

            Label hrg2 = new Label();
            hrg2.Location = new Point(147, 240);
            hrg2.Text = "Rp. 230.000";
            this.panel1.Controls.Add(hrg2);

            Button btn2 = new Button();
            btn2.Location = new Point(147, 270);
            btn2.Text = "Add To Cart";
            btn2.Click += btn2_Click;
            this.panel1.Controls.Add(btn2);

            //KETIGA
            PictureBox pb3 = new PictureBox();
            pb3.Image = Properties.Resources._31;
            pb3.Location = new Point(266, 81);
            pb3.Size = new Size(100, 123);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb3);

            Label lb3 = new Label();
            lb3.Location = new Point(266, 219);
            lb3.Text = "Open Collar Short-Sleeve Shirt";
            this.panel1.Controls.Add(lb3);

            Label hrg3 = new Label();
            hrg3.Location = new Point(266, 240);
            hrg3.Text = "Rp. 450.000";
            this.panel1.Controls.Add(hrg3);

            Button btn3 = new Button();
            btn3.Location = new Point(266, 270);
            btn3.Text = "Add To Cart";
            btn3.Click += btn2_Click;
            this.panel1.Controls.Add(btn3);
        }

        private void shortsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            panel1.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources._12;
            pb.Location = new Point(32, 81);
            pb.Size = new Size(100, 123);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb);

            Label lb = new Label();
            lb.Location = new Point(38, 219);
            lb.Text = "Chino Shorts ";
            this.panel1.Controls.Add(lb);

            Label hrg = new Label();
            hrg.Location = new Point(38, 240);
            hrg.Text = "Rp. 450.000";
            this.panel1.Controls.Add(hrg);

            Button btn = new Button();
            btn.Location = new Point(38, 270);
            btn.Text = "Add To Cart";
            btn.Click += btn1_Click;
            this.panel1.Controls.Add(btn);


            //KEDUA
            PictureBox pb2 = new PictureBox();
            pb2.Image = Properties.Resources._22;
            pb2.Location = new Point(147, 81);
            pb2.Size = new Size(100, 123);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb2);

            Label lb2 = new Label();
            lb2.Location = new Point(147, 219);
            lb2.Text = "Linen Blend Shorts ";
            this.panel1.Controls.Add(lb2);

            Label hrg2 = new Label();
            hrg2.Location = new Point(147, 240);
            hrg2.Text = "Rp. 450.000";
            this.panel1.Controls.Add(hrg2);

            Button btn2 = new Button();
            btn2.Location = new Point(147, 270);
            btn2.Text = "Add To Cart";
            btn2.Click += btn2_Click;
            this.panel1.Controls.Add(btn2);

            //KETIGA
            PictureBox pb3 = new PictureBox();
            pb3.Image = Properties.Resources._32;
            pb3.Location = new Point(266, 81);
            pb3.Size = new Size(100, 123);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb3);

            Label lb3 = new Label();
            lb3.Location = new Point(266, 219);
            lb3.Text = "Dry Stretch Easy Shorts (Leaf) ";
            this.panel1.Controls.Add(lb3);

            Label hrg3 = new Label();
            hrg3.Location = new Point(266, 240);
            hrg3.Text = "Rp. 350.000";
            this.panel1.Controls.Add(hrg3);

            Button btn3 = new Button();
            btn3.Location = new Point(266, 270);
            btn3.Text = "Add To Cart";
            btn3.Click += btn2_Click;
            this.panel1.Controls.Add(btn3);
        }

        private void longPantsToolStripMenuItem_Click(object sender, EventArgs e)
        {

            panel1.Controls.Clear();
            PictureBox pb = new PictureBox();
            pb.Image = Properties.Resources._13;
            pb.Location = new Point(32, 81);
            pb.Size = new Size(100, 123);
            pb.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb);

            Label lb = new Label();
            lb.Location = new Point(38, 219);
            lb.Text = "Baker Pants ";
            this.panel1.Controls.Add(lb);

            Label hrg = new Label();
            hrg.Location = new Point(38, 240);
            hrg.Text = "Rp. 450.000";
            this.panel1.Controls.Add(hrg);

            Button btn = new Button();
            btn.Location = new Point(38, 270);
            btn.Text = "Add To Cart";
            btn.Click += btn1_Click;
            this.panel1.Controls.Add(btn);


            //KEDUA
            PictureBox pb2 = new PictureBox();
            pb2.Image = Properties.Resources._23;
            pb2.Location = new Point(147, 81);
            pb2.Size = new Size(100, 123);
            pb2.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb2);

            Label lb2 = new Label();
            lb2.Location = new Point(147, 219);
            lb2.Text = "AIRism UV Protection Pocketed Soft Leggings ";
            this.panel1.Controls.Add(lb2);

            Label hrg2 = new Label();
            hrg2.Location = new Point(147, 240);
            hrg2.Text = "Rp. 350.000";
            this.panel1.Controls.Add(hrg2);

            Button btn2 = new Button();
            btn2.Location = new Point(147, 270);
            btn2.Text = "Add To Cart";
            btn2.Click += btn2_Click;
            this.panel1.Controls.Add(btn2);

            //KETIGA
            PictureBox pb3 = new PictureBox();
            pb3.Image = Properties.Resources._33;
            pb3.Location = new Point(266, 81);
            pb3.Size = new Size(100, 123);
            pb3.SizeMode = PictureBoxSizeMode.Zoom;
            this.panel1.Controls.Add(pb3);

            Label lb3 = new Label();
            lb3.Location = new Point(266, 219);
            lb3.Text = "AIRism Soft Flare Leggings";
            this.panel1.Controls.Add(lb3);

            Label hrg3 = new Label();
            hrg3.Location = new Point(266, 240);
            hrg3.Text = "Rp. 350.000";
            this.panel1.Controls.Add(hrg3);

            Button btn3 = new Button();
            btn3.Location = new Point(266, 270);
            btn3.Text = "Add To Cart";
            btn3.Click += btn2_Click;
            this.panel1.Controls.Add(btn3);

        }

        private void dataGridView1_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow a = dataGridView1.CurrentRow;
            int qty = Convert.ToInt32(a.Cells[1].Value.ToString());
            if (qty == 0)
            {
                dataGridView1.Rows.Remove(a);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
