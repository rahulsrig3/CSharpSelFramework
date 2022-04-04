using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpSelFramework.Generics
{
    public class FileUtility
    {
        [Test]
        public string ReadDataFromRunSettings(string key)
        {
            string value = TestContext.Parameters.Get(key);
            return value;
        }
    }
}
