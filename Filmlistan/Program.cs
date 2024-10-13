using Filmlistan;

Movie movie1 = new Movie
{
    Name = "The Lion King",
    Director = "Roger Allers, Rob Minkoff",
    ReleaseDate = new DateTime(1994, 6, 24),
    LengthInMinutes = 88,
    SuitableForChildren = true,
    Stars = new string[] { "Matthew Broderick", "James Earl Jones", "Jeremy Irons" }
};

Movie movie2 = new Movie
{
    Name = "Inception",
    Director = "Christopher Nolan",
    ReleaseDate = new DateTime(2010, 7, 16),
    LengthInMinutes = 148,
    SuitableForChildren = false,
    Stars = new string[] { "Leonardo DiCaprio", "Joseph Gordon-Levitt", "Ellen Page" }
};

Movie movie3 = new Movie
{
    Name = "The Matrix",
    Director = "Lana Wachowski, Lilly Wachowski",
    ReleaseDate = new DateTime(1999, 3, 31),
    LengthInMinutes = 136,
    SuitableForChildren = false,
    Stars = new string[] { "Keanu Reeves", "Laurence Fishburne", "Carrie-Anne Moss" }
};

List<Movie> movies = new(){movie1, movie2, movie3};
foreach (var movie in movies)
{
    Console.WriteLine(movie);
    Console.WriteLine();
}
