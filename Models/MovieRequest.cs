using System.ComponentModel.DataAnnotations;

namespace MvcMovie.Models;
public class MovieRequest
{
    [StringLength(60, MinimumLength = 3)]
    [Required(ErrorMessage = "Vui lòng nhập dữ liệu !")]
    [Display(Name = "Tiêu đề")]
    public string? Title { get; set; }
    [DataType(DataType.Date)]
    [Display(Name = "Ngày tháng")]
    [Required(ErrorMessage = "Vui lòng nhập dữ liệu !")]

    public DateTime ReleaseDate { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$")]
    [Required(ErrorMessage = "Vui lòng nhập dữ liệu !")]

    [StringLength(30)]
    public string? Genre { get; set; }
    [Range(1, 100)]
    [DataType(DataType.Currency)]
    [Required(ErrorMessage = "Vui lòng nhập dữ liệu !")]

    public decimal Price { get; set; }
    [RegularExpression(@"^[A-Z]+[a-zA-Z0-9""'\s-]*$")]
    [StringLength(5)]
    [Required(ErrorMessage = "Vui lòng nhập dữ liệu !")]
    public string? Rating { get; set; }
}