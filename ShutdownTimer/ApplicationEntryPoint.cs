using System;
using System.Threading;
using System.Windows.Forms;

namespace ShutdownTimer
{
    internal static class ApplicationEntryPoint
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        private static void Main()
        {
            using (Mutex mutex = new Mutex(true, "ShutdownTimer.SingleInstance", out bool createdNew))
            {
                if (!createdNew)
                {
                    return;
                }

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new ShutdownTimerForm());
            }
        }
    }
}
