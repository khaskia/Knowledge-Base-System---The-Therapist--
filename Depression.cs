using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBS
{
    public partial class DepressionTest : Form
    {
        public DepressionTest()
        {

            InitializeComponent();

            LazinessRules.Appearance = TabAppearance.FlatButtons;
            LazinessRules.ItemSize = new Size(0, 1);
            LazinessRules.SizeMode = TabSizeMode.Fixed;

            ResultTxt.SelectAll();
            ResultTxt.SelectionAlignment = HorizontalAlignment.Center;
            
            /* LazinessRules.Appearance = TabAppearance.FlatButtons;
             LazinessRules.SizeMode = TabSizeMode.Fixed;
             LazinessRules.ItemSize = new Size(0,1);*/
        }

        private int power = 0;
        
        private void button2_Click(object sender, EventArgs e)
        {
           
            if (f11.Checked) power += 0;
            else if (f12.Checked) power += 1;
            else if (f13.Checked) power += 2;
            else if (f14.Checked) power += 3;
            else
            {
                MessageBox.Show("Please Select an Option");   
            }
            LazinessRules.SelectedTab = LazinessRule2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f21.Checked) power += 0;
            else if (f22.Checked) power += 1;
            else if (f23.Checked) power += 2;
            else if (f24.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (f31.Checked) power += 0;
            else if (f32.Checked) power += 1;
            else if (f33.Checked) power += 2;
            else if (f34.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (f41.Checked) power += 0;
            else if (f42.Checked) power += 1;
            else if (f43.Checked) power += 2;
            else if (f44.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (f51.Checked) power += 0;
            else if (f52.Checked) power += 1;
            else if (f53.Checked) power += 2;
            else if (f54.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");

            LazinessRules.SelectedTab = LazinessRule6;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (f61.Checked) power += 0;
            else if (f62.Checked) power += 1;
            else if (f63.Checked) power += 2;
            else if (f64.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule7;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (f71.Checked) power += 0;
            else if (f72.Checked) power += 1;
            else if (f73.Checked) power += 2;
            else if (f74.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule8;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            if (f81.Checked) power += 0;
            else if (f82.Checked) power += 1;
            else if (f83.Checked) power += 2;
            else if (f84.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessRule9;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            if (f91.Checked) power += 0;
            else if (f92.Checked) power += 1;
            else if (f93.Checked) power += 2;
            else if (f94.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            LazinessRules.SelectedTab = LazinessResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (power <= 3)
            {
                ResultTxt.Text =
                    "الاكتئاب الشديد\r\nوفقا للاستمارة المختصرة فان تشخيص حالتك هو اصابتك بالاكتئاب بمستوى خطير. ينبغي فحص إمكانية التوجه للحصول على استشارة وعلاج.";
                ResultTxt.Text += "\n تقدر تكلم الدكتور الخاص بينا ";
                button11.Visible = true;
            }
            else if (power > 3 && power <= 7)
            {
                ResultTxt.Text = "انت في المرتبه الثانية من الاكتئاب " + "\r\n" +
                                 "حاول تغير وتطور من نفسك علي اد ماتقدر " +
                                 "في امل والسعي درجات ياريت تعيد الاختبار تاني بعد" +
                                 "شهر وتكون نتائجك افضل  :)  ";

                ResultTxt.Text = "\n تقدر تكلم الدكتور الخاص بينا ";

                button11.Visible = true;
            }
            else if (power > 7 && power <= 10)
            {
                ResultTxt.Text = "لديك اكتأب بنسبة بسيطة ";
                ResultTxt.Text+="مستواك لا بأس به حياتك قد تكون طبيعيه \r\n ";


            }
            else if (power > 10 && power <= 20)
            {
                ResultTxt.Text =
                    "وضعكم طبيعي, لا يشتبه بإصابتكم بالاكتئاب\r\nحتى لو شعرتم بشيء في الآونة الأخيرة," +
                    " فان وضعكم سليم" +
                    " وطبيعي تمامًا. انتم بدون" +
                    " شك" +
                    " لا تعانون من الاكتئاب.";
                //ResultTxt.Visible = true;
            }

            else if (power > 20 && power <= 27)
            {
                ResultTxt.Text = "انت كويس جدا ياريت تخليك كدا علي طول ";
            }

        }

        private void button11_Click(object sender, EventArgs e) {
            ChapPage c = new ChapPage();
            c.Show();
            Process.Start("http://localhost:1335/default.html");
        }
    }
}
