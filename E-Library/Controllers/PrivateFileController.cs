using E_Library.BUS.IBUS;
using E_Library.DTO.PrivateFile;
using Microsoft.AspNetCore.Mvc;

namespace E_Library.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PrivateFileController : ControllerBase
    {
        private readonly IPrivateFileBUS _privateFileBUS;

        public PrivateFileController(IPrivateFileBUS privateFileBUS)
        {
            _privateFileBUS = privateFileBUS;
        }

        [HttpGet]
        public ActionResult GetAllPrivateFile()
        {
            var result = _privateFileBUS.GetAllPrivateFile();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("ComboboxType")]
        public ActionResult GetComboboxType()
        {
            var result = _privateFileBUS.GetComboboxType();
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("FillAndSearch")]
        public ActionResult FilAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch)
        {
            var result = _privateFileBUS.FillAndSearchPrivateFile(fillAndSearch);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }

        [HttpGet("UploadPrivateFile")]
        public ActionResult UploadPrivateFile(ListPrivateFileUploadDTO lstUpload)
        {
            var result = _privateFileBUS.UploadPrivateFile(lstUpload);
            if (result.Any())
                return Ok(result);
            return BadRequest("Loi roi");
        }
    }
}