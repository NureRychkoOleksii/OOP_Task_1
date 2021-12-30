using System;
using System.IO;
using System.Linq;
using System.Net.Mime;
using System.Drawing;

namespace OOPTask1
{
    public class File_Info
    {
        public string _Path { get; set; }

        public string FileName { get; set; }

        private DirectoryInfo directoryInfo;
        
        public File_Info()
        {
            
        }

        public File_Info(string path)
        {
            _Path = path;
        }
        
        public string[] FileOutput()
        {
            return Directory.GetFiles(_Path, "*", SearchOption.AllDirectories);
            //.ToList();
            //.ForEach(f => Console.WriteLine(Path.GetFileName(f)));
        }

        public string[] FileOutputByName()
        {
            return Directory
                .GetFiles(_Path, "*", SearchOption.AllDirectories)
                .OrderBy(f => f)
                .ToArray();
           

            // string[] lst = Directory.GetFiles(Path, "*", SearchOption.AllDirectories);
            // Array.Sort(lst);
            // foreach (var i in lst)
            // {
            //     Console.WriteLine(Path.GetFileName(i));
            // }
        }

        public void FileOutputAsTree()
        {
            FileInfo[] fileinfoarr = Directory.GetFiles(_Path,"*",SearchOption.AllDirectories).Select(f => new FileInfo(f)).ToArray();
            foreach (var i in fileinfoarr)
            {
                Console.WriteLine($"- file : {i.Name}");
                Console.WriteLine($"   - size: {i.Length} bytes");
                Console.WriteLine($"   - date created: {i.CreationTime}");
                Console.WriteLine($"   - last updated: {i.LastWriteTime}");
                // if (i.Extension == ".jpg" || i.Extension == ".jpeg" || i.Extension == ".png" || i.Extension == ".gif")
                // {
                //     Bitmap bmp = new Bitmap(i.Name);
                //     Console.WriteLine($"   - Resolution : {bmp.Height}x{bmp.Width}");
                // }
            }
        }
        
        public string[] FileOutputBySize()
        {
            return Directory
                .GetFiles(_Path)
                .OrderBy(f => new FileInfo(f).Length)
                .ToArray();
            
            // foreach (var i in lst)
            // {
            //     Console.WriteLine(Path.GetFileName(i));
            // }
            
        }

        public string FileOutput200Symbols(string fileName)
        {
            string[] kek = File.ReadAllLines($@"{_Path}\{fileName}");
            int strLength = 0;
            string final = "";
            
            foreach (var i in kek)
            {
                strLength += i.Length;
            }

            bool t = false;

            for (int i = 0; i < kek.Length; i++)
            {

                for (int j = 0; j < kek[i].Length; j++)
                {
                    if (final.Length == 200)
                    {
                        t = true;
                        break;
                    }

                    final += kek[i][j];
                }

                if (t == true)
                {
                    break;
                }

            }


            return final;
        }

        public string[] FileOutputHiddenFilesToo()
        {
            string[] lstinfo = Directory.GetFiles(_Path);
            FileAttributes[] arr=new FileAttributes[lstinfo.ToArray().Length];
            int ind = 0;
            foreach (var i in lstinfo)
            {
                arr[ind] = File.GetAttributes(i);
                ind++;
            }

            ind = 0;
            FileAttributes[] lst = arr;
            foreach (var i in lst)
            {
                if((i & FileAttributes.Hidden)==FileAttributes.Hidden)
                {
                    arr[ind] = RemoveAttribute(i, FileAttributes.Hidden);
                    File.SetAttributes(lstinfo[ind],arr[ind]);
                }
            }
            return FileOutput();
        }
        private FileAttributes RemoveAttribute(FileAttributes attributes, FileAttributes attributesToRemove)
        {
            return attributes & ~attributesToRemove;
        }

        public bool FindSubStr(string subStr, string fileName)
        {
            string str = FileOutput200Symbols(fileName);
            return str.Contains(subStr);
        }
        
        public string[] FileOutputByExtension()
        {
            string[] lst = Directory.GetFiles(_Path);
            return lst
                .OrderBy(f => Path.GetExtension(f))
                .ToArray();
            // foreach (var i in lst)
            // {
            //     Console.WriteLine(Path.GetFileName(i));
            // }
        }
        
        public void ChangeFolder(string path)
        {
            _Path = path;
        }

        public string CurrentPath()
        {
            return _Path;
        }
        
        public void FolderMove(string path)
        {
            string finalpath = $@"{path}\{FileName}";
            File.Move($@"{_Path}\{FileName}",finalpath);
        }

        public void CreateFolder(string foldername)
        {
            Directory.CreateDirectory(@$"{_Path}\{foldername}");
        }

        public void DeleteFolder(string foldername)
        {
            Directory.Delete($@"{_Path}\{foldername}",true);
        }

        public void CreateFile(string filename)
        {
            var file=File.Create($@"{_Path}\{filename}");
            file.Close();
        }

        public void DeleteFile(string filename)
        {
            File.Delete($@"{_Path}\{filename}");
        }

        public void RenameFile(string filename, string newfilename)
        {
            string sourcefile = $@"{_Path}\{filename}";
            FileInfo fi = new FileInfo(sourcefile);
            if (fi.Exists)
            {
                fi.MoveTo($@"{_Path}\{newfilename}");
            }
        }

        public void RenameFolder(string foldername, string newfoldername)
        {
            DirectoryInfo di = new DirectoryInfo($@"{_Path}\{foldername}");
            if (di.Exists == true)
            {
                Directory.Move($@"{_Path}\{foldername}",$@"{_Path}\{newfoldername}");
            }
        }
        
    }
}