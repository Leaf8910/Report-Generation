using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.PlatformConfiguration;
using Report_Generation; // Adjust the namespace as needed

namespace Report_Generation
{
    public static class FileHelper
    {
        public static string ReadAssetFile(string filename)
        {
            string content;
            try
            {
                // Get the AssetManager from the Android context
                using (StreamReader sr = new StreamReader(Android.App.Application.Context.Assets.Open(filename)))
                {
                    content = sr.ReadToEnd();
                }
            }
            catch (Exception ex)
            {
                content = $"Error reading file: {ex.Message}";
            }
            return content;
        }
    }
}
