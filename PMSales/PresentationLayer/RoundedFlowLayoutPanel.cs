
namespace PMSales.PresentationLayer
{
    internal class RoundedFlowLayoutPanel : FlowLayoutPanel
    {
        public Color BackColor { get; set; }
        public int BorderRadius { get; set; }
        public Image BackgroundImage { get; set; }
        public ImageLayout BackgroundImageLayout { get; set; }
        public BorderStyle BorderStyle { get; set; }
        public Font Font { get; set; }
        public Color ForeColor { get; set; }
        public Point Location { get; set; }
        public string Name { get; set; }
        public Size Size { get; set; }
        public int TabIndex { get; set; }
    }
}