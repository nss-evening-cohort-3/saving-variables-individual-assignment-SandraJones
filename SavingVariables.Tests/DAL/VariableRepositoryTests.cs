using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Runtime.Remoting.Contexts;
using SavingVariables.DAL;

namespace SavingVariables.Tests.DAL
{
    [TestClass]
    public class VariableRepositoryTests
    {
        private List<Constants> constants_list;
        private Mock<DbSet<Constants>> mock_constants_table;
        private Mock<SavingVariables.Constants> mock_context;
        

        [TestInitialize]
        public void Initialize()
        {
            mock_context = new Mock<VarRepoContext>.Mock();
            mock_constants_table = new Mock<DbSet<Constants>>();
            constants_list = new List<Constants>();       
        }
        [TestMethod]
        public void RepoEnsureCanCreateInstanceOfMock()
        { 
            Assert.IsNotNull(mock_context);
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

        public static explicit operator Mock<T>(Mock<VarRepoContext> v)
        {
            throw new NotImplementedException();
        }

        internal class Mock : Mock<Constants>
        {
        }
    }
}
