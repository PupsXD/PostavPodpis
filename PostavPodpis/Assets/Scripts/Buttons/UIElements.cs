using System;
using UnityEngine;

namespace Buttons
{
    public class UIElements : MonoBehaviour
    {
        [SerializeField] private GameObject voter;
        private IEVotable _buttonVoter;
        private void Start()
        {
            
            
        }

        private void Update()
        {
            if (Input.GetButtonDown("Jump"))
            {
                
                //int votesAmount = _buttonVoter.AddVotes(); //Кринж код, я просто тестил хуйню, запоминаю как работать с интерфейсами.
            }
        }
    }
}