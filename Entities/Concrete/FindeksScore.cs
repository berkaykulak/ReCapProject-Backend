﻿using Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entities.Concrete
{
    public class FindeksScore : IEntity
    {
        public int Id { get; set; }
        public int CustomerId { get; set; }
        public string NationalIdentity { get; set; }
        public int Score { get; set; }
    }
}