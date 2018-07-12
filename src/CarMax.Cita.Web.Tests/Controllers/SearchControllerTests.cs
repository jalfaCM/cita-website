using CarMax.Cita.Web.Controllers;
using CarMax.Cita.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace CarMax.Cita.Web.Tests.Controllers
{
    public class SearchControllerTests
    {
        readonly SearchController _controller;

        public SearchControllerTests()
        {
            _controller = new SearchController();
        }

        [Fact]
        public void ShouldReturnView()
        {
            //Arrange

            //act
            var response = _controller.Index();

            //Assert
            Assert.True(response is ViewResult);
            Assert.True((response as ViewResult).Model is SearchViewModel);

            var viewModel = (SearchViewModel)(response as ViewResult).Model;
            Assert.Equal(2, viewModel.Cars.Count);
        }
    }
}
