namespace Shop.UIForms.Helpers
{
    using Interfaces;
    using Resources;
    using Xamarin.Forms;

    public static class Languages
    {
        static Languages()
        {
            var ci = DependencyService.Get<ILocalize>().GetCurrentCultureInfo();
            Resource.Culture = ci;
            DependencyService.Get<ILocalize>().SetLocale(ci);
        }

        public static string Accept => Resource.Accept;

        public static string Error => Resource.Error;

        public static string EmailError => Resource.EmailError;

        public static string LoginError => Resource.LoginError;

        public static string PasswordError => Resource.PasswordError;

        public static string Login => Resource.Login;

        public static string Email => Resource.Email;

        public static string EnterEmail => Resource.EnterEmail;

        public static string Password => Resource.Password;

        public static string EnterPass => Resource.EnterPass;

        public static string Remember => Resource.Remember;

        public static string About => Resource.About;

        public static string Setup => Resource.Setup;

        public static string CloseSession => Resource.CloseSession;

        public static string Price => Resource.Price;

        public static string Stock => Resource.Stock;

        public static string Products => Resource.Products;

        public static string TapImage => Resource.TapImage;

        public static string Name => Resource.Name;

        public static string ProductName => Resource.ProductName;

        public static string Save => Resource.Save;

        public static string EditProduct => Resource.EditProduct;

        public static string Delete => Resource.Delete;

        public static string EnterName => Resource.EnterName;

        public static string EnterPrice => Resource.EnterPrice;

        public static string Confirm => Resource.Confirm;

        public static string DeleteProduct_ => Resource.DeleteProduct_;

        public static string Yes => Resource.Yes;

        public static string No => Resource.No;
    }
}
