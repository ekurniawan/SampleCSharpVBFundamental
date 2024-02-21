namespace SampleCSharp
{
    public class Window
    {
        private int top;
        public int Top
        {
            get { return top; }
            set { top = value; }
        }

        private int left;
        public int Left
        {
            get { return left; }
            set { left = value; }
        }

        public Window()
        {
            top = 0;
            left = 0;
        }

        //objek konstruktor
        public Window(int top, int left)
        {
            this.top = top;
            this.left = left;
        }

        public virtual void DrawWindow()
        {
            Console.WriteLine("Draw window pada ({0},{1})",
            top, left);
        }
    }

    public class ListBox : Window
    {
        private string listBoxContent;
        public string ListBoxContent
        {
            get { return listBoxContent; }
            set { listBoxContent = value; }
        }

        public ListBox(int top, int left, string contents) : base(top, left)
        {
            this.listBoxContent = contents;
        }

        public override void DrawWindow()
        {
            //base.DrawWindow();
            Console.WriteLine("Draw List box content: {0} {1} {2}", Top, Left, ListBoxContent);
        }
    }
}
