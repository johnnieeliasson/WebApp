
using WebApp.Models.ViewModels;

namespace WebApp.Helpers.Services;

public class ShowcaseService
{ 
    private readonly List<ShowcaseViewModel> _showcases = new()
    {
        new ShowcaseViewModel()
        {
            Ingress = "WELCOME TO BMERKETO SHOP",
            Title = "Exclusive Chair gold Collection.",
            ImageUrl = "images/placeholders/625x647.svg",
            Button = new LinkButtonViewModel
            {
                Content = "SHOP NOW",
                LinkUrl = "/products",
            }
        },
        new ShowcaseViewModel()
        {
            Ingress = "BMERKETO THE BEST A PERSON CAN GET",
            Title = "Now with all new spices",
            ImageUrl = "images/placeholders/625x647.svg",
            Button = new LinkButtonViewModel
            {
                Content = "SHOP NOW",
                LinkUrl = "/products",
            }
        }
    };


    public ShowcaseViewModel GetLatest()
    {
        return _showcases.LastOrDefault()!;
    }

}
