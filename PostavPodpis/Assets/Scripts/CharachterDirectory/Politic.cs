
using System.Collections.Generic;
using CharachterDirectory.Charachter_names;
using UnityEngine;


namespace CharachterDirectory
{
    public class Politic : Charachter, IGenerateCharachter
    {
        //+ к базовым значениям персонажа требуются еще и статки
        public int intelegence; //Интеллект
        public int agressiveness; //агрессивность + к военной диаспоре
        public int wealthiness; //+ к банкирам и международным отношениям
        public int goodForPeasants; //+ к настроению населения

        public int baseVoteAmount; //Базовое значение поддержки для политика

        
        
        public Politic(string charachterName, int age, bool isWoman, bool isObese) : base(charachterName,  age, isWoman, isObese)
        {
            this.charachterName = charachterName;
            this.age = age;
            this.isWoman = isWoman;
            this.isObese = isObese;
        }

        


        public void SetBaseVoteAmount()
        {
            baseVoteAmount = Random.Range(10, 50); //Условная заглушка по данным, надо считать
        }

        public void RandomizeCharachterAppearance(List<Sprite> charachterFaces, List<Sprite> charachterBodies)
        {
            int i = Random.Range(0, charachterFaces.Count);
            int j = Random.Range(0, charachterBodies.Count);
            Sprite characterFace = charachterFaces[i];
            Sprite charachterBody = charachterBodies[j];

            // Создаем объект для тела персонажа
            GameObject bodyObject = new GameObject("Body");
    
            // Устанавливаем его позицию
            bodyObject.transform.position = new Vector3(transform.position.x, transform.position.y - 1f, -0.5f); // Примерное расположение на -0.5 по z

            // Делаем bodyObject дочерним по отношению к текущему объекту (персонажу)
            bodyObject.transform.parent = transform;

            // Добавляем компонент SpriteRenderer и устанавливаем спрайт для тела персонажа
            SpriteRenderer bodyRenderer = bodyObject.AddComponent<SpriteRenderer>();
            bodyRenderer.sprite = charachterBody;

            // Устанавливаем спрайт для лица персонажа
            GetComponent<SpriteRenderer>().sprite = characterFace;
        //     int i = Random.Range(0, 5);
        //     int j = Random.Range(0, 5);
        //     Sprite characterFace = charachterFaces[i];
        //     Sprite charachterBody = charachterBodies[j];
        //     GetComponent<SpriteRenderer>().sprite = characterFace;
        //     GetComponent<SpriteRenderer>().sprite = charachterBody;
         }
        
        public void RandomizeCharacterName(ENames eNames, ESurname eSurname) //это работает, осталось сделать конкотанацию и объединить в одну строчку, приплюсовав к имени перса
        {
            string randomName = ((ENames)Random.Range(0, ENames.GetValues(typeof(ENames)).Length)).ToString();
            string randomSurname = ((ESurname)Random.Range(0, ESurname.GetValues(typeof(ESurname)).Length)).ToString();


            Debug.Log($"{randomName} {randomSurname}"); 
        }

        public void RandomizeCharachterStats()
        {
            this.intelegence = Random.Range(1, 25);
            this.agressiveness = Random.Range(1, 25);
            this.wealthiness = Random.Range(1, 25);
            this.goodForPeasants = Random.Range(1, 25);
            
            Debug.Log($"{intelegence}, {agressiveness}, {wealthiness}, {goodForPeasants}");
        }
    }
}