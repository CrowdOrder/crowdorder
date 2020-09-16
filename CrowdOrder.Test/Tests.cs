using CrowdOrder.beta.Data;
using CrowdOrder.beta.Infrastructure;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Moq;
using NUnit.Framework;

namespace CrowdOrder.Test
{
    public class Tests
    {
        private CategoryRepository _categoryRepository;
        private ILogger<CategoryRepository> _logger;
        private ApplicationDbContext _context;
        private Cache _cache;
        [SetUp]
        public void Setup()
        {
            _context = CreateContext();
            _logger = Mock.Of<ILogger<CategoryRepository>>();
            _cache = Mock.Of<Cache>();
            _categoryRepository = new CategoryRepository(_logger, _context, _cache);
        }

        [Test]
        public void CategoryRepository_MenuBuilder_HidesEmpty()
        {
            var data = _categoryRepository.MenuData();

            Assert.IsTrue(data.Count == 0);
        }


        //[Test]
        //public void UrlRewriteService_GetAll_ReturnsList()
        //{
        //    var data = UrlRewriteService.GetOptions(_context);

        //    Assert.IsTrue(data.Count > 0);
        //}

        private ApplicationDbContext CreateContext()
        {
            var options = new DbContextOptionsBuilder<ApplicationDbContext>()
           .UseInMemoryDatabase(databaseName: "CrowdOrderDatabase").Options;

            // Insert seed data into the database using one instance of the context
            var context = new ApplicationDbContext(options);
            DbInitialiser.Initialize(context);
            return context;
        }
    }
}