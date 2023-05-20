using Acme.StudentOnBoardingAbp.StudentDetails;
using StudentOnboarding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentOnBoardingAbp.Students
{
    public class StudentAppService :
    CrudAppService<
        StudentDetail, //The Book entity
        StudentDTO, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDTO>, //Used to create/update a book
    IStudentAppService //implement the IBookAppService
    {
        public StudentAppService(IRepository<StudentDetail, Guid> repository)
            : base(repository)
        {

        }
    }
}