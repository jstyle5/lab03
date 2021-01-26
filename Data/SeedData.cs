using System.Collections.Generic;
using lab03.Models;
using Microsoft.EntityFrameworkCore;

namespace lab03.Data
{
    public static class SeedData
    {

        // this is an extension method to the ModelBuilder class
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Province>().HasData(
                GetProvinces()
            );

            modelBuilder.Entity<City>().HasData(
                GetCities()
            );
        }

        public static List<Province> GetProvinces()
        {
            List<Province> provinces = new List<Province> {
                new Province () {
                    ProvinceCode = "BC",
                    ProvinceName = "British Columbia",
                },
                new Province () {
                    ProvinceCode = "AB",
                    ProvinceName = "Alberta",
                },
                new Province () {
                    ProvinceCode = "ON",
                    ProvinceName = "Ontario",
                },
                new Province () {
                    ProvinceCode = "MB",
                    ProvinceName = "Manitoba",
                },
            };

            return provinces;
        }

        public static List<City> GetCities()
        {
            List<City> cities = new List<City>() {
                new City {
                    CityId = 1,
                    CityName = "Vancouver",
                    Population = 675218,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 2,
                    CityName = "Richmond",
                    Population = 216288,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 3,
                    CityName = "Surrey",
                    Population = 518467,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 4,
                    CityName = "Burnaby",
                    Population = 249197,
                    ProvinceCode = "BC",
                },
                new City {
                    CityId = 5,
                    CityName = "Calgary",
                    Population = 1336000,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 6,
                    CityName = "Edmonton",
                    Population = 981280,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 7,
                    CityName = "Red Deer",
                    Population = 100418,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 8,
                    CityName = "Lethbridge",
                    Population = 99769,
                    ProvinceCode = "AB",
                },
                new City {
                    CityId = 9,
                    CityName = "Winnipeg",
                    Population = 749534,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 10,
                    CityName = "Selkirk",
                    Population = 10278,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 11,
                    CityName = "Dauphin",
                    Population = 8457,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 12,
                    CityName = "The Pas",
                    Population = 5513,
                    ProvinceCode = "MB",
                },
                new City {
                    CityId = 13,
                    CityName = "Toronto",
                    Population = 2615000,
                    ProvinceCode = "ON",
                },
                new City {
                    CityId = 14,
                    CityName = "Ottawa",
                    Population = 934234,
                    ProvinceCode = "ON",
                },
                new City {
                    CityId = 15,
                    CityName = "Mississauga",
                    Population = 721599,
                    ProvinceCode = "ON",
                },
                new City {
                    CityId = 16,
                    CityName = "Vaughan",
                    Population = 306233,
                    ProvinceCode = "ON",
                },
              };

            return cities;
        }
    }
}