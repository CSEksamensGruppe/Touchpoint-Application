﻿
using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using TouchpointApp.Model;
using System.Collections.Generic;


namespace Testing
{
    [TestClass]
    public class UnitTest1
    {
        

        public UnitTest1()
        {
            //testobjekt = new Undervisningssted("","");
        }
        [TestMethod]
        public void OpretUndervisingsstedUdenAdresse()
        {

            // arrange 
           





            Assert.ThrowsException<ArgumentException>(() => { new Undervisningssted("", ""); });





            //Assert.ThrowsException<ArgumentException>(() => { Undervisningssted us1 = new Undervisningssted(lokale, adresse); });

        }

        [TestMethod]
        public void TestMethod2()
        {

        }
    }
}