using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DateTimeSample
{
    public partial class Form1 : Form
    {
        //現在時刻取得
        private DateTime _now;

        public Form1()
        {
            InitializeComponent();
        }

        private void btNow_Click(object sender, EventArgs e)
        {
            //現在日時取得
            _now = DateTime.Now;

            tbNowDisp.Text = _now.ToString("F");

#if true
            //参考演算子
            tbLeapYear.Text = DateTime.IsLeapYear(_now.Year) ? "閏年です。" : "閏年ではありません。";

#else
            if (DateTime.IsLeapYear(day.Year))
            {
                tbLeapYear.Text = "閏年です。";
            }
            else
            {
                tbLeapYear.Text = "閏年ではありません。";
            }
#endif
        }

        private void btBefore_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;

            tbNowDisp.Text = _now.ToString("F");

            var day = _now.AddMonths(-(int)nudMonthBeforeAfter.Value);
            day = day.AddDays(-(int)nudDayBeforeAfter.Value);
            
            tbBeforeAfterDisp.Text = day.ToString("D");

#if true
            //参考演算子
            tbLeapYear.Text = DateTime.IsLeapYear(day.Year) ? "閏年です。" : "閏年ではありません。";

#else
            if (DateTime.IsLeapYear(day.Year))
            {
                tbLeapYear.Text = "閏年です。";
            }
            else
            {
                tbLeapYear.Text = "閏年ではありません。";
            }
#endif
        }

        private void btAfter_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;

            tbNowDisp.Text = _now.ToString("F");

            var day = _now.AddMonths((int)nudMonthBeforeAfter.Value);
            day = day.AddDays((int)nudDayBeforeAfter.Value);

            tbBeforeAfterDisp.Text = day.ToString("D");

#if true
            //三項演算子
            tbLeapYear.Text = DateTime.IsLeapYear(day.Year) ? "閏年です。" : "閏年ではありません。";

#else
            if (DateTime.IsLeapYear(day.Year))
            {
                tbLeapYear.Text = "閏年です。";
            }
            else
            {
                tbLeapYear.Text = "閏年ではありません。";
            }
#endif
        }

        private void btAns_Click(object sender, EventArgs e)
        {
            _now = DateTime.Now;

            var birth = mcBirthDay.SelectionRange.Start.ToShortDateString();
            var items = birth.Split('/');

            var day = new DateTime(int.Parse(items[0]), int.Parse(items[1]), int.Parse(items[2]));

            int interval = (int)(_now - day).TotalDays;

            tbAns.Text = interval.ToString();
        }
    }
}
