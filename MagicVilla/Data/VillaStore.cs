﻿using MagicVilla.Models.Dto;

namespace MagicVilla.Data
{
    public static class VillaStore
    {
        public static List<VillaDTO> villaList = new List<VillaDTO>{
                new VillaDTO{Id=1, Name="Pool View", Sqft=100, Occupancy=4},
                new VillaDTO{Id=2, Name="Beach View", Sqft=200, Occupancy=5}
        };
    }
}
