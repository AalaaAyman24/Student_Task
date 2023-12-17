using Student_Form.classes;
using System.Net;

namespace Student_Form
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
           
            
            ApplicationConfiguration.Initialize();
            Application.Run(new Login());

            var _context = new AppDbcontext();
            var s = new Student();
            _context.Students.Add(s);
            _context.SaveChanges(); 


            
        }
    }
}