﻿namespace ContosoUniversity.Domain.Core.Behaviours.InstructorApplicationService
{
    using ContosoUniversity.Core.Domain;
    using ContosoUniversity.Core.Domain.ContextualValidation;
    using ContosoUniversity.Core.Domain.InvariantValidation;
    using System;
    using System.ComponentModel.DataAnnotations;

    public class CreateInstructorWithCourses
    {
        // CreateInstructorWithCourses.CommandModel
        public class CommandModel
        {
            [Required]
            [StringLength(50)]
            public string LastName { get; set; }

            [Required]
            [StringLength(50, ErrorMessage = "First name cannot be longer than 50 characters.")]
            public string FirstMidName { get; set; }

            public DateTime HireDate { get; set; } = DateTimeHelper.Today;

            [StringLength(50)]
            public string OfficeLocation { get; set; }

            public int[] SelectedCourses { get; set; }
        }

        // CreateInstructorWithCourses.Request
        public class Request : DomainRequest<CommandModel>
        {
            public Request(string userId, CommandModel commandModel)
                : base(userId, commandModel)
            {
                InvariantValidation = new InvariantValidation(this);
                ContextualValidation = new ContextualValidation(this);
            }
        }

        // CreateInstructorWithCourses.Response
        public class Response : DomainResponse
        {
            public Response(ValidationMessageCollection validationDetails, int? instructorId = null)
                : base(validationDetails)
            {
                InstructorId = instructorId;
            }

            public int? InstructorId { get; set; }
        }

        // CreateInstructorWithCourses.InvariantValidation
        public class InvariantValidation : UserDomainRequestInvariantValidation<Request, CommandModel>
        {
            public InvariantValidation(Request context)
                : base(context)
            {
            }
        }

        // CreateInstructorWithCourses.ContextualValidation
        public class ContextualValidation : ContextualValidation<Request, CommandModel>
        {
            public ContextualValidation(Request context)
                : base(context)
            {
            }
        }
    }
}
