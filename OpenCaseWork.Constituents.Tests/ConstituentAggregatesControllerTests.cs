using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Controllers;
using Microsoft.AspNetCore.Routing;
using Microsoft.EntityFrameworkCore;
using Newtonsoft.Json.Linq;
using OpenCaseWork.Constituents.Controllers;
using OpenCaseWork.Constituents.Data;
using OpenCaseWork.Core.Data;
using OpenCaseWork.Models.Constituents;
using OpenCaseWork.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace OpenCaseWork.Constituents.Tests
{
    public class ConstituentAggregatesControllerTests
    {
        string _phoneNumber = "1112223333";
        DbContextOptions<ConstituentContext> _options;
        private ConstituentAggregatesController _controller;
        private IConstituentRepository _constituentRepo;
        private IRepository<Constituent> _genericConstituentRepo;
        private IRepository<ConstituentContact> _genericContactRepo;
        private IEntityRepository _entityRepo;

        public ConstituentAggregatesControllerTests()
        {
            _options = new DbContextOptionsBuilder<ConstituentContext>()
                .UseInMemoryDatabase(databaseName: "TestCRUD")
                .Options;

            var context = new ConstituentContext(_options);

            _constituentRepo = new ConstituentRepository(context);
            _genericConstituentRepo = new Repository<Constituent>(context);
            _genericContactRepo = new Repository<ConstituentContact>(context);
            _entityRepo = new EntityRepository(context);
                              
            _controller = new ConstituentAggregatesController(context,_constituentRepo, _entityRepo);
            _controller.ControllerContext = new ControllerContext
            {
                HttpContext = new DefaultHttpContext(),
                RouteData = new RouteData(),
                ActionDescriptor = new ControllerActionDescriptor()
            };

        }

        private ConstituentAggregate CreateTestAggregate()
        {
            var agg = new ConstituentAggregate();
            var constituent = new Constituent();
            var contact = new ConstituentContact();            

            constituent.FirstName = "Joe";
            constituent.LastName = "Smith";
            constituent.ConstituentId = 0;
            agg.Constituent = constituent;
  
            contact.ContactTypeId = 1;
            contact.ContactValue = _phoneNumber;
            agg.Contacts = new List<ConstituentContact>();
            agg.Contacts.Add(contact);

            return agg;
        }

        private void ValidateAggregateResult(IActionResult result)
        {
            var objectResult = Assert.IsType<OkObjectResult>(result);
            var newAgg = Assert.IsType<EntityResponse<ConstituentAggregate>>(objectResult.Value);
            Assert.Equal(1, newAgg.Data.Constituent.ConstituentId);
            Assert.Equal(1, newAgg.Data.Contacts.Count);
            Assert.Equal(_phoneNumber, newAgg.Data.Contacts[0].ContactValue);
        }

        [Fact]
        public async Task Test_CreateAndGetConstituentAggregate()
        {
            //Arrange
            var agg = CreateTestAggregate();

            //Act
            IActionResult result = await _controller.Post(agg);

            //Assert
            ValidateAggregateResult(result);

            //Act
            IActionResult getResult = await _controller.Get(1);

            //Assert
            ValidateAggregateResult(getResult);
        }
    }
}
