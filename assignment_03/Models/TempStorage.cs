using System;
using System.Collections.Generic;

namespace assignment_03.Models
{
    public static class TempStorage
    {
        private static List<AddMovie> movies = new List<AddMovie>();

        public static IEnumerable<AddMovie> Movies => movies;

        public static void AddMovie(AddMovie movie)
        {
            movies.Add(movie);
        }
    }
}
