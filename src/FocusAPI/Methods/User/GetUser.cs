﻿using System.Net;
using FocusCore.Queries.User;
using FocusCore.Models;
using MediatR;
using FocusAPI.Data;
using FocusAPI.Helpers;
using FocusCore.Responses;
using FocusCore.Responses.User;
using Microsoft.EntityFrameworkCore;

namespace FocusAPI.Methods.User;
public class GetUser
{
    public class Handler : IRequestHandler<GetUserQuery, MediatrResultWrapper<GetUserResponse>>
    {
        FocusAPIContext _apiContext;
        public Handler(FocusAPIContext apiContext) 
        {
            _apiContext = apiContext;
        }

        public async Task<MediatrResultWrapper<GetUserResponse>> Handle(
            GetUserQuery query,
            CancellationToken cancellationToken = default)
        {
            BaseUser? user = await GetUser(query, cancellationToken);

            if (user != null)
            {
                return new()
                {
                    HttpStatusCode = HttpStatusCode.OK,
                    Data = new GetUserResponse
                    {
                        User = user,
                        SelectedIslandId = user.SelectedIsland?.Id,
                        SelectedPetId = user.SelectedPet?.Id,
                        UserIslandIds = user.Islands?.Select(ui => ui.IslandId).ToList() ?? new(),
                        UserPetIds = user.Pets?.Select(up => up.PetId).ToList() ?? new()
                    }
                };
            }
            else
            {
                return new()
                {
                    HttpStatusCode = HttpStatusCode.NotFound,
                    Message = $"User not found with Auth0Id: {query.Auth0Id}"
                };
            }
        }

        private async Task<BaseUser?> GetUser(
            GetUserQuery query,
            CancellationToken cancellationToken)
        {
            try
            {
                return await _apiContext.Users
                    .Where(u => u.Auth0Id == query.Auth0Id)
                    .Include(user => user.Islands)
                    .Include(user => user.Pets)
                    .Include(user => user.Decor)
                    .Include(user => user.Badges)
                    .Include(user => user.SelectedIsland)
                    .Include(user => user.SelectedPet)
                    .Include(user => user.SelectedDecor)
                    .Include(user => user.SelectedBadge)
                    .Select(user => ProjectionHelper.ProjectToBaseUser(user))
                    .FirstOrDefaultAsync(cancellationToken);
            }
            catch (Exception e)
            {
                throw new Exception($"Error getting user: {e.Message}");
            }
        }
    }
}