using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Security.Policy;

namespace ASP.NET.MVC_Exprtiment.Helpers;

public class TimeTagHelper: TagHelper
{
    public override void Process(TagHelperContext context, TagHelperOutput output)
    {
        output.TagMode = TagMode.StartTagAndEndTag;
        output.TagName = "div";
        output.Content.SetContent($"Actual server time: {DateTime.Now:R}");
    }
}
