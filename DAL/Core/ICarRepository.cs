﻿using Domain;
using System;
using System.Collections.Generic;

namespace DAL.Core
{
    public interface ICarRepository
    {
        IEnumerable<Car> GetAll();
        Car Get(Guid Id);
        void Insert(Car model);
        void Update(Car model);
        void Delete(Car model);
        void Save();
    }
}