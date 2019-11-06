using CourseG3;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentGeo1.Controllers
{
    [ApiController]
    public class StudentController : ControllerBase
    {
        public static List<Student> student = new List<Student>();
        public static List<Courses> courses = new List<Courses>();

        // GET: api/Student
        [HttpGet("api/Student")]
        public IActionResult GetStudent()
        {
            return Ok(student);
        }

        // GET: api/Course
        [HttpGet("api/Course")]
        public IActionResult GetCourse()
        {
            var courseList = student.GroupBy(x => x.Course).Select(x => new { x.Key, count = x.Count() });
            return Ok(courseList);
        }

        // GET: api/Student/5
        [HttpGet("api/Student/{id}")]
        public IActionResult GetStudentById(int id)
        {
            var checkId = student.SingleOrDefault(x => x.Id == id);
            if (checkId == null)
            {
                return NotFound();
            }
            return Ok(checkId);
        }

        // GET: api/Course/5
        [HttpGet("api/Cousre/{id}")]
        public IActionResult GetCourseById(int id)
        {
            var checkId = courses.SingleOrDefault(x => x.courseId == id);
            if (checkId == null)
            {
                return NotFound();
            }
            return Ok(checkId);
        }

        // POST: api/Student
        [HttpPost("api/Student")]
        public IActionResult CreateStud(Student student2)
        {
            int id;
            bool flag = false;
            var lastStudent = student.OrderBy(x => x.Id).LastOrDefault();
            id = lastStudent == null ? 1 : lastStudent.Id + 1;
            foreach (var course in courses)
            {
                if (student2.Course == course.courseName)
                {
                    flag = true;
                }

            }
            if (flag == false)
            {
                return Conflict("Course is not in the list");
            }

            if (Convert.ToDateTime(student2.Dob) > DateTime.Now)
            {
                return Conflict("Enter a valid date");
            }
            if (Convert.ToDateTime(student2.EnrollmentDate) > DateTime.Now)
            {
                return Conflict("Enter a valid date");
            }

            var GiveStudentDetails = new Student
            {
                Id = id,
                FirstName = student2.FirstName,
                LastName = student2.LastName,
                Dob = student2.Dob,
                Address = student2.Address,
                PhoneNumber = student2.PhoneNumber,
                Course = student2.Course,
                EnrollmentDate = student2.EnrollmentDate
            };
            student.Add(GiveStudentDetails);
            return Ok(GiveStudentDetails.Id);
        }

        [HttpPost("api/Course")]
        public IActionResult CreateCourse(Courses course)
        {
            var new_course = courses.OrderByDescending(x => x.courseId).FirstOrDefault();
            int id = new_course == null ? 1 : new_course.courseId + 1;
            var details_to_be_added = new Courses
            {
                courseId = id,
                courseName = course.courseName,
            };
            courses.Add(details_to_be_added);
            return Ok(details_to_be_added);
        }

        // PUT: api/Student/5
        [HttpPut("api/Student/{id}")]
        public IActionResult PutStudent(int id, Student student1)
        {
            var checkId = student.SingleOrDefault (x => x.Id == id);
            if (checkId == null)
            {
                return NotFound();
            }
            checkId.FirstName = student1.FirstName;
            checkId.LastName = student1.LastName;
            checkId.Dob = student1.Dob;
            checkId.Address = student1.Address;
            checkId.PhoneNumber = student1.PhoneNumber;
            checkId.Course = student1.Course;
            checkId.EnrollmentDate = student1.EnrollmentDate;
            return Ok(checkId);

        }

        // PUT: api/Course/5
        [HttpPut("api/Course/{id}")]
        public IActionResult PutCourse(int id, Courses course1)
        {
            var checkId = courses.SingleOrDefault(x => x.courseId == id);
            if (checkId == null)
            {
                return NotFound();
            }
            checkId.courseName = course1.courseName;
            return Ok(checkId);

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("api/Student/{id}")]
        public IActionResult DeleteStudent(int id)
        {
            var checkId = student.SingleOrDefault(x => x.Id == id);
            if (checkId == null)
            {
                return NotFound();
            }
            student.Remove(checkId);

            return Ok();

        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("api/Course/{id}")]
        public IActionResult DeleteCourse(int id)
        {
            var checkId = courses.SingleOrDefault(x => x.courseId == id);
            if (checkId == null)
            {
                return NotFound();
            }
            courses.Remove(checkId);

            return Ok();

        }
    }
}