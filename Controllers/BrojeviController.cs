using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Models.Brojevi;

/// <summary>
/// Summary description for Class1
/// </summary>
public class Class1 : ControllerBase
{
	[HttpGet]
    public IAsyncResult Brojevi( int i)
    {
        var n = Brojevi();

        return n.ToString();

    }
}
