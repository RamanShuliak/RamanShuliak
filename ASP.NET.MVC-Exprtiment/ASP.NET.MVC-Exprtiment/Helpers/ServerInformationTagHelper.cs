using Microsoft.AspNetCore.Razor.TagHelpers;

namespace ASP.NET.MVC_Exprtiment.Helpers
{
    public class ServerInformationTagHelper: TagHelper
    {
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "div";

            var processorId = Thread.GetCurrentProcessorId();

            output.Content.SetContent($"Process ID of App is: {processorId}");
        }
    }
}
