using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Shapes;

namespace Drawing
{
    class Square : DrawingShape, IDraw, IColor
    {
        public Square(int sideLength) : base(sideLength)
        {
        }

        public override void Draw(Canvas canvas)
        {
            if (this.shape is not null)
            {
                canvas.Children.Remove(this.shape);
            }
            else
            {
                this.shape = new Rectangle();
            }

            base.Draw(canvas);
        }
    }
}
