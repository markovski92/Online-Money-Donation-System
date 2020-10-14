﻿namespace OnlineMoneyDonationSystem.Web.Areas.Administration.Controllers
{
    using OnlineMoneyDonationSystem.Common;
    using OnlineMoneyDonationSystem.Web.Controllers;

    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;

    [Authorize(Roles = GlobalConstants.AdministratorRoleName)]
    [Area("Administration")]
    public class AdministrationController : BaseController
    {
    }
}
