using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SavingVariables.DAL;

namespace SavingVariables.Tests.DAL
{
    [TestClass]
    public class VarRepoContextTests
    {
        [TestMethod]
        public void EnsureCanCreateInstance()
        {
            VarRepoContext context_repo = new VarRepoContext();
        }
    }
}
