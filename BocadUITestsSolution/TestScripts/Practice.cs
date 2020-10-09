using BocadAPITestsSolution.Core;
using BocadUITestsSolution.Prerequisite;
using BocadUITestsSolution.UIControls;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Automation;
using TestStack.White;

namespace BocadUITestsSolution.TestScripts
{
    [TestClass]
    public class Practice
    {
        [TestMethod]
        public void SampleTest()
        {
            Login.CreationofNewJob();
        }
        
    }
}
