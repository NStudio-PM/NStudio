using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Drawing.Text;

namespace NStudio
{
    public partial class LogInModule : Form
    {
        private static ResourceManager _rm;

        public LogInModule()
        {

            InitializeComponent();
            _rm = new ResourceManager("NStudio.Language.strings", Assembly.GetExecutingAssembly());
            // usage example by me
            Console.WriteLine($"{LogInModule.GetString("hello")} {LogInModule.GetString("world")}");
            LogInModule.ChangeLanguage("en");
            Console.WriteLine($"{LogInModule.GetString("hello")} {LogInModule.GetString("world")}");

        }

        public static string GetString(string name)
        {
            return _rm.GetString(name);
        }

        public static void ChangeLanguage(string language)
        {

            var cultureInfo = new CultureInfo(language);

            CultureInfo.CurrentCulture = cultureInfo;
            CultureInfo.CurrentUICulture = cultureInfo;

        }
    }
}
