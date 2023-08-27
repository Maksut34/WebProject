using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DAL.Abstract;
using Web_DTO.Data;
using Web_DTO.RepoStory;
using Web_Entity.Models;

namespace Web_DAL.Concreate
{
    public class Users_Information_DAL:RepoStory<Users_İnformation,DataContext>,IUsers_Information_DAL
    {
    }
}
