using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrg.Models;
using System;

namespace MusicOrg.Tests
{
    [TestClass]
    public class VinylTests
    {
        [TestMethod]
        public void VinylConstructor_CreatesInstanceOfVinyl_Vinyl()
        {
            Vinyl newVinyl = new Vinyl("Abbey Road");
            Assert.AreEqual(typeof(Vinyl), newVinyl.GetType());
        }
        [TestMethod]
        public void GetTitle_ReturnsTitleOfVinyl_String()
        {
            string title = "Abbey Road";
            Vinyl newVinyl = new Vinyl(title);
            string result = newVinyl.Title;
            Assert.AreEqual(title, result);
        }
    }
}