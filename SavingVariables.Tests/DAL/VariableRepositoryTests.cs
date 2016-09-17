using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace SavingVariables.Tests.DAL
{
    [TestClass]
    public class VariableRepositoryTests
    {
        private List<Constants> constants_list;
        private Mock<DbSet<Constants>> mock_constants_table;
        private Mock<SavingVariablesContext> mock_context;

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<SavingVariablesContext>();
            mock_constants_table = new Mock<DbSet<Constants>>();
            constants_list = new List<Constants>();
        }

        private class Constants
        {
        }

        private class DbSet<T>
        {
        }
    }

        internal class Mock<T>
        {
            public Mock()
            {
            }
    }
}
