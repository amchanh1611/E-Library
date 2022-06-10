using E_Library.BUS.IBUS;
using E_Library.DTO.PrivateFile;
using E_Library.Models;
using E_Library.Repository.IRepository;

namespace E_Library.BUS.BUS
{
    public class PrivateFileBUS :IPrivateFileBUS
    {
        private readonly IPrivateFileRepository _privateFileRepository;
        public PrivateFileBUS(IPrivateFileRepository privateFileRepository)
        {
            _privateFileRepository = privateFileRepository;
        }

        public List<PrivateFileDTO> FillAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch)
        {
            var privateFiles = _privateFileRepository.FillAndSearchPrivateFile(fillAndSearch);
            var result = privateFiles.Select(s => new PrivateFileDTO { PrivateFileType = s.PrivateFileType, PrivateFileName = s.PrivateFileName, Editor = s.Editor, LastDateEdit = s.LastDateEdit, Size = s.Size }).ToList();
            return result;
        }

        public List<PrivateFileDTO> GetAllPrivateFile()
        {
            var privateFile = _privateFileRepository.GetAllPrivateFile();
            var result = privateFile.Select(s=> new PrivateFileDTO { PrivateFileType=s.PrivateFileType, PrivateFileName=s.PrivateFileName,Editor=s.Editor,LastDateEdit=s.LastDateEdit,Size=s.Size }).ToList();
            return result;
        }

        public List<PrivateFileComboboxTypeDTO> GetComboboxType()
        {
            var privateFiles = _privateFileRepository.GetAllPrivateFile();
            var comboboxtype = privateFiles.Select(s => new PrivateFileComboboxTypeDTO { PrivateFileType = s.PrivateFileType }).Distinct().ToList();
            return comboboxtype;
        }

        public List<PrivateFileUploadedDTO> UploadPrivateFile(ListPrivateFileUploadDTO lstUpload)
        {
            List<PrivateFileUploadedDTO> result = new List<PrivateFileUploadedDTO>();
            //foreach(var id in lstUpload.PrivateFileId)
            //{
            //    var privateFile = _privateFileRepository.GetPrivateFileById(id);
            //    result.Add(new PrivateFileUploadedDTO { PrivateFileType = privateFile.PrivateFileType, PrivateFileName = privateFile.PrivateFileName, Size = privateFile.Size });
            //}
            //var privateFiles = _privateFileRepository.GetAllPrivateFile().ToList();
            //foreach (var id in lstUpload.PrivateFileId)
            //{
            //    foreach (var privateFile in privateFiles)
            //    {
            //        if(privateFile.PrivateFileId==id)
            //        {
            //            result.Add(new PrivateFileUploadedDTO { PrivateFileType = privateFile.PrivateFileType, PrivateFileName = privateFile.PrivateFileName, Size = privateFile.Size });
            //        }
            //    }

            //}
            //List<IQueryable<PrivateFiles>> privateFiles = new List<IQueryable<PrivateFiles>>();

            //foreach (var id in lstUpload.PrivateFileId)
            //{
            //    var privateFile = _privateFileRepository.GetPrivateFileById(id);
            //    privateFiles.Add(privateFile);
            //}
            //List<PrivateFiles> lstPrivateFile=privateFiles.ToList();
            //foreach (var privateFile in lstPrivateFile)
            //{
            //    result.Add(privateFile);
            //}
            var privateFiles = _privateFileRepository.GetPrivateFileById(lstUpload.PrivateFileId);
            return privateFiles.Select(s => new PrivateFileUploadedDTO { PrivateFileType = s.PrivateFileType, PrivateFileName = s.PrivateFileName, Size = s.Size }).ToList();
             
        }
    }
}