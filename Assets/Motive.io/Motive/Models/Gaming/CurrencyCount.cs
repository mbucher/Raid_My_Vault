//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
using System;
using System.Collections.Generic;

using Motive.Core.Json;
using Motive.Core.Scripting;

public class CurrencyCount
{
    public string Currency { get; set; }
    public int Count { get; set; }

    public CurrencyCount()
    {
    }

    public CurrencyCount(string currency, int count)
    {
        Currency = currency;
        Count = count;
    }

    public override string ToString ()
    {
        return string.Format ("[CurrencyCount: Currency={0}, Count={1}]", Currency, Count);
    }    
}
