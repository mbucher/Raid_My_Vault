//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18052
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Linq;
using System.Collections.Generic;
using JsonFx.Json;
using Motive.Core.Json;
using Motive.Core.Scripting;
using Motive.Core.Globalization;
using Motive.Core.Models;

public class Collectible : ScriptObject, IMediaItemProvider
{
    public LocalizedMedia LocalizedImage { get; set; }
    public LocalizedText LocalizedTitle { get; set; }
    public string Title { get { return LocalizedText.GetText(LocalizedTitle); } }

    public int InventoryOrder { get; set; }
    public string InventoryPath { get; set; }

    public string ImageUrl
    {
        get
        {
            var mediaItem = LocalizedMedia.GetMediaItem(LocalizedImage);

            if (mediaItem != null && mediaItem.MediaType == Motive.Core.Media.MediaType.Image)
            {
                return mediaItem.Url;
            }

            return null;
        }
    }
    public string[] StoryTags { get; set; }
    public IContent[] Attachments { get; set; }
	public Collectible ()
    {
        InventoryOrder = 0;
    }

    public void GetMediaItems(IList<Motive.Core.Media.MediaItem> items)
    {
        if (LocalizedImage != null)
        {
            LocalizedImage.GetMediaItems(items);
        }

        if (Attachments != null)
        {
            foreach (var content in Attachments)
            {
                var mediaProvider = content as IMediaItemProvider;

                if (mediaProvider != null)
                {
                    mediaProvider.GetMediaItems(items);
                }
            }
        }
    }
}
