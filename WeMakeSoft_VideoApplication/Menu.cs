using System;
using WeMakeSoft_extentionVideo_Models;

namespace WeMakeSoft_VideoApplication
{
    internal class Menu
    {
        public void Start()
        {
            ShowWelcomeGreeting();
            StartLoop();
            
        }

        private void StartLoop()
        {
           ShowMainMenu();
           int choice = 0;
           var Video = new Video();
           while (GetMainMenuSelection() != 0 )
           {
               if (choice == -1)
               {
                   
               }
           }
        }

        private void SearchVideo()
        {
            Console.WriteLine("What to search for 1 - Title,  2 - Id,  0 - Go Back");
            int choice;
            while (expression)
            {
                
            }
        }

        private int GetMainMenuSelection()
        {
            return -1;
        }

        private void ShowMainMenu()
        {
            Console.WriteLine();
        }

        public void ShowWelcomeGreeting()
        {
            Console.WriteLine(StringConstants.WelcomeGreeting);
        }
    }
}