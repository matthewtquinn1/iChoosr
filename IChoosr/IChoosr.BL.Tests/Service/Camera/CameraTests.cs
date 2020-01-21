using System.IO;
using System.Linq;
using FluentAssertions;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Service.Camera;
using IChoosr.DA;
using NSubstitute;
using NUnit.Framework;

namespace IChoosr.BL.Tests.Service.Camera
{
    [TestFixture]
    public class CameraTests
    {
        private ICameraRepository _repo;
        private ICameraService _service;

        [SetUp]
        public void Setup()
        {
            _repo = Substitute.For<ICameraRepository>();

            _service = new CameraService(_repo);
        }

        // TODO: Won't pass yet, example test of style
        [Test]
        public void WhenCallingGetCameras_ThenCamerasShouldBeReturned()
        {
            // TODO: Setup test data
            _repo.GetCameraCsv().Returns(new StreamReader(""));

            var cameras = _service.GetCameras();

            cameras.First().Id.Should().Be("1");
        }
      }
}
