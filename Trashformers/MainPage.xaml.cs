using Camera.MAUI;
using Microsoft.Maui.Controls.PlatformConfiguration;
using System.Net;
namespace Trashformers
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }

        private async void TakePhoto(object sender, EventArgs e)
        {
            FileResult photo = await MediaPicker.Default.CapturePhotoAsync();
            if (photo != null)
            {
                var stream = await photo.OpenReadAsync();
                myImage.Source = ImageSource.FromStream(() => stream);
            }
        }

            private async void Button_Clicked(object sender, EventArgs e)
        {
            FileResult photo = MediaPicker.Default.CapturePhotoAsync().Result;
            myImage.Source = photo.FileName;
            
        }
    }
}