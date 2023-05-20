using System;
using System.Collections.Generic;
using System.Text;
using Volo.Abp.Application.Dtos;
using Volo.Abp.Application.Services;

namespace Acme.StudentOnBoardingAbp.StudentDetails
{
    public interface IStudentAppService :
    ICrudAppService< //Defines CRUD methods
        StudentDTO, //Used to show books
        Guid, //Primary key of the book entity
        PagedAndSortedResultRequestDto, //Used for paging/sorting
        CreateUpdateStudentDTO> //Used to create/update a book
    {

    }
}
 