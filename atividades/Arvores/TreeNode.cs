using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Arvores
{
    // <T> - representa GENERIC
    // permite definir o tipo específico para TreeNode quando ele for declarado/instanciado
    public class TreeNode<T>{
        public T Data { get; set;}
        public TreeNode<T> Parent {get; set;} //primeiro
        public List<TreeNode<T>> Children { get;set;}

        public int GetHeight () {
            int height = 1;
            TreeNode<T> current = this;
            while(current.Parent != null){
                height++;
                current = current.Parent;
            }

            return height;
        }
    }
    
}

