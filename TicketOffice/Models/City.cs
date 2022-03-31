using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TicketOffice.Models;

public class City
{
    [Key]
    public int Id { get; set; }
    
    [MaxLength(24, ErrorMessage = "Назва міста не може бути більше 24 символів"),
     MinLength(2, ErrorMessage = "Назва міста не може бути менше 2 символів")]
    [Display(Name = "Назва міста")]
    [Required(ErrorMessage = "Поле має бути заповненим")]
    public string Name { get; set; }
    
    [Display(Name = "Дата відправлення")]
    [DataType(DataType.Date)]
    public DateTime? ArrivalTime { get; set; }
    
    [Display(Name = "Дата прибуття")]
    [DataType(DataType.Date)]
    public DateTime? DepartureTime { get; set; }

    
    [ForeignKey("Route")]
    public int RouteId { get; set; }
    public Route Route { get; set; }
}