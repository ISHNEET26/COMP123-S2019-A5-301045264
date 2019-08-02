using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace COMP123_S2019_A5_301045264
{
    static class Program
    {
        public static Dictionary<FormNames, Form> Forms;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Forms = new Dictionary<FormNames, Form>();
            Forms.Add(FormNames.SPLASH_FORM, new SplashForm());
            Forms.Add(FormNames.START_FORM, new StartForm());
            Forms.Add(FormNames.SELECT_FORM, new SelectForm());
            Forms.Add(FormNames.PRODUCT_INFO_FORM, new ProductInfoForm());
            Forms.Add(FormNames.ORDER_FORM, new OrderForm());
            Forms.Add(FormNames.ABOUT_FORM, new AboutForm());
            Application.Run(new SplashForm());
        }
    }
}
