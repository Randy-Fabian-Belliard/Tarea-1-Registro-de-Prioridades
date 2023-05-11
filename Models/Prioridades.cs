using System.ComponentModel.DataAnnotations;

public class Prioridades{
  
  [Key]

public int PrioridadId { get; set; }
public string Descricion { get; set; } = string.Empty;

public DateTime DiasCompromiso{ get; set; } = DateTime.Today;


}