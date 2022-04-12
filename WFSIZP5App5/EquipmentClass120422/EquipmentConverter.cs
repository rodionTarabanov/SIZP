using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    internal class EquipmentConverter : ExpandableObjectConverter
    {
        public override object ConvertTo(ITypeDescriptorContext context, CultureInfo culture, object value, Type destinationType)
        {
            if (destinationType == typeof(string) && value is Equipment)
            {
                Equipment e = (Equipment)value;
                return e.EquipmentClassName + " - " + e.EquipmentDiagramPos;
            }
            return base.ConvertTo(context, culture, value, destinationType);
        }
    }
}
