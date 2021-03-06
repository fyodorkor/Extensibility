﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using System;
    using System.Collections.Generic;
    using WixToolset.Data.Bind;
    using WixToolset.Extensibility.Services;

    public interface ILayoutContext
    {
        IServiceProvider ServiceProvider { get; }

        IMessaging Messaging { get; set; }

        IEnumerable<ILayoutExtension> Extensions { get; set; }

        IEnumerable<string> ContentFilePaths { get; set; }

        IEnumerable<FileTransfer> FileTransfers { get; set; }

        string OutputPdbPath { get; set; }

        string ContentsFile { get; set; }

        string OutputsFile { get; set; }

        string BuiltOutputsFile { get; set; }

        bool SuppressAclReset { get; set; }
    }
}
