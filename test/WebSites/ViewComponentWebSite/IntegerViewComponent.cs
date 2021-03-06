// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using Microsoft.AspNet.Mvc;

namespace ViewComponentWebSite
{
    public class IntegerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return Invoke(17);
        }

        public IViewComponentResult Invoke(int valueFromView)
        {
            return View(valueFromView);
        }
    }
}