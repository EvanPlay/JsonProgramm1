using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonProgramm.obr
{
    public class Searcher
    {
        public bool SearhcerMethod(string filePath)
        {
            if(File.Exists(filePath))//Проверка на существование файла
            {
                if(filePath.Contains(@".json"))//Проверка на содержание в названии файла формата .json
                {
                    Console.WriteLine("Файл корректен!");
                    Console.WriteLine("");
                    return true;
                }
                else
                {
                    Console.WriteLine("Файл не корректен!");
                    Console.WriteLine("");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Файла не существует!");
                Console.WriteLine("");
                return false;
            }
        }
    }
}
