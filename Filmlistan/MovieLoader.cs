namespace MovieDb;

public class MovieLoader
{
    Movie movie2 = new SciFi(
    title: "Contact",
    runningTime: 148,
    stars: new List<Actor>
    {
        new Actor("Jodie Foster", 1962),      // Played Dr. Eleanor "Ellie" Arroway
        new Actor("Matthew McConaughey", 1969),   // Played Palmer Joss
        new Actor("Tom Skerritt", 1933),      // Played David Drumlin
        new Actor("James Woods", 1947),       // Played Michael Kitz
        new Actor("John Hurt", 1940)          // Played S. R. Hadden
    },
    spaceships: 1
);

    Movie movie1 = new Comedy(
        title: "Spaceballs",
        runningTime: 104,
        stars: new List<Actor>
        {
    new Actor("Mel Brooks", 1926),      // Played President Skroob & Yogurt
    new Actor("John Candy", 1950),      // Played Barf
    new Actor("Bill Pullman", 1953),    // Played Lone Starr
    new Actor("Rick Moranis", 1953),    // Played Dark Helmet
    new Actor("Daphne Zuniga", 1962)    // Played Princess Vespa
        },
        funnyScenes: 34);

    Movie movie3 = new MovieDb.Action
    (
        title: "The Matrix",
        runningTime: 136,
        stars: new List<Actor>
            {
        new Actor("Keanu Reeves", 1964),
        new Actor("Laurence Fishburne", 1961),
        new Actor("Carrie-Anne Moss", 1967),
        new Actor("Hugo Weaving", 1960)
            },
        shotsFired: 2435);

    public (Movie,Movie, Movie) Get3Movies()
    {
        return (movie1, movie2, movie3);
    }
}
