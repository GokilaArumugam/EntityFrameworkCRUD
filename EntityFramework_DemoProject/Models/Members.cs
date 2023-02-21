using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Web;

namespace EntityFramework_DemoProject.Models
{
    public class Members
    {
        public int Id { get; set; }
        [Required, DataType(DataType.Text)]
        public string Name { get; set; }
        public string Gender { get; set; }
        [Required, Range(18, 50)]
        public int Age { get; set; }
        public string Address { get; set; }
        [Required]
        [DataType(DataType.PhoneNumber)]
        public long MobileNo { get; set; }
        [Required, DataType(DataType.EmailAddress), DisplayName("Email Id")]
        public string Email_ID { get; set; }
        [Required, DataType(DataType.Password)]
        public string Password { get; set; }
        [Required, DataType(DataType.Password)]
        public string ConfirmPassword { get; set; }
        public string SelectType { get; set; }
        [Required]
        public string University { get; set; }
        [Required]
        public string Department { get; set; }
        [Required]
        public string City { get; set; }
    }
    public enum University
    {
        IndianInstituteofTechnologyMadrasChennai,
        VelloreInstituteofTechnologyVellore,
        SRMInstituteofScienceandTechnologyChennai,
        AmritaVishwaVidyapeethamCoimbatore,
        AnnaUniversityChennai,
        TamilNaduAgriculturalUniversityCoimbatore,
        UniversityofMadrasChennai,
        NationalInstituteofTechnologyTiruchirappalli,
        TamilNaduTeacherEducationUniversityChennai,
        ChennaiMathematicalInstituteChennai,
        SASTRAUniversityThanjavur,
        BharathidasanUniversityTiruchirappalli,
        BharathiarUniversityCoimbatore,
        AnnamalaiUniversityChidambaram,
        AlagappaUniversityChidambaram
    }
    public enum Department
    {
        ComputerScienceEngineering,
        MechanicalEngineering,
        CivilEngineering,
        ElectricalAndElectronicsEngineering,
        ElectronicsAndCommunicationEngineering,
        DepartmentofTamil,
        DepartmentofEnglish,
        DepartmentofMaths,
        DepartmentofComputerScience,
        PlantBreedingGenetics,
        PlantProtection,
        PlantMolecularBiologyBiotechnology,
        AgricultureRuralDevelopment
    }
    public enum City
    {
        Chennai,
        Coimbatore,
        Madurai,
        Tiruchirappalli,
        Salem,
        Thirunelvelli,
        Tiruppur,
        Vellor,
        Erode,
        Thoothukudi,
        Thanjavur,
        Dindugal,
        Sivakasi,
        Karur,
        Thenni,
        Kanchipuram
    }
    public enum Type
    {
        Student,
        Staff
    }
}