using System;
using System.IO;
using System.Linq;


namespace OOP_Task_1
{
    public class File_Info
    {
        public string _Path { get; set; }

        public string File_Name { get; set; }

        private DirectoryInfo directoryInfo;

        public void Enter_File_Name(string name)
        {
            File_Name = name;
        }

        public File_Info()
        {
            
        }

        public File_Info(string path)
        {
            _Path = path;
        }
        
        public void File_Output()
        {
            Directory
                .GetFiles(_Path, "*", SearchOption.AllDirectories)
                .ToList()
                .ForEach(f => Console.WriteLine(Path.GetFileName(f)));
        }

        public void Change_Folder(string path)
        {
            _Path = path;
        }

        public string Current_Path()
        {
            return _Path;
        }
        
        public void Folder_Move(string path)
        {
            string final_path = $@"{path}\{File_Name}";
            File.Move($@"{_Path}\{File_Name}",final_path);
        }

        public void Create_Folder(string folder_name)
        {
            Directory.CreateDirectory(@$"{_Path}\{folder_name}");
        }

        public void Delete_Folder(string folder_name)
        {
            
            // void DeleteDirectory(string directoryName, bool checkDirectiryExist)
            // {
            //     if (Directory.Exists(directoryName))
            //         Directory.Delete(directoryName, true);
            //     else if (checkDirectiryExist)
            //         throw new SystemException("Directory you want to delete is not exist");
            // }
            
            Directory.Delete($@"{_Path}\{folder_name}",true);
        }
    }
}