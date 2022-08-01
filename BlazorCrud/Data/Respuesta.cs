using System.Collections.Generic;

namespace BlazorCrud.Data
{
    public class Respuesta<T>
    {
        public int Success { get; set; }
        public string ErrCode { get; set; }

        public T Data { get; set; }
      
    }
   
}
