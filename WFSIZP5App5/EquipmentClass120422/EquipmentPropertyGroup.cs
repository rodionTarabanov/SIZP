using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    public class EquipmentPropertyGroup : ICustomTypeDescriptor
    {
        public List<Equipment> equipmentProperties { get; set; }
        public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);
        public string GetClassName() =>TypeDescriptor.GetClassName(this, true);
        public string GetComponentName() =>TypeDescriptor.GetComponentName(this, true);
        public TypeConverter GetConverter() =>TypeDescriptor.GetConverter(this, true);
        public EventDescriptor GetDefaultEvent() =>TypeDescriptor.GetDefaultEvent(this, true);
        public PropertyDescriptor GetDefaultProperty() => TypeDescriptor.GetDefaultProperty(this, true);
        public object GetEditor(Type editorBaseType) => TypeDescriptor.GetEditor(this, editorBaseType, true);
        public EventDescriptorCollection GetEvents() =>TypeDescriptor.GetEvents(this, true);
        public EventDescriptorCollection GetEvents(Attribute[] attributes) =>TypeDescriptor.GetEvents(this, true);
        public PropertyDescriptorCollection GetProperties() => this.GetProperties(new Attribute[] { });
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            PropertyDescriptor[] pds = new PropertyDescriptor[this.equipmentProperties.Count];

            int i = 0;
            foreach (Equipment e in this.equipmentProperties)
            {
                pds[i] = new EquipmentPropertyDescriptor(e, attributes);
                i++;
            }
            return new PropertyDescriptorCollection(pds);

        }
        public object GetPropertyOwner(PropertyDescriptor pd) => this.equipmentProperties;
        
    }
}
