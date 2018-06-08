using Microsoft.AspNetCore.Http;
using System;
using System.Linq;

namespace GameStore2.Models
{
    public class CartLogic
    {
        private readonly GameStore2Context _context;
        private readonly string _shoppingCartID;

        private CartLogic(GameStore2Context context, string id)
        {
            _context = context;
            _shoppingCartID = id;
        }

        public static CartLogic GetCart(GameStore2Context db, HttpContext context)
        {
            return GetCart(db, GetCartId(context));
        }

        public static CartLogic GetCart(GameStore2Context db, string cartId)
        {
            return new CartLogic(db, cartId);
        }

        public static string GetCartId(HttpContext context)
        {
            var cartId = context.Session.GetString("Session");

            if (cartId == null)
            {
                cartId = Guid.NewGuid().ToString();

                context.Session.SetString("Session", cartId);
            }

            return cartId;
        }

        public void AddToCart(Game game)
        {
            var cartItem = _context.Cart.SingleOrDefault(c => c.ShoppingCartID == _shoppingCartID && c.CartGameID == game.GameID);

            if (cartItem == null)
            {
                cartItem = new Cart
                {
                    ShoppingCartID = _shoppingCartID,
                    Quantity = 1,
                    CartGameID = game.GameID,
                    CartGameTitle = game.Title,
                    CartGameUnitPrice = game.UnitPrice
                };
                _context.Cart.Add(cartItem);
            }
        }
    }
}
