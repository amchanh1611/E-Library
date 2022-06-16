using E_Library.DTO.PrivateFile;
using E_Library.Models;
using E_Library.Repository.IRepository;

namespace E_Library.Repository.Repository
{
    public class PrivateFileRepository : IPrivateFileRepository
    {
        private readonly E_LibraryDbContext _context;

        public PrivateFileRepository(E_LibraryDbContext context)
        {
            _context = context;
        }

        public IQueryable<PrivateFile> FillAndSearchPrivateFile(FillAndSearchPrivateFileDTO fillAndSearch)
        {
            IQueryable<PrivateFile> query = _context.PrivateFiles;
            if (fillAndSearch.PrivateFileType != null)
                query = query.Where(w => w.PrivateFileType == fillAndSearch.PrivateFileType);
            if (fillAndSearch.InfoSearch != null)
                query = query.Where(w => w.PrivateFileName.Contains(fillAndSearch.InfoSearch));
            return query;
        }

        public IQueryable<PrivateFile> GetAllPrivateFile()
        {
            return _context.PrivateFiles;
        }

        public IQueryable<PrivateFile> GetPrivateFileById(List<int> lstId)
        {
            IQueryable<PrivateFile> query = _context.PrivateFiles.Where(x => lstId.Contains(x.PrivateFileId));

            return query;
        }
    }
}