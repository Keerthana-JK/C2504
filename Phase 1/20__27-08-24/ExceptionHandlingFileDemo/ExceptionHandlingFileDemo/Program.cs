﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandlingFileDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filename = "file2.txt";
            StreamReader reader = null;
            try
            {
                Console.WriteLine("1-Trying...");//Log.Debug
                reader = new StreamReader(filename);
                Console.WriteLine(reader.ReadToEnd());//Log.Info
                Console.WriteLine("1-Tried!!!");//Log.Debug

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine("2-Catch");//Log.Debug
                Console.WriteLine("File not found: " + ex.Message);//Log.Error
            }
            finally
            {
                Console.WriteLine("3-Finally");//Log.Debug
                                               // This code will always execute, whether an exception occurs or not.
                if (reader != null)
                {
                    reader.Close();
                    Console.WriteLine("File read stream closed.");//Log.Debug
                }
            }

            Console.WriteLine("4-Normal flow...");//Log.Debug
            StreamWriter writer = new StreamWriter(filename, true);
            Console.Write("Enter text:");
            writer.WriteLine(Console.ReadLine());
            writer.Close();
        }
    }
}
