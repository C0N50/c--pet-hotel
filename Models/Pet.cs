using System.Text.Json.Serialization;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace pet_hotel
{
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PetBreed {
        Shepherd,
        Poodle,
        Beagle,
        Bulldog,
        Terrier,
        Boxer,
        Labrador,
        Retriever
    }
    
    [JsonConverter(typeof(JsonStringEnumConverter))]
    public enum PetColor {
        Black,
        White,
        Golden,
        Tricolor,
        Spotted
    }
    public class Pet {

        
        public int id { get; set; }

        [Required]
        public string name {get; set;}

        [Required]
        public PetBreed breed {get; set;}

        [Required]
        public PetColor color {get; set;}

        public DateTime? checkedInAt {get; set;}

        [ForeignKey("petOwner")]
        [Required]
        public int petOwnerid {get; set;}

        public PetOwner petOwner {get; set;}
    }
}



