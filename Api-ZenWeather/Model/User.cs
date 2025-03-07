using System.ComponentModel.DataAnnotations;

namespace Api_ZenWeather.Model
{
    public sealed class User
    {
        public Guid Id { get; set; }

        [Required(ErrorMessage = "La ubicación es requerida.")]
        public string Location { get; set; }
    }
}
