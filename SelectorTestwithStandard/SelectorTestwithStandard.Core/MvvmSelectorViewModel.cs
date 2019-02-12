using System;
using System.Collections.Generic;
using System.Text;
using MvvmCross.ViewModels;

namespace SelectorTestwithStandard.Core
{
    public class MvvmSelectorViewModel : MvxViewModel
    {
        public MvxObservableCollection<DroidListItem> Tests { get; set; } = new MvxObservableCollection<DroidListItem>
        {
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true },
            new DroidListItem{One = true, Two = false, Three = false },
            new DroidListItem{One = false, Two = true, Three = false },
            new DroidListItem{One = false, Two = false, Three = true }
        };
    }
}
