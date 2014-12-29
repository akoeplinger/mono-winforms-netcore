namespace System.Windows.Forms
{
    internal interface IBindingListView
    {
        string Filter { get; set; }
        ListSortDescriptionCollection SortDescriptions { get;  }
        bool SupportsAdvancedSorting { get;  }
        bool SupportsFiltering { get;  }

        void ApplySort(ListSortDescriptionCollection sorts);
    }
}