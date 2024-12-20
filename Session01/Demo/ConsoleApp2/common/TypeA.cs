using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace common
{
    //What can be written inside namespace?
    //1-Class
    //2-Struct
    //3-Interface
    //4-Enum

    //Allowed Access Modifiers in namespace:
    //1-Internal
    //2-Public
    public class TypeA
    {
      //Defalut access is private
        private int x;
        internal int y;
        public int z;
        #region Definitions
        /*
        //what you can write inside the class or struct
        //1-Attributes
        //2-Property
        //3-Functions(Constructor-Getter-Setter-Method)
        //4-Event
        //-------------------------------
        //Allowed access modifires in struct
        1 private(can be accessed in class or struct only)
        2 public(can be accessed everywhere)
        3 internal(can be accessen in project)
        -----------------------------------
        Allowed in class:
        private
        private protected
        protected
        internal
        internal protected
        public
      ------------------------------------------
        Allowed in Interface:
        Signature for property
        Signature for method
        Default Implemetnation for method
      */
        #endregion
    }
}
