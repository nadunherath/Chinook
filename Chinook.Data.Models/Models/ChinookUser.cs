﻿namespace Chinook.Data.Models.Models;

// Add profile data for application users by adding properties to the ChinookUser class
public class ChinookUser : IdentityUser
{
    public virtual ICollection<UserPlaylist> UserPlaylists { get; set; }
}

