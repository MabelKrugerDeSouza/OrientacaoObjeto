using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace Projeto_Curso.Contas.DataTime
{
    class RepresentandoHoraData
    {
        static void Main(string[] agrs)
        {

            //----------------------------------------------------------------------------------------------

            //* PADRAO ISO 8601.
            /* 
            DateTime d1 = DateTime.Parse("2020-09-29  14:11:20");
            DateTime d2 = DateTime.Parse("2020-09-29T14:11:58Z");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

            Console.WriteLine(d2.ToString("yyyy-MM-ddTHH:mm:ssz")); //Tomar cuidado pois está errado.
            Console.WriteLine(d2.ToUniversalTime().ToString("yyyy-MM-ddTHH:mm:ssz"));
            */
            //------------------------------------------------------------------------------------------------

            /*
             
            DateTime date = new DateTime(200, 8, 15, 12, 5, 58, DateTimeKind.Local);
            DateTime date1 = new DateTime(200, 8, 15, 12, 5, 58, DateTimeKind.Utc);
            DateTime date2 = new DateTime(200, 8, 15, 12, 5, 58);

            Console.WriteLine(date);
            Console.WriteLine(date.Kind);
            Console.WriteLine(date.ToLocalTime());
            Console.WriteLine(date.ToUniversalTime());

            Console.WriteLine(date1);
            Console.WriteLine(date2);
 
             */

            //------------------------------------------------------------------------------------------------------

            /*
             
            DateTime d1 = DateTime.Now;
            DateTime dia = d1.AddDays(7);

            Console.WriteLine(d1);
            Console.WriteLine(dia);

            Console.WriteLine("1) Date " + d1.Date);
            Console.WriteLine("2) Day " + d1.Day);
            Console.WriteLine("3) DayOfWeek " + d1.DayOfWeek);
            Console.WriteLine("4) DauOfYear " + d1.DayOfYear);
            Console.WriteLine("5) Hour " + d1.Hour);
            Console.WriteLine("6) Kind " + d1.Kind);
            Console.WriteLine("7) MilliSeconds " + d1.Millisecond);
            Console.WriteLine("8) Minute " + d1.Minute);
            Console.WriteLine("9) Month " + d1.Month);
            Console.WriteLine("10) Second " + d1.Second);
            Console.WriteLine("11) Tick " + d1.Ticks);
            Console.WriteLine("12) TimeOfDay " + d1.TimeOfDay);
            Console.WriteLine("13) Year " + d1.Year);

            DateTime minuto = d1.AddMinutes(3);
            Console.WriteLine(d1.ToLongDateString());
            Console.WriteLine(d1.ToLongTimeString());
            Console.WriteLine(d1.ToShortDateString());
            Console.WriteLine(d1.ToShortTimeString());
            Console.WriteLine(hora);
             */

            //-------------------------------------------------------------------------------------------------

            /*
             
            DateTime d2 = DateTime.Now;
            DateTime d3 = DateTime.Today;
            DateTime d4 = DateTime.UtcNow; // horario universal

            Console.WriteLine(d1);
            Console.WriteLine(d2);
            Console.WriteLine(d3);
            Console.WriteLine(d4);

             
             */

            //-------------------------------------------------------------------------------------------------

            /*
             
            DateTime d1 = DateTime.Parse("2020-08-15");
            DateTime d2 = DateTime.Parse("28/09/2020");

            Console.WriteLine(d1);
            Console.WriteLine(d2);

             */

            //-------------------------------------------------------------------------------------------------

            /*
             
            DateTime d1 = DateTime.ParseExact("2020-08-15", "yyyy-MM-dd", CultureInfo.InvariantCulture);
            DateTime d2 = DateTime.ParseExact("15/08/2020", "dd/MM/yyyy", CultureInfo.InvariantCulture);

            Console.WriteLine(d1);
            Console.WriteLine(d2);
             
             */
        }
    }
}
