#:sdk Microsoft.NET.Sdk
#:property RuntimeIdentifier=win-x64
#:property PublishAot=false
#:property PublishTrimmed=false
#:property ImplicitUsings=false
#:property Nullable=enable
#:property TargetFramework=net10.0-windows
#:property OutputType=winexe
#:property UseWindowsForms=true
#:property ApplicationIcon=app.ico

using System;
using System.Drawing;
using System.Windows.Forms;

Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new MainWindow());

public class MainWindow : Form
{
    public MainWindow()
    {
        Text = "C# Window";
        try
        {
            Icon = new Icon($"app.ico");
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }

        Width = 1280;
        Height = 768;
        StartPosition = FormStartPosition.CenterScreen;
    }
}
