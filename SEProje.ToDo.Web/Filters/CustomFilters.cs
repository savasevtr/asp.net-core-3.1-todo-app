using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using SEProje.ToDo.Web.Models;
using System.Linq;

namespace SEProje.ToDo.Web.Filters
{
    public class CustomFilters : ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            var dictionaryGelen = context.ActionArguments.Where(I => I.Key == "model").FirstOrDefault();
            var model = (KullaniciKayitViewModel)dictionaryGelen.Value;

            if (model.Ad.ToLower() == "yavuz")
            {
                context.Result = new RedirectResult(@"\Home\Error");
            }

            base.OnActionExecuting(context);
        }
    }
}
