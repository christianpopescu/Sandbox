namespace ProcessesAndThreads.CmdLine
{
    /// <summary>
    /// Interface for running tools on CMD
    /// Pattern : cmd <Tool/> <Arguments/>
    /// </summary>

    public interface IRunCmdUtil
    {
        /// <summary>
        /// Run synchrous tool with arguments 
        /// "ToolPath" tool's path. Ex: @"C:\Program Files (x86)\7-Zip\7z" 
        /// ToolArguments">tool's arguments
        /// </summary>

 
        // Run The command line for the given tools (ToolPath) with the given arguments (ToolArguments)
        void RunSyncUtil(string toolPath, string toolArguments, string pWorkingDirectory = "" );


        /// <summary>
        /// Run The command line for the given tools (ToolPath) with the given arguments (ToolArguments)
        /// </summary>
        /// <param name="toolPath"></param>
        /// <param name="toolArguments"></param>
        /// <param name="pWorkingDirectory"></param>
        /// <returns>Get the output streem of the tool</returns>
        string RunSyncUtilGetOutput(string toolPath, string toolArguments, string pWorkingDirectory);
    }
}