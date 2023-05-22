﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AppTest
{
    static class Program
    {
        // LAPTOP-H6PI0HTC
        // DESKTOP-C145KAF
        // DESKTOP-A34VKT1
        public static string serverName = "DESKTOP-C145KAF";

        public static float priceFormula(float standardPrice, char flightClass)
        {
            float newPrice = standardPrice;
            if (flightClass == 'A')
            {
                newPrice += 100;
            }
            else if (flightClass == 'B')
            {
                newPrice += 50;
            }

            return newPrice;
        }

        public static bool IsStringNumeric(string input)
        {
            foreach (char c in input)
            {
                if (!Char.IsDigit(c))
                {
                    return false;
                }
            }
            return true;
        }


        public static DataTable CustomerData = new DataTable("CUSTOMER");
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginPage());
        }
    }
}
