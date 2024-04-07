﻿using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FocusCore.Commands.Social;
public class CreateFriendRequestCommand : IRequest<Unit>
{
    public string UserEmail { get; set; }
    public string FriendEmail { get; set; }
}