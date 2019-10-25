using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MVP
{
    static class Presentor
    {
        


        
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Model model = new Model(10,20);
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
        }
        
        public static int GetCountObject()
        {
            return Model.countObject;
        }
        public static void CountObjectPlus()
        {
            Model.countObject++;
        }
        public static void CountObjectMinus()
        {
            Model.countObject--;
        }
        
    }
}
