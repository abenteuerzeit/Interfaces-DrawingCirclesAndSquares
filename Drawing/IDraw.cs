using Windows.UI.Xaml.Controls;

namespace Drawing
{
    interface IDraw
    {
        int X { get; set; }
        int Y { get; set; }
        void Draw(Canvas canvas);
    }
}
