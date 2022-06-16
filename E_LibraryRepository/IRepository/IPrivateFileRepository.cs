using E_Library.DTO.PrivateFile;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IPrivateFileRepository
    {
        public IQueryable<PrivateFile> GetAllPrivateFile();
        public IQueryable<PrivateFile> FillAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch);
        public IQueryable<PrivateFile> GetPrivateFileById(List<int> id);
    }
}