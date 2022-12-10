using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Conductor
{
    internal static class Soderzhimoye
    {
        
        public static string Nachalo()
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Этот компьютер");
            Console.SetCursorPosition(0, 1);
            Console.WriteLine("-------------------------------------------------------------------------------------------------");
            DriveInfo[] diski = DriveInfo.GetDrives();
            foreach (DriveInfo drive in diski)
            { 
                Console.WriteLine($"  {drive.Name} Свободно {drive.TotalFreeSpace / 1073741824} ГБ из {drive.TotalSize / 1073741824} ГБ");                   
            }
            Strelki menu = new Strelki(2, 2);
            int position = menu.Arrow() - 3;
            return diski[position].Name;
        }
        public static string Catalog(string poc)
        {
            Console.SetCursorPosition(50, 0);
            Console.WriteLine("Папка");
            Console.WriteLine("  Название\t\t\t\t\t\t\t\t\t     Дата создания");
            string pac = $"{poc}";
            List<string> elements = new List<string>();
            var dirInfo = new DirectoryInfo(pac);  
            int num = 0;
            string[] direct = Directory.GetDirectories(pac);
            string[] files = Directory.GetFiles(pac);
            elements = [direct, files];
            foreach (string elik in elements)
            {
                Console.WriteLine($"  {elik}");
                Console.SetCursorPosition(80, num + 3);
                Console.WriteLine($"  {dirInfo.CreationTime}");
                num++;
            }
            Strelki menu = new Strelki(num + 3, 3);
            int vybrpos = menu.Arrow()-3;
            return Catalog(elements[vybrpos]);
        }
        public static void Zapusk()
        {  
            string drive = Nachalo();
            string path = Catalog(drive);
            Process.Start(new ProcessStartInfo {FileName = path, UseShellExecute = true});
        }
    }
}






                
               
        
       
                        
                
        
    


   

