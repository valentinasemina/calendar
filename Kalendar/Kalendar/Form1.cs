using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendar
{
    
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Use_param_param_pum(Date date, TextBox tb_day, TextBox tb_month, TextBox tb_year)
        {
            tb_day.Text = date.dayM.ToString();
            tb_month.Text = date.monthM.ToString();
            tb_year.Text = date.yearM.ToString();
        }
        private void Use_param_convert(Date date, TextBox tb_day, TextBox tb_month, TextBox tb_year)
        {
            date.dayM = Convert.ToInt32(tb_day.Text);
            date.monthM = Convert.ToInt32(tb_month.Text);
            date.yearM = Convert.ToInt32(tb_year.Text);
        }

        private void button1_Click(object sender, EventArgs e) 
        {
            Date date = new Date();
            Use_param_param_pum(date, tb_day, tb_month, tb_year);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            Use_param_convert(date, tb_day, tb_month, tb_year);
                date.NextDate();
                Use_param_param_pum(date, tb_day, tb_month, tb_year); 
        }

        private void bt_create_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            Use_param_convert(date, tb_day, tb_month, tb_year);
            if (!date.Check())
            {
                tb_day.Clear();
                tb_month.Clear();
                tb_year.Clear();
            }
        }
    }
}
