using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace FilyeSystemWatcher

{
    class Program
    {
        static void Main(string[] args)
        {
            //Scrieti un program care monitorizeaza 3 foldere diferite, pentru orice modificari posibile, si afiseaza la consola modificarile care s-au produs.
            FileSystemWatcher fileSystemWatcher = new FileSystemWatcher();

            fileSystemWatcher.Path = "C:\\Test1";

            fileSystemWatcher.Created += FileSystemWatcher_Created;
            fileSystemWatcher.Renamed += FileSystemWatcher_Renamed;
            fileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            

            

            FileSystemWatcher fileSystemWatcher1 = new FileSystemWatcher();
            fileSystemWatcher1.Path = "C:\\Test2";

            fileSystemWatcher1.Created += FileSystemWatcher_Created;
            fileSystemWatcher1.Renamed += FileSystemWatcher_Renamed;
            fileSystemWatcher1.Deleted += FileSystemWatcher_Deleted;
            




            FileSystemWatcher fileSystemWatcher2 = new FileSystemWatcher();
            fileSystemWatcher2.Path = "C:\\Test3";

            fileSystemWatcher2.Created += FileSystemWatcher_Created;
            fileSystemWatcher2.Renamed += FileSystemWatcher_Renamed;
            fileSystemWatcher2.Deleted += FileSystemWatcher_Deleted;



            fileSystemWatcher.EnableRaisingEvents = true;
            fileSystemWatcher1.EnableRaisingEvents = true;
            fileSystemWatcher2.EnableRaisingEvents = true;
            Console.WriteLine("Press any key to close");
            Console.ReadKey();

        }

        

        private static void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            Console.WriteLine($"Renamed from {e.OldName} to {e.Name} ");


        }

        private static void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Created: {e.Name}");
        }

        
        

        private static void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            Console.WriteLine($"Deleted: {e.Name}");

           

            


        }
    } }
