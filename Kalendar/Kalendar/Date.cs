using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalendar
{
    class Date
    {

        bool isVisocos(int year)
        {
            if (!((yearM % 4 == 0 && yearM % 100 != 0) || yearM % 4 == 0 && yearM % 400 == 0))
            {
                return true;
            }
            return false;
        }

        public int dayM, monthM, yearM;
        public Date()
        {
            dayM = DateTime.Now.Day;
            monthM = DateTime.Now.Month;
            yearM = DateTime.Now.Year;
        }
        public void NextDate()
        {
            dayM++;
            int[] md = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
            if ((yearM % 4 == 0 && yearM % 100 != 0) || (yearM % 4 == 0 && yearM % 400 == 0) )
            {
                md[1] = 29;
            }

            if (monthM>=12&&dayM >= md[monthM-1]+1)
            {
                yearM++;
                monthM = 1;
                dayM = 1;
            }
            if ( dayM >= md[monthM - 1]+1)
            {
                dayM = 1;
                monthM++;
            }
           
        }
       public bool Check()
       {

             
                if (dayM > 31 || dayM < 0)                
                return false;
                if (monthM > 12 || monthM< 0)
                return false;
                if (dayM == 31 && (monthM == 4 || dayM == 6 || monthM == 9 || monthM == 11))
                return false;
                if (monthM == 2 && dayM == 29 && isVisocos(yearM))
                return false;
                else
            return true;
       }
 
    }
}