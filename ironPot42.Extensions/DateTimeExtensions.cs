using System;
using System.Collections.Generic;
using System.Linq;

namespace ironPot42.Extensions
{
  public static class DateTimeExtensions
  {
    public static IEnumerable<DateTime> GetDateRange(this DateTime startDate, DateTime endDate)
    {
      if (endDate < startDate)
        throw new ArgumentException("endDate must be greater than or equal to startDate");

      return Enumerable.Range(0, (endDate - startDate).Days + 1).Select(d => startDate.AddDays(d));
    }
  }
}
