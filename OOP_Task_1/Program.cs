using System;

namespace OOP_Task_1
{
    class Program
    {
        static void Main(string[] args)
        {
            File_Info file = new File_Info(@"E:\Projects\Test_Rep_1");
            //file.File_Output_By_Size();
            //file.File_Output_By_Extension();
            file.Enter_File_Name("1, Ричко.doc");
            //file.Folder_Move(@"C:\Users\moonler\Desktop");
            file.Change_Folder(@"C:\Users\moonler\Desktop\мусор");
            file.File_Output_Hidden_Files_Too();
            file.Create_Folder("ВАЛЕРЧИК_ТЕСТ");
            Console.WriteLine(file.Current_Path());
            //file.Delete_Folder("фывфыв");
            file.Create_File("Валерчик тест.txt");
            file.Delete_File("Валерчик тест.txt");
            file.Rename_File("5c3c9a1ca93c0.jpeg","test.jpeg");
            //file.Rename_Folder("ВАЛЕРЧИК_ТЕСТ","тест_ренейм");
        }
    }
}
