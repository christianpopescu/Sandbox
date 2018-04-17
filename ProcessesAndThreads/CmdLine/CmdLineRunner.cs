using System.Diagnostics;
using System.IO;

namespace ProcessesAndThreads.CmdLine
{
    /// <summary>
    /// Windows CMD Line wrapper
    /// </summary>
    public class CmdLineRunner : IRunCmdUtil
    {
        private Process _runningCmdProcess;

    public void RunSyncUtil(string toolPath, string toolArguments, string pWorkingDirectory = "")
    {

            if (_runningCmdProcess == null)
                _runningCmdProcess = new Process();

            _runningCmdProcess.StartInfo.FileName = toolPath;
            _runningCmdProcess.StartInfo.Arguments = toolArguments;
            _runningCmdProcess.StartInfo.UseShellExecute = true;
            _runningCmdProcess.StartInfo.WorkingDirectory = pWorkingDirectory;

            _runningCmdProcess.Start();
            _runningCmdProcess.WaitForExit();

        }

        public string RunSyncUtilGetOutput(string toolPath, string toolArguments, string pWorkingDirectory = "")
        {
            if (_runningCmdProcess == null)
                _runningCmdProcess = new Process();

            _runningCmdProcess.StartInfo.FileName = toolPath;
            _runningCmdProcess.StartInfo.Arguments = toolArguments;
            _runningCmdProcess.StartInfo.UseShellExecute = false;
            _runningCmdProcess.StartInfo.RedirectStandardOutput = true;
            _runningCmdProcess.StartInfo.WorkingDirectory = pWorkingDirectory;

            _runningCmdProcess.Start();
            // Synchronously read the standard output of the spawned process. 
            StreamReader reader = _runningCmdProcess.StandardOutput;
            string output = reader.ReadToEnd();

            _runningCmdProcess.WaitForExit();
            _runningCmdProcess.Close();
            return output;
        }
    }
}