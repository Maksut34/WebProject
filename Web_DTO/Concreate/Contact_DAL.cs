using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Web_DAL.Abstract;
using Web_DTO.Data;
using Web_Entity.Models;
using Web_DTO.RepoStory;

namespace Web_DAL.Concreate
{
    public class Contact_DAL:RepoStory<Contact,DataContext>,IContact_DAL
    {
    }
}
