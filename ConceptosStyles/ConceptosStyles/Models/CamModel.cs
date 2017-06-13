using ConceptosStyles.ContentView;
using System.Threading.Tasks;
using Xamarin.Forms;
using XLabs;
using XLabs.Forms.Mvvm;
using XLabs.Ioc;
using XLabs.Platform.Device;
using XLabs.Platform.Services.Media;

namespace ConceptosStyles.Models
{
    [ViewType(typeof(SolicitudesDocAdicionalesContentView))]
    public class CameraModel : ViewModel
    {
        ///// <summary>
        ///// The _picture chooser
        ///// </summary>
        //private IMediaPicker _mediaPicker;
        ///// <summary>
        ///// The _image source
        ///// </summary>
        //private ImageSource _imageSource;
        ///// <summary>
        ///// The _video info
        ///// </summary>
        //private string _videoInfo;
        ///// <summary>
        ///// The _take picture command
        ///// </summary>
        //private RelayCommand _takePictureCommand;
        ///// <summary>
        ///// The _select picture command
        ///// </summary>
        //private RelayCommand _selectPictureCommand;
        ///// <summary>
        ///// The _select video command
        ///// </summary>
        //private RelayCommand _selectVideoCommand;

        ///// <summary>
        ///// The _scheduler
        ///// </summary>
        //private readonly TaskScheduler _scheduler = TaskScheduler.FromCurrentSynchronizationContext();
        ////private CancellationTokenSource cancelSource;

        ///// <summary>
        ///// Initializes a new instance of the <see cref="CameraViewModel" /> class.
        ///// </summary>
        //public CameraModel()
        //{
        //    Setup();
        //}

        ///// <summary>
        ///// Gets or sets the image source.
        ///// </summary>
        ///// <value>The image source.</value>
        //public ImageSource ImageSource
        //{
        //    get
        //    {
        //        return _imageSource;
        //    }
        //    set
        //    {
        //        this.ChangeAndNotify(ref _imageSource, value);
        //    }
        //}

        ///// <summary>
        ///// Gets or sets the video info.
        ///// </summary>
        ///// <value>The video info.</value>
        //public string VideoInfo
        //{
        //    get
        //    {
        //        return _videoInfo;
        //    }
        //    set
        //    {
        //        this.ChangeAndNotify(ref _videoInfo, value, "VideoInfo");
        //    }
        //}

        ///// <summary>
        ///// Gets the take picture command.
        ///// </summary>
        ///// <value>The take picture command.</value>
        //public RelayCommand TakePictureCommand
        //{
        //    get
        //    {
        //        return _takePictureCommand ?? (_takePictureCommand = new RelayCommand(
        //            async () => await TakePicture(),

        //            () => true));
        //    }
        //}

        ///// <summary>
        ///// Gets the select video command.
        ///// </summary>
        ///// <value>The select picture command.</value>
        //public RelayCommand SelectVideoCommand
        //{
        //    get
        //    {
        //        return _selectVideoCommand ?? (_selectVideoCommand = new RelayCommand(
        //            async () => await SelectVideo(),

        //            () => true));
        //    }
        //}
        ///// <summary>
        ///// Gets the select picture command.
        ///// </summary>
        ///// <value>The select picture command.</value>
        //public RelayCommand SelectPictureCommand
        //{
        //    get
        //    {
        //        return _selectPictureCommand ?? (_selectPictureCommand = new RelayCommand(
        //            async () => await SelectPicture(),

        //            () => true));
        //    }
        //}

        ///// <summary>
        ///// Setups this instance.
        ///// </summary>
        //void Setup()
        //{
        //    if (_mediaPicker != null)
        //    {
        //        return;
        //    }

        //    var device = Resolver.Resolve<IDevice>();

        //    _mediaPicker = DependencyService.Get<IMediaPicker>();
        //    //RM: hack for working on windows phone? 
        //    if (_mediaPicker == null)
        //        _mediaPicker = device.MediaPicker;
        //}
        ///// <summary>
        ///// Takes the picture.
        ///// </summary>
        ///// <returns>Task.</returns>
        //private async Task TakePicture()
        //{
        //    Setup();

        //    ImageSource = null;

        //    await this._mediaPicker.TakePhotoAsync(new CameraMediaStorageOptions { DefaultCamera = CameraDevice.Front, MaxPixelDimension = 400 }).ContinueWith(t =>
        //    {
        //        if (t.IsFaulted)
        //        {
        //            var s = t.Exception.InnerException.ToString();
        //        }
        //        else if (t.IsCanceled)
        //        {
        //            var canceled = true;
        //        }
        //        else
        //        {
        //            var mediaFile = t.Result;

        //            ImageSource = ImageSource.FromStream(() => mediaFile.Source);

        //            return mediaFile;
        //        }

        //        return null;
        //    }, _scheduler);
        //}

        ///// <summary>
        ///// Selects the picture.
        ///// </summary>
        ///// <returns>Task.</returns>
        //private async Task SelectPicture()
        //{
        //    Setup();

        //    ImageSource = null;
        //    try
        //    {
        //        var mediaFile = await this._mediaPicker.SelectPhotoAsync(new CameraMediaStorageOptions
        //        {
        //            DefaultCamera = CameraDevice.Front,
        //            MaxPixelDimension = 400
        //        });
        //        ImageSource = ImageSource.FromStream(() => mediaFile.Source);
        //    }
        //    catch (System.Exception ex)
        //    {

        //    }

        //}

        ///// <summary>
        ///// Selects the video.
        ///// </summary>
        ///// <returns>Task.</returns>
        //private async Task SelectVideo()
        //{
        //    Setup();

        //    VideoInfo = "Selecting video";

        //    try
        //    {
        //        var mediaFile = await this._mediaPicker.SelectVideoAsync(new VideoMediaStorageOptions());

        //        if (mediaFile != null)
        //        {
        //            VideoInfo = string.Format("Your video size {0} MB", ConvertBytesToMegabytes(mediaFile.Source.Length));
        //        }
        //        else
        //        {
        //            VideoInfo = "No video was selected";
        //        }
        //    }
        //    catch (System.Exception ex)
        //    {
        //        if (ex is TaskCanceledException)
        //            VideoInfo = "Selecting video canceled";
        //    }



        //}
        //static double ConvertBytesToMegabytes(long bytes)
        //{
        //    return (bytes / 1024f) / 1024f;
        //}
    }
}
