using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day7assignment
{
    public class fileioops
    {
        public void createfile() 
        {
            // string path = @"D:\mphasis";
            try
            {
                string path = "D:\\mphasis Simplilearn\\Day7\\";
                Console.WriteLine("enter filename");
                string fname = Console.ReadLine();
                string fpath = path + fname;
                if (!File.Exists(fpath))
                {
                    File.Create(fpath);
                    Console.WriteLine($"File {fname} Created successful");
                }
                else
                {
                    Console.WriteLine($"File {fname} alreadyexist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("finish");
                Console.ReadKey();
            }

        }
        public void readfile()
        {

            StreamReader sr;
            try
            {
                string fpath = "D:\\mphasis Simplilearn\\Day7\\abc.txt";
                sr = new StreamReader(fpath);
                string text = "";
                while ((text = sr.ReadLine()) != null)
                {
                    Console.WriteLine(text);
                }
                sr.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("error" + ex.Message);
            }
            finally
            {
                Console.ReadKey();
            }
        }
        public void appendfile()
        {
            Console.WriteLine("enter the the file path");
            string fpath = Console.ReadLine();
            if (File.Exists(fpath))
            {
                Console.WriteLine("file already exist");
            }
            else
            {
                StreamWriter sw = File.AppendText(fpath);
                sw.WriteLine("welcome to stream writing example");
                sw.Dispose();
                sw.Close();
                Console.WriteLine("created and text written");
            }
            Console.ReadKey();
        }
        public void deletefile()
        {
            try
            {
                string path = "D:\\mphasis Simplilearn\\Day7\\";
                Console.WriteLine("enter filename");
                string fname = Console.ReadLine();
                string fpath = path + fname;
                if (File.Exists(fpath))
                {
                    File.Delete(fpath);
                    Console.WriteLine($"File {fname} deleted successful");
                }
                else
                {
                    Console.WriteLine($"File {fname} alreadyexist");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("error");
            }
            finally
            {
                Console.WriteLine("finish");
                Console.ReadKey();
            }
        }
    }
}
