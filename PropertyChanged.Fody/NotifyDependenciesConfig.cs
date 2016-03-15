using System.Linq;

public partial class ModuleWeaver
{
  public bool NotifyDependencies = true;

  public void ResolveNotifyDependenciesConfig()
  {
    var value = Config?.Attributes("NotifyDependencies").FirstOrDefault();
    if (value != null)
    {
      NotifyDependencies = bool.Parse((string)value);
    }
  }
}