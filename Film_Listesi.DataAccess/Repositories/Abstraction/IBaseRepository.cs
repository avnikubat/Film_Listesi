using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Film_Listesi.DataAccess.Repositories.Abstraction
{
    public interface IBaseRepository
    {
        void Eraser(GroupBox groupBox);
    }
}
