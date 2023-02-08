using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SPDM.DLL.Entities
{
    public abstract class Entity
    {
        private int id;

        public int Id
        {
            get
            {
                return id;
            }
            set
            {
                id = value;
            }

        }

        private DateTime createTime;

        public Entity()
        {
            this.id = 0;
            createTime = DateTime.Now;
        }

        public Entity(int id, DateTime createTime)
        {
            this.id = id;
            this.createTime = createTime;
        }

        public bool IsNew
        {
            get
            {
                //Boolean p = id <= 0;
                //return p;
                return id <= 0;
            }
        }

        public DateTime CreateTime { get => createTime; }

        public virtual void Print()
        {
            Console.WriteLine("Id - {0}, CreateDate-{1}", id, createTime);
        }
    }
}

