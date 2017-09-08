using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputStudentJSON
{
    class SummaryData{
        public double average { get; set; }
        public double maxScore { get; set; }
        public double minScore { get; set; }

        public SummaryData(double a, double max, double min)
        {
            average = a;
            maxScore = max;
            minScore = min;
        }
    }
}
