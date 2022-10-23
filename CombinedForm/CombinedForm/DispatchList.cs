using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CombinedForm
{
    //class for Stack
    internal class DispatchList
    {
       public Stack<Box> dispatchList = new Stack<Box>();


        public void addBox(Box b)
        {
            dispatchList.Push(b);
        }

        public Box removeBox()
        {
           return dispatchList.Pop(); 
        }
       

        public Stack<Box> getAllLoadedBoxes()
        {
            return dispatchList;
        }      


    }
    


    
}
