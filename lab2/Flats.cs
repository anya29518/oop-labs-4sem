using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab2
{
    [Serializable]
    public class Flats
    {
        [Required]
        public string Meters { get; set; }
        public DateTime Date { get; set; } = DateTime.Now;
        [Required]
        [Range(1, 40)]
        public string Floor { get; set; }
        [Required]
        public List<string> Options { get; set; }
        public string Cost { get; set; }
        [Required]
        public string NumberOfRooms { get; set; }
        [Required]
        public Address AddressOfFlat { get; set; }
        [Required]
        public List<Room> Rooms { get; set; }
        public Flats()
        {

        }

        public Flats(string meters, DateTime date,string floor, List<string> options,
            string cost,string numberofrooms, Address addressofflat, List<Room> rooms)
        {
            Meters = meters;
            Date = date;
            Floor = floor;
            Options = options;
            Cost = cost;
            NumberOfRooms = numberofrooms;
            AddressOfFlat = addressofflat;
            Rooms = rooms;
        }

        public override string ToString()
        {
            return $"Метраж: {Meters}, дата поcтройки {Date}, этаж {Floor}," +
                $"{string.Join(",", this.Options.Select(option => $"Опции: {option}")) }, " +
                $" цена {Cost}, количество комнат {NumberOfRooms}, адрес {AddressOfFlat}," +
                $" {string.Join(",", this.Rooms.Select(room => $"комнаты: {room}")) },";
        }

    }
    [Serializable]
    public class Address
    {
        [Required]
        [StringLength(50, MinimumLength = 2)]
        public string Country { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 5)]
        public string City { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Area { get; set; }
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Street { get; set; }
        [Required]
        public string House { get; set; }
        [Required]
        [Range(1, 10)]
        public string Corpus { get; set; }
        [Required]
        [Range(1, 10)]
        public string Door { get; set; }
        [Required]
        [Range(1, 20)]
        public string Floor { get; set; }
        [Required]
        [Range(1, 1000)]
        public string Flat { get; set; }
       

        public Address()
        {

        }
        public Address(string country, string city, string area,string street,
            string house, string corpus, string door, string floor, string flat)
        {
            Country = country;
            City = city;
            Area = area;
            Street = street;
            House = house;
            Corpus = corpus;
            Door = door;
            Floor = floor;
            Flat = flat;
        }

        public override string ToString()
        {
            return $"{Country}, {City}, {Area}, {Street}, {House}" +
                $"{Corpus}, {Door}, {Floor},{Flat}";
        }
    }
    [Serializable]
    public class Room
    {
        [Required]
        [StringLength(50, MinimumLength = 3)]
        public string Type { get; set; }
        [Required]
        public string Square { get; set; }
       
        [Required]
        [Range(1, 5)]
        public string NumberOfWindows { get; set; }
        [Required]
        public string SideOfWindows { get; set; }
        
        public Room()
        {

        } 

        public Room(string type, string square,
            string numberofwindows, string sideofwindows)
        {
            Type = type;
            Square = square;
            NumberOfWindows = numberofwindows;
            SideOfWindows = sideofwindows;
        }

        public override string ToString()
        {
            return $"Комната {Square}кв.м, кол-во окон {NumberOfWindows}, сторона {SideOfWindows}";
        }

    }
}
