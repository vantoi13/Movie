using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;
public class MovieViewModel
{
    public int Id { get; set; }
    [Display(Name = "Tiêu đề")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Ngày tháng")]

    public DateTime ReleaseDate { get; set; }

    [StringLength(30)]
    public string? Genre { get; set; }
    [DataType(DataType.Currency)]

    public decimal Price { get; set; }
    public string? Rating { get; set; }
}