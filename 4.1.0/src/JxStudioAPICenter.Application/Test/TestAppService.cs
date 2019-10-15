using Abp.Domain.Repositories;
using JxStudioAPICenter;
using JxStudioAPICenter.Test;
using Microsoft.EntityFrameworkCore;
using System;
using System.Linq;
using System.Threading.Tasks;
using JxStudioAPICenter.Alipay;

namespace JxStudioAPICenter.Test
{
    public class TestAppService : JxStudioAPICenterAppServiceBase, ITestAppService
    {
        private readonly IAlipayManager _alipayManager;

        public TestAppService(IAlipayManager alipayManager)
        {
            _alipayManager = alipayManager;
        }

        public async Task<string> GetAppId(string code)
        {
            await _alipayManager.GetAuthAsync(code);
            return "Hello World!";
        }
    }
}
