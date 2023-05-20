using DocumentFormat.OpenXml.Drawing.Charts;
using DocumentFormat.OpenXml.InkML;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using StudentOnboarding.Filter;
using StudentOnboarding.Models;
using StudentOnboarding.Wrappers;

namespace StudentOnboarding.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class StudentsController : ControllerBase
    {
        public readonly DatabaseContext _dbContext;
        public StudentsController(DatabaseContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        //With Pagination
                [HttpGet]
                public async Task<IActionResult> GetAll([FromQuery]PaginationFilter filter)
                {
           
                    // return await _dbContext.Students.ToListAsync();
                    var validFilter = new PaginationFilter(filter.PageNumber, filter.PageSize);
                    var pageData=await _dbContext.Students.Include(e => e.StdEducation)
                    .Skip((validFilter.PageNumber - 1) * validFilter.PageSize)
                        .Take(validFilter.PageSize).ToListAsync();
                    var totalRecords=await _dbContext.Students.CountAsync();
                    return Ok(new PagedResponse<List<StudentDetails>>(pageData,validFilter.PageNumber,validFilter.PageSize));

                }

        // Without Paginator
        /*
                [HttpGet]
                public async Task<ActionResult<IEnumerable<StudentDetails>>> GetStudents()
                {
                    if (_dbContext.Students == null)
                    {
                        return NotFound();
                    }
                    // return await _dbContext.Students.ToListAsync();

                    var students = await _dbContext.Students
                    .Include(e => e.StdEducation)
                    .ToListAsync();
                    return students;

                }
            */


        // get the value from student UID number
        [HttpGet("{UID}")]
        public async Task<ActionResult<StudentDetails>> GetStudent(String UID)
        {
            if (_dbContext.Students == null)
            {
                return NotFound();
            }
            //  var student=await _dbContext.Students.FindAsync(UID);
            var student = await _dbContext.Students
                .Where(e => e.GenerateUID == UID)
                .Include(e => e.StdEducation)
                .FirstOrDefaultAsync();

            if (student == null)
            {
                return NotFound();
            }

            return student;
        }


        [HttpPost]
        public async Task<ActionResult<StudentDetails>> PostStudent(StudentDetails student)
        {
            _dbContext.Students.Add(student);
            await _dbContext.SaveChangesAsync();
            return Ok();
                //CreatedAtAction(nameof(GetStudent), new {id = student.GenerateUID}, student);
        }

        // This method is not updating other table(Second Table)
        [HttpPut("{UID}")]
        public async Task<IActionResult> PutStudent(string UID, StudentDetails student)
        {
            if (UID != student.GenerateUID)
            {
                return BadRequest();
            }

            //this is for 2 tables updation
            _dbContext.Students.Update(student);
            await _dbContext.SaveChangesAsync();

            //without below line also it will work proerly
           // _dbContext.Entry(student).State = EntityState.Modified;
            try
            {
                await _dbContext.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!StudentAvailability(UID))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }
            return Ok();
        }

        private bool StudentAvailability(string UID)
        {
            return (_dbContext.Students?.Any(x=> x.GenerateUID == UID)).GetValueOrDefault();
        }

        [HttpDelete("{UID}")]
        public async Task<IActionResult> DeleteStudent(string UID)
        {
            if (_dbContext.Students == null)
            {
                return NotFound();
            }
            var student = await _dbContext.Students.FindAsync(UID);
            if(student == null)
            {
                return NotFound();
            }
            _dbContext.Students.Remove(student);
            await _dbContext.SaveChangesAsync();
            return Ok();
        }



    }
}
