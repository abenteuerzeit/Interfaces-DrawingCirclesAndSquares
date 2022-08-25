using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace Drawing
{
    internal class Circle : DrawingShape, IDraw, IColor
    {

        public Circle(int diameter) : base(diameter)
        { }

        public override void Draw(Canvas canvas)
        {
            if (this.shape is not null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Ellipse();
            }
            base.Draw(canvas);
        }
    }
}
