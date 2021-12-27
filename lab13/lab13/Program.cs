namespace lab13
{
    internal static class Program
    {
        static void Main(string[] args)
        {
            YADDiskInfo.getFreeDrivesSpace();
            YADLog.writeToLog("YADDiskInfo.getFreeDrivesSpace()");

            YADFileInfo.getFileinfo(@"D:\2 курс\ооп\lab13\lab13\log.txt");
            YADLog.writeToLog("YADFileInfo.getFileinfo()", "log.txt", @"D:\2 курс\ооп\lab13\lab13\log.txt");

            YADDirInfo.getDirinfo(@"e:\!ПОИТ\2\First\ООТП\Лабы\lab13");
            YADLog.writeToLog("YADDirInfo.getDirinfo()", "", @"D:\2 курс\ооп\lab13\lab13");

            YADFileManager.getAllDirsAndFilesOfDisk(@"E:\");
            YADLog.writeToLog("YADFileManager.getAllDirsAndFilesOfDisk()", "", @"D:\");

            YADFileManager.getAllFilesWithExtension(@"e:\!ПОИТ\2\First\ЯП\КП\YAD-2021\YAD-2021", ".txt");
            YADLog.writeToLog("YADFileManager.getAllDirsAndFilesOfDisk()", "", @"e:\!ПОИТ\2\First\ЯП\КП\YAD-2021\YAD-2021");

            YADFileManager.createZIP(@"D:\2 курс\ооп\lab13\BKAInspect\BKAFiles");
            YADLog.writeToLog("YADFileManager.createZIP()");
        }
    }
}