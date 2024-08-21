namespace Module01Activity02
{
    public partial class MainPage : ContentPage
    {
        public string Firstname { get; set; }
        public Color ColorRed { get; set; }

        public MainPage()
        {
            InitializeComponent();


            Firstname = "Hello, MAUI!";
            ColorRed = Colors.Red;

            this.BindingContext = this;

        }

        private void OnChangedLabelName(object sender, EventArgs e)
        {
            this.Resources["StaticUsername"] = "Peter Pan";
        }

        private void OnChangedLabelNameDynamic(object sender, EventArgs e)
        {
            this.Resources["DynamicUsername"] = "Peter Pan";
        }

        private void OnChangedBgColor(object sender, EventArgs e)
        {
            this.Resources["DynamicLocalBgColor"] = Colors.SkyBlue;
        }

        private void OnChangedBgColorB(object sender, EventArgs e)
        {
            this.Resources["DynamicLocalBgColor"] = Colors.Blue;
        }

        private void OnChangedBgColorLB(object sender, EventArgs e)
        {
            this.Resources["DynamicLocalBgColor"] = Colors.LightBlue;
        }

        private void OnChangedBoxColor(object sender, EventArgs e)
        {
            this.Resources["DynamicBoxColor"] = Colors.Red;
        }



    }

}
