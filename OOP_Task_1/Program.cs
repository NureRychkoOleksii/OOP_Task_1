using System;
using System.IO;
using OOPTask1;

namespace OOP_Task_1
{
    class Program
    {
        static void Main(string[] args)
        { 
            bool ifWorking=true;
            File_Info fileInfo = new File_Info(@"C:\Users\moonler\Desktop");
            while (ifWorking)
            {
                Console.WriteLine(fileInfo.CurrentPath()+"> ");
                string[] stringArr = Console.ReadLine().Split(" ");
                switch (stringArr[0])
                {
                    case "cd":
                        fileInfo.ChangeFolder(stringArr[1]);
                        break;
                    
                    case "dir":
                        foreach (var i in fileInfo.FileOutput())
                        {
                            Console.WriteLine(Path.GetFileName(i));
                        }
                        break;
                    
                    case "dir:c":
                        Console.WriteLine(fileInfo.CurrentPath());
                        break;
                    
                    case "dir-f":
                        foreach (var i in fileInfo.FileOutputHiddenFilesToo())
                        {
                            Console.WriteLine(Path.GetFileName(i));
                        }
                        break;

                    case "dir-t":
                        fileInfo.FileOutputAsTree();
                        break;
                    
                    case "dir-s-n":
                        foreach (var i in fileInfo.FileOutputByName())
                        {
                            Console.WriteLine(Path.GetFileName(i));
                        }
                        break;
                    
                    case "dir-s-e":
                        foreach (var i in fileInfo.FileOutputByExtension())
                        {
                            Console.WriteLine(Path.GetFileName(i));
                        }
                        break;
                    
                    case "dir-s-s":
                        foreach (var i in fileInfo.FileOutputBySize())
                        {
                            Console.WriteLine(Path.GetFileName(i));
                        }
                        break;
                    
                    case "type":
                        Console.WriteLine(fileInfo.FileOutput200Symbols(stringArr[1]));
                        break;
                    
                    case "type-s":
                        Console.WriteLine(fileInfo.FindSubStr(stringArr[1],stringArr[2]));
                        break;
                    
                    case "md":
                        fileInfo.CreateFolder(stringArr[1]);
                        break;
                    
                    case "nul":
                        fileInfo.CreateFile(stringArr[1]);
                        break;
                    
                    case "ren":
                        fileInfo.RenameFile(stringArr[1], stringArr[2]);
                        break;

                    case "ren-f":
                        fileInfo.RenameFolder(stringArr[1], stringArr[2]);
                        break;
                    
                    case "del":
                        fileInfo.DeleteFile(stringArr[1]);
                        break;
                    
                    case "del-f":
                        fileInfo.DeleteFolder(stringArr[1]);
                        break;
                    
                    case "move":
                        fileInfo.FolderMove(stringArr[1]);
                        break;
                    
                    case "exit":
                        ifWorking = false;
                        break;
                    
                }
            }
        }
    }
}
