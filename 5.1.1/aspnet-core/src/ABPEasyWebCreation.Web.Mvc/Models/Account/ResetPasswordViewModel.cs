using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using Abp.Auditing;
using Abp.Authorization.Users;
using Abp.Extensions;
using ABPEasyWebCreation.Validation;

namespace ABPEasyWebCreation.Web.Models.Account
{
    public class ResetPasswordViewModel
    {
        [Required]
        [EmailAddress]
        [StringLength(AbpUserBase.MaxEmailAddressLength)]
        public string EmailAddress { get; set; }

    }
}
