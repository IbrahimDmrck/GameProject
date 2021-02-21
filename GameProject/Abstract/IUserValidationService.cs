using GameProject.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameProject.Abstract
{
    interface IUserValidationService
    {
        bool validate(Gamer gamer);
    }
}
