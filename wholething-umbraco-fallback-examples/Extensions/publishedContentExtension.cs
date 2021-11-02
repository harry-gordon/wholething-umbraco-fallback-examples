
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Umbraco.Cms.Core.Models.PublishedContent;
using Umbraco.Extensions;

namespace wholething_umbraco_fallback_examples.Extensions
{
    public static class publishedContentExtension
    {
        public static string GetMetaThumbnail(this IPublishedContent mediaItem)
        {
            if (mediaItem != null && mediaItem.HasProperty("altText") && mediaItem.HasValue("altText"))
            {
                return mediaItem.Value<string>("altText");
            }

            return "";
        }
    }
}
