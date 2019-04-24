using System;
using System.Linq;
using System.Text;
using AutoItX3Lib; 

namespace addressbook_tests_autoit
{
    public class HelperBase
    {
        protected string WINTITLE;
        protected AutoItX3 aux;
        protected ApplicationManager manager;

        public HelperBase(ApplicationManager manager)
        {
            this.aux = manager.Aux;
            WINTITLE = ApplicationManager.WINTITLE;
            this.manager = manager;
        }
    }
}