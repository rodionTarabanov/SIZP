using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WFSIZP5App5.EquipmentClass
{
    [TypeConverter(typeof(EquipmentConverter))]
    public class Equipment
    {
        private string _equipmentClassName = "";
        private string _equipmentPassportType = "";
        private string _equipmentDiagramPos = "";
        public Equipment()
        {
        }

        [Browsable(true)]
        [Category("Основные сведения")]
        //[DisplayName("Вид оборудования")] //
        //[Description("Вид оборудования")]
        public string EquipmentClassName
        {
            get { return _equipmentClassName; }
            set { _equipmentClassName = value; }
        }

        [Browsable(true)]
        [Category("Основные сведения")]
        //[DisplayName("Тип оборудования")] //
        //[Description("Тип оборудования")]
        public string EquipmentPassportType
        {
            get { return _equipmentPassportType; }
            set { _equipmentPassportType = value; }
        }

        [Browsable(true)]
        [Category("Основные сведения")]
        //[DisplayName("Обозначение на схеме")] //
        //[Description("Обозначение на схеме")]

        public string EquipmentDiagramPos
        {
            get { return _equipmentDiagramPos; }
            set { _equipmentDiagramPos = value; }
        }

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(this.EquipmentClassName);
            sb.Append(",");
            sb.Append(this.EquipmentPassportType);
            sb.Append(",");
            sb.Append(this.EquipmentDiagramPos);
            return base.ToString();
        }

    }
}
