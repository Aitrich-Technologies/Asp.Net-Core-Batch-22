namespace IntrfcFileOOPs
{
    interface IReadable
    {
        public void Read();
    }
    interface IWritable
    {
        public void Write();
    }
    class Document: IReadable, IWritable
    {
        public void Read()
        {
            Console.WriteLine("Interface IReadable is reading");
        }
        public void Write()
        {
            Console.WriteLine("Interface IWritable is writing");
        }
    }
    interface IFile:IReadable,IWritable
    {
        public void save();
    }
    class FileDocument :IFile
    {
        public void Read()
        {
            Console.WriteLine("Reading from FileDocument");
        }
        public void Write()
        {
            Console.WriteLine("Writing from FileDocument");
        }
        public void save()
        {
            Console.WriteLine("Saving from FileDocument");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Document document=new Document();
            document.Read();
            document.Write();

            FileDocument filedocument=new FileDocument();
            filedocument.Read();
            filedocument.Write();
            filedocument.save();

            IReadable ireadable = filedocument;
            IWritable iwritable = filedocument;
            IFile ifile = filedocument;


            ireadable.Read();
            iwritable.Write();
            ifile.save();
        }
    }
}
