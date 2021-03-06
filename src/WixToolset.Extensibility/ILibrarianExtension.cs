// Copyright (c) .NET Foundation and contributors. All rights reserved. Licensed under the Microsoft Reciprocal License. See LICENSE.TXT file in the project root for full license information.

namespace WixToolset.Extensibility
{
    using WixToolset.Data;

    public interface ILibrarianExtension
    {
        void PreCombine(ILibraryContext context);

        string Resolve(SourceLineNumber sourceLineNumber, IntermediateTupleDefinition tupleDefinition, string path);

        void PostCombine(Intermediate library);
    }
}
