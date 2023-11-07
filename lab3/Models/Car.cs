using Microsoft.AspNetCore.Mvc;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace lab3.Models
{
    public class Car
    {
        [HiddenInput]
        public int id { get; set; }
        [Required(ErrorMessage = "Podaj model!")]
        [Display(Name = "Model")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzona nazwa modelu jest za długa, wprowadź model maksymalnie do 50 znaków.")]
        public string model { get; set; }

        [Required(ErrorMessage = "Podaj producenta!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzona nazwa producenta jest za długa, wprowadź producenta maksymalnie do 50 znaków.")]
        
        [Display(Name = "Producent")]
        public string make { get; set; }

        [RegularExpression(@"^\d+\.\d$", ErrorMessage = "Pojemność musi być w formacie 'n.m'")]
        [Range(0.0, 8.0, ErrorMessage = "Pojemność musi być w przedziale 0.0-8.0")]
        [Display(Name = "Pojemność skokowa (w litrach)")]
        public double displacement { get; set; }
        [Display(Name = "Moc (w HP)")]
        [RegularExpression(@"^\d{1,4}$", ErrorMessage = "\"Wprowadzona moc jest za długa, wprowadź moc maksymalnie do 4 znaków.\")]")]
        public int horsepower { get; set; }

        [Display(Name = "Typ silnika")]
        public string engine_type { get; set; }

        [Required(ErrorMessage = "Podaj nr rejestracyjny!")]
        [StringLength(maximumLength: 7, ErrorMessage = "Wprowadzona tablica jest za długa, wprowadź nr rejestracyjny maksymalnie do 7 znaków.")]
        [Display(Name = "Nr rejestracyjny")]
        public string plate { get; set; }

        [Required(ErrorMessage = "Wymagane podanie właściciela!")]
        [StringLength(maximumLength: 50, ErrorMessage = "Wprowadzony właściciel ma za długie imię, wprowadź właściciela maksymalnie do 50 znaków.")]
        [Display(Name = "Właściciel")]
        public string owner { get; set; }

    }
}
/*    public enum engineTypes
{
    None, LPG, Petrol, Diesel, Hybrid, EV
    }
*/