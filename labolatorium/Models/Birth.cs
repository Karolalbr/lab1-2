using System;
using System.ComponentModel.DataAnnotations;

public class Birth
{
    [Required(ErrorMessage = "Imię jest wymagane.")]
    public string Name { get; set; }

    [Required(ErrorMessage = "Data urodzenia jest wymagana.")]
    [DataType(DataType.Date)]
    public DateTime BirthDate { get; set; }
}
