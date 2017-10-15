using System;
using System.IO;
using MissionOutreachMobile.Data;
using MissionOutreachMobile.Droid;
using Xamarin.Forms;

[assembly: Dependency(typeof(FileHelper))]
namespace MissionOutreachMobile.Droid
{
    public class FileHelper : IFileHelper
    {
        public string GetLocalFilePath(string filename)
        {
            string path = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            return Path.Combine(path, filename);
        }
    }
}
