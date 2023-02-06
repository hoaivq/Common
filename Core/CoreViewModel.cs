using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Common
{
    public class CoreViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }

        public ICommand LoadViewCommand { get; set; }
        public CoreViewModel()
        {
            LoadViewCommand = new RelayCommand<object>((p) => { return true; }, async (p) =>
            {
                await LoadView();
            });
        }

        public virtual async Task LoadDanhMuc()
        {

            await Task.CompletedTask;
        }
        public virtual async Task LoadView()
        {
            await Task.CompletedTask;
        }
    }
}
