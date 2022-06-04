using E_Library.BUS.IBUS;
using E_Library.DTO.Subject;
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

        [HttpGet("ComboboxTeacher")]
        public ActionResult GetComboboxTeacher()
        {
            var result = _subjectBUS.GetComboboxTeacher();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("ComboboxStatus")]
        public ActionResult GetComboboxStatus()
        {
            var result = _subjectBUS.GetComboboxStatus();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("FillAndSearch")]
        public ActionResult FillAndSearchSubject(FillAndSearchSubjectDTO fillSubjectDTO)
        {
            var result = _subjectBUS.FillAndSearchSubject(fillSubjectDTO);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
    }
}