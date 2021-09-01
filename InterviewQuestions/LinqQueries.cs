using System;
using System.Collections.Generic;
using System.Linq;
using Utilities;

namespace InterviewQuestions
{
    public sealed class LinqQueries
	{
		/// <summary>
		/// Takes two arrays for creating a new one from the multiply result of their matched values.
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

		/// <summary>
		/// Takes two arrays for creating a new one from the union result and grouping their matched values.
		/// </summary>
		/// <returns></returns>
		public IEnumerable<string> GetResultForUniting2Arrays(int[] data1, int[] data2)
		{
			var qry = from a in data1
					  join b in data2
					  on a equals b into c
					  select new { a, c = c.Count() }.ToString();

			return qry;// qry;
		}

		/// <summary>
		/// Gets a new array from the reverse result of their union.
		/// </summary>
		public List<string> GetResultWithReverse(string[] data1, string[] data2)
		{
			List<string> result = new List<string>();
			foreach (var item in data1.Union(data2).Reverse())
			{
				result.Add(item);
			}
			return result;
		}

		/// <summary>
		/// Receives a car object and ordered it base its color property.
		/// </summary>
		/// <param name="data"></param>
		/// <returns></returns>
		public List<IGrouping<string,Car>> MixingColor(Car[] data)
		{
			var qry = (from a in data
					  group a by a.Color).ToList();

			return qry;
		}

		public List<string> GetOrderedNameList(Person[] people)
        {
			List<string> result = new List<string>();

			result = (from person in people
					 orderby person.Name
					 select person.Name).ToList();

			return result;
		}
	}	
}
