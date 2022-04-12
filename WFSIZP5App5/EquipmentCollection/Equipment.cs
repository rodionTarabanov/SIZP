using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace WFSIZP5App5
{
    [TypeConverter(typeof(EquipmentConverter))]
    public class Equipment
    {
        private string equipmentClassName = "";
        private string equipmentPassportType = "";
        private string equipmentDiagramPos = "";
        public Equipment()
        {
        }
        
        [Browsable(true)]
        [Category("Основные сведения")]
        [DisplayName("Вид оборудования")] //
        [Description("Вид оборудования")]
        public string EquipmentClassName
        {
            get { return equipmentClassName; }
            set { equipmentClassName = value; }
        }

        [Browsable(true)]
        [Category("Основные сведения")]
        [DisplayName("Тип оборудования")] //
        [Description("Тип оборудования")]
        public string EquipmentPassportType
        {
            get { return equipmentPassportType; }
            set { equipmentPassportType = value; }
        }

        [Browsable(true)]
        [Category("Основные сведения")]
        [DisplayName("Обозначение на схеме")] //
        [Description("Обозначение на схеме")]
        public string EquipmentDiagramPos
        {
            get { return equipmentDiagramPos; }
            set { equipmentDiagramPos = value; }
        }


    }
}
