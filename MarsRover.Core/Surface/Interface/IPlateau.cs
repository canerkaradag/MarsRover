namespace MarsRover.Core.Surface.Interface
{
    public interface IPlateau
    {
        Size Size { get; set; }
        void SizeDefine(int width, int height);
    }
}
