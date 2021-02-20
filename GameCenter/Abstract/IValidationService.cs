using GameCenter.Entitites;
using System;
using System.Collections.Generic;
using System.Text;

namespace GameCenter.Abstract
{
    public interface IValidationService
    {
        bool Validate(Gamer gamer);
    }
}
