using System;
using System.Threading.Tasks;
using Abp.TestBase;
using coolez.EntityFrameworkCore;
using coolez.Tests.TestDatas;

namespace coolez.Tests
{
    public class coolezTestBase : AbpIntegratedTestBase<coolezTestModule>
    {
        public coolezTestBase()
        {
            UsingDbContext(context => new TestDataBuilder(context).Build());
        }

        protected virtual void UsingDbContext(Action<coolezDbContext> action)
        {
            using (var context = LocalIocManager.Resolve<coolezDbContext>())
            {
                action(context);
                context.SaveChanges();
            }
        }

        protected virtual T UsingDbContext<T>(Func<coolezDbContext, T> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<coolezDbContext>())
            {
                result = func(context);
                context.SaveChanges();
            }

            return result;
        }

        protected virtual async Task UsingDbContextAsync(Func<coolezDbContext, Task> action)
        {
            using (var context = LocalIocManager.Resolve<coolezDbContext>())
            {
                await action(context);
                await context.SaveChangesAsync(true);
            }
        }

        protected virtual async Task<T> UsingDbContextAsync<T>(Func<coolezDbContext, Task<T>> func)
        {
            T result;

            using (var context = LocalIocManager.Resolve<coolezDbContext>())
            {
                result = await func(context);
                context.SaveChanges();
            }

            return result;
        }
    }
}
