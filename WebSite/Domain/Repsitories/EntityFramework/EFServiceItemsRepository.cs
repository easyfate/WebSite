using System;
using System.Linq;
using WebSite.Domain.Entities;
using WebSite.Domain.Repsitories;
using WebSite.Domain.Repsitories.Abstract;
using Microsoft.EntityFrameworkCore;
namespace WebSite.Domain.Repsitories.EntityFramework
{
   
        public class EFServiceItemsRepository : IServiceItemRepository
        {
            private readonly AppDbContext context;
            public EFServiceItemsRepository(AppDbContext context)
            {
                this.context = context;
            }

            public IQueryable<TextField> GetTextFields()
            {
                return context.TextFields;
            }
            public TextField GetTextField(Guid id)
            {
                return context.TextFields.FirstOrDefault(x => x.Id == id);
            }

            public TextField GetTextFieldByCodeWord(string codeWord)
            {
                return context.TextFields.FirstOrDefault(x => x.CodeWord == codeWord);
            }
            public void SaveTextField(TextField entity)
            {
                if (entity.Id == default)
                {
                    context.Entry(entity).State = EntityState.Added;
                }
                else
                {
                    context.Entry(entity).State = EntityState.Modified;
                }
                context.SaveChanges();
            }

            public void DeleteTextField(Guid id)
            {
                context.TextFields.Remove(new TextField { Id = id });
                context.SaveChanges();
            }
        }
}
    