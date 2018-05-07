using System;
using Foundation;
using UIKit;

using Photos;
namespace PhotoPicker
{
    public partial class ViewController : UIViewController, IUIImagePickerControllerDelegate
    {
        UITapGestureRecognizer profileTapGesture;
        UITapGestureRecognizer selectTapGesture;

        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            InitializeComponents();
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }

        void InitializeComponents(){
            txtEditProfile.Hidden = txtEditBottom.Hidden = true;
            profileTapGesture = new UITapGestureRecognizer(ShowOptions) { Enabled = true };
            upperView.AddGestureRecognizer(profileTapGesture);
            selectTapGesture = new UITapGestureRecognizer(ShowOptions) { Enabled = true };
            viewBottom.AddGestureRecognizer(selectTapGesture);
        }

        void ShowOptions(UITapGestureRecognizer gesture){
            //var imagePickerController = new UIImagePickerController
            //{
            //    //SourceType = UIImagePickerControllerSourceType.PhotoLibrary

            //    CameraDevice = UIImagePickerControllerCameraDevice.Rear
            //};
            //PresentViewController(imagePickerController, true, null);
            var dialog = UIAlertController.Create("What do you want to do?", null, UIAlertControllerStyle.ActionSheet);
            dialog.AddAction(UIAlertAction.Create("Camera", UIAlertActionStyle.Default, action => openCamera()));
            dialog.AddAction(UIAlertAction.Create("Gallery", UIAlertActionStyle.Default, action => openGallery()));
            PresentViewController(dialog, true, null);
        }

        void openCamera(){
            //Console.WriteLine("UwU");

        }

        void openGallery(){
            if(!UIImagePickerController.IsSourceTypeAvailable(UIImagePickerControllerSourceType.PhotoLibrary)){
                //Imprimir mensaje
                return;
            }
            CheckPhotoLibraryAuthStatus(PHPhotoLibrary.AuthorizationStatus);
        }

        void CheckPhotoLibraryAuthStatus(PHAuthorizationStatus authorizationStatus)
        {
            switch (authorizationStatus)
            {
                case PHAuthorizationStatus.NotDetermined:
                    //Pedir el permiso para acceder
                    PHPhotoLibrary.RequestAuthorization(CheckPhotoLibraryAuthStatus);
                    break;
                case PHAuthorizationStatus.Restricted:
                    //Mostrar mensaje de restringido
                    break;
                case PHAuthorizationStatus.Denied:
                    //Mostrar mensaje de denegado el permiso
                    break;
                case PHAuthorizationStatus.Authorized:
                    //Vamos a abrir la galeria
                    InvokeOnMainThread(() =>
                    {
                        var imagePickerController = new UIImagePickerController
                        {
                            SourceType = UIImagePickerControllerSourceType.PhotoLibrary,
                            Delegate = this
                        };
                        PresentViewController(imagePickerController, true, null);
                    });
                    break;
                default:
                    break;
            }
        }

        [Export("imagePickerControllerDidCancel:")]
        public void Canceled(UIImagePickerController picker)
        {
            picker.DismissViewController(true, null);
        }

        [Export("imagePickerController:didFinishPickingMediaWithInfo:")]
        public void FinishedPickingMedia(UIImagePickerController picker, NSDictionary info)
        {
            var image = info[UIImagePickerController.OriginalImage] as UIImage;
            imgProfile.Image = image;
            picker.DismissViewController(true, null);
        }

        void ShowMessage(string title, string message, UIViewController fromViewController){
            var dialog = UIAlertController.Create(title, message, UIAlertControllerStyle.Alert);
            dialog.AddAction(UIAlertAction.Create("Ok", UIAlertActionStyle.Default, null));
            fromViewController.PresentViewController(dialog, true, null);
        }
    }
}
