using System;

namespace UI
{
    class AdvancedNavigationService
    {
        #region Singleton

        private static volatile AdvancedNavigationService instance;
        private static object syncRoot = new Object();

        private AdvancedNavigationService() { }

        private static AdvancedNavigationService Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (syncRoot)
                    {
                        if (instance == null)
                            instance = new AdvancedNavigationService();
                    }
                }

                return instance;
            }
        }
        #endregion


    }
}
