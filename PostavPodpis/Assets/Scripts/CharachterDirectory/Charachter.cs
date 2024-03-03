using UnityEngine;

namespace CharachterDirectory
{
    public abstract class Charachter : MonoBehaviour
    {
        public string charachterName;
        public int age;
        public bool isWoman;
        public bool isObese;
        
        
        public Charachter(string charachterName, int age, bool isWoman, bool isObese)
        {
            this.charachterName = charachterName;
            this.age = age;
            this.isWoman = isWoman;
            this.isObese = isObese;
        }

        
    }
}