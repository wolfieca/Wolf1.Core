using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.CodeAnalysis.CSharp.Scripting;

namespace Wolf1.Core.Script
{
    /// <summary>
    /// IScript classes represent the WOlf1 scripting capabilities. In a 
    /// change from the Wizard System model, Wolf1 scripts are made up of
    /// one or more code segments. Scripts form the basis of Strategies, 
    /// Policies, Rules, and various other dynamic aspect of the system
    /// operations.
    /// </summary>
    interface IScript
    {
        String Name { get; set; }
        Dictionary<int, String> Script { get; set; }
        CSharpScript SubScript { get; }
    }
}
