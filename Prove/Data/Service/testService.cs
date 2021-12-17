using Prove.Data.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Prove.Data.Service
{
    public class testService
    {
        private AppDbContext _context;

        public testService(AppDbContext context)
        {
            _context = context;
        }
        public void AddTest(string name)
        {
            var testmodel = new ProveModel()
            {
                Name = name,
                
            };

            _context.Prova.Add(testmodel);
            _context.SaveChanges();
        }

    }
}
