namespace EdoProValidator
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

            //string edoInstall = "E:\\Games\\YuGiOh\\ProjectIgnis";
            //CardDatabase.Instance.UseSource(edoInstall);
            //MessageBox.Show(new Deck(edoInstall + "\\deck\\ABC - Adventurer.ydk").ToString());

            ApplicationConfiguration.Initialize();
            Application.Run(new frm_validator());
        }
    }
}