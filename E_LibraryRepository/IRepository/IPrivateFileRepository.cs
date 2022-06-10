using E_Library.DTO.PrivateFile;
using E_Library.Models;

namespace E_Library.Repository.IRepository
{
    public interface IPrivateFileRepository
    {
        public IQueryable<PrivateFiles> GetAllPrivateFile();
        public IQueryable<PrivateFiles> FillAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch);
        public IQueryable<PrivateFiles> GetPrivateFileById(List<int> id);
    }
}