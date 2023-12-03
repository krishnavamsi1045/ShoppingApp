using CommunityToolkit.Mvvm.ComponentModel;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingApp.Models
{
    public  class Category
    {
        public Category(short id, string name, short parentId,string image )
        {
            Id = id;
            Name = name;
            Image = image;
            ParentId = parentId;
        }

        public short Id { get; set; }
         
        public string Name {  get; set; }
        public string Image {  get; set; }
        public short ParentId { get; set; }
        public bool isMainCategory => ParentId == 0;
    }
}
