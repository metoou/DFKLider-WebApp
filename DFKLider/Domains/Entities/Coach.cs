﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace DFKLider.Domains.Entities
{
    public class Coach:EntityBase
    {
        [Required]
        public Guid Id { get; set; }

        [Display(Name = "Дата рождения тренера")]
        public DateTime Burthday { get; set; }

        [Display(Name = "Образование тренера")]
        public string Education { get; set; }

        [Display(Name = "Контактный телефон тренера")]
        public string Phone { get; set; }
        public Guid? GroupId { get; set; }
        public Group Groups { get; set; }


    }
}