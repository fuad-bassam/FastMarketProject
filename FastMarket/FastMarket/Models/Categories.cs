﻿using System.Collections.Generic;

namespace FastMarket.Models
{
    // Categories Model

    public class Categories
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Details { get; set; }

        public  List<CategoriesProduct> categoriesProducts { get; set; }

    }
}
