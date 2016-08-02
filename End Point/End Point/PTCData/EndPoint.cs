using System;
using System.ComponentModel.DataAnnotations;

namespace EndPointData
{
  public class EndPoint
  {    
    public int EndPointId { get; set; }

    [Required(ErrorMessage = "End Point must be filled in.")]
    [Display(Description = "End Point")]
    [StringLength(150, MinimumLength = 4,
       ErrorMessage = "End Point Name must be greater than {2} characters and less than {1} characters.")]
    public string EndPointName { get; set; }

    public string Environment { get; set; }
    public string ServiceName { get; set; }

  
  }
}
