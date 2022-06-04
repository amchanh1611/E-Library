using E_Library.BUS.IBUS;
using E_Library.DTO.Document;
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

        [HttpGet("FillAndSearch")]
        public ActionResult FillAndSearchDocument(FillAndSearchDocumentDTO fillAndSearchDocumnet)
        {
            var result = _documentBUS.FillAndSearchDocument(fillAndSearchDocumnet);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
    }
}