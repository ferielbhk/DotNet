using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AM.ApplicationCore.Domain
{
    public class Passenger
    {
        [Key]
        [StringLength(7)]
        public string PassportNumber { get; set; }
        [MinLength(3 , ErrorMessage ="Minimm 3 caracteres ")]
        [MaxLength(25 , ErrorMessage ="Maxmm 25 caracteres")]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        [Display(Name ="Date of birth")]
        public DateTime BirthDate { get; set; }
        public string EmailAdress { get; set; }
        public string PhoneNumber { get; set; }
        public ICollection<Flight> Flights { get; set; }
       
        public bool CheckProfile(string prenom, string nom,string email=null)
        {
            if(email!=null)
            return (prenom.Equals(FirstName) && nom.Equals(LastName)&&email.Equals(EmailAdress));
            else
                return (prenom.Equals(FirstName) && nom.Equals(LastName));

        }
        public virtual void PassengerType()
        {
            Console.WriteLine("i am a passenger");
        }
    }
}
