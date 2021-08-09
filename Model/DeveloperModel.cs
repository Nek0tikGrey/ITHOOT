﻿using Model.Core;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Model
{
    public class DeveloperModel:BaseModel
    {
        [Display(Name = "Ім'я")]
        [StringLength(50)]
        [Required]
        public string Name { get; set; }
        [Display(Name = "Прізвище")]
        [StringLength(50)]
        [Required]
        public string Surname { get; set; }
        [Display(Name="Проекти")]
        public IList<ProjectModel> Projects { get; set; }
        [Required]
        [Display(Name = "Посада")]
        public Guid PositionId { get; set; }
        [Display(Name = "Посада")]
        public PositionModel Position { get; set; }
    }
}
