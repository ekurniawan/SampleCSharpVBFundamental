namespace SampleCSharp
{
    public interface IStorable
    {
        void Read();
        void Write();
        int Status { get; set; }
    }

    public interface ISaveable : IStorable
    {
        bool Save();
        bool Delete();
    }

    public interface ICompressable
    {
        void Compress();
        void Decompress();
    }

    public class Document : IStorable, ICompressable
    {
        public int Status { get; set; }

        public void Compress()
        {
            Console.WriteLine("Compressing document...");
        }

        public void Decompress()
        {
            Console.WriteLine("Decompressing document...");
        }

        public void Read()
        {
            Console.WriteLine("Reading...");
        }

        public void Write()
        {
            Console.WriteLine("Writing...");
        }
    }

    public class Image : ICompressable
    {
        public void Compress()
        {
            Console.WriteLine("Compressing Image...");
        }

        public void Decompress()
        {
            Console.WriteLine("Decompressing Image...");
        }
    }
}
