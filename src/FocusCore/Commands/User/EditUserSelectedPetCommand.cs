﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FocusCore.Responses;
using MediatR;

namespace FocusCore.Commands.User;
public class EditUserSelectedPetCommand : IRequest<MediatrResult>
{
    public Guid? UserId { get; set; }
    public Guid? PetId { get; set; }
}