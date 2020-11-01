using System.Collections.ObjectModel;
using System.ComponentModel;
using System.IO;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
namespace Photos
{
    class VM : INotifyPropertyChanged
    {
        //  public Command Photo { get; set; }
        public ObservableCollection<Image> types { get; set; }
        public ObservableCollection<Image> Types { get => types; set { types = value; OnPropertyChanged("Types"); } }
        public VM()
        {
            //  Photo = new Command(OnPickPhotoButtonClicked);
            Types = new ObservableCollection<Image>();
            Types.Add(new Image() { Source = "heart", BackgroundColor = Color.White });
            Types.Add(new Image() { Source = "heart", BackgroundColor = Color.White });
            Types.Add(new Image() { Source = "heart", BackgroundColor = Color.White });
            Types.Add(new Image() { Source = "heart", BackgroundColor = Color.White });
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
