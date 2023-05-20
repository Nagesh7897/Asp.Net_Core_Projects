using Acme.StudentOnBoardingAbp.StudentDetails;
using AutoMapper;
using StudentOnboarding.Models;

namespace Acme.StudentOnBoardingAbp;
public class StudentOnBoardingAbpApplicationAutoMapperProfile : Profile
{
    public StudentOnBoardingAbpApplicationAutoMapperProfile()
    {
        CreateMap<StudentDetail, StudentDTO>();
        CreateMap<CreateUpdateStudentDTO, StudentDetail>();
        /* You can configure your AutoMapper mapping configuration here.
         * Alternatively, you can split your mapping configurations
         * into multiple profile classes for a better organization. */
    }
}
