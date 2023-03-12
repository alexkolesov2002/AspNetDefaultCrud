using Crud.Core.Providers;

namespace Crud.Core.Web
{
    /// <summary>
    /// This class is used to find root path of the web project in;
    /// unit tests (to find views) and entity framework core command line commands (to find conn string).
    /// </summary>
    public static class WebContentDirectoryFinder
    {
        public static string CalculateContentRootFolder()
        {
            var coreAssemblyDirectoryPath = Path.GetDirectoryName(typeof(Provider).Assembly.Location);
            if (coreAssemblyDirectoryPath == null)
            {
                throw new Exception("Could not find location!");
            }

            var directoryInfo = new DirectoryInfo(coreAssemblyDirectoryPath);
            while (!DirectoryContains(directoryInfo.FullName, "CRUD.sln"))
            {
                directoryInfo = directoryInfo.Parent ?? throw new Exception("Could not find content root folder!");
            }
            

            var webHostFolder = directoryInfo.FullName + $"{Path.DirectorySeparatorChar}Crud.Host";
            if (Directory.Exists(webHostFolder))
            {
                return webHostFolder;
            }

            throw new Exception("Could not find root folder of the web project!" + webHostFolder + "\n" + coreAssemblyDirectoryPath +  "\n" + directoryInfo);
        }

        private static bool DirectoryContains(string directory, string fileName)
        {
            return Directory.GetFiles(directory).Any(filePath => string.Equals(Path.GetFileName(filePath), fileName));
        }
    }
}
