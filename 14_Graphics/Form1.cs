using System.Drawing;

namespace _14_Graphics
{
    public partial class Form1 : Form
    {
        int redraw_count = 0;
        List<Point> points = new List<Point>(); 
        public Form1()
        {
            InitializeComponent();
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();
            PaintFigure( g);
        }
        void PaintFigure(Graphics g)
        {
            int x = 53, y = 63, height = 480, width = 1000;
            Pen pen = new Pen(Brushes.Sienna, 15);
            pen.StartCap = System.Drawing.Drawing2D.LineCap.Square;
            pen.DashCap = System.Drawing.Drawing2D.DashCap.Flat;
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            Rectangle rectangle = new Rectangle(x, y, width, height);
            Point point = new Point(130, 130);
            Size size = new Size(500, 300);
            Rectangle rectangle1 = new Rectangle(point, size);

            g.DrawEllipse(pen, rectangle);
            g.FillEllipse(Brushes.Blue, rectangle1);
            Pen linePen = new Pen(Color.Red, 20);
            linePen.StartCap = System.Drawing.Drawing2D.LineCap.SquareAnchor;
            linePen.EndCap = System.Drawing.Drawing2D.LineCap.ArrowAnchor;
            linePen.DashStyle = System.Drawing.Drawing2D.DashStyle.DashDot;
            linePen.DashCap = System.Drawing.Drawing2D.DashCap.Round;

            g.DrawLine(linePen, 20, 600, 1500, 600);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            this.Text = $"{redraw_count++}";
            //Graphics g = this.CreateGraphics();
            Graphics g = e.Graphics;
            PaintFigure(g);
            PrintPoints(g);

        }

        private void PrintPoints(Graphics g)
        {
            foreach (Point p in points)
            {
                g.FillEllipse(Brushes.Teal, p.X - 10, p.Y - 10, 20, 20);
            }

        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point point = e.Location;
            points.Add(point);
            this.CreateGraphics().FillEllipse(Brushes.Teal, point.X-10, point.Y-10, 20, 20);
        }
    }
}