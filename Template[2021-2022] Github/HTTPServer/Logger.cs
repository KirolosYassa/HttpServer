﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HTTPServer
{
    class Logger
    {
        static StreamWriter sr = new StreamWriter("log.txt");

        public static void LogException(Exception ex)
        {
            // TODO: Create log file named log.txt to log exception details in it



            //Datetime:
            DateTime dateTimeNow = DateTime.Now;

            //message:
            // for each exception write its details associated with datetime 

            using (sr)
            {

                sr.WriteLine(dateTimeNow.ToString() + "   :   ");
                sr.Write(ex.ToString() + "  : ");
                sr.WriteLine(ex.Message);
            }



        }
    }
}