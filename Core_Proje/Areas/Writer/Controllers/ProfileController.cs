﻿using Core_Proje.Areas.Writer.Models;
using Core_Proje.Areas.Writer.WriterValidationRules;
using Core_Proje.EL.Concrete;
using FluentValidation.Results;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

namespace Core_Proje.Areas.Writer.Controllers
{
    [Area("Writer")]
    [Route("Writer/[controller]/[action]")]
    public class ProfileController : Controller
    {
        private readonly UserManager<WriterUser> _userManager;

        public ProfileController(UserManager<WriterUser> userManager)
        {
            _userManager = userManager;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var values = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModel model = new UserEditViewModel();
            model.Name = values.Name;
            model.Surname = values.Surname;
            model.PictureUrl = values.ImageUrl;
            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Index(UserEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserEditViewModelValidator validations = new UserEditViewModelValidator();
            ValidationResult result1 = validations.Validate(p);
            if (p.Picture != null)
            {
                var resource = Directory.GetCurrentDirectory();
                var extension = Path.GetExtension(p.Picture.FileName);
                var imagename = Guid.NewGuid() + extension;
                var savelocation = resource + "/wwwroot/UserImage/" + imagename;
                var stream = new FileStream(savelocation, FileMode.Create);
                await p.Picture.CopyToAsync(stream);
                user.ImageUrl = imagename;
            }
            if (result1.IsValid)
            {
                user.Name = p.Name;
                user.Surname = p.Surname;
                var result = await _userManager.UpdateAsync(user);
                if (result.Succeeded)
                {
                    return RedirectToAction("Index", "Profile");
                }
            }
            else
            {
                foreach (var item in result1.Errors)
                {
                    ModelState.AddModelError(item.PropertyName, item.ErrorMessage);
                }
            }
            return View();
        }

        [HttpGet]
        public IActionResult PasswordEdit()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> PasswordEdit(UserPasswordEditViewModel p)
        {
            var user = await _userManager.FindByNameAsync(User.Identity.Name);
            UserPasswordEditViewModelValidator validations = new UserPasswordEditViewModelValidator();
            ValidationResult result1 = validations.Validate(p);
            user.PasswordHash = _userManager.PasswordHasher.HashPassword(user, p.Password);
            var result = await _userManager.UpdateAsync(user);
            if (result.Succeeded)
            {
                return RedirectToAction("Index", "Login");
            }
            else
            {
                foreach (var item in result1.Errors)
                {
                    ModelState.AddModelError("", item.ErrorMessage);
                }
            }

            return View();
        }
    }
}
