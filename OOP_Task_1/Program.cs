using System;
using OOPTask1;

namespace OOP_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            File_Info file = new File_Info(@"E:\Projects\Test_Rep_1");
            //file.File_Output_By_Size();
            //file.File_Output_By_Extension();
            //file.FileOutputAsTree();
            //file.EnterFileName("1, Ричко.doc");
            //file.Folder_Move(@"C:\Users\moonler\Desktop");
            file.ChangeFolder(@"C:\Users\moonler\Desktop\мусор");
           // file.FileOutputHiddenFilesToo();
            //file.CreateFolder("ВАЛЕРЧИК_ТЕСТ");
            Console.WriteLine(file.CurrentPath());
            //file.Delete_Folder("фывфыв");
            //file.CreateFile("Валерчик тест.txt");
            //file.DeleteFile("Валерчик тест.txt");
           // file.RenameFile("960.webp","test.webp");
            file.FileOutput200Symbols("file.txt");
            //file.Rename_Folder("ВАЛЕРЧИК_ТЕСТ","тест_ренейм");
        }
    }
}
