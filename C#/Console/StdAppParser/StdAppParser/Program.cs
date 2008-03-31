using System;
using System.IO;
using System.Text;


namespace StdAppParser2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*            switch (args.Length)
                        {
                            case 0:
                                if (File.Exists(args[0]))
                                {
                                    ReadContents(args[0]);
                                }
                                else
                                {
                                    Console.WriteLine("\nThe file ==> {0} does not exist!!\n\n", args[0]);
                                }
                                break;
                            case 1:
                                Console.WriteLine("\nPlease enter your Database name as an argument.\n\n\nUsage: StdAppParser.exe DataBasePath\n\n");
                                break;
                            default:
                                Console.WriteLine("\nToo many parameters...\n\n");
                                break;
                        }*/

            /*if (args.Length == 1)
            {
                if (File.Exists(args[0]))
                {
                    ReadContents(args[0]);
                }
                else
                {
                    Console.WriteLine("\nThe file ==> {0} does not exist!!\n\n", args[0]);
                }
            }
            else if (args.Length == 0)
            {
                Console.WriteLine("\nPlease enter your Database name as an argument.\n\n\nUsage: StdAppParser.exe DataBasePath\n\n");
            }
            else
            {
                Console.WriteLine("\nToo many parameters...\n\n");
            }*/
            if (args.Length != 0)
            {
                for (int i = 0; i < args.Length; ++i)
                {
                    if (File.Exists(args[i]))
                    {
                        Console.WriteLine("\nFrom {0} file:\n\n", args[i]);
                        ReadContents(args[i]);
                        Console.WriteLine("\n");
                    }
                    else
                    {
                        Console.WriteLine("\nThe file ==> {0} does not exist!!\n\n", args[0]);
                    }
                }
            }
            else
            {
                Console.WriteLine("\nPlease enter your Database name as an argument.\n\n\nUsage: StdAppParser.exe DataBasePath\n\n");
            }
        }


        static bool IsNumber(string numStr)
        {
            int result;
            if (int.TryParse(numStr, out result))
                return true;
            else
                return false;
        }

        static void ReadContents(string filePath)
        {
            string result = string.Empty;
            bool foundHeader = false;
            bool setCompleted = false;
            bool isEmptyFile = true;

            using (StreamReader sr = new StreamReader(filePath, Encoding.UTF8))
            {
                string line = string.Empty;

                while (sr.Peek() != -1)
                {
                    line = sr.ReadLine().Trim();

                    if (line == string.Empty)
                        continue;

                    if (!foundHeader)
                    {
                        isEmptyFile = false;

                        if (line != "StdAppv1.0")
                        {
                            Console.WriteLine("\nInvalid database file!!\n\n");
                            break;
                        }
                        else
                        {
                            foundHeader = true;
                            continue;
                        }
                    }
                    else
                    {
                        int pos = line.IndexOf(":");
                        if (pos == -1 || pos == 0 || pos == line.Length - 1)
                        {
                            Console.WriteLine("\nInvalid data in stream!!\n\n");
                            break;
                        }

                        string key = line.Substring(0, pos).Trim();
                        string value = line.Substring(pos + 1).Trim();

                        switch (key)
                        {
                            case "No":
                                result += string.Format("{0}        :  {1}", key, value);
                                break;
                            case "Student":
                                result += string.Format("{0}   :  {1}", key, value);
                                break;
                            case "Physics":
                                result += string.Format("{0}   :  {1}", key, value);
                                if (!IsNumber(value))
                                {
                                    Console.WriteLine("\nInvliad numeric value!!\n\n");
                                    return;
                                }
                                break;
                            case "Math":
                                result += string.Format("{0}      :  {1}", key, value);
                                if (!IsNumber(value))
                                {
                                    Console.WriteLine("\nInvliad numeric value!!\n\n");
                                    return;
                                }
                                break;
                            case "Chemistry":
                                result += string.Format("{0} :  {1}", key, value);
                                if (!IsNumber(value))
                                {
                                    Console.WriteLine("\nInvliad numeric value!!\n\n");
                                    return;
                                }
                                setCompleted = true;
                                break;
                            default:
                                Console.WriteLine("\nInvalid Key!!\n\n");
                                return;
                        }

                    }

                    if (setCompleted)
                    {
                        setCompleted = false;
                        result += "\n\n\n";
                    }
                    else
                        result += "\n";
                }
            }

            if (isEmptyFile)
                Console.WriteLine("\nEmpty File!!\n\n");

            Console.WriteLine(result);
        }
    }
}
