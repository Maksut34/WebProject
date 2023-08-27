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
    public class AddStory_DAL:RepoStory<AddStory,DataContext>,IAddStory_DAL
    {
    }
}
