using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Gamely.Models
{
    public class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        [Display(Name = "Имя")]
        public string Name { get; set; }

        public bool IsSubscribedToNewsletter { get; set; }

        public MembershipType MembershipType { get; set; }

        [Display(Name = "Тип подписки")]
        public byte MembershipTypeId { get; set; }

        [Display(Name = "Дата рождения")]
        [Min18YearsIfAMember]
        public DateTime? Birthdate { get; set; }
    }
}