using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionEg
{
    class ExceptionHandle
    {
        public void WriteData()
        {
            FileStream fs = new FileStream("d:\\test.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);

            try
            {
                Console.WriteLine("Enter the ata");
                string st = Console.ReadLine();
                sw.WriteLine(st);
                sw.Flush();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                sw.Close();
                fs.Close();
            }
        }
    }
    class FilesEg
    {
         static void Main()
        {
            ExceptionHandle exceptionHandle = new ExceptionHandle();
            exceptionHandle.WriteData();
            
        } 
    }
}
