using System;
using System.Web;
using System.Web.Mvc;

namespace WebDeveloper.Helpers
{
    public static class CustomHelper
    {
        private static string result = string.Empty;
        public static IHtmlString DisplayPriceStatic(double price)
        {            
            //result = (Price == 0.0) ? " <span> Free!!!</span>" : $"<span>{Price}</span>";
            return new HtmlString(GetHtmlForPrice(price));
        }

        public static IHtmlString DisplayPriceExtension(this HtmlHelper helper, double price)
        {
            return new HtmlString(GetHtmlForPrice(price));
        }


        //Seccion Fechas
        public static IHtmlString DisplayDateOrNullStatic(DateTime? createDate)
        {
            return new HtmlString(GetHtmlForDate(createDate));
        }

        public static IHtmlString DisplayDateOrNullExtension(this HtmlHelper helper, DateTime? createDate)
        {
            return new HtmlString(GetHtmlForDate(createDate));
        }

        private static string GetHtmlForPrice(double price)
        {
            return (price == 0.0) ? " <span> Free!!!</span>" : $"<span>{price}</span>";
        }

        private static string GetHtmlForDate(DateTime? createDate)
        {
            return (createDate == null) ? "<span> Sin Fecha establecida!!!</span>" : $"<span>{createDate}</span>";
        }

    }





}
