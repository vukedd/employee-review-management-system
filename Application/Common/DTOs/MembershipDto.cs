﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Common.DTOs
{
    public class MembershipDto
    {
        public long UserId { get; set; }
        public bool IsTeamLead { get; set; }
    }
}
