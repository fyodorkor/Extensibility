﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using System;
    using System.Collections.Generic;
    using System.Xml.Linq;
    using WixToolset.Data;
    using WixToolset.Extensibility.Services;

    public interface ICompileContext
    {
        IServiceProvider ServiceProvider { get; }

        IMessaging Messaging { get; set; }

        string CompilationId { get; set; }

        IEnumerable<ICompilerExtension> Extensions { get; set; }

        string OutputPath { get; set; }

        /// <summary>
        /// Gets or sets the platform which the compiler will use when defaulting 64-bit attributes and elements.
        /// </summary>
        /// <value>The platform which the compiler will use when defaulting 64-bit attributes and elements.</value>
        Platform Platform { get; set; }

        XDocument Source { get; set; }
    }
}
