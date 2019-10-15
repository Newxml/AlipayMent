using Abp.Application.Services;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace JxStudioAPICenter.Test
{
    public interface ITestAppService : IApplicationService
    {
        Task<string> GetAppId(string code);
    }
}
