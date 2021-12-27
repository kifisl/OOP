using System.IO;
using System.IO.Compression;

namespace lab13
{
    public static class YADFileManager
    {
        public static void getAllDirsAndFilesOfDisk(string diskName)
        {
            var allDrives = DriveInfo.GetDrives();
            foreach (var drive in allDrives)
            {
                if (drive.Name == diskName)
                {
                    DirectoryInfo dir = new DirectoryInfo(@"e:\!ПОИТ\2\First\ООТП\Лабы\lab13");
                    if(dir.GetDirectories("YADInspect").Length == 0)
                    {
                        DirectoryInfo subDir = dir.CreateSubdirectory("YADInspect");
                        DirectoryInfo dr = new DirectoryInfo(diskName);
                        using (StreamWriter file = new StreamWriter(subDir.FullName + @"\" + "YADDirInfo.txt"))
                        {
                            file.WriteLine("----------Директории----------");
                            foreach (var d in dr.GetDirectories())
                                file.WriteLine($"{d.Name}");
                            file.WriteLine("-------------------------------");

                            file.WriteLine("----------Файлы----------");
                            foreach (var d in dr.GetFiles())
                                file.WriteLine($"{d.Name}");
                            file.WriteLine("-------------------------");
                        }
                        FileInfo dirinfo = new FileInfo(subDir.FullName + @"\" + "YADDirInfo.txt");
                        dirinfo.CopyTo(subDir.FullName + @"\" + "YADDirInfoCOPY.txt");
                        dirinfo.Delete();
                    }
                    break;
                }
            }
        }

        public static void getAllFilesWithExtension(string dirPath, string extension)
        {
            DirectoryInfo directory = new DirectoryInfo(dirPath);
            if (directory.Exists)
            {
                DirectoryInfo temp = new DirectoryInfo(@"e:\!ПОИТ\2\First\ООТП\Лабы\lab13");
                if (temp.GetDirectories("YADInspect")[0].GetDirectories("YADFiles").Length == 0)
                {
                    DirectoryInfo Files = temp.CreateSubdirectory("YADFiles");

                    foreach (var file in directory.GetFiles($"*{extension}"))
                        file.CopyTo(Files.FullName + @"\" + file.Name);
                    
                    Files.MoveTo(temp.GetDirectories("YADInspect")[0].FullName + "\\YADFiles");
                }
            }
        }

        public static void createZIP(string dir)
        {
            string zipName = @"e:\!ПОИТ\2\First\ООТП\Лабы\lab13\YADInspect\YADFiles.zip";
            if (new DirectoryInfo(@"D:\2 курс\ооп\lab13\BKAInspect").GetFiles("*.zip").Length == 0)
            {
                ZipFile.CreateFromDirectory(dir, zipName);
                DirectoryInfo direct = new DirectoryInfo(dir);
                foreach (var innerFile in direct.GetFiles())
                    innerFile.Delete();
                direct.Delete();
                ZipFile.ExtractToDirectory(zipName, dir);
            }
        }
    }
}
