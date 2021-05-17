using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace MVVM.View
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Operations : ContentPage
    {
        public Operations()
        {
            InitializeComponent();
            this.BindingContext = new ViewModels.OperationsViewModel();
        }
    }
}