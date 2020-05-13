using System;
using AppKit;
using SOMacHead;
using SOMacHead.macOS;
using Xamarin.Forms;
using Xamarin.Forms.Platform.MacOS;

[assembly: Xamarin.Forms.ExportRenderer(typeof(MyContentView), typeof(MyContentViewRenderer))]
namespace SOMacHead.macOS
{
    public class MyContentViewRenderer : VisualElementRenderer<ContentView>
    {
        public MyContentViewRenderer()
        {
        }
    }
}
