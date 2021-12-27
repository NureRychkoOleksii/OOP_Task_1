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
                string[] stringArr = Console.ReadLine().Split(" ");
                switch (stringArr[0])
                {
                    case "cd":
                        fileInfo.ChangeFolder(stringArr[1]);
                        break;
                    
                    case "dir":
                        fileInfo.FileOutput();
                        break;
                    
                    case "dir:c":
                        Console.WriteLine(fileInfo.CurrentPath());
                        break;
                    case "dir-f":
                        fileInfo.FileOutputHiddenFilesToo();
                        break;
                    case "dir-t":
                        fileInfo.FileOutputAsTree();
                        break;
                    case "dir-s-n":
                        fileInfo.FileOutputByName();
                        break;
                    case "dir-s-e":
                        fileInfo.FileOutputByExtension();
                        break;
                    case "dir-s-s":
                        fileInfo.FileOutputBySize();
                        break;
                    case "type":
                        Console.WriteLine(fileInfo.FileOutput200Symbols(stringArr[1]));
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
