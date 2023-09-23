﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template.API.Core.Services.Generic
{
    public interface ISoftDelete
    {
        public bool IsDeleted { get; set; }

        public void Undo()
        {
            IsDeleted = false;
        }
    }
}
