using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WFSIZP5App5
{
    internal class EquipmentConverter : ExpandableObjectConverter
    {
		public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
		{
			if (destType == typeof(string) && value is Equipment)
			{
				Equipment equipment = (Equipment)value;

				// Return department and department role separated by comma.
				return equipment.EquipmentClassName + " " + equipment.EquipmentDiagramPos;
			}
			return base.ConvertTo(context, culture, value, destType);
		}

	}

    //internal class EquipmentCollectionConverter : ExpandableObjectConverter
    //{
    //    public override object ConvertTo(ITypeDescriptorContext context, System.Globalization.CultureInfo culture, object value, Type destType)
    //    {
    //        if (destType == typeof(string) && value is EquipmentCollection)
    //        {
    //            // Return department and department role separated by comma.
    //            return "Данные по оборудованию";
    //        }
    //        return base.ConvertTo(context, culture, value, destType);
    //    }
    //}
}
