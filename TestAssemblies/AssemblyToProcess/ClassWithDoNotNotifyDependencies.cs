using System.ComponentModel;
using PropertyChanged;

public class ClassWithDoNotNotifyDependencies : INotifyPropertyChanged
{
  public event PropertyChangedEventHandler PropertyChanged;

  [DoNotNotify]
  public bool FullNameCalled { get; set; }

  [DoNotNotifyDependencies]
  public string FirstName { get; set; }

  [DoNotNotifyDependencies]
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