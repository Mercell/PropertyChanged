using System.Xml.Linq;
using NUnit.Framework;

[TestFixture]
public class NotifyDependenciesConfigTests
{
  [Test]
  public void False()
  {
    var xElement = XElement.Parse("<PropertyChanged NotifyDependencies='false'/>");
    var moduleWeaver = new ModuleWeaver { Config = xElement };
    moduleWeaver.ResolveNotifyDependenciesConfig();
    Assert.IsFalse(moduleWeaver.NotifyDependencies);
  }

  [Test]
  public void True()
  {
    var xElement = XElement.Parse("<PropertyChanged NotifyDependencies='true'/>");
    var moduleWeaver = new ModuleWeaver { Config = xElement };
    moduleWeaver.ResolveNotifyDependenciesConfig();
    Assert.IsTrue(moduleWeaver.NotifyDependencies);
  }

  [Test]
  public void Default()
  {
    var moduleWeaver = new ModuleWeaver();
    moduleWeaver.ResolveNotifyDependenciesConfig();
    Assert.IsTrue(moduleWeaver.NotifyDependencies);
  }
}