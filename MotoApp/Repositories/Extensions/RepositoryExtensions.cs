﻿namespace MotoApp.Repositories.Extensions;
using MotoApp.Entities;
using MotoApp.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



public static class RepositoryExtensions
{
    public static void AddBatch<T>(this IRepository<T> repository, T[] items) where T : class, IEntity
    {
        foreach (var item in items)
        {
            repository.Add(item);

        }
        repository.Save();
    }
}


