namespace SampleCSharp
{
    public interface IStorable
    {
        void Read();
        void Write();
        int Status { get; set; }
    }
}
