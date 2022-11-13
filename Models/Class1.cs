using DAL;
using System.Collections.ObjectModel;

namespace Models
{
    public class Class1
    {
        public class MainViewModel : BaseViewmodel
        {
            private string _naam = "";
            private ObservableCollection<Store> _stores;

            public override string this[string columnName]
            {
                get
                {
                    return "";
                }
            }

            public ObservableCollection<Store> Stores
            {
                get { return _stores; }
                set
                {
                    _stores = value;
                    NotifyPropertyChanged();
                }
            }

            public string Naam
            {
                get { return _naam; }
                set
                {
                    _naam = value;
                    NotifyPropertyChanged();
                }
            }

            public void Zoeken()
            {
                //lijst storen ophalen
                List<Store> lijstStores = DatabaseOperations.OphalenWinkelsViaWinkelnaam(Naam);
                Stores = new ObservableCollection<Store>(lijstStores);
            }
        }
    }
}
}