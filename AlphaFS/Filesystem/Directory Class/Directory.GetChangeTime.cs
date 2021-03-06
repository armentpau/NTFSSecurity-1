/*  Copyright (C) 2008-2016 Peter Palotas, Jeffrey Jangli, Alexandr Normuradov
 *  
 *  Permission is hereby granted, free of charge, to any person obtaining a copy 
 *  of this software and associated documentation files (the "Software"), to deal 
 *  in the Software without restriction, including without limitation the rights 
 *  to use, copy, modify, merge, publish, distribute, sublicense, and/or sell 
 *  copies of the Software, and to permit persons to whom the Software is 
 *  furnished to do so, subject to the following conditions:
 *  
 *  The above copyright notice and this permission notice shall be included in 
 *  all copies or substantial portions of the Software.
 *  
 *  THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR 
 *  IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY, 
 *  FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE 
 *  AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER 
 *  LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM, 
 *  OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN 
 *  THE SOFTWARE. 
 */

using Microsoft.Win32.SafeHandles;
using System;
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   partial class Directory
   {
      /// <summary>[AlphaFS] Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(string path)
      {
         return File.GetChangeTimeCore(true, null, null, path, false, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeCore(true, null, null, path, false, pathFormat);
      }


      
      /// <summary>[AlphaFS] Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(string path)
      {
         return File.GetChangeTimeCore(true, null, null, path, true, PathFormat.RelativePath);
      }
      
      /// <summary>[AlphaFS] Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeCore(true, null, null, path, true, pathFormat);
      }



      /// <summary>[AlphaFS] Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="safeHandle">An open handle to the directory from which to retrieve information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTime(SafeFileHandle safeHandle)
      {
         return File.GetChangeTimeCore(true, null, safeHandle, null, false, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="safeHandle">An open handle to the directory from which to retrieve information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtc(SafeFileHandle safeHandle)
      {
         return File.GetChangeTimeCore(true, null, safeHandle, null, true, PathFormat.RelativePath);
      }
      
      #region Transactional

      /// <summary>[AlphaFS] Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path)
      {
         return File.GetChangeTimeCore(true, transaction, null, path, false, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Gets the change date and time of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in local time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to obtain creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeCore(true, transaction, null, path, false, pathFormat);
      }



      /// <summary>[AlphaFS] Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path)
      {
         return File.GetChangeTimeCore(true, transaction, null, path, true, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Gets the change date and time, in Coordinated Universal Time (UTC) format, of the specified directory.</summary>
      /// <returns>A <see cref="System.DateTime"/> structure set to the change date and time for the specified directory. This value is expressed in UTC time.</returns>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The file for which to obtain change date and time information, in Coordinated Universal Time (UTC) format.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static DateTime GetChangeTimeUtcTransacted(KernelTransaction transaction, string path, PathFormat pathFormat)
      {
         return File.GetChangeTimeCore(true, transaction, null, path, true, pathFormat);
      }

      #endregion // Transactional
   }
}
