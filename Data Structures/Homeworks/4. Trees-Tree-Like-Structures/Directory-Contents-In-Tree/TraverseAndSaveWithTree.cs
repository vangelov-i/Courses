using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class TraverseAndSaveWithTree
{
    static void Main()
    {
        var currentFolder = new DirectoryInfo("E:/Old Laptop/The Wedding 20.07.2013");
        var directoriesSizes = new Dictionary<string, long>();

        GetDirectoriesSizes(directoriesSizes, currentFolder);

        PrintFolders(0, currentFolder, directoriesSizes);
    }

    private static void PrintFolders(int indent, DirectoryInfo currentFolder, Dictionary<string, long> directoriesSizes)
    {
        Console.WriteLine(
            "{0}{1}: {2}", 
            new string(' ', 2* indent), 
            currentFolder.Name, 
            directoriesSizes[currentFolder.Name] / 1024 / 1024);

        foreach (var directory in currentFolder.GetDirectories())
        {
            PrintFolders(indent + 1, directory, directoriesSizes);
        }
    }

    private static long GetDirectoriesSizes(Dictionary<string, long> directoriesSizes, DirectoryInfo currentFolder)
    {
        long filesSum = currentFolder.GetFiles().Select(f => f.Length).Sum();
        directoriesSizes[currentFolder.Name] = filesSum;
        if (currentFolder.GetDirectories().Length == 0)
        {
            return directoriesSizes[currentFolder.Name];
        }

        foreach (var directory in currentFolder.GetDirectories())
        {
            directoriesSizes[currentFolder.Name] += GetDirectoriesSizes(directoriesSizes, directory);
        }

        return directoriesSizes[currentFolder.Name];
    }

    //static void Main()
    //{
    //    var currentFolder = new DirectoryInfo("C:/Windows");
    //    var foldersSize = new Dictionary<Folder, long>();
    //    Folder parentFolder = null;
    //    while (true)
    //    {
    //        var folderFiles = currentFolder.GetFiles();
    //        var filesToAdd = new File[folderFiles.Length];
    //        for (int index = 0; index < filesToAdd.Length; index++)
    //        {
    //            var currentFile = new File(folderFiles[index].Name, folderFiles[index].Length);
    //            filesToAdd[index] = currentFile;
    //        }

    //        var folderToAdd = new Folder(currentFolder.Name, filesToAdd);
    //        if (!foldersSize.co)
    //        {

    //        }

    //        parentFolder = folderToAdd;
    //    }
    //}
}

class Folder
{
    public Folder(string name, File[] files)
    {
        this.Name = name;
        this.Files = files;
    }

    public string Name { get; set; }

    public File[] Files { get; set; }

    public Folder[] ChildFolders { get; set; }
}

class File
{
    public File(string name, long size)
    {
        this.Name = name;
        this.Size = size;
    }

    public string Name { get; set; }

    public long Size { get; set; }
}