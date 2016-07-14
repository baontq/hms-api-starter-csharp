using System;
using System.Collections.Generic;
using com.healthmarketscience.api.samples.dotnet.domain;
using System.Diagnostics;

namespace com.healthmarketscience.api.samples.dotnet
{
    public class SearchTest
    {
        static public void Main(String[] args)
        {
            Core.SetConfiguration(TestConstants.TEST_API_CONFIGURATION);
            //Core.EnableSecurityProtocol();
            SearchResponse matches = Search.findAll(TestConstants.GetSearchParameters(), TestConstants.DEFAULT_SECRET);
            matches.Practitioners.ForEach(p => p.DebugPrint());
            
            
        }
    }
}
