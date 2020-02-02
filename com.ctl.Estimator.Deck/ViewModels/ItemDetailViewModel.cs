using System;

using com.ctl.Estimator.Deck.Models;

namespace com.ctl.Estimator.Deck.ViewModels
{
    public class ItemDetailViewModel : BaseViewModel
    {
        public Item Item { get; set; }
        public ItemDetailViewModel(Item item = null)
        {
            Title = item?.Text;
            Item = item;
        }
    }
}
