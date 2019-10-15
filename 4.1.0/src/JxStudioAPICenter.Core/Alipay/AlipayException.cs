using System;
using System.Collections.Generic;
using System.Text;
using Abp.Dependency;
using Abp.Events.Bus.Exceptions;
using Abp.Events.Bus.Handlers;

namespace JxStudioAPICenter.Alipay
{
    public class UserException
    {
        public class ExceptionHandler : IEventHandler<AbpHandledExceptionData>, ITransientDependency
        {
            public void HandleEvent(AbpHandledExceptionData eventData)
            {
                //  这里可以捕获异常
                //throw new UserFriendlyException(eventData.Exception.Message);
            }
        }
    }
}
