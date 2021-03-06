﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using System;
    using System.Collections.Generic;
    using WixToolset.Data;
    using WixToolset.Extensibility.Services;

    public interface IResolveContext
    {
        IServiceProvider ServiceProvider { get; }

        IMessaging Messaging { get; set; }

        IEnumerable<BindPath> BindPaths { get; set; }

        IEnumerable<IResolverExtension> Extensions { get; set; }

        IEnumerable<IExtensionData> ExtensionData { get; set; }

        IEnumerable<string> FilterCultures { get; set; }

        string IntermediateFolder { get; set; }

        Intermediate IntermediateRepresentation { get; set; }

        IEnumerable<Localization> Localizations { get; set; }

        IVariableResolver VariableResolver { get; set; }
    }
}
