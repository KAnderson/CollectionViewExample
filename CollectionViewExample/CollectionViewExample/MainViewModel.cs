using System.Collections.ObjectModel;

namespace CollectionViewExample
{
    public class AdviceCard
    {
        public string Title { get; set; }
        public string Content { get; set; }
    }

    public class MainViewModel
    {
        public ObservableCollection<AdviceCard> AdviceCards { get; set; }

        public MainViewModel()
        {
            AdviceCards = new ObservableCollection<AdviceCard>();
        }

        public void InitializeAsync()
        {
            AdviceCards.Add(new AdviceCard { Content = "something 1", Title = "title 1" });
            AdviceCards.Add(new AdviceCard { Content = "something 2", Title = "title 2" });
        }
    }

    
}