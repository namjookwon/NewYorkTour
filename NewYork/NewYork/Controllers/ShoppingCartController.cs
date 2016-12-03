using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using NewYork.Models;
using NewYork.ViewModels;

namespace NewYork.Controllers
{
    public class ShoppingCartController : Controller
    {
        DBContext storeDB = new DBContext();

        //
        // GET: /ShoppingCart/

        public ActionResult Index()
        {
            var cart = ShoppingCart.GetCart(storeDB, this.HttpContext);

            // Set up our ViewModel
            var viewModel = new ShoppingCartViewModel
            {
                CartItems = cart.GetCartItems(),
                CartTotal = cart.GetTotal()
            };

            // Return the view
            return View(viewModel);
        }

        //
        // GET: /ShoppingCart/AddToCart/5

        public ActionResult AddToCart(int id)
        {

            // Retrieve the album from the database
            var addedShow = storeDB.Shows
                .Single(show => show.ShowId == id);

            // Add it to the shopping cart
            var cart = ShoppingCart.GetCart(storeDB, this.HttpContext);

            cart.AddToCart(addedShow);

            storeDB.SaveChanges();

            // Go back to the main store page for more shopping
            return RedirectToAction("Index");
        }

        //
        // AJAX: /ShoppingCart/RemoveFromCart/5

        [HttpPost]
        public ActionResult RemoveFromCart(int id)
        {
            // Retrieve the current user's shopping cart
            var cart = ShoppingCart.GetCart(storeDB, this.HttpContext);

            // Get the name of the album to display confirmation
            string showName = storeDB.Carts
                .Single(item => item.RecordId == id).show.Title;

            // Remove from cart
            int itemCount = cart.RemoveFromCart(id);

            storeDB.SaveChanges();

            string removed = (itemCount > 0) ? " 1 copy of " : string.Empty;

            // Display the confirmation message

            var results = new ShoppingCartRemoveViewModel
            {
                Message = removed + showName +
                    " has been removed from your shopping cart.",
                CartTotal = cart.GetTotal(),
                CartCount = cart.GetCount(),
                ItemCount = itemCount,
                DeleteId = id
            };

            return Json(results);
        }

        [ChildActionOnly]
        public ActionResult CartSummary()
        {
            var cart = ShoppingCart.GetCart(storeDB, this.HttpContext);

            var cartItems = cart.GetCartItems()
                .Select(a => a.show.Title)
                .OrderBy(x => x);

            ViewBag.CartCount = cartItems.Count();
            ViewBag.CartSummary = string.Join("\n", cartItems.Distinct());

            return PartialView("CartSummary");
        }
    }
}