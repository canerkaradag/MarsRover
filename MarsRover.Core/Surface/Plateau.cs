using MarsRover.Core.Surface.Interface;

namespace MarsRover.Core.Surface.Plateau
{
    public class Plateau : IPlateau
    {
        public Size Size { get; set; }

        public void SizeDefine(int width, int height)
        {
            Size = new Size(width, height);
        }
    }
}
