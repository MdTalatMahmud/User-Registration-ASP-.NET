//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.ComponentModel.DataAnnotations;

namespace UserRegistration
{
    using System;
    using System.Collections.Generic;
    
    public partial class Table
    {
        public int Id { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be blank")]
        public string Username { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be blank")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string Password { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be blank")]
        [DataType(System.ComponentModel.DataAnnotations.DataType.Password)]
        public string ConfirmPassword { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be blank")]
        public string Fullname { get; set; }
        [Required(AllowEmptyStrings = false, ErrorMessage = "Can not be blank")]
        public string Email { get; set; }
    }
}
