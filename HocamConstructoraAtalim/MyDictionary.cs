using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HocamConstructoraAtalim
{
    public class MyDictionary
    {
        List<DictionaryEntity> list;
        public MyDictionary()
        {
            list = new List<DictionaryEntity>();
        }
        public void Add(int id, string value)
        {
          DictionaryEntity entity = new DictionaryEntity();
            entity.id = id; 
            entity.Value = value;
            list.Add(entity);


        }

        public void ShowList() {
            foreach (DictionaryEntity item in list)
            {
                Console.WriteLine(item.id + " / " + item.Value);
            }
        
        }
     



    }
}
