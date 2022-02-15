using System.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVC2.Models
{
    public class Person
    {
        [DisplayNameAttribute("Ma Khach Hang")]
        public int Id { get; set; }  
        
        [DisplayNameAttribute("Tên")]         
        public string FirtName { get; set; }  
        
        [DisplayNameAttribute("Họ")] 
        public string LastName { get; set; }  
        
        [DisplayNameAttribute("Nơi sinh")] 
        public string City { get; set; }   

        [DisplayNameAttribute("Giới tính")] 
        public String Gender {get;set;}  
// public Person (int inputID, String inputFirtName, String inputLastName, String inputCity, String inputGender){
//           this.Id = inputID;
//            this.FirtName = inputFirtName;
//            this.LastName = inputLastName;
//            this.City = inputCity;
//            this.Gender = inputGender;
//        }
  }    
    public enum Gender
    {
        male,
        female,
        other,
    }
}
