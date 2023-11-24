using System.Drawing;

namespace _15_Paint
{
    public partial class Form1 : Form
    {
        enum ShapeTypes { Rectangle, Line, Ellipse};
        Point startPosition;
        List<MyShape> shapes = new List<MyShape>();
        public Form1()
        {
            InitializeComponent();
            colorList.Items.Add(Color.Red);
            colorList.Items.Add(Color.Blue);
            colorList.Items.Add(Color.Green);
            colorList.Items.Add(Color.Yellow);
            colorList.DropDownStyle = ComboBoxStyle.DropDownList;
            colorList.SelectedIndex = 0;

            foreach (var item in Enum.GetValues(typeof(ShapeTypes)))
            {
                typeList.Items.Add(item);
            }
            typeList.SelectedIndex = 0;
            typeList.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            this.Text = "Down";
            startPosition = e.Location;
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            Point end = e.Location;
            Graphics g = this.CreateGraphics();
            Color color = (Color)colorList.SelectedItem;
            this.Text = "Up";
            MyShape shape = null;
            var type = (ShapeTypes) typeList.SelectedItem;
            if(type == ShapeTypes.Rectangle || type == ShapeTypes.Ellipse)
            {                
                Rectangle rectangle = new Rectangle();
                rectangle.X = startPosition.X < end.X ? startPosition.X : end.X;
                rectangle.Y = startPosition.Y < end.Y ? startPosition.Y : end.Y;

                rectangle.Width = Math.Abs(e.X - startPosition.X);
                rectangle.Height = Math.Abs(e.Y - startPosition.Y);               


                if(type == ShapeTypes.Rectangle)
                {
                    shape = new MyRectangle(color, rectangle);
                }
                else
                    shape = new MyEllipse(color, rectangle);
                                           
            }
            else if(type == ShapeTypes.Line)
            {
                shape = new MyLine(color, startPosition, end);             
            }
            shape.Draw(g);
            shapes.Add(shape);



            //rectangles.Add(new MyLine());
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;

            foreach (var shape in shapes)
            {
                shape.Draw(g);
            }
            Font f = new Font("Verdana", 35, FontStyle.Bold | FontStyle.Italic);
            g.DrawString("Hello world", f, Brushes.Blue, 50, 100);
        }
    }
    abstract class MyShape
    {
        public abstract void Draw(Graphics g);  
    }
    class MyLine : MyShape
    {
        public Pen Pen { get; set; }
        public Point Start { get; set; }
        public Point End { get; set; }
        public MyLine() { }
        public MyLine(Color c, Point s, Point e) 
        {
            Pen = new Pen(c);
            Start = s;
            End = e;

        }

        public override void Draw(Graphics g)
        {
            g.DrawLine(Pen, Start, End);
        }
    }
    class MyRectangle : MyShape
    {
        public Color Color { get; set; }
        public Rectangle Rectangle { get; set; }
        public MyRectangle() { }
        public MyRectangle(Color color, Rectangle rect) 
        { 
            Color = color; 
            Rectangle = rect; 
        }
        public override void Draw(Graphics g)
        {
            g.FillRectangle(new SolidBrush(Color), Rectangle);
        }
    }
    class MyEllipse : MyRectangle
    {
        public MyEllipse() { }
        public MyEllipse(Color color, Rectangle rect) :base(color, rect) { }      
        public override void Draw(Graphics g)
        {
            g.FillEllipse(new SolidBrush(Color), Rectangle);
        }

    }
}