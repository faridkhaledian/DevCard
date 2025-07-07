using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل طول نام، 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        public string Email { get; set; }

       
        public int Service { get; set; }
        public string Message { get; set; }
        public SelectList Services { get; set; }
    }
}
