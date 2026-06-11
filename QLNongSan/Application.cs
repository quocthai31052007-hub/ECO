namespace QLNongSan
{
    // A composible collection for BLL interfaces - entry point should declare implementations
    public class Application
    {
        public required Authentication.Services.IAuthenticationService authenticationService;
        // public required Products.Services.IProductService productService;
    }
}
