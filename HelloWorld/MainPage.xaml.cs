using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using HelloLibrary;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HelloWorld
{
    /// <summary>
    ///     An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            HelloClass.Hello();
        }

        private void button2_Click(object sender, RoutedEventArgs e)
        {
            HelloClass.World();
        }
    }
}