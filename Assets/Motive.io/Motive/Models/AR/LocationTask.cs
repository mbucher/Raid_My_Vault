
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
using Motive.Core.Json;
using Motive.Core.Scripting;
using Motive.AR.LocationServices;
using Motive.Core.Models;
using Motive.Core.Globalization;
using Motive.UI;

public class LocationTask : CharacterTask
{
    public Location[] Locations { get; set; }

    public DoubleRange ActionRange { get; set; }

    public MediaElement Marker { get; set; }

    public bool IsHidden { get { return HasAttribute(PlayerTaskAttributes.Hidden); } }

    public LocationTask () : base("motive.ar.locationTask")
    {
    }

    public override void GetMediaItems(IList<Motive.Core.Media.MediaItem> items)
    {
        base.GetMediaItems(items);

        MediaElement.GetMediaItems(Marker, items);
    }
}
