using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace jobrecuritment.Helpers
{
    public static class Extensions
    {
        public static bool isImage(this IFormFile file, int v)
        {
            if (file.ContentType.Contains("image"))
            {
                return true;
            }
            return false;
        }

        public static bool isSmallerThan(this IFormFile file,int kb)
        {
            if (file.Length < kb)
            {
                return true;
            }
            return false;
        }

        public static string Upload(this IFormFile file,string path)
        {
            string fileName = Guid.NewGuid().ToString() + file.FileName;
            string finalPath = Path.Combine(path, fileName);

            using(FileStream stream =new FileStream(finalPath, FileMode.Create))
            {
                file.CopyToAsync(stream);
            }
            return fileName;
        }
    }
}
