using StudentOnboarding.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Volo.Abp.Data;
using Volo.Abp.DependencyInjection;
using Volo.Abp.Domain.Repositories;

namespace Acme.StudentOnBoardingAbp.Student
{
    public class DataSeaderContributor : IDataSeedContributor, ITransientDependency
    {
        private readonly IRepository<StudentDetail, Guid> _studentRepository;

        public DataSeaderContributor(IRepository<StudentDetail, Guid> studentRepository)
        {
            _studentRepository = studentRepository;
        }

        public async Task SeedAsync(DataSeedContext context)
        {
            if (await _studentRepository.GetCountAsync() <= 0)
            {
                await _studentRepository.InsertAsync(
                    new StudentDetail
                    {

                        GenerateUID = "A00001",
                        SFirstName = "Nagesh",
                      
                    },
                    autoSave: true
                );

                await _studentRepository.InsertAsync(
                    new StudentDetail
                    {
                        GenerateUID = "A00002",
                        SFirstName = "Shubham",
                        SLastName="Kechale"
                    },
                    autoSave: true
                );
            }
        }
    }
}
