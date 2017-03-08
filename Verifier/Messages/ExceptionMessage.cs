using System;

namespace Verifier.Reources
{
    public static class ExceptionMessage
    {
        // 30001
        public const String FileOpenError =
            "هنگام باز کردن فایل خطا رخ داده است، لطفا فایل مورد نظر را بررسی کرده و دوباره امتحان کنید";

        // 30002
        public const String Format = 
            "فرمت فایل ورودی صحیح نمی باشد، لطفا فایل ورودی را بررسی کرده و دوباره امتحان کنید.";

        // 30003
        public const String FileNotFound =
            "فایل {0} یافت نشد، لطفا اطلاعات وارد شده را بررسی نموده و دوباره امتحان کنید.";

        // 30004
        public const String SignUknonwProblem =
            "هنگام رمز نمودن فایل خطای نامشخص رخ داده است.";

    }
}
