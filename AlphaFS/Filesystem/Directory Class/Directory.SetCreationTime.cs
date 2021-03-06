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

using System;
using System.Security;

namespace Alphaleonis.Win32.Filesystem
{
   partial class Directory
   {
      #region .NET

      /// <summary>Sets the date and time the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTime(string path, DateTime creationTime)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTime.ToUniversalTime(), null, null, false, PathFormat.RelativePath);
      }



      /// <summary>Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTimeUtc, null, null, false, PathFormat.RelativePath);
      }

      #endregion // .NET

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTime(string path, DateTime creationTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTime.ToUniversalTime(), null, null, false, pathFormat);
      }

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="modifyReparsePoint">If <see langword="true"/>, the date and time information will apply to the reparse point (symlink or junction) and not the file or directory linked to. No effect if <paramref name="path"/> does not refer to a reparse point.</param>
      [SecurityCritical]
      public static void SetCreationTime(string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
      }



      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTimeUtc, null, null, false, pathFormat);
      }

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="modifyReparsePoint">If <see langword="true"/>, the date and time information will apply to the reparse point (symlink or junction) and not the file or directory linked to. No effect if <paramref name="path"/> does not refer to a reparse point.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtc(string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, null, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
      }

      #region Transactional

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      [SecurityCritical]
      public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTime.ToUniversalTime(), null, null, false, PathFormat.RelativePath);
      }
      
      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTime.ToUniversalTime(), null, null, false, pathFormat);
      }

      /// <summary>[AlphaFS] Sets the date and time the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTime">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in local time.</param>
      /// <param name="modifyReparsePoint">If <see langword="true"/>, the date and time information will apply to the reparse point (symlink or junction) and not the file or directory linked to. No effect if <paramref name="path"/> does not refer to a reparse point.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeTransacted(KernelTransaction transaction, string path, DateTime creationTime, bool modifyReparsePoint, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTime.ToUniversalTime(), null, null, modifyReparsePoint, pathFormat);
      }



      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      [SecurityCritical]
      public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTimeUtc, null, null, false, PathFormat.RelativePath);
      }

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTimeUtc, null, null, false, pathFormat);
      }

      /// <summary>[AlphaFS] Sets the date and time, in coordinated universal time (UTC), that the directory was created.</summary>
      /// <param name="transaction">The transaction.</param>
      /// <param name="path">The directory for which to set the creation date and time information.</param>
      /// <param name="creationTimeUtc">A <see cref="System.DateTime"/> containing the value to set for the creation date and time of <paramref name="path"/>. This value is expressed in UTC time.</param>
      /// <param name="modifyReparsePoint">If <see langword="true"/>, the date and time information will apply to the reparse point (symlink or junction) and not the file or directory linked to. No effect if <paramref name="path"/> does not refer to a reparse point.</param>
      /// <param name="pathFormat">Indicates the format of the path parameter(s).</param>
      [SecurityCritical]
      public static void SetCreationTimeUtcTransacted(KernelTransaction transaction, string path, DateTime creationTimeUtc, bool modifyReparsePoint, PathFormat pathFormat)
      {
         File.SetFsoDateTimeCore(true, transaction, path, creationTimeUtc, null, null, modifyReparsePoint, pathFormat);
      }

      #endregion // Transactional
   }
}
