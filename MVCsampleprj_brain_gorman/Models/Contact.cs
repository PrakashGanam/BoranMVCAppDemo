using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace MVCsampleprj_brain_gorman.Models
{
    public class Contact
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage ="First Name is Required")]
        [StringLength(ContactwebConstants.MAX_FIRST_NAME_LENGTH)]
        public string FirstName { get; set; }
        [StringLength(ContactwebConstants.MAX_LAST_NAME_LENGTH)]
        public string LastName { get; set; }

        [Required(ErrorMessage ="Email id is required")]
        [EmailAddress(ErrorMessage ="Invalid Email Address")]
        [MaxLength(ContactwebConstants.MAX_EMAIL_LENGTH)]
        public string Email { get; set; }

        [Required(ErrorMessage = "Phone number is required")]
        [Phone(ErrorMessage ="Invalid Phone number")]
        [StringLength(ContactwebConstants.MAX_PHONE_LENGTH)]
        public string PhonePrimary { get; set; }

        [Phone(ErrorMessage ="Invalid Phone number")]
        [StringLength(ContactwebConstants.MAX_PHONE_LENGTH)]
        public string PhoneSecondary { get; set; }

        [DataType(DataType.Date)]
        public DateTime BirthDay { get; set; }

        [Required(ErrorMessage ="Street Address 1 is Required")]
        [StringLength(ContactwebConstants.MAX_STREET_ADDRESS_LENGTH)]
        public string StreetAddress1 { get; set; }
        public string StreetAddress2 { get; set; }

        [Required]
        [StringLength(ContactwebConstants.MAX_CITY_LENGTH)]
        public string City { get; set; }

        [Required(ErrorMessage ="State id required")]
        public int Stateid { get; set; }
        public virtual State State{ get; set; }

        [StringLength(ContactwebConstants.MAX_ZIPCODE_LENGTH, MinimumLength =ContactwebConstants.MIN_ZIPCODE_LENGTH)]
        public string Zip { get; set; }

        [Required]
        public string UserId { get; set; }
        public virtual ApplicationUser User { get; set; }

        [Display(Name ="Full Name")]
        public string FriendlyName => $"{FirstName} {LastName}";

        public string FriendlyAddress => string.IsNullOrWhiteSpace(StreetAddress2) ? $"{StreetAddress1}, {City}, {State.Abbreviation}, {Zip}"
                                                            :$"{StreetAddress1}, {StreetAddress2}, {City}, {State.Abbreviation}, {Zip}";
    }
}