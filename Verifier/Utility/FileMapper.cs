using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows;
using Verifier.Exceptions;

namespace Verifier.Utility
{
    public class FileMapper
    {
        /// <summary>
        /// نام کانتینر مربوط به کلید را باز می گرداند
        /// </summary>
        /// <returns></returns>
        public string GetContainerName()
        {
            string contaierName = ((App)Application.Current).ContainerName;
            if (String.IsNullOrWhiteSpace(contaierName))
            {
                throw new UserInterfaceException("نام کاربری در سیستم یافت نشد.");
            }
            return contaierName.Trim();
        } 

        public byte[] GetCheckFile()
        {
            string contaierName = GetContainerName();
            string direcroty = PathHelper.GetPath("Resources");
            string checkfileName = Directory.GetFiles(direcroty, String.Format("chk_{0}_*.zip", contaierName))
                .OrderByDescending(f => new FileInfo(f).CreationTime).FirstOrDefault();
            return File.ReadAllBytes(checkfileName);
        }

        public string GetPublicKeyContent()
        {
            string contaierName = GetContainerName();
            string direcroty = PathHelper.GetPath("Resources");
            string publicKeyFileName = Directory.GetFiles(direcroty, String.Format("puk_{0}_*.xml", contaierName))
                .OrderByDescending(f => new FileInfo(f).CreationTime).FirstOrDefault();
            return File.ReadAllText(publicKeyFileName);
        }

        /// <summary>
        /// فایل حاوی کلید عمومی را در دیسک ذخیره می نماید
        /// </summary>
        public void SavePublicKeyToPath(string fileName)
        {
            try
            {
                string path = Path.GetDirectoryName(fileName);
                if (path != null)
                {
                    if (!Directory.Exists(path))
                    {
                        Directory.CreateDirectory(path);
                    }
                }
                File.WriteAllText(fileName, new FileMapper().GetPublicKeyContent());
            }
            catch (Exception)
            {
                throw new UserInterfaceException("امکان ذخیره فایل کلید عمومی وجود ندارد، لطفا با بخش پشتیبانی تماس بگیرید.");
            }
        }
    }
}
