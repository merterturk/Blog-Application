using BlogApp.Entities.ComplexTypes;
using BlogApp.Entities.Dtos.ImageDto;
using BlogApp.Shared.Utilities.Extensions;
using BlogApp.Shared.Utilities.Results.Abstract;
using BlogApp.Shared.Utilities.Results.ComplexTypes;
using BlogApp.Shared.Utilities.Results.Concrete;
using BlogApp.Web.Helpers.Abstract;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using System;
using System.IO;
using System.Text.RegularExpressions;

namespace BlogApp.Web.Helpers.Concrete
{
    public class ImageHelper : IImageHelper
    {
        private readonly IWebHostEnvironment _env;
        private readonly string _wwwroot;
        private const string imgFolder = "img";
        private const string userImagesFolder = "userImages";
        private const string postImagesFolder = "postImages";
        public ImageHelper(IWebHostEnvironment env)
        {
            _env = env;
            _wwwroot = _env.WebRootPath;
        }
        public string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null)
        {
            folderName ??= pictureType == PictureType.User ? userImagesFolder : postImagesFolder;
            if (!Directory.Exists($"{_wwwroot}/{imgFolder}/{folderName}"))
            {
                Directory.CreateDirectory($"{_wwwroot}/{imgFolder}/{folderName}");
            }
            string oldFileName = Path.GetFileNameWithoutExtension(pictureFile.FileName);
            string fileExtension = Path.GetExtension(pictureFile.FileName);
            DateTime dateTime = DateTime.Now;

            Regex regex = new Regex("[*'\",._&#^@]");
            name = regex.Replace(name,String.Empty);
            string newFileName = $"{name}_{dateTime.FullDateAndTimeStringWithUnderscore()}{fileExtension}";
            var path = Path.Combine($"{_wwwroot}/{imgFolder}/{folderName}", newFileName);
            using (var stream = new FileStream(path, FileMode.Create))
            {
                 pictureFile.CopyToAsync(stream);
            }

            string message = pictureType == PictureType.User
                ? $"{name} adlı kullanıcının resimi başarıyla yüklenmiştir."
                : $"{name} adlı makalenin resimi başarıyla yüklenmiştir.";

            return $"{folderName}/{newFileName}";
        }

        public IDataResult<ImageDeletedDto> Delete(string pictureName)
        {
            var fileToDelete = Path.Combine($"{_wwwroot}/{imgFolder}/", pictureName);
            if (System.IO.File.Exists(fileToDelete))
            {
                var fileInfo = new FileInfo(fileToDelete);
                var imageDeletedDto = new ImageDeletedDto()
                {
                    FullName = pictureName,
                    Extension = fileInfo.Extension,
                    Path = fileInfo.FullName,
                    Size = fileInfo.Length
                };
                System.IO.File.Delete(fileToDelete);
                return new DataResult<ImageDeletedDto>(ResultStatus.Success, imageDeletedDto);
            }
            else
            {
                return new DataResult<ImageDeletedDto>(ResultStatus.Error, $"Böyle bir resim bulunamadı", null);
            }
        }
    }
}
