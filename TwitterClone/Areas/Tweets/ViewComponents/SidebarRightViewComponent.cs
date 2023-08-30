﻿using Microsoft.AspNetCore.Mvc;

namespace TwitterClone.Areas.Tweets.ViewComponents
{
    public class SidebarRightViewComponent : ViewComponent
    {

      public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(); // le view se trouve la : Views/Shared/Components/SidebarRight/Default.cshtml
        }
    }
}