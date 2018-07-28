﻿namespace RapidNote.Models.Abstract
{
    public abstract class BaseModel
    {
        public int Id { get; set; }
        public abstract string GetKeyName();
    }
}