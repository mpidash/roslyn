﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using Microsoft.CodeAnalysis.LanguageServer;

namespace Microsoft.CodeAnalysis.ExternalAccess.Razor;

internal static class RazorUri
{
    public static Uri CreateAbsoluteUri(string absolutePath)
        => ProtocolConversions.CreateAbsoluteUri(absolutePath);

    public static string GetDocumentFilePathFromUri(Uri uri)
        => ProtocolConversions.GetDocumentFilePathFromUri(uri);
}
