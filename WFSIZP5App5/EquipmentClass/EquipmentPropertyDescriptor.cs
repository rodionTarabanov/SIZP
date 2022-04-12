using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    internal class EquipmentPropertyDescriptor : PropertyDescriptor
    {
        object Equipment;
        EquipmentProperty p;
        internal EquipmentPropertyDescriptor(object owner, EquipmentProperty property)
            : base(property.Name, null) { Equipment = owner; p = property; }
        public override Type PropertyType => p.Value?.GetType() ?? typeof(object);
        public override void SetValue(object c, object v) => p.Value = v;
        public override object GetValue(object c) => p.Value;
        public override bool IsReadOnly => false;
        public override Type ComponentType => Equipment.GetType();
        public override bool CanResetValue(object c) => false;
        public override void ResetValue(object c) { }
        public override bool ShouldSerializeValue(object c) => false;
        public override string DisplayName => p.DisplayName ?? base.DisplayName;
        public override string Description => p.Description ?? base.Description;
        public override string Category => p.Category ?? base.Category;

    }
}
