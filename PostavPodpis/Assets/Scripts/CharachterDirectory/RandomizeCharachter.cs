
using System.Collections.Generic;
using CharachterDirectory.Charachter_names;
using UnityEngine;



namespace CharachterDirectory //Тут повсюду есть проблема, что это размещено на карактере, но выполняется то один раз, а у нас персонажи меняются, проанализировать возможность траблы
{
    public class RandomizeCharachter : MonoBehaviour
    {
        public Politic playerCharachter;
        public List<Sprite> charachterFaces = new List<Sprite>(5); //временно паблик и временно тут - вынести в пул объектов
        public List<Sprite> charachterBodies = new List<Sprite>(5);
        private ENames _eNames;
        private ESurname _eSurname;


        private void Awake()
        {
            
            playerCharachter = gameObject.AddComponent<Politic>();
            
            playerCharachter.age = Random.Range(15, 50);
            playerCharachter.isWoman = false;
            playerCharachter.isObese = false;
            
            playerCharachter.RandomizeCharacterName(_eNames, _eSurname);
            playerCharachter.RandomizeCharachterStats();
      

            
        }

        public void RandomisePoilitic()
        {
            if (gameObject.GetComponent<SpriteRenderer>() == null)
            {
                gameObject.AddComponent<SpriteRenderer>();
                playerCharachter.RandomizeCharachterAppearance(charachterFaces,charachterBodies);
            }
            else
            {
            
                playerCharachter.RandomizeCharachterAppearance(charachterFaces,charachterBodies);
            }
            
        }

        
    }
}