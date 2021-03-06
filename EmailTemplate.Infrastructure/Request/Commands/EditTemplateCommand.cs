﻿using EmailTemplate.Infrastructure.Shared.Responses;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailTemplate.Infrastructure.Request.Commands
{
    public class EditTemplateCommand : IRequest<IBaseResponse>
    {
        public int Id { get; set; }
        public string Body { get; set; }
        public string Subject { get; set; }
        public bool IsValid => ((!String.IsNullOrWhiteSpace(Body)
                                  || !String.IsNullOrWhiteSpace(Subject))
                                  && Id > 0);
    }
}
