using E_Library.DTO.Document;
using E_Library.DTO.FunctionDTO;

namespace E_Library.BUS.IBUS
{
    public interface IDocumentBUS
    {
        public List<DocumentDTO> GetAllDocument();

        public bool UpdateApproveDocument(StatusApproveDocumentDTO document, int id);

        public List<DocumentComboboxStatusDTO> GetComboboxStatus();

        public List<DocumentComboboxSubjectDTO> GetComboboxSubject();
        public List<DocumentDTO> FillAndSearchDocument(FillAndSearchDocumentDTO fillAndSearchDocument);
    }
}