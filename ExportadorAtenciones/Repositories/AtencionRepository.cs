using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using ExportadorAtenciones.Data;

namespace ExportadorAtenciones.Repositories
{
    public class AtencionRepository
    {
        DBContext context;

        public AtencionRepository(DBContext context)
        {
            this.context = context;
        }

        public Entities.Atencion GetById(Object id)
        {
            return context.Atenciones.Find(id);
        }

        public DbSet<Entities.Atencion> Atenciones
        {
            get
            {
                return this.context.Atenciones;
            }
        }

        public Entities.Atencion Insert(Entities.Atencion entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            try
            {
                entity = this.context.Atenciones.Add(entity);
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }

            return entity;
        }

        public void Update(Entities.Atencion entity)
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

        public void Delete(Entities.Atencion entity)
        {
            if (entity == null)
            {
                throw new ArgumentNullException("entity");
            }
            try
            {
                this.context.Atenciones.Remove(entity);
                this.context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}