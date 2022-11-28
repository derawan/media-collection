using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MediaCollection.Models;
using Microsoft.CodeAnalysis.Differencing;

namespace MediaCollection.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MediaController : ControllerBase
    {
        private readonly DataContext _context;

        public MediaController(DataContext context)
        {
            _context = context;
        }

        // GET: Media
        [HttpGet]
        public async Task<ActionResult<IEnumerable<Media>>> GetMedias()
        {
            if (HttpContext.Request.Query.ContainsKey("query"))
            {
                var query = HttpContext.Request.Query["query"].ToString();
                return await _context.Medias.Where(item => item.AlbumName.ToLower().Contains(query.ToLower()) || item.ArtistName.ToLower().Contains(query.ToLower())).ToListAsync();
            }
                
            return await _context.Medias.ToListAsync();
        }

        // GET: Media/5
        [HttpGet("{id}")]
        public async Task<ActionResult<Media>> GetMedia(int id)
        {
            var media = await _context.Medias.FindAsync(id);

            if (media == null)
            {
                return NotFound();
            }

            return media;
        }

        // PUT: api/Media/5
       /* [HttpPut("{id}")]
        public async Task<IActionResult> PutMedia(int id, Media media)
        {
            if (id != media.ArtistId)
            {
                return BadRequest();
            }

            _context.Entry(media).State = EntityState.Modified;

            try
            {
                await _context.SaveChangesAsync();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }*/

        [HttpPut("{id}")]
        public IActionResult Put(int id, [FromBody] Media media)
        {
            /*_context.Medias.Add(value);
            _context.SaveChanges();

            return CreatedAtAction("GetMedia", new { id = value.ArtistId }, value);*/
            if (id != media.ArtistId)
            {
                return BadRequest();
            }

            _context.Entry(media).State = EntityState.Modified;

            try
            {
                _context.SaveChanges();
            }
            catch (DbUpdateConcurrencyException)
            {
                if (!MediaExists(id))
                {
                    return NotFound();
                }
                else
                {
                    throw;
                }
            }

            return NoContent();
        }

        // POST: Media
        /* [HttpPost]
         public async Task<ActionResult<Media>> PostMedia(Media media)
         {
             _context.Medias.Add(media);
             await _context.SaveChangesAsync();

             return CreatedAtAction("GetMedia", new { id = media.ArtistId }, media);
         }
 */
        [HttpPost]
        public ActionResult<Media> Post([FromBody] Media value)
        {
            _context.Medias.Add(value);
            _context.SaveChanges();

            return CreatedAtAction("GetMedia", new { id = value.ArtistId }, value);
        }

        // DELETE: api/Media/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMedia(int id)
        {
            var media = await _context.Medias.FindAsync(id);
            if (media == null)
            {
                return NotFound();
            }

            _context.Medias.Remove(media);
            await _context.SaveChangesAsync();

            return NoContent();
        }

        private bool MediaExists(int id)
        {
            return _context.Medias.Any(e => e.ArtistId == id);
        }
    }
}
