using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using MusicOrg.Models;
using System;

namespace MusicOrg.Tests
{
    [TestClass]
    public class ArtistTests
    {
        [TestMethod]
        public void Find_ReturnInstanceOfArtistWithThatId_Artist()
        {
            Artist artist = new Artist("name");
            Artist artist2 = new Artist("name");
            Artist result = Artist.Find(1);
            Assert.AreEqual(artist, result);
        }
    }
}