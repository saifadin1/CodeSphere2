﻿using CodeSphere.Domain.Premitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSphere.Application.Features.Problem.Queries.GetById
{
	public class GetByIdQuery : IRequest<Response>
	{
		public int ProblemId { get; set; }

        public GetByIdQuery(int problemId)
        {
            ProblemId = problemId;  
        }
    }
}