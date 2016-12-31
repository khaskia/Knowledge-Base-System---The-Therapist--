using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KBS {
    public partial class ChapPage : Form
    {
        public string url = "http://localhost:1333/default.html";
        public ChapPage() {
            InitializeComponent();
            webBrowser1.Navigate(url);
        }
    }
}
