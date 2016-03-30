using System;

namespace PropertyChanged
{
  /// <summary>
  /// Skip notifying dependencies
  /// </summary>
  [AttributeUsage(AttributeTargets.Class | AttributeTargets.Property | AttributeTargets.Field)]
  public class DoNotNotifyDependenciesAttribute : Attribute
  {
  }
}