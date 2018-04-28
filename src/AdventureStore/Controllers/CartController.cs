﻿using System.Linq;
using Microsoft.AspNetCore.Mvc;
using AdventureSports.Core.Data;
using AdventureSports.Core.Models;
using AdventureSports.Models;
using AdventureSports.Models.ViewModels;

namespace AdventureSports.Controllers {

    public class CartController : Controller {
        private IProductRepository repository;
        private Cart cart;

        public CartController(IProductRepository repo, Cart cartService) {
            repository = repo;
            cart = cartService;
        }

        public ViewResult Index(string returnUrl) {
            return View(new CartIndexViewModel {
                Cart = cart,
                ReturnUrl = returnUrl
            });
        }

        public RedirectToActionResult AddToCart(int productId, string returnUrl) {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);
            if (product != null) {
                cart.AddItem(product, 1);
            }
            return RedirectToAction("Index", new { returnUrl });
        }

        public RedirectToActionResult RemoveFromCart(int productId,
                string returnUrl) {
            Product product = repository.Products
                .FirstOrDefault(p => p.ProductID == productId);

            if (product != null) {
                cart.RemoveLine(product);
            }
            return RedirectToAction("Index", new { returnUrl });
        }
    }
}