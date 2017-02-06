﻿using System;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;

namespace IT.Models
{
    public class Item : Brand //Should it be like this or ...?
    {

        public int itemID { get; set; }
        [Display(Name = "Item Name")]
        public string itemName { get; set; }

    }

    public class ItemDBContext : DbContext
    {
        public DbSet<Item> Items { get; set; }
    }

}