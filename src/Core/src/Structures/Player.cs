using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.src.Structures
{
    abstract class Player
    {
        public Boolean isHuman
        {
            get
            {
                return is_human;
            }
            set
            {
                is_human = value;
            }
        }

        protected Boolean is_human;

        public Int64 Score
        {
            get
            {
                return score;
            }
            set
            {
                score = value;
            }
        }

        protected Int64 score;
    
        
        public Player(Boolean is_human)
        {
            score = 0;
            this.is_human = is_human;
        }
    }

}
