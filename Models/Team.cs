using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace TeamPlayers.Models
{
    public class Team
    {
        [Key]
        [Required, MaxLength(30)]
        [Display (Name ="Team")]
    public string? TeamName { get; set; }
    public string? City { get; set; }
    public string? Province { get; set; }
    public string? Country { get; set; }

    public List<Player>? Players { get; set; }
    }
}