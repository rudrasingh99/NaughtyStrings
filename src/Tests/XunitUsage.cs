﻿using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using NaughtyStrings;
using Xunit;

public class XunitUsage
{
    #region xUnitUsage
    [Theory]
    [MemberData(nameof(GetData))]
    public void Run(string naughtyString)
    {
        Debug.WriteLine(naughtyString);
    }

    public static IEnumerable<object[]> GetData()
    {
        return TheNaughtyStrings.All
            .Select(naughty => new object[] {naughty});
    }
    #endregion
}