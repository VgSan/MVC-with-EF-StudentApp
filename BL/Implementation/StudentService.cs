using AutoMapper;
using BL.Dto;
using BL.Interface;
using DL.Entity;
using DL.IRepository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL.Implementation
{
    public class StudentService : IStudentService
    {
        IRepository<Student> _studentRepository;

        public StudentService(
            IRepository<Student> studentRepository)
        {
            _studentRepository = studentRepository;
        }


        public List<StudentDto> GetStudents()
        {
            List<Student> stuList = _studentRepository.GetAll().ToList();
            var result = Mapper.Map<List<Student>, List<StudentDto>>(stuList);

            return result;
        }
    }
}
