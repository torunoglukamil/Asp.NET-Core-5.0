using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace my_project.Extentions
{
    static public class Extentions
    {
        public static IHtmlContent CustomTextBox(this IHtmlHelper htmlHelper, string name, string value, string placeholder = null)
        => htmlHelper.TextBox(name, value, new 
        {
            style = "background-color:grey; color:white; font-size:11px;",
            @class = "form-input",
            a = "a",
            b = "b",
            placeholder = placeholder,
        });
    }
}
