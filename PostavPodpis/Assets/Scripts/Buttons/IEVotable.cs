using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IEVotable 
{
    int AddVotes();
    int GetVotes();
    int DecreaseVotes();
}
