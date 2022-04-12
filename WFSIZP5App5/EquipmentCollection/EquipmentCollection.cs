using System.Text;
using System.Reflection;
using System.Collections;
using System.ComponentModel;
using System.Runtime.InteropServices;
using System;

namespace WFSIZP5App5
{
    public class EquipmentCollection : CollectionBase, ICustomTypeDescriptor
    {
        #region Collection impl
        public void Add(Equipment equipment)
        {
            this.List.Add(equipment);
        }

        public void Remove(Equipment equipment)
        {
            this.List.Remove(equipment);
        }

        public Equipment this[int index]
        {
            get { return (Equipment)this[index]; }
        }

        #endregion

        #region ICustomTypeDescriptor impl 
        //
        public AttributeCollection GetAttributes()
        {
            return TypeDescriptor.GetAttributes(this, true);
        }

        //
        public string GetClassName()
        {
            return TypeDescriptor.GetClassName(this, true);
        }

        //
        public string GetComponentName()
        {
            return TypeDescriptor.GetComponentName(this, true);
        }

        public System.ComponentModel.TypeConverter GetConverter()
        {
            return TypeDescriptor.GetConverter(this, true);
        }

        public EventDescriptor GetDefaultEvent()
        {
            return TypeDescriptor.GetDefaultEvent(this, true);
        }

        public PropertyDescriptor GetDefaultProperty()
        {
            return TypeDescriptor.GetDefaultProperty(this, true);
        }

        public object GetEditor(Type editorBaseType)
        {
            return TypeDescriptor.GetEditor(this, editorBaseType, true);
        }

        public EventDescriptorCollection GetEvents()
        {
            throw new NotImplementedException();
        }

        public EventDescriptorCollection GetEvents(Attribute[] attributes)
        {
            return TypeDescriptor.GetEvents(this, attributes, true);
        }


        //*****************************************************************
        public PropertyDescriptorCollection GetProperties()
        {
            PropertyDescriptorCollection pds = new PropertyDescriptorCollection(null);
            for (int i = 0; i < this.List.Count; i++)
            {
                EquipmentCollectionPropertyDescriptor pd = new
                              EquipmentCollectionPropertyDescriptor(this, i);
                pds.Add(pd);
            }
            return pds;
        }

        public PropertyDescriptorCollection GetProperties(Attribute[] attributes)
        {
            return GetProperties();
        }
        //*****************************************************************
        public object GetPropertyOwner(PropertyDescriptor pd)
        {
            return this;
        }

        #endregion
    }
}
