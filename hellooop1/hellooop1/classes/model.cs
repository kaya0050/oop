

namespace hellooop1
{
   
    public abstract class ModelRecord
    {
        
        public int Id { get; set; }
        public string Name { get; set; } 
    }

    public abstract class Model
    {
       
        public string Name {
            get {
                return ((ModelRecord)record.Value).Name;
            }
            set {
                ((ModelRecord)record.Value).Name = value;
            }
        }



        public int Id { 
            get
            {
                if (((ModelRecord)record.Value) != null)

                    return ((ModelRecord)record.Value).Id;
                else 
                    return default;
            }
            private set
            {
                ((ModelRecord)record.Value).Id = value;
            }
        }


        protected string tablename;

       
        protected Dictionary<int, object> table_data = new Dictionary<int, object>();
        protected KeyValuePair<int, object> record = default(KeyValuePair<int, object>); 

     
        public Model(string tablename)
        {
            Console.WriteLine($"Inside Model() constructor");

          
            this.tablename = tablename;
        }

        public Dictionary<int, object> getTableData()
        {
            return this.table_data;
        }

        
        public KeyValuePair<int, object> getRecord()
        {
            return this.record;
        }

       
        public void setTableData(Dictionary<int, object> table_data)
        {
            this.table_data = table_data;
        }

        public void setRecord(KeyValuePair<int, object> record)
        {
            this.record = record;
        }

       
        public KeyValuePair<int, object> find(int id)
        {
            KeyValuePair<int, object> record = default; 

            var key = id; 
            if (table_data.ContainsKey(key))
            {
                var value = table_data[id]; 
                record = new KeyValuePair<int, object>(key, value);
            }

            this.record = record; 

            return record;
        }

    }
}
