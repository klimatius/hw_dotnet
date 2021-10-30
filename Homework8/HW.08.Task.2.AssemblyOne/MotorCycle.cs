using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW._08.Task._2.AssemblyOne
{
    public class MotorCycle
    {
        public const string publicConst = "public const";
        private const string privateConst = "private const";
        protected const string protectedConst = "protected const";
        internal const string internalConst = "internal const";
        protected internal const string protectedInternalConst = "protected internal const";
        private protected const string privateProtectedConst = "private protected const";

        public string publicField = "public field";
        private string privateField = "private field";
        protected string protectedField = "protected field";
        internal string internalField = "internal field";
        protected internal string protectedInternalField = "protected internal field";
        private protected string privateProtectedField = "private protected field";

        public void PublicMethod()
        {
            Console.WriteLine("public method");
        }

        private void PrivateMethod()
        {
            Console.WriteLine("private method");
        }
        protected void ProtectedMethod()
        {
            Console.WriteLine("protected method");
        }
        internal void InternalMethod()
        {
            Console.WriteLine("internal method");
        }
        protected internal void ProtectedInternalMethod()
        {
            Console.WriteLine("protected internal method");
        }
        private protected void PrivateProtectedMethod()
        {
            Console.WriteLine("private protected method");
        }
    }
}
