using BlogApp.Entities.ComplexTypes;
using BlogApp.Entities.Dtos.ImageDto;
using BlogApp.Shared.Utilities.Results.Abstract;
using Microsoft.AspNetCore.Http;

namespace BlogApp.Web.Helpers.Abstract
{
    public interface IImageHelper
    {
        string Upload(string name, IFormFile pictureFile, PictureType pictureType, string folderName = null);
        IDataResult<ImageDeletedDto> Delete(string pictureName);
    }
}
