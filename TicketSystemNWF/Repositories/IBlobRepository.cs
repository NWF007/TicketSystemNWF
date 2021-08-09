using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TicketSystemNWF.Models;

namespace TicketSystemNWF.Repositories
{
    public interface IBlobRepository
    {
        Task<BlobInfo> GetBlobAsync(string name);
        Task<IEnumerable<string>> ListOfBlobsAsync();
        Task UploadFileBlobAsync(string filePath, string fileName);
        Task UploadContentBlobAsync(string content, string fileName);
        Task DeleteBlobAsync(string blobName);
    }
}
