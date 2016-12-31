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
    public partial class TensionTest : Form
    {
        public TensionTest()
        {

            InitializeComponent();

            TensionRules.Appearance = TabAppearance.FlatButtons;
            TensionRules.ItemSize = new Size(0, 1);
            TensionRules.SizeMode = TabSizeMode.Fixed;
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
            TensionRules.SelectedTab = LazinessRule2;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (f21.Checked) power += 0;
            else if (f22.Checked) power += 1;
            else if (f23.Checked) power += 2;
            else if (f24.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            TensionRules.SelectedTab = LazinessRule3;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (f31.Checked) power += 0;
            else if (f32.Checked) power += 1;
            else if (f33.Checked) power += 2;
            else if (f34.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            TensionRules.SelectedTab = LazinessRule4;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (f41.Checked) power += 0;
            else if (f42.Checked) power += 1;
            else if (f43.Checked) power += 2;
            else if (f44.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");
            TensionRules.SelectedTab = LazinessRule5;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (f51.Checked) power += 0;
            else if (f52.Checked) power += 1;
            else if (f53.Checked) power += 2;
            else if (f54.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");

            TensionRules.SelectedTab = LazinessRule6;
        }
        private void button7_Click(object sender, EventArgs e) {
            if (f61.Checked) power += 0;
            else if (f62.Checked) power += 1;
            else if (f63.Checked) power += 2;
            else if (f64.Checked) power += 3;
            else MessageBox.Show("Please Select an Option");

            TensionRules.SelectedTab = TensionResult;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (power <= 5)
            {
                ResultTxt.Text = "مستوي التوتر لديك عاالي \n\n" +
                                 "تشير إجاباتك إلى انك قد تكون تعاني من عوارض اكتئاب، إضافة" +
                                 " للتوتر. الاكتئاب هو مرض محتمل خطير. في حال كانت عوارض " +
                                 "الاكتئاب شديدة. الاكتئاب هو مرض خطير جداً. ان كانت اعراض" +
                                 " الاكتئاب تصعب عليك القيام بمهامك اليومية الاعتيادية," +
                                 " عليك التوجه الى طبيبك الخاص واستشارته في هذا الشأن." +
                                 " إذا كانت لديك أفكار في الانتحارية أو في إيذاء نفسك،" +
                                 " اتصل بالطبيب أو بخدمات الطوارئ على الفور.";
                ResultTxt.Text += "\n\n يمكنك الاتصال بالدكتور الخاص بنا مجانا من خلال هذا اللينك  ";
                button11.Visible = true;
            }
            else if (power > 5 && power <= 10)
            {
                ResultTxt.Text = "مستوي التوتر لديك متوسط \n\n ";

            }
            else if (power > 10 && power <= 18)
            {
                ResultTxt.Text = "مستوي التوتر لديك منخفض \n\n "+
                    "نرجو ان تظل علي هذا المستوي ";

            }
            

            else if (power > 20 && power <= 27)
            {
                ResultTxt.Text = "";
            }

        }

        private void button11_Click(object sender, EventArgs e) {
            ChapPage c = new ChapPage();
            c.Show();
            Process.Start("http://localhost:1334/default.html");
        }

       
    }
}
