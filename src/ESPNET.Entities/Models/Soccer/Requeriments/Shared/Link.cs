﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ESPNET.Models.Soccer.Requeriments.Shared;

public sealed class Link
{
    public IEnumerable<string> Rel { get; set; }
    public string Href { get; set; }
    public string Text { get; set; }
    public bool IsExternal { get; set; }
    public bool IsPremium { get; set; }
    public string Language { get; set; }
    public string ShortText { get; set; }
}