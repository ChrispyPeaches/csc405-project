﻿namespace FocusApp.Models;

public class UserSession : FocusCore.Models.BaseUserSession
{
    public new User? User { get; set; }
}
