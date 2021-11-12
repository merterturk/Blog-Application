using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BlogApp.Entities.Concrete;
using BlogApp.Shared.Utilities.Results.Abstract;

namespace BlogApp.Services.Abstract
{
    public interface IMailService
    {
        IResult Send(EmailSendDto emailSendDto);
        IResult SendContactEmail(EmailSendDto emailSendDto);
    }
}
