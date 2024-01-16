using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;
using Microsoft.Maui.Controls;

namespace MixMaster.View
{
    public class SearchViewModel : INotifyPropertyChanged
    {
        private string _searchText;
        public string SearchText
        {
            get => _searchText;
            set
            {
                if (_searchText != value)
                {
                    _searchText = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<string> RecentSearches { get; }

        public ICommand PerformSearchCommand { get; }
        public ICommand ClearSearchCommand { get; }

        public SearchViewModel()
        {
            RecentSearches = new ObservableCollection<string>();
            PerformSearchCommand = new Command(PerformSearch);
            ClearSearchCommand = new Command(ClearSearch);
        }

        private void PerformSearch()
        {
            if (!string.IsNullOrWhiteSpace(SearchText))
            {
                RecentSearches.Insert(0, SearchText);
            }
        }

        private void ClearSearch()
        {
            SearchText = string.Empty;
            RecentSearches.Clear();
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
