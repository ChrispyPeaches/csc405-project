﻿using Microsoft.EntityFrameworkCore;

namespace FocusApp.Models;

public class Friendship : FocusCore.Models.BaseFriendship
{
    [DeleteBehavior(DeleteBehavior.Restrict)]
    public new User? User { get; set; }

    [DeleteBehavior(DeleteBehavior.Restrict)]
    public new User? Friend { get; set; }
}
