namespace ShootingRangeForms
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            //todo appsettings.json configuration

            /*todo in form do the 
             
               var resources = new ResourceManager(typeof(From1));
               var image = (Bitmap)resources.GetObject("pictureBox1.Image");
               pictureBox2.Image = image;*/

            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
    }
}