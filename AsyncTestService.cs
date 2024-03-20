using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityService
{
    public class AsyncTest
    {
        public async Task<int> GetID()
        {
            await Task.Delay(3000);
            return 0;
        }
        public async Task<string> GetName()
        {
            await Task.Delay(3000);
            return "Ken";
        }
        public async Task<string> GetDescription()
        {
            await Task.Delay(3000);
            return "Ken is a student";
        }
        public async Task<string> GetLastName()
        {
            await Task.Delay(3000);
            return "Liu";
        }



    }
}
