using System;
using System.IO;

namespace OOP_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            File_Info file = new File_Info(@"C:\Users\moonler\Desktop\мусор");
            //file.File_Output();
            file.Enter_File_Name("1, Ричко.doc");
            //file.Folder_Move(@"C:\Users\moonler\Desktop");
            file.Change_Folder(@"C:\Users\moonler\Desktop\мусор");
            file.Create_Folder("ВАЛЕРЧИК_ТЕСТ");
            Console.WriteLine(file.Current_Path());
            file.Delete_Folder("фывфыв");
        }
    }
}
