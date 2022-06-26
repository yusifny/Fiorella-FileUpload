using System.IO;
using Microsoft.AspNetCore.Hosting;

namespace FrontToBack.Helpers
{
    public class Helper
    {
        public static  void DeleteFile(IWebHostEnvironment env, string folder, string filename)
        {
            string path = env.WebRootPath;
            string resultPath = Path.Combine(path, folder, filename);

            if (System.IO.File.Exists(resultPath))
            {
                System.IO.File.Delete(resultPath);
            }
        }
    }
}