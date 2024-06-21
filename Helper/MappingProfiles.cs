﻿using AutoMapper;
using PokemonReviewApp.DTO;
using PokemonReviewApp.Models;
namespace PokemonReviewApp.Helper
{
    public class MappingProfiles : Profile
    {
        public MappingProfiles()
        {
            CreateMap<Pokemon, PokemonDTO>();
            CreateMap<Category, CategoryDTO>();
            CreateMap<Country, CountryDTO>();
        }
    }

}
