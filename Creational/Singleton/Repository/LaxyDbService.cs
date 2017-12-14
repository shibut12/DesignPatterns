using System;

namespace Repository
{
    public class LazyDbService
    {
        private static LazyDbService instance = null;
        private LazyDbService(){}

        public static LazyDbService Instance
        {
            get
            {
                if(instance == null)
                {
                    instance = new LazyDbService();
                }

                return instance;
            }
        }
    }
}
