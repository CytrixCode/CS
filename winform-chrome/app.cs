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

#:package CefSharp.Common.NETCore@141.0.110
#:package CefSharp.WinForms.NETCore@141.0.110

using System;
using System.Drawing;
using System.Windows.Forms;
using CefSharp;
using CefSharp.DevTools.CacheStorage;
using CefSharp.WinForms;

CefSettings settings = new CefSettings();
settings.UserAgent = "Mozilla/5.0 (Windows NT 10.0; Win64; x64) AppleWebKit/537.36 (KHTML, like Gecko) Chrome/144.0.0.0 Safari/537.36";
settings.CachePath = $"{Environment.CurrentDirectory}\\cache";

Cef.Initialize(settings);
Application.EnableVisualStyles();
Application.SetCompatibleTextRenderingDefault(false);
Application.Run(new Chromium());
Cef.Shutdown();

public class Chromium : Form
{
    private ChromiumWebBrowser? cwb;
    public Chromium()
    {
        Text = "C# Chrome Browser";
        Icon = new Icon($"app.ico");

        Width = 1280;
        Height = 768;
        StartPosition = FormStartPosition.CenterScreen;

        cwb = new ChromiumWebBrowser("https://www.google.com")
        {
            Dock = DockStyle.Fill
        };
        Controls.Add(cwb);

    }
}
