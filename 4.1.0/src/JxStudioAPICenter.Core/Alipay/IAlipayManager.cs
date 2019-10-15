using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using Abp.Dependency;

namespace JxStudioAPICenter.Alipay
{
    public interface IAlipayManager: ITransientDependency
    {
        Task<AuthDto> GetAuthAsync(string code);
    }
}
