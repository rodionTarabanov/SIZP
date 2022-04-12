using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    internal class Equipment : ICustomTypeDescriptor
    {

        public List<EquipmentProperty> EquipmentProperties { get; set; }



        #region ICustomTypeDescriptor
        public AttributeCollection GetAttributes() => TypeDescriptor.GetAttributes(this, true);
        public string GetClassName() => TypeDescriptor.GetClassName(this, true);
        public string GetComponentName() => TypeDescriptor.GetComponentName(this, true);
        public TypeConverter GetConverter() => TypeDescriptor.GetConverter(this, true);
        public EventDescriptor GetDefaultEvent() => TypeDescriptor.GetDefaultEvent(this, true);
        public PropertyDescriptor GetDefaultProperty()
            => TypeDescriptor.GetDefaultProperty(this, true);
        public object GetEditor(Type editorBaseType)
            => TypeDescriptor.GetEditor(this, editorBaseType, true);
        public EventDescriptorCollection GetEvents() => TypeDescriptor.GetEvents(this, true);
        public EventDescriptorCollection GetEvents(Attribute[] attributes)
            => TypeDescriptor.GetEvents(this, attributes, true);
        public PropertyDescriptorCollection GetProperties() => GetProperties(new Attribute[] { });
        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            var properties = TypeDescriptor.GetProperties(this, attributes, true)
                .Cast<PropertyDescriptor>()
                .Where(p => p.Name != nameof(this.EquipmentProperties))
                .Select(p => TypeDescriptor.CreateProperty(this.GetType(), p,
                    p.Attributes.Cast<Attribute>().ToArray())).ToList();
            properties.AddRange(EquipmentProperties.Select(x => new EquipmentPropertyDescriptor(this, x)));
            return new PropertyDescriptorCollection(properties.ToArray());
        }
        public object GetPropertyOwner(PropertyDescriptor pd) => this;
        #endregion
    }
}
