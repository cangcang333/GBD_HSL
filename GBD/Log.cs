using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BWM01
{
    static class Log
    {
        //[DllImport('kernel32.dll')]

        public static string logFilePath = "";
        public static string errorLogFilePath = "";

        public static void Init()
        {
            // Log 目录放置在bin\Debug目录下，普通日志文件格式为 yyyy_MM_dd.log，错误日志文件格式为 yyyy_MM_dd.error
            string currentDirectory = Environment.CurrentDirectory;

            string date = DateTime.Now.ToLocalTime().ToString("yyyy_MM_dd");

            logFilePath = currentDirectory + @"\Log\" + date + ".log";
            errorLogFilePath = currentDirectory + @"\Log\" + date + ".error";

            /*
            if (!File.Exists(logFilePath))
            {
                // 文件不存在，先创建文件
                StreamWriter newLogFile = File.CreateText(logFilePath);
                newLogFile.Close();
            }

            if (!File.Exists(errorLogFilePath))
            {
                // 文件不存在，先创建文件
                StreamWriter newLogFile = File.CreateText(errorLogFilePath);
                newLogFile.Close();
            }
            */
        }


        // Print debug message to log file
        public static void Debug(string message)
        {
            
            // log format hhmmss|D|<file_name>|<function_name>|<class_name>|<line_number>|:message

            StackFrame stackFrame = (new StackTrace(0, true)).GetFrame(1);

            string time = DateTime.Now.ToLocalTime().ToString("HHmmss");

            string filePath = stackFrame.GetFileName();

            string fileName = Path.GetFileName(filePath);
            fileName = String.Format("{0, -12}", fileName).Substring(0, 12);

            string className = stackFrame.GetMethod().ReflectedType.FullName;
            className = String.Format("{0, -14}", className).Substring(0, 14);

            string methodName = stackFrame.GetMethod().Name;
            methodName = String.Format("{0, -12}", methodName).Substring(0, 12);

            string lineNumber = stackFrame.GetFileLineNumber().ToString();
            lineNumber = String.Format("{0, -4}", lineNumber).Substring(0, 4);

            string debugMessage = time + "|D|" + fileName + "|" + className + "|" + methodName + "|" + lineNumber + " :  " + message;
            //string debugMessage = FormatMessage("D") + message;

            try
            {
                File.AppendAllText(logFilePath, debugMessage);
                File.AppendAllText(logFilePath, Environment.NewLine);
            }
            catch(Exception e)
            {
                return;
            }
        }

        // Print info message to log file
        public static void Info(string message)
        {
            // log format hhmmss|I|<file_name>|<function_name>|<class_name>|<line_number>|:message

            StackFrame stackFrame = (new StackTrace(0, true)).GetFrame(1);

            string time = DateTime.Now.ToLocalTime().ToString("HHmmss");

            string filePath = stackFrame.GetFileName();

            string fileName = Path.GetFileName(filePath);
            fileName = String.Format("{0, -12}", fileName).Substring(0, 12);

            string className = stackFrame.GetMethod().ReflectedType.FullName;
            className = String.Format("{0, -14}", className).Substring(0, 14);

            string methodName = stackFrame.GetMethod().Name;
            methodName = String.Format("{0, -12}", methodName).Substring(0, 12);

            string lineNumber = stackFrame.GetFileLineNumber().ToString();
            lineNumber = String.Format("{0, -4}", lineNumber).Substring(0, 4);

            string infoMessage = time + "|I|" + fileName + "|" + className + "|" + methodName + "|" + lineNumber + " :  " + message;
            //string infoMessage = FormatMessage("I") + message;

            try
            {
                File.AppendAllText(logFilePath, infoMessage);
                File.AppendAllText(logFilePath, Environment.NewLine);
            }
            catch (Exception e)
            {
                return;
            }
            
        }

        // Print warning message to log file
        public static void Warning(string message)
        {
            // log format hhmmss|W|<file_name>|<function_name>|<class_name>|<line_number>|:message

            StackFrame stackFrame = (new StackTrace(0, true)).GetFrame(1);

            string time = DateTime.Now.ToLocalTime().ToString("HHmmss");

            string filePath = stackFrame.GetFileName();

            string fileName = Path.GetFileName(filePath);
            fileName = String.Format("{0, -12}", fileName).Substring(0, 12);

            string className = stackFrame.GetMethod().ReflectedType.FullName;
            className = String.Format("{0, -14}", className).Substring(0, 14);

            string methodName = stackFrame.GetMethod().Name;
            methodName = String.Format("{0, -12}", methodName).Substring(0, 12);

            string lineNumber = stackFrame.GetFileLineNumber().ToString();
            lineNumber = String.Format("{0, -4}", lineNumber).Substring(0, 4);


            string warningMessage = time + "|W|" + fileName + "|" + className + "|" + methodName + "|" + lineNumber + " :  " + message;
            //string warningMessage = FormatMessage("W") + message;
            try
            {
                File.AppendAllText(logFilePath, warningMessage);
                File.AppendAllText(logFilePath, Environment.NewLine);
            }
            catch (Exception e)
            {
                return;
            }
        }

        // Print error message to error log file and normal log file
        public static void Error(string message)
        {
            // log format hhmmss|E|<file_name>|<function_name>|<class_name>|<line_number>|:message

            StackFrame stackFrame = (new StackTrace(0, true)).GetFrame(1);

            string time = DateTime.Now.ToLocalTime().ToString("HHmmss");

            string filePath = stackFrame.GetFileName();

            string fileName = Path.GetFileName(filePath);
            fileName = String.Format("{0, -12}", fileName).Substring(0, 12);

            string className = stackFrame.GetMethod().ReflectedType.FullName;
            className = String.Format("{0, -14}", className).Substring(0, 14);

            string methodName = stackFrame.GetMethod().Name;
            methodName = String.Format("{0, -12}", methodName).Substring(0, 12);

            string lineNumber = stackFrame.GetFileLineNumber().ToString();
            lineNumber = String.Format("{0, -4}", lineNumber).Substring(0, 4);

            string errorMessage = time + "|E|" + fileName + "|" + className + "|" + methodName + "|" + lineNumber + " :  " + message;
            //string errorMessage = FormatMessage("E") + message;

            try
            {
                File.AppendAllText(errorLogFilePath, errorMessage);
                File.AppendAllText(errorLogFilePath, Environment.NewLine);

                File.AppendAllText(logFilePath, errorMessage);
                File.AppendAllText(logFilePath, Environment.NewLine);
            }
            catch (Exception e)
            {
                MessageBox.Show(String.Format("Error log append text failed, stack trace is {0}", e.StackTrace));
                return;
            }
        }

        public static string FormatMessage(string messageType)
        {
            // log format hhmmss| |<file_name>|<function_name>|<class_name>|<line_number>|:message

            StackFrame stackFrame = (new StackTrace(0, true)).GetFrame(1);

            string time = DateTime.Now.ToLocalTime().ToString("HHmmss");

            string filePath = stackFrame.GetFileName();

            string fileName = Path.GetFileName(filePath);
            fileName = String.Format("{0, -12}", fileName).Substring(0, 12);

            string className = stackFrame.GetMethod().ReflectedType.FullName;
            className = String.Format("{0, -14}", className).Substring(0, 14);

            string methodName = stackFrame.GetMethod().Name;
            methodName = String.Format("{0, -12}", methodName).Substring(0, 12);

            string lineNumber = stackFrame.GetFileLineNumber().ToString();
            lineNumber = String.Format("{0, -4}", lineNumber).Substring(0, 4);

            string message = time + "|" + messageType + "|" + fileName + "|" + className + "|" + methodName + "|" + lineNumber + " :  ";

            return message;
        }
    }
}
