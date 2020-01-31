using NewsSearch.Db;
using NewsSearch.Dto;
using NewsSearch.Entity;
using NewsSearch.Repository;
using NewsSearch.Solr;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NewsSearch.Services
{
    public class NewsApplicationServices : INewsApplicationServices
    {
        private readonly IGenericRepository<NewsEntity> _Db;
        private readonly ISolrIndexService<SolrNewsEntity> _Solr;

        public NewsApplicationServices(IGenericRepository<NewsEntity> _db, ISolrIndexService<SolrNewsEntity> _solr)
        {
            _Db = _db;
            _Solr = _solr;
        }

        public NewsDto Delete(Guid id)
        {
            throw new NotImplementedException();
        }

        public NewsDto Get(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<NewsDto> GetAll()
        {
            throw new NotImplementedException();
        }

        public NewsDto Update(NewsDto dto)
        {
            throw new NotImplementedException();
        }

        public NewsDto Insert(NewsDto dto)
        {
            NewsEntity model = new NewsEntity(dto);
            try
            {
                _Db.CreateTransaction();
                _Db.Insert(model);
                _Db.Commit();


                SolrNewsEntity document = new SolrNewsEntity(dto);
                bool SolrUpdated = _Solr.AddUpdate(document);
                if (!SolrUpdated)
                {
                    _Db.Rollback();
                }
                else
                {
                    _Db.Save();
                    _Solr.Save();
                }
               
                return new NewsDto(model);
            }
            catch(Exception err)
            {
                _Solr.RollBack();
                _Db.Rollback();
                throw err;
            }
          
        }
    }
}
