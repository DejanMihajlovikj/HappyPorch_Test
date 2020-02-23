using Our.Umbraco.DataAnnotations;

namespace UmbracoTestProject.Core.ViewModels
{
    public class ContactFormViewModel
    {
        [UmbracoRequired]
        public string Email { get; set; }

        [UmbracoRequired]
        public string Message { get; set; }

        public string EmailTo { get; set; }
        public string EmailSubject { get; set; }
    }
}
