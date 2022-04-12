using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    internal class EquipmentProperty
    {
        // сюда влепить конструктор с параметром ссылкой на строку DataBinder
        public string Name { get; set; }
        public object Value { get; set; }
        public string DisplayName { get; set; }
        public string Description { get; set; }
        public string Category { get; set; }
    }
}
