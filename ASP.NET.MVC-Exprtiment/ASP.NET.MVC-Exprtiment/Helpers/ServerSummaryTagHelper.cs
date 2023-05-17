using ASP.NET.MVC_Exprtiment.Core.Abstractions;
using Microsoft.AspNetCore.Razor.TagHelpers;
using System.Text;

namespace ASP.NET.MVC_Exprtiment.Helpers
{
    public class ServerSummaryTagHelper : TagHelper
    {
        public bool Visible { get; set; }
        public StyleInformation Style { get; set; }

        private readonly IBandService _bandService;
        public ServerSummaryTagHelper(IBandService bandService)
        {
            _bandService = bandService;
        }

        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            output.TagMode = TagMode.StartTagAndEndTag;
            output.TagName = "div";

            var serverData = await output.GetChildContentAsync();

            var sb = new StringBuilder($"<h4> Server information:</h4>");
            sb.Append(serverData.GetContent());

            var style = "";

            if(Visible)
            {
                var bandName = (await _bandService.GetBandsByPageNumberAndPageSizeAsync(0, 5))
               .FirstOrDefault()?.Name;

                sb.Append($"<h6>Band name: {bandName}</h6>");
            }

            if(Style != null)
            {
                if(Style.Color != null)
                {
                    style = $"color: {Style.Color}";
                }
                if (Style.BackgroundColor != null)
                {
                    style = $"background-color: {Style.BackgroundColor}";
                }
            }

            output.Attributes.Add("style", style);

            output.Content.SetHtmlContent(sb.ToString());
        }
    }

    public class StyleInformation
    {
        public string? Color { get; set; }
        public string? BackgroundColor { get; set; }
    }
}
