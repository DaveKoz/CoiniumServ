﻿/*
 *   CoiniumServ - crypto currency pool software - https://github.com/CoiniumServ/CoiniumServ
 *   Copyright (C) 2013 - 2014, Coinium Project - http://www.coinium.org
 *
 *   This program is free software: you can redistribute it and/or modify
 *   it under the terms of the GNU General Public License as published by
 *   the Free Software Foundation, either version 3 of the License, or
 *   (at your option) any later version.
 *
 *   This program is distributed in the hope that it will be useful,
 *   but WITHOUT ANY WARRANTY; without even the implied warranty of
 *   MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 *   GNU General Public License for more details.
 *
 *   You should have received a copy of the GNU General Public License
 *   along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System.Collections.Generic;
using Coinium.Core.Coin.Daemon;
using Coinium.Core.Server.Config;
using Coinium.Core.Server.Stratum.Config;
using Coinium.Core.Server.Vanilla.Config;

namespace Coinium.Core.Mining.Pool.Config
{
    public interface IPoolConfig
    {
        /// <summary>
        /// Is the configuration enabled?
        /// </summary>
        bool Enabled { get; }

        IStratumServerConfig StratumConfig { get; }

        IVanillaServerConfig VanillaConfig { get; }

        IList<IServerConfig> ServerConfigs { get; }

        IDaemonConfig DaemonConfig { get; }

        /// <summary>
        /// Gets the name of the algorithm.
        /// </summary>
        /// <value>
        /// The name of the algorithm.
        /// </value>
        string AlgorithmName { get; }
    }
}
