using System;
using System.Collections.Generic;
using System.Linq;
using WebSite.Domain.Repsitories.Abstract;
namespace WebSite.Domain
{
    public class DataManager
    {
        public ITextFieldsRepository TextFields {get;set;}
        public IServiceItemRepository ServiceItem { get; set; }
        public DataManager(ITextFieldsRepository textFieldsRepository, IServiceItemRepository serviceItemRepository)
        { 
            TextFields = textFieldsRepository;
            ServiceItem = serviceItemRepository;
        }

    }
}
