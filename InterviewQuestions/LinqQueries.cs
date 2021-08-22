using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterviewQuestions
{
    public class LinqQueries
    {
        /// <summary>
        /// Take two arrays for creating a new one from the multiply result of their matched values.
        /// </summary>
        /// <param name="data1"></param>
        /// <param name="data2"></param>
        public IEnumerable<int> GetResultFromMultiply2Arrays(int[] data1, int[] data2)
        {
            IEnumerable<int> query = from x in data1
                        join y in data2
                        on x equals y
                select new
                {
                    Item = x * y
                }.Item;

            return query;
        }

        public void GetResultFromArraysToNewOne()
        {
            var data1 = new[] { 1, 2, 3, 4, 5 };
            var data2 = new[] { 1, 2, 3, 1, 2, 3, 4, 1, 2 };

            var qry = from a in data1
                      join b in data2
                      on a equals b into c
                      select new { a, c };

            foreach (var item in qry)
            {
                Console.WriteLine("{0}{1}", item.a, item.c.Count());
            }
        }

        /// <summary>
        /// 
        /// </summary>
        public void GetResultWithReverse()
        {
            var data1 = new[] { "a", "b", "c", "d" };
            var data2 = new[] { "c", "d", "a" };

            foreach (var item in data1.Union(data2).Reverse())
            {
                Console.WriteLine(item);
            }
        }
        public void MixingColor()
        {
            var data = new[] { 
                new Car{ Name= "A", Color = "Blue"},
                new Car{ Name= "B", Color = "Blue"},
                new Car{ Name= "A", Color = "Red"},
                new Car{ Name= "C", Color = "Green"},
                new Car{ Name= "D", Color = "Blue"},
            };

            var qry = from a in data
                      group a by a.Color;

            foreach (var item in qry)
            {
                Console.WriteLine("{0}-{1}", item.Key, item.Count());
            }
        }
    }

    internal class Car
    {
        public string Name { get; set; }
        public string Color { get; set; }
    }
}
