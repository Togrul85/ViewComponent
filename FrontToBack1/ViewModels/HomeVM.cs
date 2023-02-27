using FrontToBack1.Models;

namespace FrontToBack1.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; }
        public SliderDetail SliderDetail { get; set; }

        public Product Product { get; set; }
    }
}
