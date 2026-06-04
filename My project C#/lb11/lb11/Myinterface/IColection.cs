using lb11.Model.Edition;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lb11.Myinterface
{
    public interface IColection
    {
        Book[] Colection { get; }
        //Принцип інтерфейсу(Interface Segregation Principle – ISP).
        //Клієнти не повинні залежати від інтерфейсів, які вони не використовують.Це означає,
        //що класи повинні мати тільки ті методи, які необхідні для їх функціонування.
    }
}
