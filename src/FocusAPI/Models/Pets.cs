﻿using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocusCore.Models;

public class Pets
{
    [Key]
    public Guid Id { get; set; }

    public int Price { get; set; }

    public string Name { get; set; } = null!;
}