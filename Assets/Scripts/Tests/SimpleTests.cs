using System.Collections;
using System.Collections.Generic;
using NUnit.Framework;
using UnityEngine;
using UnityEngine.TestTools;

namespace Testing
{
    public class SimpleTests
    {
        [Test]
        public void SimplePass()
        {
            Assert.Pass();
        }
        
        [Test]
        public void SimpleFail()
        {
            Assert.Fail();
        }
    }
}
