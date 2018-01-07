﻿#region LICENSE

//     This file (Enums.cs) is part of DepressurizerCore.
//     Copyright (C) 2018  Martijn Vegter
// 
//     This program is free software: you can redistribute it and/or modify
//     it under the terms of the GNU General Public License as published by
//     the Free Software Foundation, either version 3 of the License, or
//     (at your option) any later version.
// 
//     This program is distributed in the hope that it will be useful,
//     but WITHOUT ANY WARRANTY; without even the implied warranty of
//     MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
//     GNU General Public License for more details.
// 
//     You should have received a copy of the GNU General Public License
//     along with this program.  If not, see <https://www.gnu.org/licenses/>.

#endregion

using System;

namespace DepressurizerCore
{
    public enum ValueType
    {
        Array,

        String,

        Int
    }

    public enum GameListSource
    {
        XmlPreferred,

        XmlOnly,

        WebsiteOnly
    }

    public enum StoreLanguage
    {
        windows,

        bg, // Bulgarian

        cs, // Czech

        da, // Danish

        nl, // Dutch

        en, // English

        fi, // Finnish

        fr, // French

        de, // German

        el, // Greek

        hu, // Hungarian

        it, // Italian

        ja, // Japanese

        ko, // Korean

        no, // Norwegian

        pl, // Polish

        pt, // Portuguese

        pt_BR, // Portuguese (Brasil)

        ro, // Romanian

        ru, // Russian

        zh_Hans, // Simplified Chinese

        es, // Spanish

        sv, // Swedish

        th, // Thai

        zh_Hant, // Traditional Chinese

        tr, // Turkish

        uk // Ukrainian
    }

    /// <summary>
    ///     Operating System(s)
    /// </summary>
    [Flags]
    public enum AppPlatforms
    {
        /// <summary>
        ///     Default value
        /// </summary>
        None = 0,

        /// <summary>
        ///     Microsoft Windows
        /// </summary>
        Windows = 1 << 0,

        /// <summary>
        ///     macOS
        /// </summary>
        Mac = 1 << 1,

        /// <summary>
        ///     Linux
        /// </summary>
        Linux = 1 << 2,

        /// <summary>
        ///     Windows, Mac and Linux
        /// </summary>
        All = (1 << 3) - 1
    }

    /// <summary>
    ///     Steam App Type
    /// </summary>
    [Flags]
    public enum AppTypes
    {
        /// <summary>
        ///     Default value
        /// </summary>
        Unknown = 0,

        /// <summary>
        ///     Steam Game
        /// </summary>
        Game = 1 << 0,

        /// <summary>
        ///     Steam Software
        /// </summary>
        Application = 1 << 1,

        /// <summary>
        ///     Steam Demo
        /// </summary>
        Demo = 1 << 2,

        /// <summary>
        ///     Downloadable Content
        /// </summary>
        DLC = 1 << 3,

        /// <summary>
        ///     SDK's, servers etc..
        /// </summary>
        Tool = 1 << 4,

        /// <summary>
        ///     Steam Config Files
        /// </summary>
        Config = 1 << 5,

        /// <summary>
        ///     Steam Streaming Videos
        /// </summary>
        Video = 1 << 6,

        /// <summary>
        ///     Steam Series
        /// </summary>
        Series = 1 << 7,

        /// <summary>
        ///     All Steam Games and Software
        /// </summary>
        IncludeNormal = Application | Game,

        /// <summary>
        ///     All Steam Games, Software and Unknown
        /// </summary>
        IncludeUnknown = IncludeNormal | Unknown,

        /// <summary>
        ///     All Steam Apps
        /// </summary>
        IncludeAll = (1 << 8) - 1
    }

    /// <summary>
    ///     Action on startup
    /// </summary>
    public enum StartupAction
    {
        /// <summary>
        ///     Do nothing
        /// </summary>
        None = 0,

        /// <summary>
        ///     Load a profile
        /// </summary>
        Load,

        /// <summary>
        ///     Create a profile
        /// </summary>
        Create
    }

    /// <summary>
    ///     Depressurizer Interface Languages
    /// </summary>
    /// <remarks>
    ///     Format: https://msdn.microsoft.com/en-us/library/ee825488(v=cs.20).aspx
    /// </remarks>
    public enum InterfaceLanguage
    {
        Default,

        /// <summary>
        ///     English - United States
        /// </summary>
        English,

        /// <summary>
        ///     Spanish - Spain
        /// </summary>
        Spanish,

        /// <summary>
        ///     Russian - Russia
        /// </summary>
        Russian,

        /// <summary>
        ///     Ukrainian - Ukraine
        /// </summary>
        Ukranian,

        /// <summary>
        ///     Dutch - The Netherlands
        /// </summary>
        Dutch
    }
}