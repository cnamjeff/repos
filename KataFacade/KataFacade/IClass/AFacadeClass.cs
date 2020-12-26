using Couche2;

namespace KataFacade
{
    internal class AFacadeClass
    {
        internal ISubSytem1 _SubSystem1 { get; private set; }
        internal readonly ISubSystem2 _SubSystem2;
        internal readonly ISubSystem3 _SubSystem3;

        public AFacadeClass(ISubSytem1 subSytem1, ISubSystem2 subSystem2, ISubSystem3 subSystem3)
        {
            _SubSystem1 = subSytem1;
            _SubSystem2 = subSystem2;
            _SubSystem3 = subSystem3;
        }

    }
}