﻿// Copyright (c) Andrew Arnott. All rights reserved.
// Licensed under the Microsoft Public License (Ms-PL) license. See LICENSE file in the project root for full license information.

namespace PCLCrypto
{
    /// <summary>
    /// A PCL-compatible enumeration describing symmetric cipher modes.
    /// </summary>
    public enum SymmetricAlgorithmMode
    {
        /// <summary>
        /// The algorithm is a streaming cipher rather than a block cipher.
        /// </summary>
        Streaming,

        /// <summary>
        /// The CBC mode.
        /// </summary>
        Cbc,

        /// <summary>
        /// The ECB mode.
        /// </summary>
        Ecb,

        /// <summary>
        /// The CCM mode.
        /// </summary>
        Ccm,

        /// <summary>
        /// The GCM mode.
        /// </summary>
        Gcm,
    }
}
