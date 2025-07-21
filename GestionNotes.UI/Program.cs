namespace Gestion_Notes
{
    internal static class Program
    {
       
        [STAThread]
        static void Main()
        {
            
            ApplicationConfiguration.Initialize();
            Application.Run(new ISGA.GestionNotes.UI.Forms.frmLogin());
        }
    }
}