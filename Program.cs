using System;
using System.Diagnostics;
using System.IO;

namespace pluh{
    class Program{
        static void Main(string[] args){
            
            if(args.Length == 0)
            {
                Console.WriteLine("Pluh.🗣️ 🔥🔥");
                return;
            }

            string command = args[0].ToLower();
            
            switch(command){
                case "help":
                    Console.WriteLine("Welcome to Pluh.");
                    Console.WriteLine("Pluh is a CCT(C++ Command-Line Tool)");
                    Console.WriteLine("Here are basic commands:");
                    Console.WriteLine("code -> starts a new .cpp file in the current dir~");
                    Console.WriteLine("build -> build the executable for the main file");
                    Console.WriteLine("run -> runs the main.cpp file in the current dir~");
                break;

                case "code":
                    Code(".");
                break;

                case "build":
                    Build();
                break;

                case "run":
                    BuildAndRun();
                break;

            }
        }

        static void Code(string path)
        {
            string text = "#include<iostream>\n"+
                        "int main()\n"+
                        "{\n"+
                          "\n   return 0;"+
                        "\n}";

            File.AppendAllText(path+"/main.cpp",text);
        }

        static void BuildAndRun()
        {
            string command = "g++ main.cpp -o main && main.exe";
            
            Process process = new();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.UseShellExecute = false;
            process.Start();
                 
        }

        static void Build()
        {
            string command = "g++ main.cpp -o main";
            
            Process process = new();
            process.StartInfo.FileName = "cmd.exe";
            process.StartInfo.Arguments = "/c " + command;
            process.StartInfo.UseShellExecute = false;
            process.Start();
                 
        }
    }
}