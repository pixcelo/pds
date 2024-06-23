using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace pds.UI.WinForm.ViewModels;

public abstract class ViewModelBase : INotifyPropertyChanged
{
    public event PropertyChangedEventHandler? PropertyChanged;

    /// <summary>
    /// プロパティの変更を通知する
    /// </summary>
    /// <typeparam name="T"></typeparam>
    /// <param name="field"></param>
    /// <param name="value"></param>
    /// <param name="propertyName"></param>
    /// <returns></returns>
    protected bool SetProperty<T>(
        ref T field,
        T value,
        [CallerMemberName] string? propertyName = null)
    {
        if (Equals(field, value)) return false;

        field = value;
        this.PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));

        return true;
    }
}
