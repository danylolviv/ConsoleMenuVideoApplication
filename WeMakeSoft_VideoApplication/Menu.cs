using System;

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
           while (GetMainMenuSelection() != 0 )
           {
               if (choice == -1)
               {
                   
               }
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