namespace BlazorDraw;

internal class LineData
{
    public double x1 { get; set; }
    public double y1 { get; set; }
    public double x2 { get; set; }
    public double y2 { get; set; }

    public bool IsDragging { get; set; } = false;
}