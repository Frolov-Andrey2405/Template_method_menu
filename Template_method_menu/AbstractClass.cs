using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Template_method_menu
{
    internal abstract class AbstractClass
    {
        protected bool flag = true;

        protected abstract void Init();
        protected abstract void Idle();

        protected abstract void CleanUp();

        public void Run()
        {
            Init();
            while (flag)
            {
                Idle();
            }
            CleanUp();
        }
    }
}
