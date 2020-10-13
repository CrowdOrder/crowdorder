using CrowdOrder.beta.Models;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Text;

namespace CrowdOrder.beta.Infrastructure
{
    public static class HTMLHelperExtensions
    {
        public static IHtmlContent LogoCarousel(this IHtmlHelper htmlHelper, List<Partner> partners)
        {   
            StringBuilder html = new StringBuilder();
            html.Append("<div id = \"recipeCarousel\" class=\"carousel slide w - 100\" data-ride=\"carousel\"><div class=\"carousel-inner w-100\" role=\"listbox\"  style=\"height: 100%;\"><div class=\"carousel-item row no-gutters active\">");
            int counter = 0;
            foreach(var item in partners)
            {
                if (counter > 0 && counter%4 == 0)
                {
                    html.Append("</div><div class=\"carousel-item row no-gutters\">");
                }
                html.Append($"<div class=\"col-3 float-left\"><a href=\"{item.Url}\"><img src=\"partners/{item.LogoUrl}\" class=\"img-fluid\" alt=\"{item.Name}\"></a></div>");
                counter++;
            }

            html.Append("</div><a class=\"carousel-control-prev\" href=\"#recipeCarousel\" role=\"button\" data-slide=\"prev\"><span class=\"carousel-control-prev-icon\" aria-hidden=\"true\"></span><span class=\"sr-only\">Prev</span></a>");
            html.Append("<a class=\"carousel-control-next\" href=\"#recipeCarousel\" role=\"button\" data-slide=\"next\"><span class=\"carousel-control-next-icon\" aria-hidden=\"true\"></span><span class=\"sr-only\">Next</span></a>");
            html.Append("</div>");
            return new HtmlString(html.ToString());
        }
          
    }
}
