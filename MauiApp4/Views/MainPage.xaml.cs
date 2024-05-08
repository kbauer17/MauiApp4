namespace MauiApp4.Views
{
    public partial class MainPage : ContentPage
    {
        //private JsonSerializerOptions _serializerOptions = new JsonSerializerOptions
        //{
            //PropertyNamingPolicy = JsonNamingPolicy.CamelCase,
            //WriteIndented = true
        //};

        public MainPage()
        {
            InitializeComponent();
        }
        
        public void OnNewButtonClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            App.CatFactRepo.AddNewCatFact(NewCatFact.Text);
            StatusMessage.Text = App.CatFactRepo.StatusMessage;
        }

        public void OnGetButtonClicked(object sender, EventArgs args)
        {
            StatusMessage.Text = "";

            List<CatFact> catFact = App.CatFactRepo.GetAllCatFacts();
            FactList.ItemsSource = catFact;
        }
   
        
        
        
        //private async void GetCatFact(object sender, EventArgs e)
        //{
        //    if (Connectivity.Current.NetworkAccess != NetworkAccess.None)
        //    {
        //        try
        //        {
        //            HttpClient client = new HttpClient();
//
        //            string response = await client.GetStringAsync("https://catfact.ninja/fact");
        //            CatFact.Text = JsonSerializer.Deserialize<CatFact>(response, _serializerOptions).Fact;
         //       }
         //       catch 
         //       {
         //           
         //       }
         //   }
       // }
    }
}