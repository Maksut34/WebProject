using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DTO.Abstract;
using Web_DTO.Data;
using Web_DTO.RepoStory;
using Web_Entity.Models;

namespace Web_DTO.Concreate
{
    public class Image_DAL:RepoStory<Image,DataContext>,IImage_DAL
    {
    }
}
