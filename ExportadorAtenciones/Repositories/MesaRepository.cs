using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExportadorAtenciones.Data;

namespace ExportadorAtenciones.Repositories
{
    public class MesaRepository
    {
        DBContext context;

        public MesaRepository(DBContext context)
        {
            this.context = context;
        }

        public Entities.Mesa GetById(Object id)
        {
            return context.Mesas.Find(id);
        }

        public DbSet<Entities.Mesa> Mesas
        {
            get
            {
                return this.context.Mesas;
            }
        }

        public void Insert(Entities.Mesa entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            try
            {
                this.context.Mesas.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Update(Entities.Mesa entity)
        {
            try
            {
                if (entity == null)
                {
                    throw new ArgumentNullException("entity");
                }
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void Delete(Entities.Mesa entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            try
            {
                this.context.Mesas.Remove(entity);
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}