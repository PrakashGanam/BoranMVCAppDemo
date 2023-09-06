using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCsampleprj_brain_gorman.Models
{
    public class State
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="State")]
        [Required(ErrorMessage ="Name of the state is required")]
        [StringLength(ContactwebConstants.MAX_STATE_NAME_LENGTH)]
        public string Name { get; set; }

        [Required(ErrorMessage ="State abbrevation is required")]
        [StringLength(ContactwebConstants.MAX_STATE_ABBR_LENGTH)]
        public string Abbreviation { get; set; }
    }
}