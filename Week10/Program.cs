using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week10
{
    static class Program
    {
        static List<DemoForm> forms = new List<DemoForm>();
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            for (int i= 0; i < 5; i ++)
            {
                forms.Add(new DemoForm(i));
            }
            Application.Run(forms[0]);
        }

        public static void NavigateTo(int index)
        {
            for(int i = 0; i < forms.Count; i++)
            {
                if (i == index)
                    forms[i].Show();
                else
                    forms[i].Hide();
            }
        }
    }
}
