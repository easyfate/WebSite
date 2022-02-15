using System;
using System.Linq;
using WebSite.Domain.Entities;
namespace WebSite.Domain.Repsitories.Abstract
{
    public interface ITextFieldsRepository
    {
        IQueryable<TextField> GetTextFields(); //Выборка всез текстовых полей
        TextField GetTextField(Guid id);//Выборка тестовых полей по Guid
        TextField GetTextFieldByCodeWord(string codeWord); //Выборка по кодовому слову
        void SaveTextField(TextField entity); //Сохраняет изменения, и изменяет в базе данных
        void DeleteTextField(Guid id);//Удаление текстового поля по Guid
        

    }
}
