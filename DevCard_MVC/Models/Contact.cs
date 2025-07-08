using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.VisualStudio.Web.CodeGenerators.Mvc.Templates.BlazorIdentity.Pages.Manage;
using System.ComponentModel.DataAnnotations;

namespace DevCard_MVC.Models
{
    //public class Contact
    //{
    //    [Required(ErrorMessage = "این فیلد اجباری است")]
    //    [MinLength(3, ErrorMessage = "حداقل طول نام، 3 کاراکتر است")]
    //    [MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کاراکتر است")]
    //    public string Name { get; set; }

    //    [Required(ErrorMessage = "این فیلد اجباری است")]
    //    public string Email { get; set; }


    //    public int Service { get; set; }
    //    public string Message { get; set; }
    //    public SelectList Services { get; set; }
    //}

    public class Contact
    {
        [Required(ErrorMessage = "این فیلد اجباری است")]
        [MinLength(3, ErrorMessage = "حداقل طول نام، 3 کاراکتر است")]
        [MaxLength(100, ErrorMessage = "حداکثر طول نام، 100 کاراکتر است")]
        public string Name { get; set; }

        [Required(ErrorMessage = "این فیلد اجباری است")]
        [EmailAddress(ErrorMessage = "ایمیل وارد شده معتبر نیست")]
        public string Email { get; set; }

        [Range(1, int.MaxValue, ErrorMessage = "لطفا یک سرویس را انتخاب کنید")]
        public int Service { get; set; }

        [Required(ErrorMessage = "پیام خود را وارد نمایید")]
        [MinLength(10, ErrorMessage = "پیام باید حداقل 10 کاراکتر باشد")]
        public string Message { get; set; }

        //public SelectList Services { get; set; }
    }




}
