using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using influencer.Models.Context;
using Microsoft.AspNetCore.Authorization;

namespace influencer.Security.Default
{
    public class ClaimHandler : AuthorizationHandler<ClaimRequirement>
    {

        protected override Task HandleRequirementAsync(AuthorizationHandlerContext context, 
            ClaimRequirement requirement)
        {
            if(context.User.HasClaim(requirement.ClaimType,requirement.ClaimValue))
               context.Succeed(requirement);

            return Task.CompletedTask;
        }
    }
}
