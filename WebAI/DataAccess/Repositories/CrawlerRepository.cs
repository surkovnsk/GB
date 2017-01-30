﻿using DataAccess.Repositories.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Entities;
using DataAccess.Context;

namespace DataAccess.Repositories
{
    public class CrawlerRepository : ICrawlerRepository
    {
        WebAIDbContext context;
        public CrawlerRepository(WebAIDbContext context)
        {
            this.context = context;
        }
        public IEnumerable<Page> GetAllPagesForSite(int id)
        {
            return context.Pages.Where(x => x.SiteId == id).ToArray();
        }

        public IEnumerable<Site> GetSites()
        {
            return context.Sites.ToArray();
        }
    }
}
