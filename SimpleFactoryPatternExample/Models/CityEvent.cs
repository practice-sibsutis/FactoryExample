using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleFactoryPatternExample.Models
{
    public class CityEvent
    {
        private string imagePath;
        private decimal price;
        private IEnumerable<CategoryEnum> category;

        public required string Header { get; set; }
        public string Description { get; set; }
        public required DateTime DateTime { get; set; }
        public required string Image
        {
            get => imagePath;
            set
            {
                if (Path.IsPathFullyQualified(imagePath) == true)
                {
                    imagePath = value;
                }
                else
                {
                    imagePath = "/Assets/avalonia-logo.ico";
                }
            }
        }
        public required decimal Price
        {
            get => price;
            set
            {
                if (value >= 0)
                {
                    price = value;
                }
            }
        }

        public required IEnumerable<CategoryEnum> Category
        {
            get => category;
            set
            {
                if(value == null || value.Count() == 0)
                {
                    category = new List<CategoryEnum>();
                    category.Append(CategoryEnum.Other);
                    
                }
                category = value;
            }
        }

        public enum CategoryEnum
        {
            ForChildren,
            Sport,
            Culture,
            Tours,
            LifeStyle,
            Education,
            Online,
            Show,
            Party,
            Other
        };

    }
}
