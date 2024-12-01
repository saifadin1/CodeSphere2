﻿using CodeSphere.Domain.Models.Entities;
using CodeSphere.Domain.Premitives;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeSphere.Application.Features.Problem.Queries.GetAll
{
    public class GetAllQuery : IRequest<Response>
    {
        public string? UserId { get; set; }
        public List<int>? TopicsIds { get; set; }
        public string? ProblemName { get; set; }
        public int? Difficulty { get; set; }

        public GetAllQuery(string? userId, List<int>? topicsIds, string? problemName, int? difficulty)
        {
            UserId = userId;
            TopicsIds = topicsIds;
            ProblemName = problemName;
            Difficulty = difficulty;
        }
    }

}
