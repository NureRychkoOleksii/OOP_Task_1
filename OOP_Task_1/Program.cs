using System;

namespace OOP_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            File_Info fileInfo = new File_Info(@"C:\Users\moonler\Desktop\мусор");
            fileInfo.File_Output();
            fileInfo.Enter_File_Name("1, Ричко.doc");
            fileInfo.Folder_Move(@"C:\Users\moonler\Desktop");
        }
    }
}
