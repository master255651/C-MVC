﻿using BookStore.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BookStore.Interfaces
{
    public interface IReview
    {
        IEnumerable<Review> Reviews { get; }
    }
}
