using Microsoft.AspNetCore.Mvc;

namespace MvcMovie.Controllers.Component;
public class NavbarViewComponent : ViewComponent
{
    public Task<IViewComponentResult> InvokeAsync(){
        return Task.FromResult((IViewComponentResult)View("Default"));
    }
}