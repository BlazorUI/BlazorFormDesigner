﻿using System;
using System.Collections.Generic;
using System.Text;

namespace BlazorFormDesigner.Database.Settings
{
    public class DatabaseSettings
    {
        public string ConnectionString { get; set; } = "mongodb://localhost:27017";
        public string DatabaseName { get; set; } = "FormDesignerDatabase";
        public string UsersCollectionName { get; set; } = "Users";

        public string FormsCollectionName { get; set; } = "Forms";
    }
}
