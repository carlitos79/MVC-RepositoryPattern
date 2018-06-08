using GameStore2.DAL;
using GameStore2.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace GameStore2.Controllers
{
    public class Games2Controller : Controller
    {
        private readonly GameStore2Context _context;

        private IGameRepository gameRepository;

        public Games2Controller(GameStore2Context context)
        {
            _context = context;
            this.gameRepository = new GameRepository(_context);
        }

        // GET: Games2
        public IActionResult Index()
        {
            return View(gameRepository.GetGames().OrderByDescending(g => g.UnitPrice));
        }

        //// GET: Games2/Details/5
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

        //// GET: Games2/Create
        //public IActionResult Create()
        //{
        //    return View();
        //}

        //// POST: Games2/Create
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

        //// GET: Games2/Edit/5
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

        //// POST: Games2/Edit/5
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

        //// GET: Games2/Delete/5
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

        //// POST: Games2/Delete/5
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
