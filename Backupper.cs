using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Backup
{
    public class Backupper
    {
        public static void Backup(string srcPath, string destPath, DateTime time)
        {
            if (!Directory.Exists(srcPath) || !Directory.Exists(destPath))
            {
                Console.WriteLine("One of the paths specified do not exist, please re-check and try again later");
                return;
            }
            foreach (var file in Directory.GetFiles(srcPath))
                if (File.GetCreationTime(file) > time)
                    File.Copy(file, Path.Combine(destPath, Path.GetFileName(file)), true);
        }
    }
}
