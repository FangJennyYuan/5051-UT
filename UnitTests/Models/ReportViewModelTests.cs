using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HW1c.Models;
using System.Collections.Generic;

namespace UnitTests.Models
{
    [TestClass]
    public class ReportViewModelTests
    {
        [TestMethod]
        public void ReportViewModel_Instantiate_Default_Should_Pass()
        {
            //Arrange


            //Act
            var result = new ReportViewModel();

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Get_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();

            //Act
            var result = myTest.LogViewModel;

            //Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ReportViewModel_LogViewModel_Set_Default_Should_Pass()
        {
            //Arrange
            var myTest = new ReportViewModel();
            var myViewModel = new LogViewModel();
            var myList = new List<LogModel>();
            myList.Add(new LogModel { PhoneID = "Phone" });
            myViewModel.LogList = myList;

            //Act
            myTest.LogViewModel = myViewModel;
            var result = myTest.LogViewModel;

            //Assert
            Assert.AreEqual("Phone", result.LogList[0].PhoneID);
        }
    }
}
