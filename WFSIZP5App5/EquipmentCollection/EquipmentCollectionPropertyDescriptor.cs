using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5
{
    public class EquipmentCollectionPropertyDescriptor : PropertyDescriptor
    {
        private EquipmentCollection collection = null;
        private int index = -1;

        public EquipmentCollectionPropertyDescriptor(EquipmentCollection coll,
                int idx) : base ("#"+idx.ToString(), null)
        {
            this.collection = coll;
            this.index = idx;
        }

        public override AttributeCollection Attributes
        {
            get
            {
                return new AttributeCollection(null);
            }
        }

        public override string Description //(!!!!)
        {
            get
            {
                Equipment equipment = this.collection[index];
                StringBuilder sb = new StringBuilder();
                sb.Append(equipment.EquipmentDiagramPos);
                sb.Append(": ");
                sb.Append(equipment.EquipmentClassName);
                sb.Append(" ");
                sb.Append(equipment.EquipmentPassportType);
                return sb.ToString();
            }
        }
        public override string Name //(!!!!)
        {
            get { return "#" + index.ToString(); }
        }


        public override string DisplayName
        { 
             get
            {
                Equipment equipment = this.collection[index];
                //return emp.FirstName + " " + emp.LastName;
                return equipment.EquipmentClassName + " " + equipment.EquipmentDiagramPos;
            }       
        }

        public override Type ComponentType
        {
            get { return this.collection.GetType(); }
        }

        public override bool IsReadOnly
        {
            get { return true; }
        }

        public override Type PropertyType
        {
            get { return this.collection[index].GetType(); }
        }    
        public override bool CanResetValue(object component)
        {
            return true;
        }

        public override object GetValue(object component)
        {
            return this.collection[index];
        }

        public override void ResetValue(object component)
        {

        }

        public override void SetValue(object component, object value)
        {

        }

        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }

    }


}
