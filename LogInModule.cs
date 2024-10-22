using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

// LanguageModule
using System.Resources;
using System.Reflection;
using System.Globalization;
using System.Drawing.Text;
using System.Drawing.Drawing2D;

// TODO COLDERVOID
// remember me checkbox
// reset password label button
// summit button for login
//login module
// startup module


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

        protected override void OnPaint(PaintEventArgs e)
        {
            // Ustawienie kolorów gradientu
            Color color1 = ColorTranslator.FromHtml("#833ab4");  // Pierwszy kolor
            Color color2 = ColorTranslator.FromHtml("#fd1d1d");  // Drugi kolor
            Color color3 = ColorTranslator.FromHtml("#fcb045");  // Trzeci kolor

            // Utworzenie pędzla gradientowego
            using (LinearGradientBrush brush = new LinearGradientBrush(this.ClientRectangle, color1, color2, 45F))
            {
                // Dodanie trzeciego koloru w gradient
                ColorBlend colorBlend = new ColorBlend();
                colorBlend.Colors = new Color[] { color1, color2, color3 };
                colorBlend.Positions = new float[] { 0f, 0.5f, 1f };

                brush.InterpolationColors = colorBlend;

                // Wypełnienie tła formularza gradientem
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }

            base.OnPaint(e);
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

        private void LogInModule_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
