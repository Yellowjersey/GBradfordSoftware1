using System;
using System.Windows.Forms;


namespace GBradfordSoftware1
{
    internal static class Program
    {
  
        private static Inventory inventory = new Inventory();


        [STAThread]
        static void Main()
        {
  

            ApplicationConfiguration.Initialize();


            Application.Run(new Form1(inventory));
        }
    }
}