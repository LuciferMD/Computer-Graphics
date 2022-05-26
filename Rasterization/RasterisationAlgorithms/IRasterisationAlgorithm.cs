using ComputerGraphics.Core.Algorithms.Rasterization.Primitives;
using System.Drawing;

namespace ComputerGraphics.Core.Algorithms.Rasterization.RasterisationAlgorithms
{
    public interface IRasterisationAlgorithm
    {
        void DrawLine(Bitmap bitmap, CustomLine line, Color color);
    }
}