using MovieDb;

MovieLoader movieloader = new MovieLoader();
var (movie1, movie2, movie3) = movieloader.Get3Movies();

List<Movie> movies = new(){movie1, movie2, movie3};
foreach (var movie in movies)
{
    Console.WriteLine(movie);
    Console.WriteLine();
}
