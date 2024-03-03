using System;
using CharachterDirectory;
using UnityEngine;
using UnityEngine.UI;

namespace Currency_and_Votes
{
    public class VotesManager : MonoBehaviour
    {
        private IEVotable Ivotable;
        [SerializeField] private Politic _politic;
        
        [SerializeField] private Slider intellegenceSlider;
        [SerializeField] private Slider aggrecivenessSlider;
        [SerializeField] private Slider wealthSlider;
        [SerializeField] private Slider peasantPopularitySlider;

        private void Start()
        {
            Ivotable = new BaseVoter();
            _politic = FindObjectOfType<RandomizeCharachter>().GetComponent<Politic>();
            
            intellegenceSlider.value = _politic.intelegence;
            aggrecivenessSlider.value = _politic.agressiveness;
            wealthSlider.value = _politic.wealthiness;
            peasantPopularitySlider.value = _politic.goodForPeasants; //rename for peasantPopularity in future
        }

        public void AddVotes()
        {
            Ivotable.AddVotes();
        }

        public int GetVotes()
        {
            Ivotable.GetVotes();
            return Ivotable.GetVotes();
        }

        
    }
}