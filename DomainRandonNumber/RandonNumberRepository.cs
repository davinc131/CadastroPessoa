using System;
using System.Collections.Generic;
using System.Text;

namespace DomainRandonNumber
{
    public class RandonNumberRepository
    {
        private List<RandonNumber> randonNumbers { get; set; }

        public RandonNumberRepository()
        {
            randonNumbers = new List<RandonNumber>();
        }

        public void AddRandonNumber(RandonNumber r)
        {
            randonNumbers.Add(r);
        }

        public List<RandonNumber> RandonNumbers
        {
            get { return randonNumbers; }
            set { randonNumbers = value; }
        }
    }
}
