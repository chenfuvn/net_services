using PlatformService.Models;

namespace PlatformService.Data
{
    public class PlatformRepo : IPlatformRepo
    {
        private readonly AppDbContext _ctx;

        public PlatformRepo(AppDbContext ctx)
        {
            this._ctx = ctx;
        }
        public void CreatePlatform(Platform platform)
        {
            if (platform == null)
                throw new ArgumentNullException(nameof(platform));
            this._ctx.Platforms.Add(platform);
        }

        public IEnumerable<Platform> GetAllPlatforms()
        {
            return this._ctx.Platforms.AsEnumerable();
        }

        public Platform GetPlatformById(int id)
        {
            return this._ctx.Platforms.FirstOrDefault(c => c.Id == id)!;
        }

        public bool SaveChanges()
        {
            return this._ctx.SaveChanges() >= 0;
        }
    }
}