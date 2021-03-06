﻿// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using WixToolset.Data;
    using WixToolset.Data.Bind;

    public interface IBackend
    {
        BindResult Bind(IBindContext context);

        Intermediate Unbind(IUnbindContext context);

        bool Inscribe(IInscribeContext context);
    }
}
