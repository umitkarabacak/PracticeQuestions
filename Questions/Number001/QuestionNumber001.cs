using System;
using System.Web.Mvc;
using System.Collections.Generic;
using System.ComponentModel;
using System.Dynamic;

namespace Questions.Number001
{
    public enum EnumDeviceType
    {
        [Description("IOS")] IOS = 1,
        [Description("Android")] Android = 2,
        [Description("Web")] Web = 3,
    }

    public class UserRegisterDetail
    {
        public EnumDeviceType EnumDeviceType { get; set; }
        public DateTime? RegisteredDate { get; set; }
    }

    public static class StaticData
    {
        public static List<UserRegisterDetail> SampleData()
        {
            var sampleData = new List<UserRegisterDetail>()
            {
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,28), EnumDeviceType = EnumDeviceType.Web },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,30), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,29), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,29), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,30), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,29), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,28), EnumDeviceType = EnumDeviceType.Android},
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,29), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,28), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,29), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,30), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,30), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,31), EnumDeviceType = EnumDeviceType.Android },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,30), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,31), EnumDeviceType = EnumDeviceType.Web },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,31), EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = null, EnumDeviceType = EnumDeviceType.IOS },
                new UserRegisterDetail { RegisteredDate = new DateTime(2020,7,27), EnumDeviceType = EnumDeviceType.IOS }
            };

            return sampleData;
        }
    }

    public class RequestUserRegisterReport
    {
        public DateTime? ReportStartDate { get; set; }
        public DateTime? ReportEndDate { get; set; }
    }

    public class ResponseReportSummary
    {
        public string Name { get; set; }
        public int Value { get; set; }
    }

    public class ResponseUserReportRegister
    {
        public string Name { get; set; }
        public List<ResponseReportSummary> Series { get; set; }
    }

    public class ResponseRegisterReport
    {
        public List<ResponseUserReportRegister> Series { get; set; }
    }

    public class ResponseController : Controller
    {
        public ResponseRegisterReport GetUserReport()
        {
            return null;
        }
    }
}