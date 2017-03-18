﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ContactPoint.Common.Contacts;

namespace ContactPoint.Contacts
{
    internal class VersionGeneratorFake : IVersionGenerator
    {
        public object GetDefaultVersion()
        {
            return String.Empty;
        }

        public object GenerateNextVersion(object currentKey)
        {
            return String.Empty;
        }

        public object GetKeyFromString(string value)
        {
            return String.Empty;
        }

        public string ConvertKeyToString(object value)
        {
            return String.Empty;
        }

        public VersionsCompareResult CompareVersions(IVersionable current, IVersionable target)
        {
            return VersionsCompareResult.Unknown;
        }
    }
}
