using System.ComponentModel;
using PropertyChanged;

[DoNotNotifyDependencies]
public class ClassWithDoNotNotifyDependenciesWholeClass : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public bool FullNameCalled { get; set; }

  public string FirstName { get; set; }

  public string LastName { get; set; }

  public string FullName
  {
    get
    {
      return FirstName + " " + LastName;
    }
  }

  public void OnPropertyChanged(string propertyName)
  {
    if (propertyName == nameof(FullName))
    {
      FullNameCalled = true;
    }

    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
  }
}