using MatchMakings.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatchMakings.Data.Repository
{
   
    public class MatchMakerRepository
    {
        private readonly DataContext _matchMaker;
        public List<MatchMaker> GetAll()
        {
            return _matchMaker.MatchMakers;
        }
    }
}
