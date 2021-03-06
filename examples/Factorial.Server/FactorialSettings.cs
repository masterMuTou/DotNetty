﻿// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace Factorial.Server
{
    using System.Configuration;

    public static class FactorialSettings
    {
        public static bool IsSsl
        {
            get
            {
                string ssl = System.Configuration.ConfigurationManager.AppSettings["ssl"];
                return !string.IsNullOrEmpty(ssl) && bool.Parse(ssl);
            }
        }

        public static int Port => int.Parse(ConfigurationManager.AppSettings["port"]);
    }
}