using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Microsoft.VisualStudio.TextTemplating;
using MvcMovie.Data;
using MvcMovie.Models;

namespace MvcMovie.Services;

public class MovieService : IMovieService
{
    private readonly MvcMovieContext _context;
    private readonly IMapper _mapper;
    public MovieService(MvcMovieContext context, IMapper mapper)
    {
        _context = context;
        _mapper = mapper;
    }

    public async Task<Movie> Create(MovieRequest request)
    {
        var movie = _mapper.Map<Movie>(request);

        // Thêm đối tượng vào DbContext
        _context.Add(movie);

        // Lưu vào cơ sở dữ liệu
        await _context.SaveChangesAsync();

        // Trả về đối tượng vừa thêm
        return movie;
    }

    public async Task<bool> Delete(int id)
    {
        var movie = await _context.Movie.FindAsync(id);
        if (movie != null)
        {
            _context.Movie.Remove(movie);
        }

        await _context.SaveChangesAsync();
        return true;
    }

    public async Task<MovieViewModel> GetMovie(int id)
    {

        var movie = await _context.Movie.FirstOrDefaultAsync(m => m.Id == id);
        return _mapper.Map<MovieViewModel>(movie);


    }

    public Task<MovieViewModel> GetMovie()
    {
        throw new NotImplementedException();
    }

    public async Task<IEnumerable<MovieViewModel>> GetMovies()
    {   
        var movies = await _context.Movie.ToListAsync();
        return _mapper.Map<IEnumerable<MovieViewModel>>(movies);
    }

    public bool MovieExists(int id)
    {
        return _context.Movie.Any(e => e.Id == id);
    }

    public async Task<bool> Update(int id, MovieViewModel movieVM)
    {
        _context.Update(_mapper.Map<Movie>(movieVM));
        await _context.SaveChangesAsync();
        return true;
    }

}