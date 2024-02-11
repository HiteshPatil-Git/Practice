using Microsoft.EntityFrameworkCore;
using StudentManagementPortal.Data;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Repositories.Interfaces;

namespace StudentManagementPortal.Repositories
{
    public class ImageRepository : IImageRepository
    {
        private readonly StudentPortalDbContext dbContext;

        public ImageRepository(StudentPortalDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<Image?> GetByIdAsync(int id)
        {
            return await dbContext.Images.FindAsync(id);
        }

        public async Task<Image?> GetByStudentIdAsync(int studentId)
        {
            return await dbContext.Images.FirstOrDefaultAsync(i => i.StudentId == studentId);
        }

        public async Task<Image?> UploadAsync(IFormFile file, int studentId)
        {
            var image = new Image()
            {
                Name = file.FileName,
                StudentId = studentId,
            };
            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                image.Data = memoryStream.ToArray();
            }
            await dbContext.Images.AddAsync(image);
            await dbContext.SaveChangesAsync();
            return image;
        }
        public async Task<Image?> UpdateAsync(IFormFile file, int studentId)
        {
            var image = await dbContext.Images.FirstOrDefaultAsync(i => i.StudentId == studentId);

            image.Name = file.FileName;
            image.StudentId = studentId;


            using (var memoryStream = new MemoryStream())
            {
                await file.CopyToAsync(memoryStream);
                image.Data = memoryStream.ToArray();
            }

            await dbContext.SaveChangesAsync();
            return image;
        }


    }
}
