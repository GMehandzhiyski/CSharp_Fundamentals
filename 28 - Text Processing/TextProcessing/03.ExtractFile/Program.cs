namespace _03.ExtractFile
{
    /*C:\Internal\training-internal29\Template38.pptx*/
    internal class Program
    {
        static void Main(string[] args)
        {
           string inputString = Console.ReadLine();
           
           int fileExtensionPosition = inputString.LastIndexOf('.');//,inputString.Length-1
            string fileExtension = inputString.Substring(fileExtensionPosition + 1,((inputString.Length - 1) - fileExtensionPosition));

            int fileNamePosition = inputString.LastIndexOf('\\');//, inputString.Length - 1
            int stringLength = inputString.Length;
            string fileName = inputString.Substring(fileNamePosition + 1,fileExtensionPosition - fileNamePosition - 1);

            Console.WriteLine($"File name: {fileName}");
            Console.WriteLine($"File extension: {fileExtension}");
        }
    }
}