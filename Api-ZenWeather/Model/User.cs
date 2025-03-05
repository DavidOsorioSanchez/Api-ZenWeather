using System.ComponentModel.DataAnnotations;

namespace Api_ZenWeather.Model
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "La ubicación es requerida.")]
        public string Location { get; set; }
    }
}
