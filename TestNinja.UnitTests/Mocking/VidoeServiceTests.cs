using System;
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
           var result =  service.ReadVideoTitle(new FakeFileReader());
           Assert.That(result, Is.EqualTo("Error parsing the video."));
        }
    }
}
