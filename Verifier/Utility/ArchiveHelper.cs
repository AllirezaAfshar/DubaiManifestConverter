using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Ionic.Zip;
using Verifier.Exceptions;
using Verifier.Reources;

namespace Verifier.Utility
{
    public static class ArchiveHelper
    {
        /// <summary>
        /// مقادیر بایتی را از یک فایل فشرده شده استخراج نموده و باز می گرداند
        /// </summary>
        /// <param name="path">آدرس فایل فشرده شده</param>
        /// <param name="entryName">نام فایل در مجموعه فشرده شده</param>
        /// <returns></returns>
        public static byte[] GetByteFromArchive(String path, String entryName)
        {
            try
            {
                using (ZipFile zip = ZipFile.Read(path))
                {
                    // here, we extract every entry, but we could extract conditionally
                    // based on entry name, size, date, checkbox status, etc.  
                    foreach (ZipEntry entry in zip)
                    {
                        if (entry.FileName.Equals(entryName))
                        {
                            Stream stream = entry.OpenReader();
                            byte[] buf = new byte[stream.Length];
                            stream.Read(buf, 0, buf.Length); // read from stream to byte array   
                            return buf;
                        }
                    }
                    throw new UserInterfaceException(30003, String.Format(ExceptionMessage.FileNotFound, entryName));
                }
            }
            catch (FormatException ex)
            {
                //Log.Error("Format Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30002, ExceptionMessage.Format, ex);
                throw exception;
            }
            catch (Exception ex)
            {
                //Log.Error("Unspecific Exception Error While Uploading File(BtnUploadFile_OnClick) in Hoopad Mode.", ex);
                UserInterfaceException exception = new UserInterfaceException(30001, ExceptionMessage.FileOpenError, ex);
                throw exception;
            }
        }

    }
}
