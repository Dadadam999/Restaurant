using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant
{
    [Serializable]
    public class Waiter
    {
        public Guid Id { get; }
        public Bitmap Photo { get; set; } = new Bitmap(Properties.Resources.images);
        public string FrirstName { get; set; }
        public string LastName { get; set; }
        public string Patronymic { get; set; }
        public int Old { get; set; }
        public string Sex { get; set; }
        public Decimal StaticWage { get; set; } = 0;
        public Decimal Tips { get; set; } = 0;
        public Decimal CurrentWage { get { return StaticWage + Tips; } }
        public string Sheclude { get; set; }
        public string Post { get; set; }

        public Waiter()
        { 
         Id = Guid.NewGuid();
        }
    }
}
