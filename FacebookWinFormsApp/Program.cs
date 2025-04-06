using System;
using System.Windows.Forms;
using FacebookWrapper;

namespace BasicFacebookFeatures
{
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Clipboard.SetText("design.patterns20cc");
            FacebookService.s_UseForamttedToStrings = true;
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new FormMain());

            //diagrams google doc file:
            //https://docs.google.com/document/d/1L4EMBmyW2e9_dPKx9o-W3hXgG6Z8D0v9tqDiASlSCs0/edit?tab=t.0
        }
    }
}
