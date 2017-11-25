using PowerView.Web.UI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PowerView.Web.UI.Domain
{
    /// <summary>
    /// Class containing the Navigation bar action items.-
    /// </summary>
    public class Menu
    {
        /// <summary>
        /// Get Nav bar items.-
        /// </summary>
        /// <returns></returns>
        public IEnumerable<Navbar> NavbarItems()
        {
            List<Navbar> menu = new List<Navbar>();

            menu.Add(new Navbar { Id = 1, Name = "Dashboard", Controller = "Home", Action = "Index", ImageClass = "fa fa-dashboard fa-fw", Hidden = false, IsParent = false });
            menu.Add(new Navbar { Id = 2, Name = "Charts", ImageClass = "fa fa-bar-chart-o fa-fw", Hidden = false, IsParent = true });
            menu.Add(new Navbar { Id = 3, Name = "Flot Charts", Controller = "Home", Action = "FlotCharts", Hidden = false, IsParent = false, ParentId = 2 });
            menu.Add(new Navbar { Id = 4, Name = "Morris.js Charts", Controller = "Home", Action = "MorrisCharts", Hidden = false, IsParent = false, ParentId = 2 });
            menu.Add(new Navbar { Id = 5, Name = "Tables", Controller = "Home", Action = "Tables", ImageClass = "fa fa-table fa-fw", Hidden = false, IsParent = false });
            menu.Add(new Navbar { Id = 6, Name = "Forms", Controller = "Home", Action = "Forms", ImageClass = "fa fa-edit fa-fw", Hidden = false, IsParent = false });
            menu.Add(new Navbar { Id = 7, Name = "UI Elements", ImageClass = "fa fa-wrench fa-fw", Hidden = false, IsParent = true });
            menu.Add(new Navbar { Id = 8, Name = "Panels and Wells", Controller = "Home", Action = "Panels", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 9, Name = "Buttons", Controller = "Home", Action = "Buttons", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 10, Name = "Notifications", Controller = "Home", Action = "Notifications", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 11, Name = "Typography", Controller = "Home", Action = "Typography", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 12, Name = "Icons", Controller = "Home", Action = "Icons", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 13, Name = "Grid", Controller = "Home", Action = "Grid", Hidden = false, IsParent = false, ParentId = 7 });
            menu.Add(new Navbar { Id = 14, Name = "Multi-Level Dropdown", ImageClass = "fa fa-sitemap fa-fw", Hidden = false, IsParent = true });
            menu.Add(new Navbar { Id = 15, Name = "Second Level Item", Hidden = false, IsParent = false, ParentId = 14 });
            menu.Add(new Navbar { Id = 16, Name = "Sample Pages", ImageClass = "fa fa-files-o fa-fw", Hidden = false, IsParent = true });
            menu.Add(new Navbar { Id = 17, Name = "Blank Page", Controller = "Home", Action = "Blank", Hidden = false, IsParent = false, ParentId = 16 });
            menu.Add(new Navbar { Id = 18, Name = "Login Page", Controller = "Home", Action = "Login", Hidden = false, IsParent = false, ParentId = 16 });

            return menu;
        }
    }
}