﻿using GitCandy.App_GlobalResources;
using GitCandy.Base;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;
using System;

namespace GitCandy.Models
{
    public class TeamModel
    {
        [Required(ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_Required")]
        [StringLength(20, MinimumLength = 2, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_StringLengthRange")]
        [RegularExpression(RegularExpression.Teamname, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_Name")]
        [Display(ResourceType = typeof(SR), Name = "Team_Name")]
        public String Name { get; set; }

        [StringLength(500, ErrorMessageResourceType = typeof(SR), ErrorMessageResourceName = "Validation_StringLength")]
        [Display(ResourceType = typeof(SR), Name = "Team_Description")]
        [DisplayFormat(ConvertEmptyStringToNull = false)]
        public String Description { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Team_Members")]
        [UIHint("Members")]
        [AdditionalMetadata("Controller", "Account")]
        public String[] Members { get; set; }

        public UserRole[] MembersRole { get; set; }

        [Display(ResourceType = typeof(SR), Name = "Team_Repositories")]
        [UIHint("Members")]
        [AdditionalMetadata("Controller", "Repository")]
        public String[] Repositories { get; set; }

        public RepositoryRole[] RepositoriesRole { get; set; }

        public class UserRole
        {
            public String Name { get; set; }
            public bool IsAdministrator { get; set; }
        }

        public class RepositoryRole
        {
            public String Name { get; set; }
            public bool AllowRead { get; set; }
            public bool AllowWrite { get; set; }
        }
    }
}