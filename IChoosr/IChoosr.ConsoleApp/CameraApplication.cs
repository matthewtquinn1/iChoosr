using System;
using System.Collections.Generic;
using System.Linq;
using IChoosr.BL.Interface.Camera;
using IChoosr.BL.Model;

namespace IChoosr.ConsoleApp
{
    public class CameraApplication
    {
        private readonly ICameraService _cameraService;

        public CameraApplication(ICameraService cameraService)
        {
            _cameraService = cameraService;
        }

        private static bool _endApp;

        public void StartApplication()
        {
            Console.WriteLine("Welcome to the camera application");
            AddLineSeparator();
            AddSpacing(1);

            while (!_endApp) ShowMenu(); 
        }


        #region DisplayMethods

        private void ShowMenu()
        {
            Console.WriteLine("Please enter all or part of the name of a camera you want to see: ");
            Console.WriteLine("otherwise, type exit to close: ");
            AddSpacing(1);

            var userEntry = GetInput();
            Console.WriteLine("Loading...");
            AddSpacing(1);

            _endApp = userEntry == "EXIT";
            GetCamerasBySearchTerm(userEntry);
        }

        private void GetCamerasBySearchTerm(string userEntry)
        {
            try
            {
                var camera = _cameraService.GetCamerasByName(userEntry);

                if (camera.Any())
                {
                    ShowCameras(camera);
                }
                else
                {
                    Console.WriteLine("No camera found by that term.");
                    AddSpacing(1);
                }

            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e);

                Console.WriteLine("Something went wrong, you will now be shown the menu again");
                AddSpacing(1);
            }
        }

        private void ShowCameras(IEnumerable<CameraModel> cameras)
        {
            foreach (var cam in cameras)
            {
                AddLineSeparator();
                Console.WriteLine("ID:        " + cam.Id);
                Console.WriteLine("Full ID:   " + cam.FullId);
                Console.WriteLine("Name:      " + cam.Name);
                Console.WriteLine("Latitude:  " + cam.Latitude);
                Console.WriteLine("Longitude: " + cam.Longitude);
                AddLineSeparator();
                AddSpacing(1);
            }
        }

        #endregion


        #region ExtentionMethods

        private string GetInput() => Console.ReadLine()?.ToUpper();

        private static void AddSpacing(int amount)
        {
            for (var i = 0; i < amount; i++)
            {
                Console.WriteLine(Environment.NewLine);
            }
        }

        private static void AddLineSeparator()
        {
            Console.WriteLine(".................................");
        }

        #endregion
    }
}
