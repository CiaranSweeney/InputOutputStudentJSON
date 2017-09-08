using System;
using System.Collections.Generic;
using Newtonsoft.Json;
using System.IO;

namespace InputOutputStudentJSON{
    class Program
    {
        static void Main(string[] args)
        {
            //reading the textfile
            string input = System.IO.File.ReadAllText("input_data.txt");
            //conveting the json and put it in a list of student
            List<InputStudent> inputStudents = JsonConvert.DeserializeObject<List<InputStudent>>(input);
            List<Object> outputStudentsData = new List<Object>();
            //counter for number of student sso I can work the average
            int count = 0;
            double average = 0;
            // the max and min will keep track of what is the highest and lowest score
            double max = 0;
            double min = 100;
            //go throught the input student list
            foreach(InputStudent iStudent in inputStudents)
            {
                // creating new students from the data, to make changes such as the percentage score
                Student student = new Student(iStudent.Name, int.Parse(iStudent.Id), int.Parse(iStudent.Score), int.Parse(iStudent.MaxScore));
                outputStudentsData.Add(student);
                average += student.PercentageScore;
                if (max < student.PercentageScore)
                    max = student.PercentageScore;
                if (min > student.PercentageScore)
                    min = student.PercentageScore;
                count++;
            }
            //working out the avrage here
            average /= count;
            SummaryData summaryData = new SummaryData(average,max,min);
            //adding the summary at the end of the list which will be converted to JSON
            outputStudentsData.Add(summaryData);
            //Convert the students DATA list to Json
            String output = JsonConvert.SerializeObject(outputStudentsData, Formatting.Indented);
            //write the JSON to a text file
            File.WriteAllText("output_data.txt", output);
        }

    }
}
