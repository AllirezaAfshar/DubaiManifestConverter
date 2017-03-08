using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Net;
using System.Text;
using System.Web.Script.Serialization;
using HttpServer;
using Utils;
using Verifier.Exceptions;
using Verifier.Shared;

namespace Verifier.Utility
{
    /// <summary>
    /// 
    /// </summary>
    /// <error code="300"> </error>
    public class ServerManager
    {
        private readonly HttpServer.HttpListener _tagListener;
        private const Int32 Backlog = 0;

        public ServerManager()
        {
            _tagListener = HttpServer.HttpListener.Create(IPAddress.Parse("127.0.0.1"), CommonUtilities.ConvetToInt(ConfigurationManager.AppSettings["Port"]));
            _tagListener.RequestReceived += OnRequestTagReceived;
            _tagListener.Start(Backlog);
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        /// <error code="30001">خطای نامشخص</error>
        public void OnRequestTagReceived(object sender, RequestEventArgs e)
        {
            IHttpClientContext context = (IHttpClientContext)sender;
            IHttpRequest request = e.Request;
            IHttpResponse response = e.Request.CreateResponse(context);
            try
            {
                if (ClarifyRequest(request))
                {
                    string body = Encoding.UTF8.GetString(request.GetBody());
                    Dictionary<string, string> parameters = ParamUtility.GetParameters(body);
                    byte[] data = Convert.FromBase64String(CommonUtilities.HexStringToString(parameters["data"], Encoding.UTF8));
                    byte[] sign = Signer.Sign(data);
                    SendResponse(Convert.ToBase64String(sign), response);
                }
            }
            catch (UserInterfaceException ex)
            {
                SendException(ex, response);
            }
            catch (Exception ex)
            {
                SendException(new UserInterfaceException(30001, "هنگام رمزنگاری داده ها خطای نامشخص رخ داده است.", ex), response);
            }
        }

        /// <summary>
        /// بررسی می کند که آیا درخواست رسیده به سرور معتبر است یا خیر
        /// </summary>
        /// <remarks> تنها درخواست هایی از سرور معتبر هستند که به صورت POST, Ajax باشند </remarks>
        /// <returns></returns>
        private Boolean ClarifyRequest(IHttpRequest request)
        {
//            if (!request.IsAjax)
//            {
//                throw new UserInterfaceException("تنها درخواست های ajax توسط سرور پاسخ داده می شوند");
//            }
            if (!request.Method.Equals("POST"))
            {
                throw new UserInterfaceException("تنها درخواست های POST توسط سرور پاسخ داده می شوند");
            }
            return true;
        }

        private void SendResponse(String res, IHttpResponse response)
        {
            try
            {
                response.AddHeader("Access-Control-Allow-Origin", "*");
                JsonResult result = new JsonResult
                {
                    isSuccess = true,
                    messages = new[] {"اطلاعات با موفقیت رمزنگاری گردید."},
                    result = res
                };
                String str = Utils.CommonUtilities.StringToHexString(new JavaScriptSerializer().Serialize(result), Encoding.UTF8);
                StreamWriter writer = new StreamWriter(response.Body);
                writer.Write(str);
                writer.Flush();
                response.Send();
            }
            catch (UserInterfaceException)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new UserInterfaceException(30000, ex.Message, ex);
            }
        }

        private void SendException(UserInterfaceException ex, IHttpResponse response)
        {
            response.AddHeader("Access-Control-Allow-Origin", "*");
            JsonResult result = new JsonResult
            {
                isSuccess = false,
                messages = new[] {ex.Message}, 
                result = ex.StackTrace,
            };
            String str = Utils.CommonUtilities.StringToHexString(new JavaScriptSerializer().Serialize(result), Encoding.UTF8);
            StreamWriter writer = new StreamWriter(response.Body);
            writer.Write(str);
            writer.Flush();
            response.Send();
        }

        public void Stop()
        {
            _tagListener.Stop();
        }

        public void Start()
        {
            _tagListener.Start(Backlog);
        }

        public void Restart()
        {
            Stop();
            Start();
        }
    }
}
