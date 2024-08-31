using coolez.EntityFrameworkCore;

namespace coolez.Tests.TestDatas
{
    public class TestDataBuilder
    {
        private readonly coolezDbContext _context;

        public TestDataBuilder(coolezDbContext context)
        {
            _context = context;
        }

        public void Build()
        {
            //create test data here...
        }
    }
}