using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    public class EquipmentPropertyDescriptor : PropertyDescriptor
    {
        private Equipment property;

        public EquipmentPropertyDescriptor(Equipment taget, Attribute[] attrs)
               : base(taget.EquipmentClassName, attrs)
        {
            this.property = taget;
        }

        public override Type ComponentType
        {
            get { return null; }
        }

        

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType
        {
            get { return this.property.GetType(); }
        }

        public override string Description
        {
            get
            {
                Equipment equipment = this.property;
                StringBuilder sb = new StringBuilder();
                sb.Append(equipment.EquipmentDiagramPos);
                sb.Append(": ");
                sb.Append(equipment.EquipmentClassName);
                sb.Append("; ");
                sb.Append(equipment.EquipmentPassportType);
                return sb.ToString();
            }
        }

        public override string DisplayName
        {
            get
            {
                Equipment equipment = property;
                return equipment.EquipmentClassName + " " + equipment.EquipmentDiagramPos;
            }
        }

        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override object GetValue(object component)
        {
            return property;
        }

        public override void ResetValue(object component)
        {
            //
        }

        public override void SetValue(object component, object value)
        {
            this.property = (Equipment)value;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
