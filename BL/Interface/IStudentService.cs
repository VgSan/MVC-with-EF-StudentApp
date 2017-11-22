using BL.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Interface
{
    public interface IStudentService
    {
        List<StudentDto> GetStudents();
    }
}
