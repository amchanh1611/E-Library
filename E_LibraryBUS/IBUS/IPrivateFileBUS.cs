using E_Library.DTO.PrivateFile;

namespace E_Library.BUS.IBUS
{
    public interface IPrivateFileBUS
    {
        public List<PrivateFileDTO> GetAllPrivateFile();
        public List<PrivateFileComboboxTypeDTO> GetComboboxType();
        public List<PrivateFileDTO> FillAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch);
        public List<PrivateFileUploadedDTO> UploadPrivateFile(ListPrivateFileUploadDTO lstUpload);
    }
}