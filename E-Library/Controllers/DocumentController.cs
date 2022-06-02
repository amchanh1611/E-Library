using E_Library.BUS.IBUS;
using E_Library.Common.Enum;
using E_Library.DTO.FunctionDTO;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IDocumentBUS _documentBUS;

        public DocumentController(IDocumentBUS documentBUS)
        {
            _documentBUS = documentBUS;
        }

        [HttpGet]
        public ActionResult GetAllDocument()
        {
            var result = _documentBUS.GetAllDocument();
            if (result != null)
            {
                return Ok(result);
            }
            return BadRequest();
        }

        [HttpPut("{id}")]
        public ActionResult UpdateApproveDocument(StatusApproveDocumentDTO document, int id)
        {

            var check = _documentBUS.UpdateApproveDocument(document, id);
            if (check)
            {
                return Ok();
            }
            return BadRequest("Khong update duoc");
        }
        [HttpGet("ComboboxStatus")]
        public ActionResult GetComboboxStatus()
        {
            var result = _documentBUS.GetComboboxStatus();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("ComboboxSubject")]
        public ActionResult GetComboboxSubject()
        {
            var result = _documentBUS.GetComboboxSubject();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("FillStatus/{Status}")]
        public ActionResult FillDocumentByStatus(StatusApproveDocument status)
        {
            var result = _documentBUS.FillDocumentByStatus(status);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
        [HttpGet("FillSubject/{SubjectName}")]
        public ActionResult FillDocumentBySubject(string? subjectName)
        {
            var result = _documentBUS.FillDocumentBySubject(subjectName);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi Roi");
        }
        [HttpGet("SearchDocument")]
        public ActionResult SearchDocument(SearchSubjectDTO info)
        {
            var result = _documentBUS.SearchDocument(info);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
    }
}