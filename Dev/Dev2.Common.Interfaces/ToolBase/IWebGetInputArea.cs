﻿using System.Collections.ObjectModel;
using System.Windows.Input;

namespace Dev2.Common.Interfaces.ToolBase
{
    public interface IWebGetInputArea : IToolRegion
    {
        string QueryString { get; set; }
        string RequestUrl { get; set; }

        ObservableCollection<INameValue> Headers { get; set; }
        ICommand AddRowCommand { get; }
        ICommand RemoveRowCommand { get; }
        string HeaderText { get; set; }
        double HeadersHeight { get; set; }
    }
}