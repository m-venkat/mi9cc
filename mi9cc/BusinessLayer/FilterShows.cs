using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using mi9cc.Models;
using Mi9cc.JsonModel;

namespace mi9cc.BusinessLayer
{
    public class FilterShows : IFilterShows
    {
        private PayLoadContainer _container = null;
        public FilterShows()
        {
            
        }

       
        public List<response> ApplyFilter(PayLoadContainer container)
        {
            _container = container;
            List<response> response = null;
            if (_container != null)
            {
                 response =
                    _container.payload
                    .Where(p => p.drmAsBool == true && p.episodeCount > 0)
                    .Select(p => new response { image = p.image.showImage, slug = p.slug, title = p.title })
                    .ToList();
            }
            else
            {
                throw new NullReferenceException("PayloadContainer is null");
            }
            return response;
           
        }
    }
}
