﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Trabalho.Models
{
    public interface IQuestionRepository
    {
            IEnumerable<Question> Question { get; }
    }
}
