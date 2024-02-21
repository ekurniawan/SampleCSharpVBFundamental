namespace SampleCSharp
{
    public abstract class Control
    {
        private int top;
        private int left;

        protected int Top
        {
            get { return this.top; }
            set { this.top = value; }
        }
        protected int Left
        {
            get { return this.left; }
            set { this.left = value; }
        }

        public Control(int top, int left)
        {
            Top = top;
            Left = left;
        }

        //abstract method harus diimplementasikan
        public abstract void DrawWindow();
    }


    public abstract class Window : Control
    {
        public int Right { get; set; }
        public int Bottom { get; set; }

        public Window(int top, int left, int right, int bottom) : base(top, left)
        {
            Right = right;
            Bottom = bottom;
        }

        public abstract void DrawControl();
    }


    public class ListBox : Control, IStorable, ICompressable
    {
        private string listBoxContent;
        public string ListBoxContent
        {
            get { return listBoxContent; }
            set { listBoxContent = value; }
        }

        private int status;
        public int Status
        {
            get { return status; }
            set
            {
                status = value;
            }
        }


        public ListBox(int top, int left, string listBoxContent) : base(top, left)
        {
            this.listBoxContent = listBoxContent;
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Position :({0},{1})", Top, Left);
            Console.WriteLine("Menuliskan string pada listbox: {0}",
            listBoxContent);
        }

        public void Read()
        {
            Console.WriteLine("Reading ListBox...");
        }

        public void Write()
        {
            Console.WriteLine("Writing ListBox...");
        }

        public void Compress()
        {
            throw new NotImplementedException();
        }

        public void Decompress()
        {
            throw new NotImplementedException();
        }
    }

    public class Button : Control
    {
        private string fontColor;
        public Button(int top, int left) : base(top, left)
        {
        }

        public string FontColor
        {
            get { return fontColor; }
            set { fontColor = value; }
        }

        public override void DrawWindow()
        {
            Console.WriteLine("Position :({0},{1})", Top, Left);
            Console.WriteLine("Mewarnai tombol dengan warna: {0}", fontColor);
        }
    }

    public class GridData : Window
    {
        public GridData(int top, int left, int right, int bottom) : base(top, left, right, bottom)
        {

        }

        public override void DrawControl()
        {
            throw new NotImplementedException();
        }

        public override void DrawWindow()
        {
            throw new NotImplementedException();
        }

        public void DrawWindow(string hello)
        {
            Console.WriteLine($"{hello}");
        }
    }
}
