using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FBLAData
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            bool result;
            var mutex = new System.Threading.Mutex(true, "UniqueAppId", out result);

            if (!result)
            {
                MessageBox.Show("Another instance is already running.");
                return;
            }
           

            // Add the event handler for handling UI thread exceptions to the event.
            Application.ThreadException += new ThreadExceptionEventHandler(Application_Error);

            // Set the unhandled exception mode to force all Windows Forms errors to go through
            // our handler.
            Application.SetUnhandledExceptionMode(UnhandledExceptionMode.CatchException);

            // Add the event handler for handling non-UI thread exceptions to the event. 
            AppDomain.CurrentDomain.UnhandledException += new UnhandledExceptionEventHandler(CurrentDomain_UnhandledException);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           Application.Run(new signInForm());
            GC.KeepAlive(mutex);
        }
        static void Application_Error(object sender, ThreadExceptionEventArgs e)
        {
            try
            {
                var result = new CustomMessageBox("Thread Error","An error occured. Message: " + e.Exception.Message,  MessageBoxButtons.OKCancel).ShowDialog();
            }
            catch (Exception exc)
            {
                try
                {
                    var result = new CustomMessageBox("Fatal Error","A fatal error occured. The applcation will need to be closed.",  MessageBoxButtons.OKCancel).ShowDialog();
                }
                finally
                {
                    Application.Exit();
                }
            }
        }
        private static void CurrentDomain_UnhandledException(object sender, UnhandledExceptionEventArgs e)
        {
            try
            {
                Exception ex = (Exception)e.ExceptionObject;
                var result = new CustomMessageBox("Application Error","An error occured. Message: " + ex.Message,  MessageBoxButtons.OKCancel).ShowDialog();
            }
            catch (Exception exc)
            {
                try
                {
                    var result = new CustomMessageBox( "Fatal Error", "A fatal error occured. The applcation will need to be closed.",MessageBoxButtons.OKCancel).ShowDialog() ;
                }
                finally
                {
                    Application.Exit();
                }
            }
        }

    }
}
