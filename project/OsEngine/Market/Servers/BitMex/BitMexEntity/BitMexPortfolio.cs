﻿/*
 *Your rights to use the code are governed by this license https://github.com/AlexWan/OsEngine/blob/master/LICENSE
 *Ваши права на использование кода регулируются данной лицензией http://o-s-a.net/doc/license_simple_engine.pdf
*/

using System.Collections.Generic;

namespace OsEngine.Market.Servers.BitMex.BitMexEntity
{
    public class Types
    {
        public string account { get; set; }

        public string unrealisedProfit { get; set; }

        public string walletBalance { get; set; }
        public string marginBalance { get; set; }

        public string availableMargin { get; set; }

    }

    public class ForeignKeys
    {
    }

    public class Attributes
    {
        public string account { get; set; }
        public string currency { get; set; }
    }

    public class Datum
    {
        public string account { get; set; }
        public string currency { get; set; }
        public string unrealisedPnl { get; set; }
        public string marginBalance { get; set; }
        public string grossOpenCost { get; set; }
        public string riskValue { get; set; }
        public string initMargin { get; set; }
        public string targetExcessMargin { get; set; }
        public string walletBalance { get; set; }
        public string marginUsedPcnt { get; set; }
        public string excessMargin { get; set; }
        public string availableMargin { get; set; }
        public string withdrawableMargin { get; set; }
        public string timestamp { get; set; }
        

    }

    public class Filter
    {
        public string account { get; set; }
    }

    public class BitMexPortfolio
    {
        public string table { get; set; }
        public List<string> keys { get; set; }
        public Types types { get; set; }
        public ForeignKeys foreignKeys { get; set; }
        public Attributes attributes { get; set; }
        public string action { get; set; }
        public List<Datum> data { get; set; }
        public Filter filter { get; set; }

    }
}
