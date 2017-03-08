using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Media.Imaging;
using Verifier.Exceptions;
using ZXing;
using ZXing.Common;
using ZXing.Rendering;

namespace Verifier.Utility
{
    /// <summary>
    /// 
    /// </summary>
    /// <error code="203"></error>
    public class BarcodeHelper
    {
        /// <summary>
        /// 
        /// </summary>
        /// <error code="20301"></error>
        /// <error code="20302">خطا در ذخیره فایلس</error>
        /// <returns>
        /// آدرس فایلی که ذخیره شده است را باز می گرداند
        /// </returns>
        public static String GenerateQr(String content, int height = 400, int width = 400)
        {
            try
            {
                Type renderer = typeof (BitmapRenderer);
                BarcodeWriter writer = new BarcodeWriter
                {
                    Format = BarcodeFormat.QR_CODE,
                    Options = new EncodingOptions
                    {
                        Height = height,
                        Width = width,
                    },
                    Renderer = (IBarcodeRenderer<Bitmap>) Activator.CreateInstance(renderer)
                };
                Bitmap barcode = writer.Write(content);
                String filePath = PathHelper.GetPath("Resources\\qrcode-final.png");
                try
                {
                    if (File.Exists(filePath))
                    {
                        File.Delete(filePath);
                    }
                }
                catch (IOException)
                {
                    //DO Nothing   
                }

                barcode.Save(filePath, ImageFormat.Png);
                return filePath;
            }
            catch (IOException ex)
            {
                throw new UserInterfaceException(20302, "امکان بازکردن یا ذخیره فایل وجود ندارد، در صورتی که فایل را در نرم افزار دیگری باز کرده اید آن نرم افزار را بسته و دوباره امتحان کنید، در صورتی که این خطا باز هم وجود داشت یک بار سیستم خود را ریستارت کرده و دوباره امتحان کنید.", ex);
            }
            catch (Exception ex)
            {
                throw new UserInterfaceException(20301, "هنگام ایجاد بارکد خطای نامشخص رخ داده است", ex);
            }
        }
    }
}
