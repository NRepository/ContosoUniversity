﻿namespace ContosoUniversity.Domain.Core.Repository
{
    public interface ISoftDelete
    {
        bool IsDeleted { get; set; }
    }
}