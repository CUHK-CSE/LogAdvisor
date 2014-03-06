﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Roslyn.Compilers;
using Roslyn.Compilers.CSharp;
using System.IO;

namespace CatchBlockExtraction
{
    class Program
    {
        public static FolderInfo FolderFileInfo;
        public static IMatchListsForMultiplePatterns patternMatchRule;

        static void Main(string[] args)
        {
            String inputMode = args[0];
            String filePath = args[1];
            if (filePath.EndsWith("\\"))
            {
                filePath = filePath.Remove(filePath.LastIndexOf('\\'));
            }
            IOFileProcessing.FolderPath = filePath;
            
            Logger.Initialize();
            DateTime StartTime = DateTime.Now;          
            FolderFileInfo = new FolderInfo();
            patternMatchRule = new MatchbyPatternCategory();

            FolderInfo.InputMode = inputMode;
           
            Config.Load(IOFileProcessing.CompleteFileName("Config.txt"));

            // traverse all the code folder for pattern check
            CodeWalker walker = new CodeWalker();
            walker.LoadByInputMode(inputMode, filePath);

            DateTime EndTime = DateTime.Now;
            Logger.Log("Raw feature file generated. Total Time: " + (EndTime - StartTime).ToString());
            Logger.Log("Press any key to terminate!");
            Logger.Close();
            Console.ReadKey();  
        }
    }
}