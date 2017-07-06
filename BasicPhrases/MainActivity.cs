using Android.App;
using Android.Media;
using Android.Net;
using Android.Widget;
using Android.OS;

namespace BasicPhrases
{
    [Activity(Label = "BasicPhrases", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        private Button _buttonHello;
        private Button _buttonHowAreYou;

        private Button _buttonGoodEvening;
        private Button _buttonPlease;

        private Button _buttonMyNameIs;
        private Button _buttonDoYouSpeakEnglish;

        private Button _buttonWelcome;
        private Button _buttonILiveIn;

        private MediaPlayer _mediaPlayer;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView (Resource.Layout.Main);
            initFields();
        }

        private void initFields()
        {
            _buttonHello = FindViewById<Button>(Resource.Id.hello);
            _buttonHello.Click += _buttonClick;

            _buttonHowAreYou= FindViewById<Button>(Resource.Id.howareyou);
            _buttonHowAreYou.Click += _buttonClick;

            _buttonGoodEvening= FindViewById<Button>(Resource.Id.goodevening);
            _buttonGoodEvening.Click += _buttonClick;

            _buttonPlease = FindViewById<Button>(Resource.Id.please);
            _buttonPlease.Click += _buttonClick;
            
            _buttonMyNameIs = FindViewById<Button>(Resource.Id.mynameis);
            _buttonMyNameIs.Click += _buttonClick;

            _buttonDoYouSpeakEnglish = FindViewById<Button>(Resource.Id.doyouspeakenglish);
            _buttonDoYouSpeakEnglish.Text = "Do You\nSpeak English?";
            _buttonDoYouSpeakEnglish.Click += _buttonClick;
            
            _buttonWelcome = FindViewById<Button>(Resource.Id.welcome);
            _buttonWelcome.Click += _buttonClick;

            _buttonILiveIn = FindViewById<Button>(Resource.Id.ilivein);
            _buttonILiveIn.Click += _buttonClick;
        }

        private void _buttonClick(object sender, System.EventArgs e)
        {
            Button buttonSender = (Button) sender;
            int id = buttonSender.Id;
            string ourId = buttonSender.Resources.GetResourceEntryName(id);
            int fileId = Resources.GetIdentifier(ourId, "raw", PackageName);
           // Uri uri=Uri.Parse("android.resource://"+PackageName+"/"+fileId);
            _mediaPlayer = _mediaPlayer = MediaPlayer.Create(this,fileId);
            _mediaPlayer.Start();
        }
    }
}

