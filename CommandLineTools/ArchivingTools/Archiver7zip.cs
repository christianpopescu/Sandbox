using System;
using System.Text;
using ProcessesAndThreads.CmdLine;

namespace CommandLineTools.ArchivingTools
{
    public class Archiver7zip : ToolForArchive
    {
        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="pArchiver7Zip"></param>
        public Archiver7zip(string pArchiver7Zip, IRunCmdUtil pRunner7Zip)
        {
            ArchiverFileName = pArchiver7Zip;
            Runner7Zip = pRunner7Zip;               // Runner injection
        }

        /// <summary>
        /// Archive folder and subfolders to a given archive.
        /// 
        /// Path's archive folder
        /// </summary>
        /// <param name="pFolderPath">
        ///    Path's source Folder
        /// </param>
        /// <param name="pArchivePath">
        ///   Path's archive folder
        /// </param>
        /// 
        /// 

        public override void ArchiveFolderRecursive(string pFolderPath, string pArchivePath)
        {

            StringBuilder sb = new StringBuilder();

            sb.Append(" a -tzip ");
            sb.Append(pArchivePath);
            sb.Append(@" -r ");
            sb.Append(pFolderPath);


            Runner7Zip.RunSyncUtil(ArchiverFileName, sb.ToString());

        }

        /// <summary>
        /// Archive file 
        /// </summary>
        /// <param name="pFilePath">
        /// File to be archived
        /// </param>
        /// <param name="pArchivePath">
        /// Name of archive
        /// </param>

        public override void ArchiveFile(string pFilePath, string pArchivePath)
        {
            throw new NotImplementedException();
        }

    }
}
