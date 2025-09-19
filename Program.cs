using System;
using System.Windows.Forms;
using InventoryApp.Forms;

namespace InventoryApp
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new LoginForm());
        }
    }
}
