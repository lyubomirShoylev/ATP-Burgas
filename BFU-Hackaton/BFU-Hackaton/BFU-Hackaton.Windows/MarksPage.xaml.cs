using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace BFU_Hackaton
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public partial class MarksPage : Page
    {
        public MarksPage()
        {
            
        }
        int index { get; set; }
        protected async override void OnNavigatedTo(NavigationEventArgs e)
        {
            index = int.Parse(e.Parameter.ToString());
            /*var client = new HttpClient();
            var responce = await client.GetAsync(new Uri("http://e-services.bfu.bg/api/marks.php?fan="
            + index));
            var json = await responce.Content.ReadAsStringAsync();
            JsonSerializer serializer = new JsonSerializer();
            BFU_Hackaton.Marks.RootObject RO = JsonConvert.DeserializeObject<BFU_Hackaton.Marks.RootObject>(json);
            SubjectName.ItemsSource = RO.MARKS;*/
        }

        private async void SubjectName_Loaded(object sender, RoutedEventArgs e)
        {
            var client = new HttpClient();
            var responce = await client.GetAsync(new Uri("http://e-services.bfu.bg/api/marks.php?fan="
            + index));
            var json = await responce.Content.ReadAsStringAsync();
            JsonSerializer serializer = new JsonSerializer();
            BFU_Hackaton.Marks.RootObject RO = JsonConvert.DeserializeObject<BFU_Hackaton.Marks.RootObject>(json);
            SubjectName.ItemsSource = RO.MARKS;
        }

    }
}
