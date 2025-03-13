using System;

namespace API.Entities;

public class AppUser
{
    // Identfier attribute for users
    public int Id { get; set; }

    public required string UserName { get; set; }
}
