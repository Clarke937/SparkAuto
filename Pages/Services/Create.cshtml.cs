using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using SparkAuto.Data;
using SparkAuto.Models;
using SparkAuto.Models.ViewModel;
using SparkAuto.Utility;

namespace SparkAuto.Pages.Services
{
    [Authorize]
    public class CreateModel : PageModel
    {
        private readonly ApplicationDbContext _db;

        [BindProperty]
        public CarServiceViewModel CarServiceVM { get; set; }
        //public double Tax { get; set; }
        //public double FullPrice { get; set; }

        public CreateModel(ApplicationDbContext db)
        {
            _db = db;
        }

        public CommonValues cv {get;set;}

        public async Task<IActionResult> OnGet(int carId)
        {
            CarServiceVM = new CarServiceViewModel
            {
                Car = await _db.Car.Include(c => c.ApplicationUser).FirstOrDefaultAsync(c => c.Id == carId),
                ServiceHeader = new Models.ServiceHeader()
            };

            cv = _db.CommonValues.Find(1);

            List<String> lstServiceTypeInShoppingCart = _db.ServiceShoppingCart
                                                            .Include(c => c.ServiceType)
                                                            .Where(c => c.CarId == carId)
                                                            .Select(c => c.ServiceType.Name)
                                                            .ToList();

            IQueryable<ServiceType> lstService = from s in _db.ServiceType
                                                 where !(lstServiceTypeInShoppingCart.Contains(s.Name))
                                                 select s;

            CarServiceVM.ServiceTypesList = lstService.ToList();

            CarServiceVM.ServiceShoppingCart = _db.ServiceShoppingCart
                                                     .Include(c => c.ServiceType)
                                                     .Where(c => c.CarId == carId)
                                                     .ToList();
            CarServiceVM.ServiceHeader.TotalPrice = 0;
            CarServiceVM.ServiceHeader.Tax = 0;
            

            foreach (var item in CarServiceVM.ServiceShoppingCart)
            {

                CarServiceVM.ServiceHeader.TotalPrice += item.ServiceType.Price * item.Quantity;
                CarServiceVM.ServiceHeader.TotalPrice = Math.Round(CarServiceVM.ServiceHeader.TotalPrice, 2);
                CarServiceVM.ServiceHeader.Tax = CarServiceVM.ServiceHeader.TotalPrice * cv.iva;
                CarServiceVM.ServiceHeader.Tax = Math.Round(CarServiceVM.ServiceHeader.Tax, 2);
                CarServiceVM.ServiceHeader.EnvCharge = cv.envCharge;
                CarServiceVM.ServiceHeader.FullPrice = CarServiceVM.ServiceHeader.Tax + CarServiceVM.ServiceHeader.TotalPrice + CarServiceVM.ServiceHeader.EnvCharge;
                CarServiceVM.ServiceHeader.FullPrice = Math.Round(CarServiceVM.ServiceHeader.FullPrice, 2);
            }

            return Page();

        }

        public async Task<IActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                CarServiceVM.ServiceHeader.DateAdded = DateTime.Now;
                CarServiceVM.ServiceHeader.NextServiceDate = DateTime.Now.AddDays(90);

                CommonValues cv2 = _db.CommonValues.Find(1);

                CarServiceVM.ServiceShoppingCart = _db.ServiceShoppingCart.Include(c => c.ServiceType).Where(c => c.CarId == CarServiceVM.Car.Id).ToList();
                foreach (var item in CarServiceVM.ServiceShoppingCart)
                {
                    CarServiceVM.ServiceHeader.TotalPrice += item.ServiceType.Price * item.Quantity;
                    CarServiceVM.ServiceHeader.TotalPrice = Math.Round(CarServiceVM.ServiceHeader.TotalPrice, 2);
                    CarServiceVM.ServiceHeader.Tax = CarServiceVM.ServiceHeader.TotalPrice * cv2.iva;
                    CarServiceVM.ServiceHeader.Tax = Math.Round(CarServiceVM.ServiceHeader.Tax, 2);
                    CarServiceVM.ServiceHeader.EnvCharge = cv2.envCharge;
                    CarServiceVM.ServiceHeader.FullPrice = CarServiceVM.ServiceHeader.Tax + CarServiceVM.ServiceHeader.TotalPrice + CarServiceVM.ServiceHeader.EnvCharge;
                    CarServiceVM.ServiceHeader.FullPrice = Math.Round(CarServiceVM.ServiceHeader.FullPrice, 2);
                }
                CarServiceVM.ServiceHeader.CarId = CarServiceVM.Car.Id;

                _db.ServiceHeader.Add(CarServiceVM.ServiceHeader);
                await _db.SaveChangesAsync();

                foreach (var detail in CarServiceVM.ServiceShoppingCart)
                {
                    Console.WriteLine(detail.ServiceType.Price);

                    ServiceDetails serviceDetails = new ServiceDetails
                    {
                        ServiceHeaderId = CarServiceVM.ServiceHeader.Id,
                        ServiceName = detail.ServiceType.Name,
                        ServicePrice = detail.ServiceType.Price,
                        ServiceTypeId = detail.ServiceTypeId,
                        Quantity = detail.Quantity
                    };
                    _db.ServiceDetails.Add(serviceDetails);

                }

                _db.ServiceShoppingCart.RemoveRange(CarServiceVM.ServiceShoppingCart);

                //ACTUALIZACION DE MILLAS 
                CarServiceVM.Car.Miles = CarServiceVM.ServiceHeader.Miles;
                _db.Car.Attach(CarServiceVM.Car);
                _db.Entry(CarServiceVM.Car).Property(x => x.Miles).IsModified = true;

                await _db.SaveChangesAsync();
                return RedirectToPage("../Cars/Index", new { userId = CarServiceVM.Car.UserId });
            }

            return RedirectToPage("Create", new { carId = CarServiceVM.Car.Id });
        }

        public async Task<IActionResult> OnPostAddToCart()
        {
            ServiceShoppingCart objServiceCart = new ServiceShoppingCart()
            {
                CarId = CarServiceVM.Car.Id,
                ServiceTypeId = CarServiceVM.ServiceDetails.ServiceTypeId,
                Quantity = CarServiceVM.ServiceDetails.Quantity
            };

            _db.ServiceShoppingCart.Add(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceVM.Car.Id });
        }

        public async Task<IActionResult> OnPostRemoveFromCart(int serviceTypeId)
        {
            ServiceShoppingCart objServiceCart = _db.ServiceShoppingCart
                .FirstOrDefault(u => u.CarId == CarServiceVM.Car.Id && u.ServiceTypeId == serviceTypeId);


            _db.ServiceShoppingCart.Remove(objServiceCart);
            await _db.SaveChangesAsync();
            return RedirectToPage("Create", new { carId = CarServiceVM.Car.Id });
        }
    }
}