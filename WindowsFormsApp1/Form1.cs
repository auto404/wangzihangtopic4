using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public static int INFINITE_DISTANCE = 65535; // 无限大距离
        public static double COORDINATE_RANGE = 10000.0;// 横纵坐标范围为[-10000,10000]
 
        public class Point
        {// 二维坐标上的点Point
            public double x;
            public double y;
        }
        class XComparer : IComparer<Point>
        {
            //实现升序

            public int Compare(Point x, Point y)
            {
                return (x.x.CompareTo(y.x));
            }
        }
        class YComparer : IComparer<Point>
        {
            //实现升序

            public int Compare(Point x, Point y)
            {
                return (x.y.CompareTo(y.y));
            }
        }
   
        void SetPoints(ref List<Point> points, int length)
        {//随机函数对点数组points中的二维点进行初始化

            Random rd = new Random();
            for (int i = 0; i < length; i++)
            {
                Point p = new Point();
                p.x = (rd.Next() % COORDINATE_RANGE * 20000) / COORDINATE_RANGE - COORDINATE_RANGE;
                p.y = (rd.Next() % COORDINATE_RANGE * 20000) / COORDINATE_RANGE - COORDINATE_RANGE;
                points.Add(p);
            }
        }
        List<Point> findPoint(List<Point> points, double up, double down, double left, double right)
        {
            List<Point> pointsIn = new List<Point>();
            foreach (Point p in points)
            {
                if(p.x<=right&&p.x>=left&&p.y<=up&&p.y>=down)
                {
                    pointsIn.Add(p);
                }
            }
            return pointsIn;
        }

        public Form1()
        {
            InitializeComponent();


        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.Series[2].Points.Clear();
            chart1.Series[3].Points.Clear();
            chart1.Series[4].Points.Clear();
            double a = double.Parse(textBoxX.Text.Trim());
            double b = double.Parse(textBoxY.Text.Trim());
            double m = double.Parse(textBoxM.Text.Trim());
            double n = double.Parse(textBoxN.Text.Trim());
            double up = b;
            double down = b-n;
            double left = a;
            double right = a+m;
            int sum = 0;
            List<Point> points = new List<Point>();
            SetPoints(ref points, 10000);
                for (int i = 0; i < 10000; i++)
                {
                    chart1.Series[0].Points.AddXY(points[i].x, points[i].y);
                }
            chart1.Series[1].Points.AddXY(left,up);
            chart1.Series[1].Points.AddXY(right,up);
            chart1.Series[2].Points.AddXY(left, down);
            chart1.Series[2].Points.AddXY(right,down);
            chart1.Series[3].Points.AddXY(left, up);
            chart1.Series[3].Points.AddXY(left, down);
            chart1.Series[4].Points.AddXY(right, up);
            chart1.Series[4].Points.AddXY(right, down);
            List<Point> pointsIn=findPoint(points, up, down, left, right);
            foreach (Point point in pointsIn)
            {
                listBox1.Items.Add("(" + point.x + "," +point.y + ")");
                sum++;
            }
            listBox1.Items.Add("在矩形区域内共"+sum+"点");
            chart1.Series[0].Name = "在矩形区域内共" + sum + "点";


        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

     

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
