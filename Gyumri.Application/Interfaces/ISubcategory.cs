﻿using Gyumri.Common.ViewModel.Subcategory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gyumri.Application.Interfaces
{
    public interface ISubcategory
    {
        public Task<bool> AddSubcategory(AddSubcategoryViewModel model);
    }
}