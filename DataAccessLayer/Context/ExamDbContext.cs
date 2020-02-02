using Exams.Core.Entities;
using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Data.Entity.Validation;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace DataAccessLayer.Context
{
    public class ExamDbContext : IdentityDbContext
    {
        #region DbEntities
        //public DbSet<User> Users { get; set; } // dekhte hai ye baad me
        public DbSet<QuestionPaper> QuestionPaper { get; set; }
        public DbSet<Question> Question { get; set; }
        #endregion

        public ExamDbContext() : base("name = EFDbContext")
        {
            this.Init();
        }

        private void Init()
        {
            Database.SetInitializer<ExamDbContext>(null); // To Check
            //this.UniqueIndexes = new Dictionary<string, List<List<PropertyInfo>>>(); // to check
        }

        public override int SaveChanges()
        {
            try
            {
                return base.SaveChanges();
            }
            catch (DbEntityValidationException ex)
            {
                var errorMessages = ex.EntityValidationErrors.SelectMany(x => x.ValidationErrors).Select(x => x.ErrorMessage);

                var fullErrorMessage = string.Join("; ", errorMessages);
                // Combine the original exception message with the new one.
                var exceptionMessage = string.Concat(ex.Message, " The validation errors are: ", fullErrorMessage);

                // Throw a new DbEntityValidationException with the improved exception message.
                throw new DbEntityValidationException(exceptionMessage, ex.EntityValidationErrors);
            }
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder); 


        }
    }
}
