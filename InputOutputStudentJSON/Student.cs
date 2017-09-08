using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InputOutputStudentJSON{
    class Student {
        public string Name { get; set; }
        public int Id { get; set; }
        public double PercentageScore { get; set; }
        
        public Student(String n, int i, int score, int maxScore){
            Name = n;
            Id = i;
            PercentageScore = percentage(score, maxScore);

        }
        //works out the percentage of the students score
        public double percentage(double mark, double total){
            mark = mark * 100;
            return mark / total;
        }
    }
}
