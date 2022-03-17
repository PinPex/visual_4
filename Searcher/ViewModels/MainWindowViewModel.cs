using System;
using System.Collections.Generic;
using System.Text;
using System.Reactive;
using ReactiveUI;
using Searcher.Models;

namespace Searcher.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        string inputContent = "";
        string outputContent = "";
        string filter = "";
        public string Path 
        { 
            get { return inputContent; } 
            set { this.RaiseAndSetIfChanged(ref inputContent, ProcessingFile.Read(value)); } 
            
        }

        public string InputContent
        {
            get { return inputContent; }
            set { inputContent = value; }

        }

        public string OutputContent
        {
            get { return outputContent; }
            set { this.RaiseAndSetIfChanged(ref outputContent, value); }

        }

        public string Filter
        {
            get { return filter; }
            set 
            {
                this.RaiseAndSetIfChanged(ref filter, value);
                OutputContent = ProcessingFile.Search(inputContent, value);
            }
        }

        public void saveFile(string path, string savingContent)
        {
            ProcessingFile.Write(path, savingContent);
        }
    }
}
