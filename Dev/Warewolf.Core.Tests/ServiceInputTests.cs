﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
// ReSharper disable InconsistentNaming

namespace Warewolf.Core.Tests
{
    [TestClass]
    public class ServiceInputTests
    {
        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("ServiceInput_Constructor")]
        public void ServiceInput_Constructor_EmptyConstructor_ShouldStillConstruct()
        {
            //------------Setup for test--------------------------
            //------------Execute Test---------------------------
            var serviceOutputMapping = new ServiceInput();
            //------------Assert Results-------------------------
            Assert.IsNotNull(serviceOutputMapping);
            Assert.IsFalse(serviceOutputMapping.EmptyIsNull);
            Assert.IsFalse(serviceOutputMapping.RequiredField);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("ServiceInput_Constructor")]
        public void ServiceInput_Constructor_EmptyName_ShouldStillConsturct()
        {
            //------------Setup for test--------------------------
            const string mappingTo = "mapTo";
            //------------Execute Test---------------------------
            var serviceOutputMapping = new ServiceInput("",mappingTo);
            //------------Assert Results-------------------------
            Assert.IsNotNull(serviceOutputMapping);
            Assert.AreEqual(mappingTo,serviceOutputMapping.Value);
            Assert.AreEqual("",serviceOutputMapping.Name);
            Assert.IsTrue(serviceOutputMapping.EmptyIsNull);
            Assert.IsTrue(serviceOutputMapping.RequiredField);
        }
        
        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("ServiceInput_Constructor")]
        public void ServiceInput_Constructor_EmptyValue_ShouldStillConsturct()
        {
            //------------Setup for test--------------------------
            const string mappingFrom = "mapFrom";
            
            //------------Execute Test---------------------------
            var serviceOutputMapping = new ServiceInput(mappingFrom,"");
            //------------Assert Results-------------------------
            Assert.IsNotNull(serviceOutputMapping);
            Assert.AreEqual("",serviceOutputMapping.Value);
            Assert.AreEqual(mappingFrom,serviceOutputMapping.Name);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("ServiceInput_Constructor")]
        public void ServiceInput_Constructor_WhenNameValue_ShouldConstructorScalarMappedTo()
        {
            //------------Setup for test--------------------------
            const string mappingFrom = "mapFrom";
            const string variableMapTo = "[[mapTo]]";
            //------------Execute Test---------------------------
            var serviceOutputMapping = new ServiceInput(mappingFrom, variableMapTo);
            //------------Assert Results-------------------------
            Assert.IsNotNull(serviceOutputMapping);
            Assert.AreEqual(mappingFrom,serviceOutputMapping.Name);
            Assert.AreEqual(variableMapTo,serviceOutputMapping.Value);
        }

        [TestMethod]
        [Owner("Hagashen Naidu")]
        [TestCategory("ServiceInput_Constructor")]
        public void ServiceInput_Constructor_WhenCharInName_ShouldConstructorScalarMappedTo()
        {
            //------------Setup for test--------------------------
            const string mappingFrom = "`mapFrom`";
            const string variableMapTo = "[[mapTo]]";
            //------------Execute Test---------------------------
            var serviceOutputMapping = new ServiceInput(mappingFrom, variableMapTo);
            //------------Assert Results-------------------------
            Assert.IsNotNull(serviceOutputMapping);
            Assert.AreEqual(mappingFrom.Replace("`",""),serviceOutputMapping.Name);
            Assert.AreEqual(variableMapTo,serviceOutputMapping.Value);
        }

        
        
    }
}