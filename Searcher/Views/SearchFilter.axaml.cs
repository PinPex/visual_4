using Avalonia;
using Avalonia.Controls;
using Avalonia.Markup.Xaml;
using Searcher.ViewModels;
using Avalonia.Interactivity;

namespace Searcher.Views
{
    public partial class SearchFilter : Window
    {
        public SearchFilter()
        {
            InitializeComponent();
#if DEBUG
            this.AttachDevTools();
#endif
            this.FindControl<Button>("OkBtn").Click += delegate
            {
                Close(this.FindControl<TextBox>("Input").Text);
            };

            this.FindControl<Button>("CancelBtn").Click +=  delegate
            {
                Close("Cancel");
            };
        }

        private void InitializeComponent()
        {
            AvaloniaXamlLoader.Load(this);
        }
    }
}
