using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodePractice.CodeWarsTasks
{
    public class LikesString
    {
        public static string Likes (string [] name)
        {
            switch (name.Length)
            {
                case 0: return "no one likes this";
                    break;
                case 1: return (name[0]+" likes this");
                    break;
                case 2: return String.Format("{0} and {1} like this",name[0],name[1]);
                    break;
                case 3: return String.Format("{0}, {1} and {2} like this", name[0],name[1],name[2]);
                    break;
                default: return String.Format("{0}, {1} and {2} others like this",name[0],name[1],(name.Length-2));
                    break;
            }
        }
    }
}
