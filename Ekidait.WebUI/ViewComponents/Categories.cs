﻿using Ekidait.Core.Entities;
using Ekidait.Service.Abstract;
using Microsoft.AspNetCore.Mvc;

namespace Ekidait.WebUI.ViewComponents
{
    public class Categories : ViewComponent
    {
        private readonly IService<Category> _service;

        public Categories(IService<Category> service)
        {
            _service = service;
        }
        public async Task<IViewComponentResult> InvokeAsync()
        {
            return View(await _service.GetAllAsync(c=> c.IsTopMenu && c.IsActive));
        }
    }
}
