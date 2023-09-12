﻿using Chinook.Models;

namespace Chinook.ClientModels
{
    public class ArtistViewModel
    {
        public ArtistViewModel()
        {
            Albums = new List<AlbumViewModel>();
        }

        public long ArtistId { get; set; }
        public string? Name { get; set; }

        public List<AlbumViewModel> Albums { get; set; }
    }
}
