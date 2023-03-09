using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business_Logic.Models
{
    public class Like
    {
        private int id;
        private User user;

        public Like(int id, User user)
        {
            this.id = id;
            this.user = user;
        }

        public int Id { get => id; private set => id = value; }
        public User User { get => user; private set => user = value; }
    }
}
