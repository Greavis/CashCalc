using Community.CsharpSqlite.SQLiteClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CashCalc
{
    static class Program
    {
        //private static SqliteOpenMode Mode;

        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.SetHighDpiMode(HighDpiMode.SystemAware);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new AurizationForm());
        }
    }
    //------проброс никнейма между формами
    
    static class PublicData
    {
        public static string UserName { get; set; }
    }
}
