using E_Library.BUS.IBUS;
using E_Library.DTO;
using E_Library.DTO.FunctionDTO;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SubjectController : ControllerBase
    {
        private readonly ISubjectBUS _subjectBUS;

        public SubjectController(ISubjectBUS subjectBUS)
        {
            _subjectBUS = subjectBUS;
        }

        [HttpPost]
        public ActionResult CreateSubject(SubjectDTO subjectDTO)
        {
            var result = _subjectBUS.CreateSubject(subjectDTO);
            if (result)
            {
                return Ok();
            }
            return BadRequest("Khong them duoc");
        }

        [HttpGet]
        public ActionResult GetAllSubject()
        {
            var result = _subjectBUS.GetAllSubject();
            if (result.Any())
            {
                return Ok(result);
            }
            return BadRequest("Khong co mon hoc");
        }
        [HttpGet("ComboboxSubject")]
        public ActionResult GetComboboxSubject()
        {
            var result = _subjectBUS.GetComboboxSubject();
            if (result.Any())
            {
                return Ok(result);
            }
            return BadRequest("Loi roi");
        }
        [HttpGet("FillSubject/{id}")]
        public ActionResult FillSubjectSelected(int id)
        {
            var subject = _subjectBUS.FillSubjectBySubjectSelected(id);
            if(subject != null)
            {
                return Ok(subject);
            }
            return BadRequest("Loi roi");
        }
        [HttpGet("Search")]
        public ActionResult SearchSubject(SearchSubjectDTO searchSubjectDTO)
        {
            var result = _subjectBUS.SearchSubject(searchSubjectDTO);
            if(result.Any())
                return Ok(result);
            return BadRequest("Khong search duoc");
        }
        [HttpGet("ComboboxTeacher")]
        public ActionResult GetComboboxTeacher()
        {
            var result = _subjectBUS.GetComboboxTeacher();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("FillTeacher/{TeacherName}")]
        public ActionResult FillSubjectByTeacherSelected(string? teacherName)
        {
            var subject = _subjectBUS.FillSubjectByTeacherSelected(teacherName);
            if(subject != null)
                return Ok(subject);
            return BadRequest("loi roi");
        }
        [HttpGet("ComboboxStatus")]
        public ActionResult GetComboboxStatus()
        {
            var result = _subjectBUS.GetComboboxStatus();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("FillStatus/{Status}")]
        public ActionResult FillSubjectByStatusSelected(bool? status)
        {
            var subject = _subjectBUS.FillSubjectByStatusSelected(status);
            if (subject != null)
                return Ok(subject);
            return BadRequest("loi roi");
        }
    }
}