namespace PortableRest
{
    public class FileParameter
    {
        public FileParameter(string name, byte[] bytes, string fileName)
        {
            FileName = fileName;
            Data = bytes;
            Name = name;
        }

        public string FileName { get; set; }

        public byte[] Data { get; set; }

        public string Name { get; set; }
    }
}
