using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TwinCAT.Ads;

namespace TargetBrowser
{
    class AdsHelper
    {
        TcAdsClient adsClient;
        TcAdsSymbolInfoLoader symbolLoader;
        ITcAdsSymbol currentSymbol = null;
        AdsStream _adsStream = null;
        AdsBinaryReader _binRead = null;
        int _notificationHandle = 0;
    }
}
