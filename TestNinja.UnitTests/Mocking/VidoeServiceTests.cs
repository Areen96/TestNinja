﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Mocking;

namespace TestNinja.UnitTests.Mocking
{
   public class VidoeServiceTests
    {
        [Test]
        public void ReadVideoTitle_EmptyFile_ReturnErrorMessage()
        {
            var service = new VideoService();
            service.FileReader = new FakeFileReader();
           var result =  service.ReadVideoTitle();
           Assert.That(result, Is.EqualTo("Error parsing the video."));
        }
    }
}
