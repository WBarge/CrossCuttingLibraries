// ***********************************************************************
// Author           : Bill Barge
// Created          : 07-09-2024
//
// Last Modified By : Bill Barge
// Last Modified On : 07-09-2024
// ***********************************************************************
// <copyright file="ByteExtensions.cs" company="N/A">
//     Copyright (c) N/A. All rights reserved.
// </copyright>
// <summary></summary>
// ***********************************************************************
using System.Text;

namespace CrossCutting.Extensions
{
    /// <summary>
    /// Class ByteExtensions.
    /// </summary>
    public static class ByteExtensions
    {
        /// <summary>
        /// converts the byte array to a string
        /// </summary>
        /// <param name="bytes">The bytes.</param>
        /// <returns>System.String.</returns>
        public static string FromArrayToString(this byte[] bytes)
        {
            string returnValue = string.Empty;
            if (bytes.IsNotEmpty())
            {
                returnValue = Encoding.Unicode.GetString(bytes);
            }
            return returnValue;
        }
    }
}
