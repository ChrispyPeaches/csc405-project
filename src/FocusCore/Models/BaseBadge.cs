﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FocusCore.Models;

[Table("Badges")]
public class BaseBadge  : ISyncEntity
{
    [Key]
    public Guid Id { get; set; }

    public required string Name { get; set; } = null!;

    public required byte[] Image { get; set; } = null!;
}
