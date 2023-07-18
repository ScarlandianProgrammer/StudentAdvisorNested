using StudentAdvisorNested;
using System.ComponentModel.DataAnnotations;

Advisor compSciAdvisor = new()
{
    FullName = "Perceus Caronstein the IV",
    Email = "fakeemail@notaplace.edu",
    OfficeLocation = "Building 420, Room 69E"
};

Student compSciStudent = new()
{
    FirstName = "Davrich",
    LastName ="Munggen",
    DateOfBirth = new DateOnly(1999, 09, 20),
    SchoolEmail = "dmunggen@notaplace.edu",
    PhoneNumber = "(555)555-5555",
    Advisor = compSciAdvisor
};

Console.WriteLine($"{compSciStudent.FirstName} has {compSciStudent.Advisor.FullName} as their advisor.");