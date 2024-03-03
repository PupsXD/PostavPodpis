using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BaseVoter : IEVotable //теперь это ебать его в сраку класс состояний
{
    private int votesCount;

    public int GetVotes()
    {
        return votesCount;
    }
    
    public int AddVotes()
    {
        votesCount++;
        return votesCount;
    }

    public int DecreaseVotes()
    {
        votesCount--;
        return votesCount;
    }
    
}
