using Photogram.Interface;

namespace Photogram.Service
{
    public class PostService : IPost
    {
        private readonly PhotogramDB _context;

        public PostService(PhotogramDB context)
        {
            this._context = context;
        }

        public async Task CreatePostAsync()
        {
            await _context.SaveChangesAsync();
        }
    }
}
