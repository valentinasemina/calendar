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

        
        private void button1_Click(object sender, EventArgs e) 
        {
            Date date = new Date();
            tb_day.Text = date.dayM.ToString(); 
            tb_month.Text = date.monthM.ToString(); 
            tb_year.Text = date.yearM.ToString(); 
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Date date = new Date();
            date.dayM = Convert.ToInt32(tb_day.Text);
            date.monthM = Convert.ToInt32(tb_month.Text);
            date.yearM = Convert.ToInt32(tb_year.Text);

            if (Convert.ToInt32(tb_day.Text) > 31 || Convert.ToInt32(tb_day.Text) < 0 || (Convert.ToInt32(tb_day.Text) > 29 && Convert.ToInt32(tb_month.Text) == 2) ||
                Convert.ToInt32(tb_month.Text) > 12 || Convert.ToInt32(tb_month.Text) < 0|| 
                (Convert.ToInt32(tb_month.Text) ==2 && Convert.ToInt32(tb_day.Text) == 29 &&!((Convert.ToInt32(tb_year.Text) % 4 == 0 && Convert.ToInt32(tb_year.Text) % 100 != 0) || (Convert.ToInt32(tb_year.Text) % 4 == 0 && Convert.ToInt32(tb_year.Text) % 100 == 0 && Convert.ToInt32(tb_year.Text) % 400 == 0)))||
                (Convert.ToInt32(tb_day.Text) == 31 && (Convert.ToInt32(tb_month.Text)==4 || Convert.ToInt32(tb_month.Text) == 6 || Convert.ToInt32(tb_month.Text) == 9 || Convert.ToInt32(tb_month.Text) == 11)))
            {
                tb_day.Clear();
                tb_month.Clear();
                tb_year.Clear();
                MessageBox.Show("Неправильная дата");
            }
            else
            {
                date.NextDate();
                tb_day.Text = date.dayM.ToString();
                tb_month.Text = date.monthM.ToString();
                tb_year.Text = date.yearM.ToString();
            }
        }
    }
}
