using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;


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

        public void File_Output_By_Name()
        {
            Directory
                .GetFiles(_Path, "*", SearchOption.AllDirectories)
                .ToList()
                .OrderBy(f=>f)
                .ToList()
                .ForEach(f => Console.WriteLine(Path.GetFileName(f)));
        }

        public void File_Output_By_Size()
        {
            List<string> lst= Directory.GetFiles(_Path).ToList();
            lst
                .OrderBy(f => new FileInfo(f).Length)
                .ToList()
                .ForEach(f=>Console.WriteLine(Path.GetFileName(f)));
        }

        public void File_Output_Hidden_Files_Too()
        {
            string[] lst_info = Directory.GetFiles(_Path);
            FileAttributes[] arr=new FileAttributes[lst_info.ToList().Count];
            int ind = 0;
            foreach (var i in lst_info)
            {
                arr[ind] = File.GetAttributes(i);
                ind++;
            }

            ind = 0;
            List<FileAttributes> lst = arr.ToList();
            foreach (var i in lst)
            {
                if((i & FileAttributes.Hidden)==FileAttributes.Hidden)
                {
                    arr[ind] = RemoveAttribute(i, FileAttributes.Hidden);
                    File.SetAttributes(lst_info[ind],arr[ind]);
                }
            }
            File_Output();
        }
        private FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        public void File_Output_By_Extension()
        {
            List<string> lst = Directory.GetFiles(_Path).ToList();
            lst
                .OrderBy(f=>Path.GetExtension(f))
                .ToList()
                .ForEach(f=>Console.WriteLine(Path.GetFileName(f)));
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
            Directory.Delete($@"{_Path}\{folder_name}",true);
        }

        public void Create_File(string file_name)
        {
            var file=File.Create($@"{_Path}\{file_name}");
            file.Close();
        }

        public void Delete_File(string file_name)
        {
            File.Delete($@"{_Path}\{file_name}");
        }

        public void Rename_File(string file_name, string new_file_name)
        {
            string source_file = $@"{_Path}\{file_name}";
            FileInfo fi = new FileInfo(source_file);
            if (fi.Exists)
            {
                fi.MoveTo($@"{_Path}\{new_file_name}");
            }
        }

        public void Rename_Folder(string folder_name, string new_folder_name)
        {
            DirectoryInfo di = new DirectoryInfo($@"{_Path}\{folder_name}");
            if (di.Exists == true)
            {
                Directory.Move($@"{_Path}\{folder_name}",$@"{_Path}\{new_folder_name}");
            }
        }
        
    }
}