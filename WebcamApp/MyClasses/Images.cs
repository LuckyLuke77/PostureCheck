using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebcamApp.MyClasses
{
    internal class Images
    {
        public static String GetPath(String imageName)
        {
            String localDir;
            localDir = AppContext.BaseDirectory; // gets the path, inluding \bin\debug\
            int dirLen = localDir.Length;
            localDir = localDir.Substring(0, dirLen - 10); // remove \bin\debug\ from the path
            localDir += @"Images\" + imageName + @"\"; // add Moments\ to the path
            return localDir;
        }
    }
}
