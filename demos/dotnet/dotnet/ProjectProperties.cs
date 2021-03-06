﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

using System.Collections.Generic;
using System.IO;

namespace dotnet
{
    internal class ProjectProperties
    {
        public string AssemblyName;
        public string OutputDirectory;
        public string OutputType;
        public string Target;
        public string RuntimeIdentifier;

        public readonly List<string> Sources = new List<string>();
        public readonly List<string> References = new List<string>();
        public readonly List<string> Dependencies = new List<string>();
        public readonly List<string> CscOptions = new List<string>();
        public readonly List<string> Packages = new List<string>();

        public string OutputAssemblyPath => Path.Combine(OutputDirectory, AssemblyNameAndExtension);

        public string AssemblyNameAndExtension => AssemblyName + OutputType;

        internal string ProjectDirectory;
        internal string PackagesDirectory;
        internal string ToolsDirectory;
        internal string CscPath;
    }
}
