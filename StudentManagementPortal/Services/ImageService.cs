using Microsoft.AspNetCore.Mvc;
using StudentManagementPortal.Models.Domain;
using StudentManagementPortal.Models.DTOs;
using StudentManagementPortal.Repositories;
using StudentManagementPortal.Repositories.Interfaces;
using StudentManagementPortal.Services.Interfaces;
using System.Net;

namespace StudentManagementPortal.Services
{
    public class ImageService : IImageService
    {
        private readonly IImageRepository imageRepository;

        public ImageService(IImageRepository imageRepository)
        {
            this.imageRepository = imageRepository;
        }
        public async Task<Image?> GetByStudentIdAsync(int studentId)
        {
            var image = await imageRepository.GetByStudentIdAsync(studentId);
            if (image == null)
            {
                throw new BadHttpRequestException($"Image not found for {studentId} StudentId!!");
            }
            return image;

        }
    }
}
