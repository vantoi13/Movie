using MvcMovie.Models;

namespace MvcMovie.Services;
public interface IMovieService
{
    Task<IEnumerable<MovieViewModel>> GetMovies();
    Task<MovieViewModel> GetMovie(int id);
    Task<Movie> Create(MovieRequest request);
    Task<bool> Update(int id, MovieViewModel movie);
    Task<bool> Delete(int id);
    bool MovieExists(int id);





}
