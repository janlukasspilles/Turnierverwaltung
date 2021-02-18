using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Turnierverwaltung.ViewNS
{
    public class View
    {
        #region Attributes
        private string _text;
        #endregion
        #region Properties
        public string Text { get => _text; set => _text = value; }
        #endregion
        #region Constructors
        public View()
        {
            //Splashinfo();
        }
        #endregion
        #region Methods
        public void TextEinlesen(string text)
        {
            Text = text;
        }

        public void TextAusgeben()
        {
            Console.WriteLine(Text);
        }

        private void Splashinfo()
        {
            string[] titles = { "Projektname:", "Version:", "Datum:", "Autor:", "Klasse:" };
            string[] information = { "Turnierverwaltung", "1.0", "03.02.2021", "Jan-Lukas Spilles", "IA119" };
            Console.CursorTop = 5;
            for (int i = 0; i < information.Length; i++)
            {
                Console.CursorLeft = (Console.WindowWidth - 32) / 2;
                Console.WriteLine("{0,-12}{1,20}", titles[i], information[i]);
                Thread.Sleep(400);
            }
            Console.SetCursorPosition((Console.WindowWidth - 50) / 2, Console.WindowHeight - 2);
            Console.WriteLine("Drücken Sie eine beliebige Taste, um fortzufahren.");
            Console.ReadKey(true);
            Console.Clear();
        }
        #endregion
    }
}
