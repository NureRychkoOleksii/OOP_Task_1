using System;
using System.IO;
using System.Linq;
using System.Threading.Channels;

namespace OOP_Task_1
{
    public class File_Info
    {
        public string _Path { get; set; }

        public string File_Name { get; set; }

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
    }
}