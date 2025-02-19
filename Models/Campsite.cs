using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace CreekRiver.Models;

public class Campsite
{
  public int Id { get; set; }
  [Required]
  public string Nickname { get; set; }
  public string ImageUrl { get; set; }
  public int CampsiteTypeId { get; set; }
  public CampsiteType CampsiteType { get; set; }
  public List<Reservation> Reservations { get; set; }
}
