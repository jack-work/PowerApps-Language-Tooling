﻿// Copyright (c) Microsoft Corporation.
// Licensed under the MIT License.

using System.Collections.Generic;
using Microsoft.PowerPlatform.Formulas.Tools;
using Microsoft.PowerPlatform.Formulas.Tools.PAConvert;

namespace Backdoor.Repl.Functions
{
    public class Pack : SaveToFileFunction
    {
        public override string Name => "pack";
        public override IEnumerable<IError> SaveToFile(ICanvasDocument document, string fullPathToMsApp) => document.SaveToFile(fullPathToMsApp);
    }
}
