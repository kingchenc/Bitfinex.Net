﻿using System;
using CryptoExchange.Net;

namespace Bitfinex.Net
{
    public class BitfinexClientOptions : ExchangeOptions
    {
        /// <summary>
        /// Base address for the Rest client
        /// </summary>
        public string BaseAddress { get; set; } = "https://api.bitfinex.com";
    }

    public class BitfinexSocketClientOptions: ExchangeOptions
    {
        /// <summary>
        /// Base address for the socket client
        /// </summary>
        public string BaseAddress { get; set; } = "wss://api.bitfinex.com/ws/2";

        /// <summary>
        /// The receive timeout after which a lost connection is assumed
        /// </summary>
        public TimeSpan SocketReceiveTimeout { get; set; } = TimeSpan.FromSeconds(15);
    }
}
