using System;

namespace Repository
{
    public class EagerDbService
    {
        private static EagerDbService instance = new EagerDbService();
        private EagerDbService(){}

        public static EagerDbService Instance
        {
            get
            {
                return instance;
            }
        }
    }
}
