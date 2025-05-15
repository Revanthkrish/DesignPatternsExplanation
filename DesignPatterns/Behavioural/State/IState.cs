using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DesignPatterns.Behavioural.State
{
    // State Interface
    public interface IState
    {
        void Handle(Context context);
    }
}
