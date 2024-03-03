using System.Collections.Generic;
using CharachterDirectory.Charachter_names;
using UnityEngine;


namespace CharachterDirectory
{
    public interface IGenerateCharachter
    {
        public void RandomizeCharachterAppearance(List<Sprite> charachterFaces, List<Sprite> charachterBodies);
        public void RandomizeCharacterName(ENames eName, ESurname eSurname);

        public void RandomizeCharachterStats();
    }
}