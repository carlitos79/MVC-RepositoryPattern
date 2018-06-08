using GameStore2.DAL2;
using GameStore2.Models;
using Microsoft.AspNetCore.Mvc;

namespace GameStore2.Controllers
{
    public class Games3Controller : Controller
    {
        private readonly GameStore2Context _context;
        private UnitOfWork unitOfWork;

        public Games3Controller(GameStore2Context context)
        {
            _context = context;
            unitOfWork = new UnitOfWork(_context);
        }

        // GET: Games3
        // 5 is the number of games to be shown
        public IActionResult Index()
        {
            return View(unitOfWork.Games.GetGamesOrderByPriceDesc(5));
        }

        // GET: Games3/Details/5
        //public async Task<IActionResult> Details(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game = await _context.Game
        //        .SingleOrDefaultAsync(m => m.GameID == id);
        //    if (game == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(game);
        //}

        //// GET: Games3/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Games3/Create
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Create([Bind("GameID,Image,Title,Genre,UnitPrice,Description,UnitsInStock")] Game game)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        _context.Add(game);
        //        await _context.SaveChangesAsync();
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(game);
        //}

        //// GET: Games3/Edit/5
        //public async Task<IActionResult> Edit(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game = await _context.Game.SingleOrDefaultAsync(m => m.GameID == id);
        //    if (game == null)
        //    {
        //        return NotFound();
        //    }
        //    return View(game);
        //}

        //// POST: Games3/Edit/5
        //// To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        //// more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        //[HttpPost]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> Edit(int id, [Bind("GameID,Image,Title,Genre,UnitPrice,Description,UnitsInStock")] Game game)
        //{
        //    if (id != game.GameID)
        //    {
        //        return NotFound();
        //    }

        //    if (ModelState.IsValid)
        //    {
        //        try
        //        {
        //            _context.Update(game);
        //            await _context.SaveChangesAsync();
        //        }
        //        catch (DbUpdateConcurrencyException)
        //        {
        //            if (!GameExists(game.GameID))
        //            {
        //                return NotFound();
        //            }
        //            else
        //            {
        //                throw;
        //            }
        //        }
        //        return RedirectToAction(nameof(Index));
        //    }
        //    return View(game);
        //}

        //// GET: Games3/Delete/5
        //public async Task<IActionResult> Delete(int? id)
        //{
        //    if (id == null)
        //    {
        //        return NotFound();
        //    }

        //    var game = await _context.Game
        //        .SingleOrDefaultAsync(m => m.GameID == id);
        //    if (game == null)
        //    {
        //        return NotFound();
        //    }

        //    return View(game);
        //}

        //// POST: Games3/Delete/5
        //[HttpPost, ActionName("Delete")]
        //[ValidateAntiForgeryToken]
        //public async Task<IActionResult> DeleteConfirmed(int id)
        //{
        //    var game = await _context.Game.SingleOrDefaultAsync(m => m.GameID == id);
        //    _context.Game.Remove(game);
        //    await _context.SaveChangesAsync();
        //    return RedirectToAction(nameof(Index));
        //}

        //private bool GameExists(int id)
        //{
        //    return _context.Game.Any(e => e.GameID == id);
        //}
    }
}
